using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Collections;
using System.IO;
using System.Text.RegularExpressions;

namespace Globalizer.Code
{
    public class CodeFile : IEnumerable<Literal>
    {
        private List<Literal> m_literals;
        private readonly string m_hash;
        private readonly string m_id_prefix;
        public string Path { get; protected set; }
        public string Hash { get => this.m_hash; }
        
        public static CodeFile CreateFromFile(string filepath, Encoding encoding = null)
        {
            CodeFile item = new CodeFile(filepath);
            item.ScanFile(encoding);
            return item;
        } // static CreateFromFile

        public static IEnumerable<CodeFile> CreatFromFolder(string path, bool NonRecursive = false, Encoding encoding = null)
        {
            List<CodeFile> result = new List<CodeFile>();
            DirectoryInfo di = new DirectoryInfo(path);
            var files = di.GetFiles(Globals.FileSearchMask).Select(f=> f.FullName);
            if (!NonRecursive)
            {
                var directories = di.GetDirectories().Select(d => d.FullName);
                foreach (var dir in directories)
                    result.AddRange(CreatFromFolder(dir));
            }
            foreach (var file in files)
            {
                result.Add(CreateFromFile(file));
            }
            return result;
        } // CreateFromFolder

        protected void ScanFile(Encoding encoding = null)
        {
            if (null == encoding) encoding = Encoding.UTF8; // default;
            using (FileStream fs = new FileStream(this.Path, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                using (StreamReader rdr = new StreamReader(fs, encoding))
                {
                    int linenumber = 0;
                    while(!rdr.EndOfStream)
                    {
                        linenumber++;
                        string codeline = rdr.ReadLine();
                        MatchCollection mc = Regex.Matches(codeline, Globals.CheckPattern);
                        if (mc.Count != 0)
                        {
                            foreach (Match m in mc)
                            {
                                string id = $"ID_{this.m_id_prefix}_{linenumber}_{m.Index}";
                                bool interpolated = (m.Value.Contains("{") && m.Index != 0 && codeline[m.Index - 1] == '$');
                                Literal ltr = new Literal(id, this, linenumber, m, interpolated);
                                this.m_literals.Add(ltr);
                            } // foreach match
                        }
                    } // while
                } // using rdr
            } // using fs
        } // ScanFile

        protected CodeFile(string filePath)
        {
            this.m_id_prefix = System.IO.Path.GetFileNameWithoutExtension(filePath);
            this.Path = filePath;
            this.m_hash = MakeHash(filePath);
            this.m_literals = new List<Literal>();
        } // protected Constructor(string)

        protected string MakeHash(string filePath)
        {
            SHA256 sha = new SHA256Managed();
            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                byte[] bytehash = sha.ComputeHash(fs);
                string hash = string.Empty;
                foreach (byte b in bytehash)
                {
                    hash += b.ToString("x2");
                }
                return hash;
            } // using fs
        } // MakeHash

        protected bool CheckHash(string filePath)
        {
            string hashBeingChecked = MakeHash(filePath);
            return m_hash.Equals(hashBeingChecked);
        } // CheckHash

        #region "IEnumerable implementation"
        public IEnumerator<Literal> GetEnumerator()
        {
            return ((IEnumerable<Literal>)m_literals).GetEnumerator();
        } // GetEnumerator

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<Literal>)m_literals).GetEnumerator();
        } // GetEnumerator
        #endregion "IEnumerable implementation"
    } // class CodeFile
} // namespaceStringRefactoring

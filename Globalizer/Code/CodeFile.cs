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

        public string FullPath { get; protected set; }
        public string Hash { get => this.m_hash; }
        
        public CodeFile(string file, Encoding encoding = null)
        {
            this.FullPath = file;
            this.m_id_prefix = System.IO.Path.GetFileNameWithoutExtension(file);
            this.m_hash = MakeHash(file);
            this.m_literals = new List<Literal>();
            this.Scan(encoding);
        } // public constructor

        protected void Scan(Encoding encoding = null)
        {
            if (this.m_literals.Count > 0) this.m_literals.Clear();
            if (null == encoding) encoding = Encoding.UTF8; // default;
            using (FileStream fs = new FileStream(this.FullPath, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                using (StreamReader rdr = new StreamReader(fs, encoding))
                {
                    int linenumber = 0;
                    while(!rdr.EndOfStream)
                    {
                        linenumber++;
                        string codeline = rdr.ReadLine();
                        MatchCollection mc = Regex.Matches(codeline, Globals.StringRegExp);
                        if (mc.Count != 0)
                        {
                            foreach (Match m in mc)
                            {
                                string id = $"ID_{this.m_id_prefix}_{linenumber}_{m.Index}";
                                bool interpolated = (m.Value.Contains("{") && m.Index != 0 && codeline[m.Index - 1] == '$');
                                Literal ltr = new Literal(id, this, linenumber, m, interpolated);
                                this.m_literals.Add(ltr);
                            } // foreach match
                        } // if there are matches 
                    } // while
                } // using rdr
            } // using fs
        } // ScanFile

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
                } // foreach
                return hash;
            } // using fs
        } // MakeHash
        
        public bool CheckHash()
        {
            string hashBeingChecked = MakeHash(this.FullPath);
            return m_hash.Equals(hashBeingChecked);
        } // CheckHash

        public void SetState(Literal.WorkStates state)
        {
            foreach(var l in this.m_literals)
            {
                l.WorkState = state;
            }
        } // SetState

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

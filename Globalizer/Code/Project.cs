﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.IO;
using System.Resources;
using System.Xml.XPath;

namespace Globalizer.Code
{
    public class Project : IEnumerable<CodeFile>
    {
        private List<CodeFile> m_files;
        public string Name { get; set; }
        public string SavedFilename { get; set; }
        public string Path { get; protected set; }
        public string RegExp { get; set; }
        public string FileMask { get; set; }
        public Encoding Encoding { get; set; }
        public Guid Identity { get; protected set; }
        public Dictionary<string, string> CommonIDs { get; protected set; }
        public Project(string name, string path, Guid? identity = null)
        {
            if (null == identity) this.Identity = Guid.NewGuid(); else this.Identity = (Guid)identity; // for identification
            this.Name = name;
            this.Path = path;
            this.CommonIDs = new Dictionary<string, string>();
        } // Processor(string)

        public void ReScan()
        {
            this.CommonIDs.Clear();
            this.m_files = this.ScanFolder(this.Path);
            this.AnalyzeFrequencies();
        } // Process

        protected List<CodeFile> ScanFolder(string startPath)
        {
            List<CodeFile> result = new List<CodeFile>();
            DirectoryInfo di = new DirectoryInfo(startPath);
            var files = di.GetFiles(Globals.FileSearchMask).Select(f => f.FullName);
            var directories = di.GetDirectories().Select(d => d.FullName);
            foreach (var dir in directories)
                result.AddRange(ScanFolder(dir));

            foreach (var file in files)
                result.Add(new CodeFile(file, this.Encoding));
            return result;
        } // Rescan
        
        public void AnalyzeFrequencies()
        {
            Dictionary<string, int> freq = new Dictionary<string, int>();
            foreach(var file in this.m_files)
            {
                foreach(var literal in file)
                {
                    if (freq.ContainsKey(literal.Value))
                    {
                        freq[literal.Value]++;
                    }
                    else
                    {
                        freq.Add(literal.Value, 1);
                    }
                } // foreach literal
            } // foreach file

            int i = 0;
            foreach (var str in freq.Where(f=> f.Value > 1))
            {
                string new_id = $"COMMON_" + i.ToString("00000");
                this.CommonIDs.Add(new_id, str.Key);
                i++;
                foreach(var file in this.m_files)
                {
                    foreach(var lit in file)
                    {
                        if (lit.Value.Equals(str.Key)) lit.Id = new_id;
                    } // foreach literal
                } // foreach file
            } // foreach
        } // AnalyzeFrequencies

        public void GenerateResx(string filename)
        {
            using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.Write, FileShare.Read))
            {
                using (ResXResourceWriter wrt = new ResXResourceWriter(fs))
                {
                    foreach (var file in this.m_files)
                    {
                        foreach(var literal in file)
                        {
                            wrt.AddResource(literal.Id, literal.Value.Substring(1, literal.Value.Length - 2));
                        } // foreach literal
                    } // foreach file
                    wrt.Generate();
                } // using wrt
            } // using fs                
        } // Generate Resx

        public void Save(string filename)
        {
            this.SavedFilename = filename;
            if (File.Exists(filename)) File.Delete(filename);
            using (FileStream fs = new FileStream(filename, FileMode.CreateNew, FileAccess.Write, FileShare.None))
            {
                this.Save(fs);
            } // using fs
        } // Save

        public void Save(Stream stream)
        {
            XDocument doc = new XDocument();
            XElement rootElem = new XElement("project");
            rootElem.Add(new XAttribute("identity", this.Identity.ToString()));
            rootElem.Add(new XAttribute("name", this.Name));
            rootElem.Add(new XElement("path") { Value = Path });
            rootElem.Add(new XElement("pattern") { Value = this.RegExp });
            rootElem.Add(new XElement("searchmask") { Value = this.FileMask });
            if (this.Encoding != null) rootElem.Add(new XElement("codepage") { Value = this.Encoding.CodePage.ToString() });
            XElement commonKeys = new XElement("common");
            commonKeys.Add(new XAttribute("count", this.CommonIDs.Count.ToString()));
            foreach(string key in this.CommonIDs.Keys)
            {
                XElement entry = new XElement("entry");
                entry.Add(new XElement("key") { Value = key });
                entry.Add(new XElement("value") { Value = this.CommonIDs[key] });
                commonKeys.Add(entry);
            } // foreach common key
            rootElem.Add(commonKeys);

            XElement filesCollection = new XElement("files");
            filesCollection.Add(new XAttribute("count", this.m_files.Count().ToString()));
            foreach (var file in this.m_files)
            {
                XElement fileElem = new XElement("file");
                fileElem.Add(new XElement("path") { Value = file.FullPath.Substring(Path.Length) });
                fileElem.Add(new XElement("hash") { Value = file.Hash });
                XElement literalsCollection = new XElement("literals");
                literalsCollection.Add(new XAttribute("count", file.Count().ToString()));
                foreach (var literal in file)
                {
                    XElement literalElem = new XElement("literal");
                    if (literal.IsInterpolated) literalElem.Add(new XAttribute("interpolated", "true"));
                    literalElem.Add(new XElement("line") { Value = literal.LineNumber.ToString() });
                    literalElem.Add(new XElement("pos") { Value = literal.LinePosition.ToString() });
                    literalElem.Add(new XElement("len") { Value = literal.Length.ToString() });
                    literalElem.Add(new XElement("id") { Value = literal.Id });
                    literalElem.Add(new XElement("value") { Value = literal.Value });
                    literalElem.Add(new XElement("status") { Value = Enum.GetName(typeof(Literal.WorkStates), literal.WorkState) });
                    literalsCollection.Add(literalElem);
                }
                fileElem.Add(literalsCollection);
                filesCollection.Add(fileElem);
            } // foreach

            rootElem.Add(filesCollection);
            doc.Add(rootElem);
            doc.Save(stream);
        } // Save

        public static Project Load(string filename)
        {
            XDocument doc = XDocument.Load(filename);
            XElement root = doc.XPathSelectElement("/project");
            string name = root.Attribute("name").Value;
            Guid identity = Guid.Parse(root.Attribute("identity").Value);
            if (Program.MainWindow.ChildWindows.ContainsKey(identity))
            {
                Program.MainWindow.ActivateChild(identity);
                return null;
            }
            string path = root.XPathSelectElement("path").Value;

            Project project = new Project(name, path, identity)
            {
                RegExp = root.XPathSelectElement("pattern").Value,
                FileMask = root.XPathSelectElement("searchmask").Value,
                Encoding = (null == root.XPathSelectElement("codepage") ?
                    null : Encoding.GetEncoding(int.Parse(root.XPathSelectElement("codepage").Value))),
                m_files = new List<CodeFile>()
            };

            IEnumerable<XElement> commoncollection = root.XPathSelectElements("common/entry");
            project.CommonIDs = commoncollection.ToDictionary(
                                    item => item.Descendants("key").FirstOrDefault().Value,
                                    item => item.Descendants("value").FirstOrDefault().Value);

            IEnumerable<XElement> files = root.XPathSelectElements("files/file");
            foreach(XElement fElem in files)
            {
                string filepath = fElem.Descendants("path").FirstOrDefault().Value;
                string hash = fElem.Descendants("hash").FirstOrDefault().Value;
                IEnumerable<XElement> literalElems = fElem.XPathSelectElements("literals/literal");
                List<Literal> literals = new List<Literal>();
                foreach (XElement lElem in literalElems)
                {
                    Literal newLiteral = new Literal(
                        lElem.Descendants("id").FirstOrDefault().Value,
                        int.Parse(lElem.Descendants("line").FirstOrDefault().Value),
                        int.Parse(lElem.Descendants("pos").FirstOrDefault().Value),
                        int.Parse(lElem.Descendants("len").FirstOrDefault().Value),
                        lElem.Descendants("value").FirstOrDefault().Value,
                        lElem.Attributes("interpolated").FirstOrDefault()?.Value == "true"
                        )
                    { WorkState = (Literal.WorkStates)Enum.Parse(typeof(Literal.WorkStates), lElem.Descendants("status").FirstOrDefault().Value)};
                    
                    literals.Add(newLiteral);
                } // foreach
                CodeFile file = new CodeFile(filepath, project.Encoding, literals, hash);
                project.m_files.Add(file);
            } // foreach
            return project;
        } // Load

        #region "IEnumerable implementation"
        public IEnumerator<CodeFile> GetEnumerator()
        {
            return ((IEnumerable<CodeFile>)m_files).GetEnumerator();
        } // GetEnumerator

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<CodeFile>)m_files).GetEnumerator();
        } // GetEnumerator
        #endregion "IEnumerable implementation"
    } // class Processor
} // namespace StringRefactoring

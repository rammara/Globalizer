using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.IO;

namespace Globalizer.Code
{
    public class Project : IEnumerable<CodeFile>
    {
        private List<CodeFile> m_files;
        public string Name { get; set; }
        public string Path { get; protected set; }
        public Project(string path)
        {
            this.Path = path;
            this.ReScan();
        } // Processor(string)

        public void ReScan()
        {
            this.m_files = CodeFile.CreatFromFolder(Path).ToList();
            // doc.Save(Path.Combine(Path, "globalizer.xml"));
        } // Process

        public void Save(string filename)
        {
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
            rootElem.Add(new XAttribute("name", this.Name));
            rootElem.Add(new XElement("path") { Value = Path });
            rootElem.Add(new XElement("pattern") { Value = Globals.CheckPattern });
            rootElem.Add(new XElement("searchmask") { Value = Globals.FileSearchMask });
            XElement filesCollection = new XElement("files");
            filesCollection.Add(new XAttribute("count", this.m_files.Count().ToString()));
            foreach (var file in this.m_files)
            {
                XElement fileElem = new XElement("file");
                fileElem.Add(new XElement("path") { Value = file.Path.Substring(Path.Length) });
                fileElem.Add(new XElement("hash") { Value = file.Hash });
                XElement literalsCollection = new XElement("literals");
                literalsCollection.Add(new XAttribute("count", file.Count().ToString()));
                foreach (var literal in file)
                {
                    XElement literalElem = new XElement("literal");
                    if (literal.IsInterpolated) literalElem.Add(new XAttribute("interpolated", "true"));
                    literalElem.Add(new XElement("id") { Value = literal.Id });
                    literalElem.Add(new XElement("line") { Value = literal.LineNumber.ToString() });
                    literalElem.Add(new XElement("pos") { Value = literal.LinePosition.ToString() });
                    literalElem.Add(new XElement("len") { Value = literal.Length.ToString() });
                    literalElem.Add(new XElement("value") { Value = literal.Value });
                    literalsCollection.Add(literalElem);
                }
                fileElem.Add(literalsCollection);
                filesCollection.Add(fileElem);
            } // foreach

            rootElem.Add(filesCollection);
            doc.Add(rootElem);
            doc.Save(stream);
        } // Save

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

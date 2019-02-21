using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Globalizer.Code
{
    public class Processor
    {

        private readonly Project m_project;
        public Processor(Project project)
        {
            this.m_project = project;
        } // constructor

        public void Process()
        {
            foreach(CodeFile file in this.m_project)
            {

            } // foreach
        } // Processor

        private bool ProcessFile(CodeFile file)
        {
            if (!file.CheckHash()) return false;
            if (!MakeBackup(file)) return false;
            string[] lines = File.ReadAllLines(file.FullPath, this.m_project.Encoding);
            List<string> output = new List<string>();
            int[] linenumbers = file.Where(l=> Literal.WorkStates.Ignored != l.WorkState).Select(l=> l.LineNumber).ToArray();
            for(int l = 1 ; l <= lines.Length ; ++l)
            {
                string currentSourceLine = lines[l-1];
                if (linenumbers.Contains(l))
                {
                    IEnumerable<Literal> lineLiterals = file.Where(ltr => ltr.LineNumber == l);
                    foreach(var lit in lineLiterals)
                    {
                        if (lit.IsInterpolated)
                        {
                            // Substitute interpolated string to string.Format
                        }
                        else
                        {

                        }
                    } // for each line literals
                } // if line has literals
            } // for line number

            return true;
        } // ProcessFile

        private bool MakeBackup(CodeFile file)
        {
            try
            {
                string backupFile = Path.Combine(Path.GetDirectoryName(file.FullPath), Path.GetFileNameWithoutExtension(file.FullPath) + ".bak");
                if (File.Exists(backupFile)) File.Delete(backupFile);
                File.Copy(file.FullPath, backupFile);
                return true;
            } // try
            catch
            {
                return false;
            } // catch
        } // MakeBackup

    } // class Processor
} // namespace

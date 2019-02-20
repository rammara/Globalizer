using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Globalizer.Code
{
    public class Literal
    {
        public string Id { get; set; }
        public string FullPath { get; protected set; }
        public int LineNumber { get; protected set; }
        public int LinePosition { get; protected set; }
        public int Length { get; protected set; }
        public string Value { get; protected set; }
        public CodeFile File { get; protected set; }
        public string Substitution { get; set; }
        public bool IsInterpolated { get; protected set; }
        public Literal(string id, CodeFile file, int linenumber, Match match, bool interpolated)
        {
            this.Id = id;
            this.File = file;
            this.LineNumber = linenumber;
            this.Length = match.Length;
            this.LinePosition = match.Index;
            this.Value = match.Value;
            this.IsInterpolated = interpolated;
        } // Literal

    } // class Literal
} // namespace Stringrefactoring

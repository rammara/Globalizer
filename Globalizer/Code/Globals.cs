using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Globalizer.Code
{
    public static class Globals
    {
        public const string CSHARP_DEFAULT_PATTERN = @"""[^""\\]*(?:\\.[^""\\]*)*""";               //"(?=(^((?!///).)*$)).*((\".+? \")|('.+?')).*";
        public const string CSHARP_DEFAULT_FILEMASK = "*.cs";
        public static string CheckPattern { get; set; } = CSHARP_DEFAULT_PATTERN;
        public static string FileSearchMask { get; set; } = CSHARP_DEFAULT_FILEMASK;
    }
}

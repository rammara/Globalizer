using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Globalizer.Code
{
    public static class Globals
    {
        public const string CSHARP_DEFAULT_REGEX = @"""[^""\\]*(?:\\.[^""\\]*)*""";
        public const string CSHARP_DEFAULT_FILEMASK = "*.cs";
        public static string StringRegExp { get; set; } = CSHARP_DEFAULT_REGEX;
        public static string FileSearchMask { get; set; } = CSHARP_DEFAULT_FILEMASK;


    } // Globals
} // namespace

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webzor.Core.Helpers
{
    public static class StringHelper
    {
        public static string CombinePath(string path1, string path2) 
        {
            return ToUnixPath(Path.Combine(path1, path2));           
        } 
        public static string CombinePath(string path1, string path2, string path3)
        {
            return ToUnixPath(Path.Combine(path1, path2, path3));
        }

        public static string ToUnixPath(string path) 
        {
            return path.Replace("\\\\", "/").Replace("\\", "/");
        }
    }
}

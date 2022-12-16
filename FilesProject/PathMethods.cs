using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesProject
{
    public class PathMethods
    {
        public static string Paths(string path)
        {
            //string path = @"C:\Users\lenovo\Documents\tempDocs\cs-cheat-sheet.pdf";

            return "Extension: " + Path.GetExtension(path);
            //Console.WriteLine("File name: " + Path.GetFileName(path));
            //Console.WriteLine("Filename without extension: " + Path.GetFileNameWithoutExtension(path));
            //Console.WriteLine("Directory name: " + Path.GetDirectoryName(path));
        }
    }
}

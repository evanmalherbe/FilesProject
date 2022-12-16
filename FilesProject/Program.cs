using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Linq;

namespace FilesProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //FileMethods.Files();
            //DirectoryMethods.Directories();

            // Path methods
            //string answer = PathMethods.Paths(@"C:\Users\lenovo\Documents\tempDocs\cs - cheat - sheet.pdf");
            // Console.WriteLine(answer);

            // Exercise 1 - num of words in text file
            Console.WriteLine("Number of words: " + TextFiles.CountWords(@"c:\Users\lenovo\Downloads\test.txt"));

            // Exercise 2 - Display longest word in text file
            Console.WriteLine(TextFiles.LongestWord(@"c:\Users\lenovo\Downloads\test.txt"));
        }
    }
}

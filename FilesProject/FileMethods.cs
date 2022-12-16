using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FilesProject
{
    public class FileMethods
    {
        public static void Files()
        {
            //File methods
            string path = @"c:\Users\lenovo\Downloads\";
            string fileName = "test.txt";
            string fileName2 = "test2.txt";

            // Static methods
            string content = File.ReadAllText(path + fileName);
            Console.WriteLine(content);

            File.Copy(path + fileName, path + fileName2, true);
            File.Delete(path + fileName);

            if (File.Exists(path + fileName))
            {
                Console.WriteLine("File called: " + fileName + " exists.");
            }
            else
            {
                Console.WriteLine("File called: " + fileName + " does not exist.");
            }

            // Instance methods
            FileInfo fileInfo = new FileInfo(path + fileName2);
            fileInfo.CopyTo(path + fileName);
            fileInfo.Delete();

            if (fileInfo.Exists)
            {
                Console.WriteLine(path + fileName2 + " exists.");
            }
            else
            {
                Console.WriteLine(path + fileName2 + " does not exist.");
            }
        }
    }
}

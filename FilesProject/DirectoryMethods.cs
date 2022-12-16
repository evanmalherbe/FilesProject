using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FilesProject
{
    public class DirectoryMethods
    {
        public static void Directories()
        {
            //Directory methods
            Directory.CreateDirectory(@"c:\Users\lenovo\Documents\tempDocs\test");

            string[] files = Directory.GetFiles(@"c:\Users\lenovo\Documents\tempDocs", "*.*", SearchOption.AllDirectories);
            foreach (string file in files)
                Console.WriteLine(file);

            string[] directories = Directory.GetDirectories(@"c:\Users\lenovo\Documents\tempDocs", "*.*", SearchOption.AllDirectories);
            foreach (string directory in directories)
                Console.WriteLine(directory);

            bool exists = Directory.Exists(@"c:\Users\lenovo\Documents\tempDocs\test");
            Console.WriteLine(exists);

            DirectoryInfo dir = new DirectoryInfo(@"c:\Users\lenovo\Documents\tempDocs");
            //FileInfo[] list = dir.GetFiles();
            //foreach(FileInfo file in list)
            //    Console.WriteLine(file.FullName);

            DirectoryInfo[] directoryList = dir.GetDirectories();
            foreach (DirectoryInfo directory in directoryList)
                Console.WriteLine(directory.FullName);
        }
    }
}

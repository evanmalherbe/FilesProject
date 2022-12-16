using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FilesProject
{
    public class TextFiles
    {
        public static int CountWords(string path)
        {
            // Exercise 1 - num of words in text file
            //string path = @"c:\Users\lenovo\Downloads\";
            //string fileName = "test.txt";

            // Static methods
            string content = File.ReadAllText(path);
            //Console.WriteLine(content);

            string[] words = content.Split(' ');
            //foreach (string word in words)
            //    Console.WriteLine(word);

            return words.Length;
        }

        public static string LongestWord(string path)
        {
            // Exercise 2 - Display longest word in text file
            //string path2 = @"c:\Users\lenovo\Downloads\";
            //string fileName2 = "test.txt";

            // Static methods
            string content2 = File.ReadAllText(path);
            //Console.WriteLine(content);

            string[] words2 = content2.Split(' ');
            int[] lengths = new int[words2.Length];

            for (int i = 0; i < words2.Length; i++)
            {
                lengths[i] = (words2[i].Length);
            }

            Array.Sort(lengths, words2);

            return words2[words2.Length - 1];
        }
    }
}

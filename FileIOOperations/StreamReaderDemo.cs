using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FileIOOperations
{
    class StreamReaderDemo
    {
        public void ReadFromStreamReader()
        {
            string path = @"E:\ASP.NET\FileIOOperations\Example.txt";

            using (StreamReader sr = File.OpenText(path))
            {
                string s = " ";
                while((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
        }

        public void WriteUsingStreamWriter()
        {
            string path = @"E:\ASP.NET\FileIOOperations\Example.txt";
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine("Added using Stream Writer!");
                sw.Close();

                Console.WriteLine(File.ReadAllText(path));
            }
        }
    }
}

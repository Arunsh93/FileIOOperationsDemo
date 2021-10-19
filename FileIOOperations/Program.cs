using System;
using System.IO;

namespace FileIOOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            FileExist();
            ReadFromTheFile();
            DeleteFile();
            CopyFile();

            StreamReaderDemo readerDemo = new StreamReaderDemo();
            readerDemo.ReadFromStreamReader();
            readerDemo.WriteUsingStreamWriter();

            BinarySerialize binarySerialize = new BinarySerialize();
            binarySerialize.Serialization();

            binarySerialize.DeSerialization();
           
        }

        public static void FileExist()
        {
            string path = @"E:\ASP.NET\FileIOOperations\Example.txt";
            if(File.Exists(path))
            {
                Console.WriteLine("File Exist");
            }
            else
            {
                Console.WriteLine("File not Exist");
            }
        }

        public static void ReadFromTheFile()
        {
            string path = @"E:\ASP.NET\FileIOOperations\Example.txt";
            string lines;
            lines = File.ReadAllText(path);
            Console.WriteLine(lines);
            //Console.WriteLine(lines[1]);
        }

        public static void DeleteFile()
        {
            string path = @"E:\ASP.NET\FileIOOperations\Example1.txt";
            if (File.Exists(path))
            {
                File.Delete(path);
                Console.WriteLine("File Deleted");
            }
            else
            {
                Console.WriteLine("File Not Deleted");
            }
           
        }

        public static void CopyFile()
        {
            string sourcePath = @"E:\ASP.NET\FileIOOperations\Example.txt";
            string DestinationPath = @"E:\ASP.NET\FileIOOperations\CopyFile\CopiedFile.txt";
            File.Copy(sourcePath, DestinationPath);
            Console.WriteLine("File Copied!");
        }
        
    }
}

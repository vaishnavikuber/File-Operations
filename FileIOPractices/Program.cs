using System;
using System.IO;

namespace FileIOPractices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------File Handling---------");

            //TXTFileOperations.TXTFile();

            //TXTFileOperations.WriteFile();

            //TXTFileOperations.DeleteFile();

            //TXTFileOperations.ReadFile();

            //TXTFileOperations.CopyFile();

            //CSVFileOperations.CreateFile();

            //CSVFileOperations.WriteFile();

            //CSVFileOperations.ReadFile();

            //JSONFileOperations.CreateFile();

            //JSONFileOperations.WriteFile();

            //JSONFileOperations.DeleteFile();

            Directory();

            //FileStreamPrac.FileStraemMtd();

            //FileStreamPrac.StreamReadWrite();
        }


        public static void Directory()
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\vaish\source\repos\FileIOPractices\FileIOPractices");
            Console.WriteLine(dir.FullName);
            Console.WriteLine(dir.Attributes);
            Console.WriteLine(dir.Name);
            Console.WriteLine(dir.Parent);
            Console.WriteLine(dir.CreationTime);


            FileInfo file = new FileInfo(@"C:\Users\vaish\source\repos\FileIOPractices\FileIOPractices\NewTxtFile.txt");
            Console.WriteLine(file.FullName);
            Console.WriteLine(file.Attributes);
            Console.WriteLine(file.Name);
            Console.WriteLine(file.Length);
            Console.WriteLine(file.CreationTime);

            FileInfo[] files = dir.GetFiles("*.txt", SearchOption.AllDirectories);
            Console.WriteLine($"Matches: {files.Length}");

            foreach(FileInfo f in  files)
            {
                Console.WriteLine(f.Name+"  "+f.Length);
            }
        }

    }
}

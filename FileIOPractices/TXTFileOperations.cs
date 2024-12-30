using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FileIOPractices
{
    internal class TXTFileOperations
    {

        public static void TXTFile()
        {
            string path = @"C:\Users\vaish\source\repos\FileIOPractices\FileIOPractices\NewTxtFile.txt";

            if (File.Exists(path))
            {
                Console.WriteLine("The File Exists in the project");
            }
            else
            {
                File.Create(path);
                Console.WriteLine("The file does not exist!!!, so created new txt file.");
            }
        }

        public static void WriteFile()
        {
            string path = @"C:\Users\vaish\source\repos\FileIOPractices\FileIOPractices\NewTxtFile.txt";
            if (File.Exists(path))
            {
                File.WriteAllText(path, "Hello World!!!\n");
                File.AppendAllText(path, "Hiii User , Welcome to file");
                Console.WriteLine("Written into file.");
                
            }
            else
            {
                Console.WriteLine("File does not exists");
            }
        }

        public static void ReadFile()
        {
            string path = @"C:\Users\vaish\source\repos\FileIOPractices\FileIOPractices\NewTxtFile.txt";

            string[] lines;
                try
                {
                    lines= File.ReadAllLines(path);
                    Console.WriteLine($"{lines[0]}\n{lines[1]}");
                 
                    string text=File.ReadAllText(path);
                    Console.WriteLine(text );
                }
                catch(FileNotFoundException e)
                {
                    Console.WriteLine($"{e.Message}");
                }
                
            
        }

        public static void DeleteFile()
        {
            string path = @"C:\Users\vaish\source\repos\FileIOPractices\FileIOPractices\NewTxtFile.txt";

            try
            {
                File.Delete(path);
                Console.WriteLine("File deleted");
            }
            catch(Exception e)
            {
                Console.WriteLine($"{e.Message}");
            }

        }

        public static void CopyFile()
        {
            string sourcePath = @"C:\Users\vaish\source\repos\FileIOPractices\FileIOPractices\NewTxtFile.txt";

            string destinationPath = @"C:\Users\vaish\source\repos\FileIOPractices\FileIOPractices\TxtFile.txt";

            try
            {
                File.Copy(sourcePath, destinationPath);
                Console.WriteLine("Copied");
            }
            catch(Exception e)
            {
                Console.WriteLine($"{e.Message}");
            }
        }

    }
}

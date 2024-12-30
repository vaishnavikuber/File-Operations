using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FileIOPractices
{
    internal class CSVFileOperations
    {

        public static void CreateFile()
        {
            string path = @"C:\Users\vaish\source\repos\FileIOPractices\FileIOPractices\NewCsvFile.csv";
            
            if(File.Exists(path))
            {
                Console.WriteLine("file already exists!!!");
            }
            else
            {
                File.Create(path);
                Console.WriteLine("File not exists , so created new file");
            }
        }

        public static void WriteFile()
        {
            string path = @"C:\Users\vaish\source\repos\FileIOPractices\FileIOPractices\NewCsvFile.csv";

            if (File.Exists(path))
            {
                File.WriteAllText(path, "Hello Bangalore People!!!");
                Console.WriteLine("Written");

                File.AppendAllText(path, "How are you?");
                Console.WriteLine("Added text to exixting text");
            }
            else
            {
                Console.WriteLine("File does not exists");
            }
        } 

        public static void ReadFile()
        {
            string path = @"C:\Users\vaish\source\repos\FileIOPractices\FileIOPractices\NewCsvFile.csv";

            try
            {
                string text= File.ReadAllText(path);
                Console.WriteLine(text);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

    }
}

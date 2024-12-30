using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FileIOPractices
{
    internal class JSONFileOperations
    {

        public static void CreateFile()
        {
            string path = @"C:\Users\vaish\source\repos\FileIOPractices\FileIOPractices\NewJsonFile.json";
            try
            {
                File.Create(path);
                Console.WriteLine("Created");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void WriteFile()
        {
            string path = @"C:\Users\vaish\source\repos\FileIOPractices\FileIOPractices\NewJsonFile.json";

            try
            {
                File.WriteAllText(path, "Hello World");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
           
        }

        public static void DeleteFile()
        {
            string path = @"C:\Users\vaish\source\repos\FileIOPractices\FileIOPractices\NewJsonFile.json";

            try
            {
                File.Delete(path);
                Console.WriteLine("Deleted file.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

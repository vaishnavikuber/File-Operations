using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FileIOPractices
{
    internal class FileStreamPrac
    {

        public static void FileStraemMtd()
        {

            string path = @"C:\Users\vaish\source\repos\FileIOPractices\FileIOPractices\NewStreamFile.txt";

            FileStream fs = File.Open(path, FileMode.Create);

            string str = "Ba ba black sheep";

            byte[] byteArray = Encoding.Default.GetBytes(str);

            fs.Write(byteArray, 0, byteArray.Length);

            fs.Position = 0;

            Console.WriteLine(Encoding.Default.GetString(byteArray));

            fs.Close();


        }

        public static void StreamReadWrite()
        {
            string path = @"C:\Users\vaish\source\repos\FileIOPractices\FileIOPractices\StreamFile2.txt";

            StreamWriter sw = File.CreateText(path);

            sw.Write("Hiii");
            sw.Write("Hello Everybody");
            sw.Write("How r u");

            sw.Close();

            StreamReader sr = File.OpenText(path);

            Console.WriteLine($"Peek : {Convert.ToChar(sr.Peek())}"); 
            Console.WriteLine($"1st string : {sr.ReadLine()}");
            //Console.WriteLine($"Entire lines: {sr.ReadToEnd()}");

            
        }

    }
}

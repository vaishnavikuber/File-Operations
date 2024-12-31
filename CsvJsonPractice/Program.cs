using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using CsvHelper;

namespace CsvJsonPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Person p = new Person();

            //p.CsvWriteRead();
            p.JsonWriteRead();

        }
    }
}

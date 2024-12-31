using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.IO;
using System.Text;
using System.Text.Json.Serialization;
using CsvHelper;
using Newtonsoft.Json;

namespace CsvJsonPractice
{
    public class Person
    {
        [Required(ErrorMessage ="Id is required")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        [RegularExpression(@"^[A-Z]{1}[a-z]{2,}",ErrorMessage ="Start with capital and remaining small")]
        public string Name { get; set; }
        [EmailAddress(ErrorMessage ="Email is not valid")]
        public string Email { get; set; }
        [RegularExpression(@"\d{10}",ErrorMessage ="phone number should have 10 digits")]
        public string Phone { get; set; }
        [RegularExpression(@"\d{5,6}", ErrorMessage = "zip should have 10 digits")]
        public int Zip {  get; set; }


        public List<Person> PersonDataList()
        {
            var personData = new List<Person>()
            {
                new Person(){Id=1,Name="Rani",Email="rani@gmail.com",Phone="6578764325",Zip=456786},
                new Person(){Id=2,Name="Gani",Email="gani@gmail.com",Phone="8978764390",Zip=578787},
                new Person(){Id=1,Name="Yamini",Email="yamini@gmail.com",Phone="5678564312",Zip=58678}
            };

            var context= new ValidationContext(personData);
            var errorResult= new List<ValidationResult>();
            bool isValid = Validator.TryValidateObject(personData, context, errorResult, true);

            if(isValid )
            {
                return personData;
            }

            return null;
        }

        public void CsvWriteRead()
        {
            var personData = PersonDataList();

            //CSV file IO
            string filePath = @"C:\Users\vaish\source\repos\CsvJsonPractice\CsvJsonPractice\person.csv";

            if (File.Exists(filePath))
            {
                using (var writer = new StreamWriter(filePath))
                using (var csvWriter = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csvWriter.WriteRecords(personData);
                }
                Console.WriteLine("The data is added successfully");

                using (var reader = new StreamReader(filePath))
                using (var csvReader = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    var data = csvReader.GetRecords<Person>();
                    foreach (var person in data)
                    {
                        Console.WriteLine($"Id: {person.Id}, Name: {person.Name}, Email: {person.Email}, Phone: {person.Phone}, Zip: {person.Zip}");

                    }
                }
            }
            else
            {
                File.Create(filePath);
                Console.WriteLine("File doesnot Exists, so created new");
            }
            
        }

        public void JsonWriteRead()
        {
            var personData = PersonDataList();

            string filePath = @"C:\Users\vaish\source\repos\CsvJsonPractice\CsvJsonPractice\personData.json";

            if (File.Exists(filePath))
            {
                string jsonData = JsonConvert.SerializeObject(personData, Formatting.Indented);
                File.WriteAllText(filePath, jsonData);
                Console.WriteLine("data added successfully");

                string jsonRead = File.ReadAllText(filePath);
                var jsonDesData = JsonConvert.DeserializeObject<List<Person>>(jsonRead);
                foreach(var person in jsonDesData)
                {
                    Console.WriteLine($"Id: {person.Id}, Name: {person.Name}, Email: {person.Email}, Phone: {person.Phone}, Zip: {person.Zip}");

                }
            }
            else
            {
                File.Create(filePath);
                Console.WriteLine("File doesnot Exists, so created new");
            }
        }

    }
}

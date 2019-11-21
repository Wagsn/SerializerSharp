using System;
using System.Collections.Generic;
using System.Text;

namespace SerializerSharp
{
    internal class CSVTest
    {
        public static void Test()
        {
            Console.WriteLine("CSV: CsvHelper.CsvReader|CsvWriter");
            // CsvHelper.CsvReader 只支持流
            var source = "Name,Age,Sex\r\nWagsn,23,True\r\nBruce,25,True\r\n";
            using (CsvHelper.CsvReader reader = new CsvHelper.CsvReader(new System.IO.StreamReader(ConvertHelper.ConvertToStream(source))))
            {
                foreach (var per in reader.GetRecords<Person>())
                {
                    Console.WriteLine($"deserialize: name: {per?.Name}, age: {per?.Age}, sex: {per?.Sex}");
                }
            }
            var path = "./CSV/person.csv";
            using (CsvHelper.CsvWriter writer = new CsvHelper.CsvWriter(new System.IO.StreamWriter(System.IO.File.OpenWrite(path))))
            {
                var per = new Person { Name = "Wagsn", Age = 23, Sex = true };
                writer.WriteRecords(new List<Person> { per });
            }
        }
        public class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public bool Sex { get; set; }
        }
    }
}

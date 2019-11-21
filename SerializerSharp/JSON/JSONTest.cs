using System;
using System.Collections.Generic;
using System.Text;

namespace SerializerSharp.JSON
{
    internal class JSONTest
    {
        public static void Test()
        {
            Console.WriteLine("json: Newtonsoft.Json.JsonConvert");
            var per = Newtonsoft.Json.JsonConvert.DeserializeObject<Person>("{\"Name\": \"Wagsn\",\"Age\": 23,\"Sex\": true}");
            Console.WriteLine($"deserialize: name: {per?.Name}, age: {per?.Age}, sex: {per?.Sex}");
            Console.WriteLine($"serialize: {Newtonsoft.Json.JsonConvert.SerializeObject(per)}");
        }

        public class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public bool Sex { get; set; }
        }
    }
}

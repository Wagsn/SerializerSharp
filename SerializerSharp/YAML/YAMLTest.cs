using System;
using System.Collections.Generic;
using System.Text;

namespace SerializerSharp.YAML
{
    internal class YAMLTest
    {
        public static void Test()
        {
            Console.WriteLine("YAML: YamlDotNet.Serialization.Deserializer|Serializer");
            var zer = new YamlDotNet.Serialization.Deserializer();
            var per = zer.Deserialize<Person>("Name: Wagsn\r\nAge: 23\r\nSex: true");
            Console.WriteLine($"deserialize: name: {per?.Name}, age: {per?.Age}, sex: {per?.Sex}");
            var ser = new YamlDotNet.Serialization.Serializer();
            Console.WriteLine($"serialize: {ser.Serialize(per)}");
        }
        public class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public bool Sex { get; set; }
        }
    }
}

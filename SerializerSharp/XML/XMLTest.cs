using System;
using System.Collections.Generic;
using System.Text;

namespace SerializerSharp.XML
{
    internal class XMLTest
    {
        public static void Test()
        {
            Console.WriteLine("XML: System.Xml.Serialization.XmlSerializer");
            var ser = new System.Xml.Serialization.XmlSerializer(typeof(Person));
            var der = new System.IO.StreamReader("./XML/person.xml");
            var per = (Person)ser.Deserialize(der);
            der.Close();
            Console.WriteLine($"deserialize: name: {per?.Name}, age: {per?.Age}, sex: {per?.Sex}");
            per.Age = 24;
            var ter = System.IO.File.CreateText("./XML/person.xml");
            ser.Serialize(ter, per);
            ter.Close();
            Console.WriteLine($"serialize: ");
        }
        public class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public bool Sex { get; set; }
        }
    }
}

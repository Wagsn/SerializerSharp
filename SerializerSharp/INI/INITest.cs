using System;
using System.Collections.Generic;
using System.Text;

namespace SerializerSharp.INI
{
    internal class INITest
    {
        public static void Test()
        {
            Console.WriteLine("INI: PeanutButter.INIFile.INIFile, 没有序列化器");
            var ini = new PeanutButter.INIFile.INIFile();
            ini.Parse("[person]\r\nName=Wagsn\r\nAge=23\r\nSex=true");
            Console.WriteLine($"deserialize: name: {ini.GetValue("person", "Name")}, age: {ini.GetValue("person", "Age")}, sex: {ini.GetValue("person", "Sex")}");
            //Console.WriteLine($"serialize: {ini.}");
        }

        public class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public bool Sex { get; set; }
        }
    }
}

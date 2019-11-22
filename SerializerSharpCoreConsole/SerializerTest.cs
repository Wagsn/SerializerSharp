using System;
using System.Collections.Generic;
using System.Text;

namespace SerializerSharpDemo
{
    class SerializerTest
    {
        public static void Test()
        {
            JsonTest();
            Console.WriteLine();
            YamlTest();
        }

        public static void JsonTest()
        {
            Console.WriteLine("JSON:");
            var serializer = new SerializerSharp.JSON.JsonSerializer();
            var person = new Person { Name = "Wagsn", Age = 23, Sex = true };
            var content = serializer.Serialize(person);
            Console.WriteLine("Serialize: \r\n" + content);
            var entity = serializer.Deserialize<Person>(content);
            Console.WriteLine($"Deserialize: name={entity.Name}, " + entity);
            entity.Age++;
            Console.WriteLine("Serialize after Modified value: \r\n" + serializer.Serialize(entity));
            var entityFromFile = serializer.Deserialize<Person>(System.IO.File.OpenRead("person.json"));
            Console.WriteLine($"Deserialize from file: name={entityFromFile.Name}, " + entityFromFile);
        }

        public static void YamlTest()
        {
            Console.WriteLine("YAML:");

            var serializer = new SerializerSharp.YAML.YamlSerializer();

            // 序列化
            var person = new Person { Name = "Wagsn", Age = 23, Sex = true };
            var content = serializer.Serialize(person);
            Console.WriteLine("Serialize: \r\n" + content);

            // 反序列化
            var entity = serializer.Deserialize<Person>(content);
            Console.WriteLine($"Deserialize: name={entity.Name}, " + entity);

            // 序列化 改值之后
            entity.Age++;
            Console.WriteLine($"Serialize after Modified value: \r\n{serializer.Serialize(entity)}");

            // 反序列化 从文件
            var entityFromFile = serializer.Deserialize<Person>(System.IO.File.OpenRead("person.yaml"));
            Console.WriteLine($"Deserialize from file: name={entityFromFile.Name}, " + entityFromFile);
        }

        public class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public bool Sex { get; set; }
        }
    }

}

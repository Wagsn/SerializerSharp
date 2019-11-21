using System;
using System.Collections.Generic;
using System.Text;

namespace SerializerSharp
{
    class Program
    {
        public static void Main(string[] args)
        {
            // The three party Serializer
            ThirdPartyTest();

            Console.ReadKey();
        }

        public static void ThirdPartyTest()
        {
            // The three party Serializer
            YAML.YAMLTest.Test();
            Console.WriteLine();
            JSON.JSONTest.Test();
            Console.WriteLine();
            XML.XMLTest.Test();
            Console.WriteLine();
            INI.INITest.Test();
            Console.WriteLine();
            CSVTest.Test();
            Console.WriteLine();
            Props.PropertiesSerializerTest.Test();
        }
    }
}

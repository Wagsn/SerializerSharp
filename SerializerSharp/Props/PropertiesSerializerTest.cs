using System;
using System.Collections.Generic;
using System.Text;

namespace SerializerSharp.Props
{
    internal class PropertiesSerializerTest
    {
        public static void Test()
        {
            Console.WriteLine("Properties: MosaicoSolutions.CSharpProperties.PropertiesBuilder");
            var content = @"environments.dev.url=http://dev.bar.com
environments.dev.name=Developer Setup
environments.prod.url=http://foo.bar.com
environments.prod.name=My Cool App
my.servers[0]=dev.bar.com
my.servers[1]=foo.bar.com";
            var per = MosaicoSolutions.CSharpProperties.Properties.LoadFromString(content);
            Console.WriteLine($"environments.dev.name: {per["environments.dev.name"]}");

        }
    }
}

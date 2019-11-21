using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;

namespace SerializerSharp.CSV
{
    /// <summary>
    /// CSV Serializer
    /// </summary>
    public class CsvSerializer : ISerializer
    {
        public string Name { get; set; } = "CsvHelper";

        public TypeEntity Deserialize<TypeEntity>(string content)
        {
            if (typeof(TypeEntity).IsAssignableFrom(typeof(System.Collections.IEnumerable)))
            {
                var instan = ((System.Collections.IEnumerable)typeof(TypeEntity).Assembly.CreateInstance(typeof(TypeEntity).FullName));
                var list = new List<object>();
                using (CsvHelper.CsvReader reader = new CsvHelper.CsvReader(new StreamReader(ConvertHelper.ConvertToStream(content))))
                {
                    foreach (var per in reader.GetRecords(instan.AsQueryable().ElementType))
                    {
                        list.Add(per);
                    }
                }
                instan = list;
                return (TypeEntity)instan;
            }
            throw new InvalidCastException(typeof(TypeEntity).Name+ " is not IEnumerable");
        }

        public TypeEntity Deserialize<TypeEntity>(Stream stream)
        {
            throw new NotImplementedException();
        }

        public object Deserialize(string content, Type type)
        {
            throw new NotImplementedException();
        }

        public string Serialize(object entity)
        {
            throw new NotImplementedException();
        }

        public void Serialize(object entity, Stream stream)
        {
            throw new NotImplementedException();
        }
    }
}

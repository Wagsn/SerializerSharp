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
        /// <summary>
        /// Serializer Name
        /// </summary>
        public string Name { get; set; } = "CsvHelper";

        /// <summary>
        /// Deserialize
        /// </summary>
        /// <typeparam name="TypeEntity"></typeparam>
        /// <param name="content"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Deserialize
        /// </summary>
        /// <typeparam name="TypeEntity"></typeparam>
        /// <param name="stream"></param>
        /// <returns></returns>
        public TypeEntity Deserialize<TypeEntity>(Stream stream)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deserialize
        /// </summary>
        /// <param name="content"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public object Deserialize(string content, Type type)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Serialize
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public string Serialize(object entity)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Serialize
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="stream"></param>
        public void Serialize(object entity, Stream stream)
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SerializerSharp.JSON
{
    /// <summary>
    /// JSON序列化器
    /// </summary>
    public class JsonSerializer : ISerializer
    {
        /// <summary>
        /// Serializer Name
        /// </summary>
        public string Name { get; set; } = "Newtonsoft.Json";

        /// <summary>
        /// Deserialize
        /// </summary>
        /// <typeparam name="TypeEntity"></typeparam>
        /// <param name="content"></param>
        /// <returns></returns>
        public TypeEntity Deserialize<TypeEntity>(string content)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<TypeEntity>(content);
        }

        /// <summary>
        /// Deserialize
        /// </summary>
        /// <typeparam name="TypeEntity"></typeparam>
        /// <param name="stream"></param>
        /// <returns></returns>
        public TypeEntity Deserialize<TypeEntity>(Stream stream)
        {
            using(var reader = new StreamReader(stream))
            {
                return Deserialize<TypeEntity>(reader.ReadToEnd());
            }
        }

        /// <summary>
        /// Deserialize
        /// </summary>
        /// <param name="content"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public object Deserialize(string content, Type type)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject(content, type);
        }

        /// <summary>
        /// Serialize
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public string Serialize(object entity)
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(entity);
        }

        /// <summary>
        /// Serialize
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="stream"></param>
        public void Serialize(object entity, Stream stream)
        {
            using(var writer = new StreamWriter(stream))
            {
                writer.Write(Serialize(entity));
            }
        }
    }
}

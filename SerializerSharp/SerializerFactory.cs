using System;
using System.Collections.Generic;
using System.Text;

namespace SerializerSharp
{
    /// <summary>
    /// Serializer Factory
    /// </summary>
    public class SerializerFactory : ISerializerFactory
    {
        private Dictionary<string, ISerializer> Serializers { get; } = new Dictionary<string, ISerializer>();

        /// <summary>
        /// Serializer Factory Constructor
        /// </summary>
        public SerializerFactory()
        {
            AddSerializer<JSON.JsonSerializer>();
            AddSerializer<YAML.YamlSerializer>();
        }

        /// <summary>
        /// Get Serializer By Name
        /// </summary>
        /// <param name="serializerName"></param>
        /// <returns></returns>
        public ISerializer GetByName(string serializerName)
        {
            return Serializers[serializerName];
        }

        /// <summary>
        /// Add Serializer into Factory
        /// </summary>
        /// <param name="serializer"></param>
        public void AddSerializer(ISerializer serializer)
        {
            Serializers[serializer.Name] = serializer;
        }

        /// <summary>
        /// Add Serializer into Factory
        /// </summary>
        /// <typeparam name="TSerializer"></typeparam>
        public void AddSerializer<TSerializer>() where TSerializer: ISerializer, new()
        {
            var serializer = new TSerializer();
            Serializers[serializer.Name] = serializer;
        }
    }
}

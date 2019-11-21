using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SerializerSharp.YAML
{
    /// <summary>
    /// YAML序列化器
    /// </summary>
    public class YamlSerializer : ISerializer
    {
        private YamlDotNet.Serialization.Deserializer _deserializer;
        private YamlDotNet.Serialization.Serializer _serializer;

        public string Name { get; set; } = "YamlDotNet";

        public TypeEntity Deserialize<TypeEntity>(string content)
        {
            if (_deserializer == null) _deserializer = new YamlDotNet.Serialization.Deserializer();
            return _deserializer.Deserialize<TypeEntity>(content);
        }

        public TypeEntity Deserialize<TypeEntity>(Stream stream)
        {
            if (_deserializer == null) _deserializer = new YamlDotNet.Serialization.Deserializer();
            return _deserializer.Deserialize<TypeEntity>(new StreamReader(stream));
        }

        public object Deserialize(string content, Type type)
        {
            if (_deserializer == null) _deserializer = new YamlDotNet.Serialization.Deserializer();
            return _deserializer.Deserialize(content, type);
        }

        public string Serialize(object entity)
        {
            if (_serializer == null) _serializer = new YamlDotNet.Serialization.Serializer();
            return _serializer.Serialize(entity);
        }

        public void Serialize(object entity, Stream stream)
        {
            if (_serializer == null) _serializer = new YamlDotNet.Serialization.Serializer();
            _serializer.Serialize(new StreamWriter(stream), entity);
        }
    }
}

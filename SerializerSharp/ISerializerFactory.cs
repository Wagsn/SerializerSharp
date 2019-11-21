using System;
using System.Collections.Generic;
using System.Text;

namespace SerializerSharp
{
    /// <summary>
    /// 序列化器工厂
    /// </summary>
    public interface ISerializerFactory
    {
        /// <summary>
        /// 通过序列化器名称从工厂中获取序列化器
        /// </summary>
        /// <param name="serializerName"></param>
        /// <returns></returns>
        ISerializer GetByName(string serializerName);

        /// <summary>
        /// 添加序列化器
        /// </summary>
        /// <param name="serializer"></param>
        /// <returns></returns>
        void AddSerializer(ISerializer serializer);

        /// <summary>
        /// 添加序列化器
        /// </summary>
        /// <typeparam name="TSerializer"></typeparam>
        void AddSerializer<TSerializer>() where TSerializer : ISerializer, new();
    }
}

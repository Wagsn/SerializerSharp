using System;
using System.Collections.Generic;
using System.Text;

namespace SerializerSharp
{
    /// <summary>
    /// 序列化器
    /// 轻量对象处理
    /// 用于处理结构化数据的序列化与反序列化
    /// </summary>
    public interface ISerializer
    {
        /// <summary>
        /// 序列化器的名称（唯一，与序列化语言无关）
        /// </summary>
        string Name { get; set; }
        /// <summary>
        /// 反序列化
        /// 从字符串到指定类型对象
        /// </summary>
        /// <typeparam name="TypeEntity">实体类型</typeparam>
        /// <param name="content">序列化文本</param>
        /// <returns></returns>
        TypeEntity Deserialize<TypeEntity>(string content);
        /// <summary>
        /// 反序列化
        /// </summary>
        /// <param name="content">序列化文本</param>
        /// <param name="type">目标类型</param>
        /// <returns></returns>
        object Deserialize(string content, Type type);
        /// <summary>
        /// 反序列化
        /// 从流到指定类型对象
        /// </summary>
        /// <typeparam name="TypeEntity"></typeparam>
        /// <param name="stream"></param>
        /// <returns></returns>
        TypeEntity Deserialize<TypeEntity>(System.IO.Stream stream);
        /// <summary>
        /// 序列化
        /// 从对象到字符串
        /// 注：某些Byte模式的序列化器不支持输出String
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        string Serialize(object entity);
        /// <summary>
        /// 序列化
        /// 从对象到流
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="stream">写入流</param>
        void Serialize(object entity, System.IO.Stream stream);
        // TODO 配置注入
    }
}

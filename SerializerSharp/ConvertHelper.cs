using System;
using System.Collections.Generic;
using System.Text;

namespace SerializerSharp
{
    internal class ConvertHelper
    {
        public static System.IO.MemoryStream ConvertToStream(string content)
        {
            return new System.IO.MemoryStream(Encoding.ASCII.GetBytes(content));
        }
    }
}

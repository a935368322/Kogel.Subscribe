using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Buffers;
using Kogel.Slave.Mysql.Extensions;

namespace Kogel.Slave.Mysql
{
    class FloatType : IDataType
    {
        public object ReadValue(ref SequenceReader<byte> reader, int meta)
        {
            byte[] bytes = BitConverter.GetBytes(reader.ReadInteger(4));
            return BitConverter.ToSingle(bytes, 0);
        }
    }
}

﻿using JT808.Protocol.Extensions;
using JT808.Protocol.MessageBody;
using System;
using System.Collections.Generic;
using System.Text;

namespace JT808.Protocol.JT808Formatters.MessageBodyFormatters
{
    public class JT808_0x8103_0x0084Formatter : IJT808Formatter<JT808_0x8103_0x0084>
    {
        public JT808_0x8103_0x0084 Deserialize(ReadOnlySpan<byte> bytes, out int readSize)
        {
            int offset = 0;
            JT808_0x8103_0x0084 jT808_0x8103_0x0084 = new JT808_0x8103_0x0084();
            jT808_0x8103_0x0084.ParamLength = JT808BinaryExtensions.ReadByteLittle(bytes, ref offset);
            jT808_0x8103_0x0084.ParamValue = JT808BinaryExtensions.ReadByteLittle(bytes, ref offset);
            readSize = offset;
            return jT808_0x8103_0x0084;
        }

        public int Serialize(ref byte[] bytes, int offset, JT808_0x8103_0x0084 value)
        {
            offset += JT808BinaryExtensions.WriteByteLittle(bytes, offset, value.ParamLength);
            offset += JT808BinaryExtensions.WriteByteLittle(bytes, offset, value.ParamValue);
            return offset;
        }
    }
}
﻿using Mina.Core.Buffer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSO.Common.Serialization
{
    public interface IoBufferSerializable
    {
        void Serialize(IoBuffer output, ISerializationContext context);
    }
}

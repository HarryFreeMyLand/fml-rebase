﻿using FSO.Common.Serialization;
using Mina.Core.Buffer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSO.Server.Protocol.Gluon.Packets
{
    public class ShardShutdownCompleteResponse : AbstractGluonPacket
    {
        public uint ShardId;

        public override void Deserialize(IoBuffer input, ISerializationContext context)
        {
            ShardId = input.GetUInt32();
        }

        public override GluonPacketType GetPacketType()
        {
            return GluonPacketType.ShardShutdownCompleteResponse;
        }

        public override void Serialize(IoBuffer output, ISerializationContext context)
        {
            output.PutUInt32(ShardId);
        }
    }
}

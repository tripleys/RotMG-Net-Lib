﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotMG_Net_Lib.Networking.Packets.Outgoing
{
    public class PongPacket : OutgoingPacket
    {
        public int Serial;

        public int Time;

        public override PacketType GetPacketType() => PacketType.Pong;

        public override void Write(PacketOutput output)
        {
            output.Write(Serial);
            output.Write(Time);
        }
    }
}

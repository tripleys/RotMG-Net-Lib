using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotMG_Net_Lib.Networking.Packets.Incoming
{
    public class PingPacket : IncomingPacket
    {

        public int Serial;

        public override PacketType GetPacketType() => PacketType.Ping;

        public override void Read(PacketInput input)
        {
            Serial = input.ReadInt32();
        }
    }
}

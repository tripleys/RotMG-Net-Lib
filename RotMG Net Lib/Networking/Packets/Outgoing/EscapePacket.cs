using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotMG_Net_Lib.Networking.Packets.Outgoing
{
    public class EscapePacket : OutgoingPacket
    {
        public override PacketType GetPacketType() => PacketType.Escape;

        public override void Write(PacketOutput output)
        {
        }
    }
}

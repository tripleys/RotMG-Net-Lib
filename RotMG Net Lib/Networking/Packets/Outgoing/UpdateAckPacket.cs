using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotMG_Net_Lib.Networking.Packets.Outgoing
{
    public class UpdateAckPacket : OutgoingPacket
    {
        public override PacketType GetPacketType() => PacketType.UpdateAck;

        public override void Write(PacketOutput output)
        {
        }
    }
}

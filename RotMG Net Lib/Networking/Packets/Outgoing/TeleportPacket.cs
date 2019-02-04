using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotMG_Net_Lib.Networking.Packets.Outgoing
{
    public class TeleportPacket : OutgoingPacket
    {
        public int ObjectId;

        public override PacketType GetPacketType() => PacketType.Teleport;

        public override void Write(PacketOutput output)
        {
            output.Write(ObjectId);
        }
    }
}

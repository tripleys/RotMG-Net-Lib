using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotMG_Net_Lib.Networking.Packets.Outgoing
{
    public class KeyInfoRequestPacket : OutgoingPacket
    {
        public int ItemType;

        public override PacketType GetPacketType() => PacketType.KeyInfoRequest;

        public override void Write(PacketOutput output)
        {
            output.Write(ItemType);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotMG_Net_Lib.Networking.Packets.Outgoing
{
    public class BuyPacket : OutgoingPacket
    {
        public int ObjectId;
        public int Quantity;

        public override PacketType GetPacketType() => PacketType.Buy;

        public override void Write(PacketOutput output)
        {
            output.Write(ObjectId);
            output.Write(Quantity);
        }
    }
}

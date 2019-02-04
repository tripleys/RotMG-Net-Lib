using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotMG_Net_Lib.Networking.Packets.Outgoing
{
    public class CancelTradePacket : OutgoingPacket
    {
        public override PacketType GetPacketType() => PacketType.CancelTrade;

        public override void Write(PacketOutput output)
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotMG_Net_Lib.Networking.Packets.Incoming
{
    public class TradeRequestedPacket : IncomingPacket
    {
        public string Name;

        public override PacketType GetPacketType() => PacketType.TradeRequested;

        public override void Read(PacketInput input)
        {
            Name = input.ReadUTF();
        }
    }
}

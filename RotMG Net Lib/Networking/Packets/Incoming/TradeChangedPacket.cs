using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotMG_Net_Lib.Networking.Packets.Incoming
{
    public class TradeChangedPacket : IncomingPacket
    {
        public bool[] Offer;

        public override PacketType GetPacketType() => PacketType.TradeChanged;

        public override void Read(PacketInput input)
        {
            Offer = new bool[input.ReadInt16()];
            for (int i = 0; i < Offer.Length; i++)
                Offer[i] = input.ReadBoolean();
        }
    }
}

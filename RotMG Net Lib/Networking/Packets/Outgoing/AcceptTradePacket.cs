using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotMG_Net_Lib.Networking.Packets.Outgoing
{
    public class AcceptTradePacket : OutgoingPacket
    {
        public bool[] ClientOffer;
        public bool[] PartnerOffer;

        public override PacketType GetPacketType() => PacketType.AcceptTrade;

        public override void Write(PacketOutput output)
        {
            output.Write((short)ClientOffer.Length);
            foreach (bool slot in ClientOffer)
                output.Write(slot);
            output.Write((short)PartnerOffer.Length);
            foreach (bool slot in PartnerOffer)
                output.Write(slot);
        }
    }
}

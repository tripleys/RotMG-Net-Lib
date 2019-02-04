using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotMG_Net_Lib.Networking.Packets.Outgoing
{
    public class ChangePetSkinPacket : OutgoingPacket
    {
        public int PetId;
        public int SkinType;
        public int Currency;

        public override PacketType GetPacketType() => PacketType.PetChangeSkinMsg;

        public override void Write(PacketOutput output)
        {
            output.Write(PetId);
            output.Write(SkinType);
            output.Write(Currency);
        }
    }
}

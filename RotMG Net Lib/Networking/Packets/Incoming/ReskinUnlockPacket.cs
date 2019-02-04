using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotMG_Net_Lib.Networking.Packets.Incoming
{
    public class ReskinUnlockPacket : IncomingPacket
    {
        public int SkinID;
        public int IsPetSkin;

        public override PacketType GetPacketType() => PacketType.ReskinUnlock;

        public override void Read(PacketInput input)
        {
            SkinID = input.ReadInt32();
            IsPetSkin = input.ReadInt32();
        }
    }
}

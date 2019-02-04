using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotMG_Net_Lib.Networking.Packets.Incoming
{
    public class RealmHeroesResponsePacket : IncomingPacket
    {
        public int NumberOfRealmHeroes;

        public override PacketType GetPacketType() => PacketType.RealmHeroLeftMsg;

        public override void Read(PacketInput input)
        {
            NumberOfRealmHeroes = input.ReadInt32();
        }
    }
}

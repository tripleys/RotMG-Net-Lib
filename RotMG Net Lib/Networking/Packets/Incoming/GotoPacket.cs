using RotMG_Net_Lib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotMG_Net_Lib.Networking.Packets.Incoming
{
    public class GotoPacket : IncomingPacket
    {

        public int ObjectId;

        public WorldPosData Pos;

        public override PacketType GetPacketType() => PacketType.Goto;

        public override void Read(PacketInput input)
        {
            ObjectId = input.ReadInt32();
            (Pos = new WorldPosData()).Read(input);
        }
    }
}

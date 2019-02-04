using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotMG_Net_Lib.Networking.Packets.Incoming
{
    public class QuestObjIdPacket : IncomingPacket
    {
        public int ObjectId;

        public override PacketType GetPacketType() => PacketType.QuestObjId;

        public override void Read(PacketInput input)
        {
            ObjectId = input.ReadInt32();
        }
    }
}

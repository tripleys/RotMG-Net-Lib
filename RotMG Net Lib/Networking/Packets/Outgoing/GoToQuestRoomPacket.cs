using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotMG_Net_Lib.Networking.Packets.Outgoing
{
    public class GoToQuestRoomPacket : OutgoingPacket
    {
        public override PacketType GetPacketType() => PacketType.QuestRoomMsg;

        public override void Write(PacketOutput output)
        {
        }
    }
}

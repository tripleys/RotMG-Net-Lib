using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotMG_Net_Lib.Networking.Packets.Incoming
{
    public class QuestRedeemResponsePacket : IncomingPacket
    {
        public bool Ok;
        public string Message;

        public override PacketType GetPacketType() => PacketType.QuestRedeemResponse;

        public override void Read(PacketInput input)
        {
            Ok = input.ReadBoolean();
            Message = input.ReadUTF();
        }
    }
}

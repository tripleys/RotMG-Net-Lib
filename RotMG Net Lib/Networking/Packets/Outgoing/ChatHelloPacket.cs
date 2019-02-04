using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotMG_Net_Lib.Networking.Packets.Outgoing
{
    public class ChatHelloPacket : OutgoingPacket
    {
        public string AccountId;
        public string Token;

        public override PacketType GetPacketType() => PacketType.ChatHelloMsg;

        public override void Write(PacketOutput output)
        {
            output.WriteUTF(AccountId);
            output.WriteUTF(Token);
        }
    }
}

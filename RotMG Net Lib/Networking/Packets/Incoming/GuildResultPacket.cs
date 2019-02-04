using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotMG_Net_Lib.Networking.Packets.Incoming
{
    public class GuildResultPacket : IncomingPacket
    {
        public bool Success;
        public string LineBuilderJSON;

        public override PacketType GetPacketType() => PacketType.GuildResult;

        public override void Read(PacketInput input)
        {
            Success = input.ReadBoolean();
            LineBuilderJSON = input.ReadUTF();
        }
    }
}

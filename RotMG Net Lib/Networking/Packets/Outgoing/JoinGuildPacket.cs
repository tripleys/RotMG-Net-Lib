using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotMG_Net_Lib.Networking.Packets.Outgoing
{
    public class JoinGuildPacket : OutgoingPacket
    {
        public string GuildName;

        public override PacketType GetPacketType() => PacketType.JoinGuild;

        public override void Write(PacketOutput output)
        {
            output.WriteUTF(GuildName);
        }
    }
}

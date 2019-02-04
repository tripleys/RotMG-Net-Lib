using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotMG_Net_Lib.Networking.Packets.Outgoing
{
    public class GuildInvitePacket : OutgoingPacket
    {
        public string Name;

        public override PacketType GetPacketType() => PacketType.GuildInvite;

        public override void Write(PacketOutput output)
        {
            output.WriteUTF(Name);
        }
    }
}

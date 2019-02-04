using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotMG_Net_Lib.Networking.Packets.Outgoing
{
    public class CreatePacket : OutgoingPacket
    {
        public short ClassType;
        public short SkinType;

        public override PacketType GetPacketType() => PacketType.Create;

        public override void Write(PacketOutput output)
        {
            output.Write(ClassType);
            output.Write(SkinType);
        }
    }
}

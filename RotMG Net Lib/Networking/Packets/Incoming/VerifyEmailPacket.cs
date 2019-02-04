using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotMG_Net_Lib.Networking.Packets.Incoming
{
    public class VerifyEmailPacket : IncomingPacket
    {
        public override PacketType GetPacketType() => PacketType.VerifyEmail;

        public override void Read(PacketInput input)
        {
        }
    }
}

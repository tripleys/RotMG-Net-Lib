using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotMG_Net_Lib.Networking.Packets.Outgoing
{
    public class ShootAckPacket : OutgoingPacket
    {
        public int Time;

        public override PacketType GetPacketType() => PacketType.ShootAck;

        public override void Write(PacketOutput output)
        {
            output.Write(Time);
        }
    }
}

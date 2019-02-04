using RotMG_Net_Lib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotMG_Net_Lib.Networking.Packets.Outgoing
{
    public class GroundDamagePacket : OutgoingPacket
    {
        public int Time;
        public WorldPosData Position;

        public override PacketType GetPacketType() => PacketType.GroundDamage;

        public override void Write(PacketOutput output)
        {
            output.Write(Time);
            Position.Write(output);
        }
    }
}

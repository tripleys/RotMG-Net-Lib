using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotMG_Net_Lib.Networking.Packets.Outgoing
{
    public class OtherHitPacket : OutgoingPacket
    {
        public int Time;
        public byte BulletId;
        public int ObjectId;
        public int TargetId;

        public override PacketType GetPacketType() => PacketType.OtherHit;

        public override void Write(PacketOutput output)
        {
            output.Write(Time);
            output.Write(BulletId);
            output.Write(ObjectId);
            output.Write(TargetId);
        }
    }
}

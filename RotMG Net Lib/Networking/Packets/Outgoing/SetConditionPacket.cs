using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotMG_Net_Lib.Networking.Packets.Outgoing
{
    public class SetConditionPacket : OutgoingPacket
    {
        public byte ConditionEffect;
        public float ConditionDuration;

        public override PacketType GetPacketType() => PacketType.SetCondition;

        public override void Write(PacketOutput output)
        {
            output.Write(ConditionEffect);
            output.Write(ConditionDuration);
        }
    }
}

using RotMG_Net_Lib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotMG_Net_Lib.Networking.Packets.Outgoing
{
    public class InvSwapPacket : OutgoingPacket
    {
        public int Time;
        public WorldPosData Position;
        public SlotObjectData SlotObject1;
        public SlotObjectData SlotObject2;

        public override PacketType GetPacketType() => PacketType.InvSwap;

        public override void Write(PacketOutput output)
        {
            output.Write(Time);
            Position.Write(output);
            SlotObject1.Write(output);
            SlotObject2.Write(output);
        }
    }
}

using RotMG_Net_Lib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotMG_Net_Lib.Networking.Packets.Outgoing
{
    public class UseItemPacket : OutgoingPacket
    {
        public int Time;
        public SlotObjectData SlotObject;
        public WorldPosData ItemUsePos;
        public byte UseType;

        public override PacketType GetPacketType() => PacketType.UseItem;

        public override void Write(PacketOutput output)
        {
            output.Write(Time);
            SlotObject.Write(output);
            ItemUsePos.Write(output);
            output.Write(UseType);
        }
    }
}

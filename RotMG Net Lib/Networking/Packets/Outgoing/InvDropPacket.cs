using RotMG_Net_Lib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotMG_Net_Lib.Networking.Packets.Outgoing
{
    public class InvDropPacket : OutgoingPacket
    {
        public SlotObjectData SlotObject;

        public override PacketType GetPacketType() => PacketType.InvDrop;

        public override void Write(PacketOutput output)
        {
            SlotObject.Write(output);
        }
    }
}

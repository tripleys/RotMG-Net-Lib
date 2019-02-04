using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotMG_Net_Lib.Networking.Packets.Outgoing
{
    public class ChooseNamePacket : OutgoingPacket
    {
        public string Name;

        public override PacketType GetPacketType() => PacketType.ChooseName;

        public override void Write(PacketOutput output)
        {
            output.WriteUTF(Name);
        }
    }
}

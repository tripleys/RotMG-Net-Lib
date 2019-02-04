using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotMG_Net_Lib.Networking.Packets.Outgoing
{
    public class PlayerTextPacket : OutgoingPacket
    {
        public string Text;

        public override PacketType GetPacketType() => PacketType.PlayerText;

        public override void Write(PacketOutput output)
        {
            output.WriteUTF(Text);
        }
    }
}

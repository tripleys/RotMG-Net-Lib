using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotMG_Net_Lib.Networking.Packets.Incoming
{
    public class KeyInfoResponsePacket : IncomingPacket
    {
        public string Name;
        public string Description;
        public string Creator;

        public override PacketType GetPacketType() => PacketType.KeyInfoResponse;

        public override void Read(PacketInput input)
        {
            Name = input.ReadUTF();
            Description = input.ReadUTF();
            Creator = input.ReadUTF();
        }
    }
}

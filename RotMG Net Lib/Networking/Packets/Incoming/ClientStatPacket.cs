using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotMG_Net_Lib.Networking.Packets.Incoming
{
    public class ClientStatPacket : IncomingPacket
    {
        public string Name;
        public int Value;

        public override PacketType GetPacketType() => PacketType.ClientStat;

        public override void Read(PacketInput input)
        {
            Name = input.ReadUTF();
            Value = input.ReadInt32();
        }
    }
}

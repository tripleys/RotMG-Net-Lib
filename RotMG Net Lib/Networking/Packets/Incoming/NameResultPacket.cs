using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotMG_Net_Lib.Networking.Packets.Incoming
{
    public class NameResultPacket : IncomingPacket
    {
        public bool Success;

        public string ErrorText;

        public override PacketType GetPacketType() => PacketType.NameResult;

        public override void Read(PacketInput input)
        {
            Success = input.ReadBoolean();
            ErrorText = input.ReadUTF();
        }
    }
}

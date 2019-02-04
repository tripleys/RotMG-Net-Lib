using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotMG_Net_Lib.Networking.Packets.Incoming
{
    public class FailurePacket : IncomingPacket
    {
        
        public int ErrorId;
        public string ErrorDescription;

        public override PacketType GetPacketType() => PacketType.Failure;

        public override void Read(PacketInput input)
        {
            this.ErrorId = input.ReadInt32();
            this.ErrorDescription = input.ReadUTF();
        }
    }
}

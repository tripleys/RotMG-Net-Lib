using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotMG_Net_Lib.Networking.Packets.Incoming
{
    public class CreateSuccessPacket : IncomingPacket
    {
        public int ObjectId;
        public int CharId;

        public override PacketType GetPacketType() => PacketType.CreateSuccess;

        public override void Read(PacketInput input)
        {
            ObjectId = input.ReadInt32();
            CharId = input.ReadInt32();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotMG_Net_Lib.Networking.Packets.Incoming
{
    public class NotificationPacket : IncomingPacket
    {
        public int ObjectId;
        public string Message;
        public int Color;

        public override PacketType GetPacketType() => PacketType.Notification;

        public override void Read(PacketInput input)
        {
            ObjectId = input.ReadInt32();
            Message = input.ReadUTF();
            Color = input.ReadInt32();
        }
    }
}

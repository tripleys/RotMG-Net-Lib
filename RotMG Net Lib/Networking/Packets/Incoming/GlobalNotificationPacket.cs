using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotMG_Net_Lib.Networking.Packets.Incoming
{
    public class GlobalNotificationPacket : IncomingPacket
    {
        public int Type;
        public string Text;

        public override PacketType GetPacketType() => PacketType.GlobalNotification;

        public override void Read(PacketInput input)
        {
            Type = input.ReadInt32();
            Text = input.ReadUTF();
        }
    }
}

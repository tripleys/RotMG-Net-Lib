namespace RotMG_Net_Lib.Networking.Packets.Incoming
{
    public class GlobalNotificationPacket : IncomingPacket
    {
        public int Type;
        public string Text;

        public override PacketType GetPacketType() => PacketType.GLOBAL_NOTIFICATION;

        public override void Read(PacketInput input)
        {
            Type = input.ReadInt32();
            Text = input.ReadUTF();
        }
    }
}
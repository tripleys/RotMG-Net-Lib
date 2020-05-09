namespace RotMG_Net_Lib.Networking.Packets.Incoming
{
    public class TextPacket : IncomingPacket
    {
        public string Name;
        public int ObjectId;
        public int NumStars;
        public byte BubbleTime;
        public string Recipient;
        public string Text;
        public string CleanText;
        public bool IsSupporter;

        public override PacketType GetPacketType() => PacketType.TEXT;

        public override void Read(PacketInput input)
        {
            Name = input.ReadUTF();
            ObjectId = input.ReadInt32();
            NumStars = input.ReadInt32();
            BubbleTime = input.ReadByte();
            Recipient = input.ReadUTF();
            Text = input.ReadUTF();
            CleanText = input.ReadUTF();
            IsSupporter = input.ReadBoolean();
        }
    }
}

namespace RotMG_Net_Lib.Networking.Packets.Incoming
{
    public class KeyInfoResponsePacket : IncomingPacket
    {
        public string Name;
        public string Description;
        public string Creator;

        public override PacketType GetPacketType() => PacketType.KEY_INFO_REQUEST;

        public override void Read(PacketInput input)
        {
            Name = input.ReadUTF();
            Description = input.ReadUTF();
            Creator = input.ReadUTF();
        }
    }
}
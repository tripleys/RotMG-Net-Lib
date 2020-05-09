namespace RotMG_Net_Lib.Networking.Packets.Incoming
{
    public class ClientStatPacket : IncomingPacket
    {
        public string Name;
        public int Value;

        public override PacketType GetPacketType() => PacketType.CLIENTSTAT;

        public override void Read(PacketInput input)
        {
            Name = input.ReadUTF();
            Value = input.ReadInt32();
        }
    }
}

namespace RotMG_Net_Lib.Networking.Packets.Incoming
{
    public class NameResultPacket : IncomingPacket
    {
        public bool Success;

        public string ErrorText;

        public override PacketType GetPacketType() => PacketType.NAMERESULT;

        public override void Read(PacketInput input)
        {
            Success = input.ReadBoolean();
            ErrorText = input.ReadUTF();
        }
    }
}
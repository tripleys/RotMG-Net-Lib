namespace RotMG_Net_Lib.Networking.Packets.Incoming
{
    public class VerifyEmailPacket : IncomingPacket
    {
        public override PacketType GetPacketType() => PacketType.VERIFY_EMAIL;

        public override void Read(PacketInput input)
        {
        }
    }
}
namespace RotMG_Net_Lib.Networking.Packets.Outgoing
{
    public class EscapePacket : OutgoingPacket
    {
        public override PacketType GetPacketType() => PacketType.ESCAPE;

        public override void Write(PacketOutput output)
        {
        }
    }
}
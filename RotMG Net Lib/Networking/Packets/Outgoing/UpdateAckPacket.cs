namespace RotMG_Net_Lib.Networking.Packets.Outgoing
{
    public class UpdateAckPacket : OutgoingPacket
    {
        public override PacketType GetPacketType() => PacketType.UPDATEACK;

        public override void Write(PacketOutput output)
        {
        }
    }
}

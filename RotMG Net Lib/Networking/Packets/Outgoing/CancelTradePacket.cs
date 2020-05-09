namespace RotMG_Net_Lib.Networking.Packets.Outgoing
{
    public class CancelTradePacket : OutgoingPacket
    {
        public override PacketType GetPacketType() => PacketType.CANCELTRADE;

        public override void Write(PacketOutput output)
        {
        }
    }
}

namespace RotMG_Net_Lib.Networking.Packets.Outgoing
{
    public class RequestTradePacket : OutgoingPacket
    {
        public string Name;

        public override PacketType GetPacketType() => PacketType.REQUESTTRADE;

        public override void Write(PacketOutput output)
        {
            output.WriteUTF(Name);
        }
    }
}
namespace RotMG_Net_Lib.Networking.Packets.Outgoing
{
    public class BuyPacket : OutgoingPacket
    {
        public int ObjectId;
        public int Quantity;

        public override PacketType GetPacketType() => PacketType.BUY;

        public override void Write(PacketOutput output)
        {
            output.Write(ObjectId);
            output.Write(Quantity);
        }
    }
}

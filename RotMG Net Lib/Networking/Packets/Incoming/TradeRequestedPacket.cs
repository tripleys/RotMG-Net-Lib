namespace RotMG_Net_Lib.Networking.Packets.Incoming
{
    public class TradeRequestedPacket : IncomingPacket
    {
        public string Name;

        public override PacketType GetPacketType() => PacketType.TRADEREQUESTED;

        public override void Read(PacketInput input)
        {
            Name = input.ReadUTF();
        }
    }
}
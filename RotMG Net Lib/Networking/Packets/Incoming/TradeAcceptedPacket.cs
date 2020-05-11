namespace RotMG_Net_Lib.Networking.Packets.Incoming
{
    public class TradeAcceptedPacket : IncomingPacket
    {
        public bool[] ClientOffer;
        public bool[] PartnerOffer;

        public override PacketType GetPacketType() => PacketType.TRADEACCEPTED;

        public override void Read(PacketInput input)
        {
            ClientOffer = new bool[input.ReadInt16()];
            for (short i = 0; i < ClientOffer.Length; i++)
                ClientOffer[i] = input.ReadBoolean();
            PartnerOffer = new bool[input.ReadInt16()];
            for (short i = 0; i < PartnerOffer.Length; i++)
                PartnerOffer[i] = input.ReadBoolean();
        }
    }
}
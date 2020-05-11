namespace RotMG_Net_Lib.Networking.Packets.Outgoing
{
    public class AcceptTradePacket : OutgoingPacket
    {
        public bool[] ClientOffer;
        public bool[] PartnerOffer;

        public override PacketType GetPacketType() => PacketType.ACCEPTTRADE;

        public override void Write(PacketOutput output)
        {
            output.Write((short) ClientOffer.Length);
            foreach (bool slot in ClientOffer)
                output.Write(slot);
            output.Write((short) PartnerOffer.Length);
            foreach (bool slot in PartnerOffer)
                output.Write(slot);
        }
    }
}
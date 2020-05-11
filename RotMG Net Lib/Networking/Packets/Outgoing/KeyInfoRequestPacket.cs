namespace RotMG_Net_Lib.Networking.Packets.Outgoing
{
    public class KeyInfoRequestPacket : OutgoingPacket
    {
        public int ItemType;

        public override PacketType GetPacketType() => PacketType.KEY_INFO_REQUEST;

        public override void Write(PacketOutput output)
        {
            output.Write(ItemType);
        }
    }
}
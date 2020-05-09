namespace RotMG_Net_Lib.Networking.Packets.Outgoing
{
    public class InvDropPacket : OutgoingPacket
    {
        public SlotObjectData SlotObject;

        public override PacketType GetPacketType() => PacketType.INVDROP;

        public override void Write(PacketOutput output)
        {
            SlotObject.Write(output);
        }
    }
}

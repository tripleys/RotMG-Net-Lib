namespace RotMG_Net_Lib.Networking.Packets.Outgoing
{
    public class TeleportPacket : OutgoingPacket
    {
        public int ObjectId;

        public override PacketType GetPacketType() => PacketType.TELEPORT;

        public override void Write(PacketOutput output)
        {
            output.Write(ObjectId);
        }
    }
}
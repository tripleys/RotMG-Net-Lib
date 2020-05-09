namespace RotMG_Net_Lib.Networking.Packets.Outgoing
{
    public class PlayerHitPacket : OutgoingPacket
    {
        public byte BulletId;
        public int ObjectId;

        public override PacketType GetPacketType() => PacketType.PLAYERHIT;

        public override void Write(PacketOutput output)
        {
            output.Write(BulletId);
            output.Write(ObjectId);
        }
    }
}

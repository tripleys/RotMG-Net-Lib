namespace RotMG_Net_Lib.Networking.Packets.Outgoing
{
    public class SquareHitPacket : OutgoingPacket
    {
        public int Time;
        public byte BulletId;
        public int ObjectId;

        public override PacketType GetPacketType() => PacketType.SQUAREHIT;

        public override void Write(PacketOutput output)
        {
            output.Write(Time);
            output.Write(BulletId);
            output.Write(ObjectId);
        }
    }
}
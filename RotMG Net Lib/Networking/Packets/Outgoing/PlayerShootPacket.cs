namespace RotMG_Net_Lib.Networking.Packets.Outgoing
{
    public class PlayerShootPacket : OutgoingPacket
    {
        public int Time;
        public byte BulletId;
        public short ContainerType;
        public WorldPosData StartingPos;
        public float Angle;

        public override PacketType GetPacketType() => PacketType.PLAYERSHOOT;

        public override void Write(PacketOutput output)
        {
            output.Write(Time);
            output.Write(BulletId);
            output.Write(ContainerType);
            StartingPos.Write(output);
            output.Write(Angle);
        }
    }
}

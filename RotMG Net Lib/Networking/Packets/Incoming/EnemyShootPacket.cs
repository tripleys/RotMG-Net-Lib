namespace RotMG_Net_Lib.Networking.Packets.Incoming
{
    public class EnemyShootPacket : IncomingPacket
    {
        public byte BulletId;
        public int OwnerId;
        public byte BulletType;
        public WorldPosData StartingPos;
        public float Angle;
        public short Damage;
        public byte NumShots;
        public float AngleInc;

        public override PacketType GetPacketType() => PacketType.ENEMYSHOOT;

        public override void Read(PacketInput input)
        {
            BulletId = input.ReadByte();
            OwnerId = input.ReadInt32();
            BulletType = input.ReadByte();
            (StartingPos = new WorldPosData()).Read(input);
            Angle = input.ReadSingle();
            Damage = input.ReadInt16();
            if (input.Remaining() > 0)
            {
                NumShots = input.ReadByte();
                AngleInc = input.ReadSingle();
            }
            else
            {
                NumShots = 1;
                AngleInc = 0;
            }
        }
    }
}

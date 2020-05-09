namespace RotMG_Net_Lib.Networking.Packets.Incoming
{
    public class AllyShootPacket : IncomingPacket
    {
        public byte BulletId;
        public int OwnerId;
        public short ContainerType;
        public float Angle;

        public override PacketType GetPacketType() => PacketType.ALLYSHOOT;

        public override void Read(PacketInput input)
        {
            BulletId = input.ReadByte();
            OwnerId = input.ReadInt32();
            ContainerType = input.ReadInt16();
            Angle = input.ReadSingle();
        }
    }
}

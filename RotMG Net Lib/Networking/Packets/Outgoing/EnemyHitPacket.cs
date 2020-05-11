namespace RotMG_Net_Lib.Networking.Packets.Outgoing
{
    public class EnemyHitPacket : OutgoingPacket
    {
        public int Time;
        public byte BulletId;
        public int TargetId;
        public bool Kill;

        public override PacketType GetPacketType() => PacketType.ENEMYHIT;

        public override void Write(PacketOutput output)
        {
            output.Write(Time);
            output.Write(BulletId);
            output.Write(TargetId);
            output.Write(Kill);
        }
    }
}
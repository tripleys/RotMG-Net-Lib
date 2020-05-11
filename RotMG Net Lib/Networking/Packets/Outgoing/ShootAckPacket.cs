namespace RotMG_Net_Lib.Networking.Packets.Outgoing
{
    public class ShootAckPacket : OutgoingPacket
    {
        public int Time;

        public override PacketType GetPacketType() => PacketType.SHOOTACK;

        public override void Write(PacketOutput output)
        {
            output.Write(Time);
        }
    }
}
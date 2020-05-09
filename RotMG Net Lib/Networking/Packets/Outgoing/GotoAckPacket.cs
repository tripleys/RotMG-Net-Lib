namespace RotMG_Net_Lib.Networking.Packets.Outgoing
{
    public class GotoAckPacket : OutgoingPacket
    {

        public int Time;

        public override PacketType GetPacketType() => PacketType.GOTOACK;

        public override void Write(PacketOutput output)
        {
            output.Write(Time);
        }
    }
}

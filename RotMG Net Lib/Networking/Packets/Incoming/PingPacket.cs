namespace RotMG_Net_Lib.Networking.Packets.Incoming
{
    public class PingPacket : IncomingPacket
    {
        public int Serial;

        public override PacketType GetPacketType() => PacketType.PING;

        public override void Read(PacketInput input)
        {
            Serial = input.ReadInt32();
        }
    }
}
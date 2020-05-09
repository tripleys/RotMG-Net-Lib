namespace RotMG_Net_Lib.Networking.Packets
{
    public abstract class OutgoingPacket
    {
        public abstract PacketType GetPacketType();

        public abstract void Write(PacketOutput output);
    }
}

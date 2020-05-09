namespace RotMG_Net_Lib.Networking.Packets.Outgoing
{
    public class CreatePacket : OutgoingPacket
    {
        public short ClassType;
        public short SkinType;
        public bool IsChallenger;

        public override PacketType GetPacketType() => PacketType.CREATE;

        public override void Write(PacketOutput output)
        {
            output.Write(ClassType);
            output.Write(SkinType);
            output.Write(IsChallenger);
        }
    }
}
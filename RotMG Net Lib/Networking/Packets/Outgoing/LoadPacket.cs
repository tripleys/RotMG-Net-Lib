namespace RotMG_Net_Lib.Networking.Packets.Outgoing
{
    public class LoadPacket : OutgoingPacket
    {

        public int CharId;
        public bool IsFromArena;
        public bool IsChallenger;

        public override PacketType GetPacketType() => PacketType.LOAD;

        public override void Write(PacketOutput output)
        {
            output.Write(CharId);
            output.Write(IsFromArena);
            output.Write(IsChallenger);
        }
    }
}

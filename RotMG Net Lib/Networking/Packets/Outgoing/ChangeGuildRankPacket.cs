namespace RotMG_Net_Lib.Networking.Packets.Outgoing
{
    public class ChangeGuildRankPacket : OutgoingPacket
    {
        public string Name;
        public int GuildRank;

        public override PacketType GetPacketType() => PacketType.CHANGEGUILDRANK;

        public override void Write(PacketOutput output)
        {
            output.WriteUTF(Name);
            output.Write(GuildRank);
        }
    }
}
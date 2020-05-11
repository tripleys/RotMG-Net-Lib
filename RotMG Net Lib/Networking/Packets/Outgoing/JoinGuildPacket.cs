namespace RotMG_Net_Lib.Networking.Packets.Outgoing
{
    public class JoinGuildPacket : OutgoingPacket
    {
        public string GuildName;

        public override PacketType GetPacketType() => PacketType.JOINGUILD;

        public override void Write(PacketOutput output)
        {
            output.WriteUTF(GuildName);
        }
    }
}
namespace RotMG_Net_Lib.Networking.Packets.Outgoing
{
    public class GuildRemovePacket : OutgoingPacket
    {
        public string Name;

        public override PacketType GetPacketType() => PacketType.GUILDREMOVE;

        public override void Write(PacketOutput output)
        {
            output.WriteUTF(Name);
        }
    }
}
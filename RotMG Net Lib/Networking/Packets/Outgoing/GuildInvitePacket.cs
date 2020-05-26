namespace RotMG_Net_Lib.Networking.Packets.Outgoing
{
    public class GuildInvitePacket : OutgoingPacket
    {
        public string Name;

        public override PacketType GetPacketType() => PacketType.GUILDINVITE;

        public override void Write(PacketOutput output)
        {
            output.WriteUTF(Name);
        }
    }
}
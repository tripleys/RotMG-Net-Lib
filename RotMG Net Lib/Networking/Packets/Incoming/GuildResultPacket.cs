namespace RotMG_Net_Lib.Networking.Packets.Incoming
{
    public class GuildResultPacket : IncomingPacket
    {
        public bool Success;
        public string LineBuilderJSON;

        public override PacketType GetPacketType() => PacketType.GUILDRESULT;

        public override void Read(PacketInput input)
        {
            Success = input.ReadBoolean();
            LineBuilderJSON = input.ReadUTF();
        }
    }
}

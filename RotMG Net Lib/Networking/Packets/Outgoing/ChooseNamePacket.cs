namespace RotMG_Net_Lib.Networking.Packets.Outgoing
{
    public class ChooseNamePacket : OutgoingPacket
    {
        public string Name;

        public override PacketType GetPacketType() => PacketType.CHOOSENAME;

        public override void Write(PacketOutput output)
        {
            output.WriteUTF(Name);
        }
    }
}

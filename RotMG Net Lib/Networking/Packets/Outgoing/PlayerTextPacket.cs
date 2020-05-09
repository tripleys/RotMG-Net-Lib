namespace RotMG_Net_Lib.Networking.Packets.Outgoing
{
    public class PlayerTextPacket : OutgoingPacket
    {
        public string Text;

        public override PacketType GetPacketType() => PacketType.PLAYERTEXT;

        public override void Write(PacketOutput output)
        {
            output.WriteUTF(Text);
        }
    }
}

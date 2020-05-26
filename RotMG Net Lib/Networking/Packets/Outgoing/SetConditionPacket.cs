namespace RotMG_Net_Lib.Networking.Packets.Outgoing
{
    public class SetConditionPacket : OutgoingPacket
    {
        public byte ConditionEffect;
        public float ConditionDuration;

        public override PacketType GetPacketType() => PacketType.SETCONDITION;

        public override void Write(PacketOutput output)
        {
            output.Write(ConditionEffect);
            output.Write(ConditionDuration);
        }
    }
}
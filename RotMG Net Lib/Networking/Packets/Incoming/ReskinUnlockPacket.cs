namespace RotMG_Net_Lib.Networking.Packets.Incoming
{
    public class ReskinUnlockPacket : IncomingPacket
    {
        public int SkinID;
        public int IsPetSkin;

        public override PacketType GetPacketType() => PacketType.RESKIN_UNLOCK;

        public override void Read(PacketInput input)
        {
            SkinID = input.ReadInt32();
            IsPetSkin = input.ReadInt32();
        }
    }
}
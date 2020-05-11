namespace RotMG_Net_Lib.Networking.Packets.Outgoing
{
    public class ChangePetSkinPacket : OutgoingPacket
    {
        public int PetId;
        public int SkinType;
        public int Currency;

        public override PacketType GetPacketType() => PacketType.PET_CHANGE_SKIN_MSG;

        public override void Write(PacketOutput output)
        {
            output.Write(PetId);
            output.Write(SkinType);
            output.Write(Currency);
        }
    }
}
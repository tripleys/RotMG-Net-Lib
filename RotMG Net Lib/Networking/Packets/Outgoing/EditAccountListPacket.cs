namespace RotMG_Net_Lib.Networking.Packets.Outgoing
{
    public class EditAccountListPacket : OutgoingPacket
    {
        public int AccountListId;
        public bool Add;
        public int ObjectId;

        public override PacketType GetPacketType() => PacketType.EDITACCOUNTLIST;

        public override void Write(PacketOutput output)
        {
            output.Write(AccountListId);
            output.Write(Add);
            output.Write(ObjectId);
        }
    }
}

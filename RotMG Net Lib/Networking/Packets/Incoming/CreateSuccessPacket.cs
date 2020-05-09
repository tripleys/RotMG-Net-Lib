namespace RotMG_Net_Lib.Networking.Packets.Incoming
{
    public class CreateSuccessPacket : IncomingPacket
    {
        public int ObjectId;
        public int CharId;

        public override PacketType GetPacketType() => PacketType.CREATE_SUCCESS;

        public override void Read(PacketInput input)
        {
            ObjectId = input.ReadInt32();
            CharId = input.ReadInt32();
        }
    }
}

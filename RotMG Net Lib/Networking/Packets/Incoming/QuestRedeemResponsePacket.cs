namespace RotMG_Net_Lib.Networking.Packets.Incoming
{
    public class QuestRedeemResponsePacket : IncomingPacket
    {
        public bool Ok;
        public string Message;

        public override PacketType GetPacketType() => PacketType.QUEST_REDEEM_RESPONSE;

        public override void Read(PacketInput input)
        {
            Ok = input.ReadBoolean();
            Message = input.ReadUTF();
        }
    }
}

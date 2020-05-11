namespace RotMG_Net_Lib.Networking.Packets.Outgoing
{
    public class GoToQuestRoomPacket : OutgoingPacket
    {
        public override PacketType GetPacketType() => PacketType.QUEST_ROOM_MSG;

        public override void Write(PacketOutput output)
        {
        }
    }
}
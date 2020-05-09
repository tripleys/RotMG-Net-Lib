namespace RotMG_Net_Lib.Networking.Packets.Incoming
{
    public class QuestObjIdPacket : IncomingPacket
    {
        public int ObjectId;

        public override PacketType GetPacketType() => PacketType.QUESTOBJID;

        public override void Read(PacketInput input)
        {
            ObjectId = input.ReadInt32();
        }
    }
}

namespace RotMG_Net_Lib.Networking.Packets.Outgoing
{
    public class ActivePetUpdateRequestPacket : OutgoingPacket
    {
        public byte CommandType;
        public uint InstanceId;

        public override PacketType GetPacketType() => PacketType.ACTIVE_PET_UPDATE_REQUEST;

        public override void Write(PacketOutput output)
        {
            output.Write(CommandType);
            output.Write(InstanceId);
        }
    }
}
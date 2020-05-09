namespace RotMG_Net_Lib.NetLib.Networking.Packets.Incoming
{
    public class FailurePacket : IncomingPacket
    {
        
        public int ErrorId;
        public string ErrorDescription;

        public override PacketType GetPacketType() => PacketType.FAILURE;

        public override void Read(PacketInput input)
        {
            ErrorId = input.ReadInt32();
            ErrorDescription = input.ReadUTF();
        }
    }
}

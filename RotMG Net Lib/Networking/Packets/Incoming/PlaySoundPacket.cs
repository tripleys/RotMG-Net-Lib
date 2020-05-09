namespace RotMG_Net_Lib.NetLib.Networking.Packets.Incoming
{
    public class PlaySoundPacket : IncomingPacket
    {
        public int OwnerId;
        public int SoundId;

        public override PacketType GetPacketType() => PacketType.PLAYSOUND;
        
        public override void Read(PacketInput input)
        {
            OwnerId = input.ReadInt32();
            SoundId = input.ReadByte();
        }
    }
}
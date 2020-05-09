namespace RotMG_Net_Lib.Networking.Packets.Incoming
{
    public class ShowEffectPacket : IncomingPacket
    {
        public byte EffectType;
        public int TargetObjectId;
        public WorldPosData Pos1;
        public WorldPosData Pos2;
        public int Color;
        public float Duration;

        public override PacketType GetPacketType() => PacketType.SHOWEFFECT;

        public override void Read(PacketInput input)
        {
            EffectType = input.ReadByte();
            TargetObjectId = input.ReadInt32();
            Pos1 = new WorldPosData().Read(input);
            Pos2 = new WorldPosData().Read(input);
            Color = input.ReadInt32();
            Duration = input.ReadSingle();
        }
    }
}
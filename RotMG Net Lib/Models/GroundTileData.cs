using RotMG_Net_Lib.Networking.Packets;

namespace RotMG_Net_Lib.Models
{
    public class GroundTileData
    {
        public short X;
        public short Y;
        public ushort Type;

        public void Read(PacketInput input)
        {
            X = input.ReadInt16();
            Y = input.ReadInt16();
            Type = input.ReadUInt16();
        }
    }
}

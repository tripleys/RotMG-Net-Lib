using RotMG_Net_Lib.Models;

namespace RotMG_Net_Lib.Networking.Packets.Incoming
{
    public class GotoPacket : IncomingPacket
    {

        public int ObjectId;

        public WorldPosData Pos;

        public override PacketType GetPacketType() => PacketType.GOTO;

        public override void Read(PacketInput input)
        {
            ObjectId = input.ReadInt32();
            (Pos = new WorldPosData()).Read(input);
        }
    }
}

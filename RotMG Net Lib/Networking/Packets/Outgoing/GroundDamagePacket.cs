using RotMG_Net_Lib.Models;

namespace RotMG_Net_Lib.Networking.Packets.Outgoing
{
    public class GroundDamagePacket : OutgoingPacket
    {
        public int Time;
        public WorldPosData Position;

        public override PacketType GetPacketType() => PacketType.GROUNDDAMAGE;

        public override void Write(PacketOutput output)
        {
            output.Write(Time);
            Position.Write(output);
        }
    }
}

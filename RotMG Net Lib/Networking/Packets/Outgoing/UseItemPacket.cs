using RotMG_Net_Lib.Models;

namespace RotMG_Net_Lib.Networking.Packets.Outgoing
{
    public class UseItemPacket : OutgoingPacket
    {
        public int Time;
        public SlotObjectData SlotObject;
        public WorldPosData ItemUsePos;
        public byte UseType;

        public override PacketType GetPacketType() => PacketType.USEITEM;

        public override void Write(PacketOutput output)
        {
            output.Write(Time);
            SlotObject.Write(output);
            ItemUsePos.Write(output);
            output.Write(UseType);
        }
    }
}
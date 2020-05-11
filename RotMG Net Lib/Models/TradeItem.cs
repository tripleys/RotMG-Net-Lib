using RotMG_Net_Lib.Networking.Packets;

namespace RotMG_Net_Lib.Models
{
    public class TradeItem
    {
        public int Item;
        public int SlotType;
        public bool Tradeable;
        public bool Included;

        public void Read(PacketInput input)
        {
            Item = input.ReadInt32();
            SlotType = input.ReadInt32();
            Tradeable = input.ReadBoolean();
            Included = input.ReadBoolean();
        }
    }
}
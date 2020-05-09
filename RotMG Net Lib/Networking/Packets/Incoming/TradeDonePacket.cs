using RotMG_Net_Lib.Models;

namespace RotMG_Net_Lib.Networking.Packets.Incoming
{
    public class TradeDonePacket : IncomingPacket
    {

        public TradeResult Result;

        public string Description;

        public override PacketType GetPacketType() => PacketType.TRADEDONE;

        public override void Read(PacketInput input)
        {
            Result = (TradeResult) input.ReadInt32();
            Description = input.ReadUTF();
        }
    }
}

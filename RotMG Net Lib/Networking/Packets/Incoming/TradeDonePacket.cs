using RotMG_Net_Lib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotMG_Net_Lib.Networking.Packets.Incoming
{
    public class TradeDonePacket : IncomingPacket
    {

        public TradeResult Result;

        public string Description;

        public override PacketType GetPacketType() => PacketType.TradeDone;

        public override void Read(PacketInput input)
        {
            Result = (TradeResult) input.ReadInt32();
            Description = input.ReadUTF();
        }
    }
}

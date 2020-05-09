using RotMG_Net_Lib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotMG_Net_Lib.Networking.Packets.Outgoing
{
    public class MovePacket : OutgoingPacket
    {
        public int TickId;
        public int Time;
        public WorldPosData NewPosition;
        public List<MoveRecord> Records;

        public override PacketType GetPacketType() => PacketType.Move;

        public override void Write(PacketOutput output)
        {
            Records ??= new List<MoveRecord>();

            output.Write(TickId);
            output.Write(Time);
            NewPosition.Write(output);
            output.Write((short) Records.Count);
            foreach (var record in Records)
            {
                record.Write(output);
            }
        }
    }
}
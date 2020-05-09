using System.Collections.Generic;
using RotMG_Net_Lib.Models;

namespace RotMG_Net_Lib.Networking.Packets.Outgoing
{
    public class MovePacket : OutgoingPacket
    {
        public int TickId;
        public int Time;
        public WorldPosData NewPosition;
        public List<MoveRecord> Records = new List<MoveRecord>();

        public override PacketType GetPacketType() => PacketType.MOVE;

        public override void Write(PacketOutput output)
        {
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
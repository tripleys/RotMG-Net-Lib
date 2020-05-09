using RotMG_Net_Lib.Models;

namespace RotMG_Net_Lib.Networking.Packets.Incoming
{
    public class NewTickPacket : IncomingPacket
    {

        public int TickId;

        public int TickTime;

        public ObjectStatusData[] Statuses;

        public override PacketType GetPacketType() => PacketType.NEWTICK;

        public override void Read(PacketInput input)
        {
            TickId = input.ReadInt32();
            TickTime = input.ReadInt32();
            Statuses = new ObjectStatusData[input.ReadInt16()];
            for (int i = 0; i < Statuses.Length; i++)
                (Statuses[i] = new ObjectStatusData()).Read(input);
        }
    }
}

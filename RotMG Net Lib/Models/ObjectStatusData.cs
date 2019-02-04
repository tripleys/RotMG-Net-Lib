using RotMG_Net_Lib.Networking.Packets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotMG_Net_Lib.Models
{
    public class ObjectStatusData
    {
        public int ObjectId;
        public WorldPosData Pos;
        public StatData[] Stats;

        public void Read(PacketInput input)
        {
            ObjectId = input.ReadInt32();
            (Pos = new WorldPosData()).Read(input);
            Stats = new StatData[input.ReadInt16()];
            for(int i = 0; i < Stats.Length; i++)
            {
                (Stats[i] = new StatData()).Read(input);
            }
        }
    }
}

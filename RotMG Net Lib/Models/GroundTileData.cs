using RotMG_Net_Lib.Networking.Packets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotMG_Net_Lib.Models
{
    public class GroundTileData
    {
        public short X;
        public short Y;
        public ushort Type;

        public void Read(PacketInput input)
        {
            X = input.ReadInt16();
            Y = input.ReadInt16();
            Type = input.ReadUInt16();
        }
    }
}

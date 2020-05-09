using RotMG_Net_Lib.Networking.Packets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotMG_Net_Lib.Models
{
    public class WorldPosData
    {

        public float X;

        public float Y;

        public WorldPosData()
        {

        }

        public WorldPosData(float X, float Y)
        {
            this.X = X;
            this.Y = Y;
        }

        public WorldPosData Read(PacketInput input)
        {
            X = input.ReadSingle();
            Y = input.ReadSingle();
            return this;
        }

        public void Write(PacketOutput output)
        {
            output.Write(X);
            output.Write(Y);
        }

        public float DistanceTo(WorldPosData wp)
        {
            float dx = wp.X - X;
            float dy = wp.Y - Y;
            return (float)Math.Sqrt(dx * dx + dy * dy);
        }

        public float DistanceTo(float x, float y)
        {
            float dx = x - X;
            float dy = y - Y;
            return (float)Math.Sqrt(dx * dx + dy * dy);
        }
    }
}

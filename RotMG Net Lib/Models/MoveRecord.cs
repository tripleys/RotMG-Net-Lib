using RotMG_Net_Lib.Networking.Packets;

namespace RotMG_Net_Lib.Models
{
    public class MoveRecord
    {
        public int Time;
        public float X;
        public float Y;

        public MoveRecord(int time, float x, float y)
        {
            Time = time;
            X = x;
            Y = y;
        }

        public void Write(PacketOutput output)
        {
            output.Write(Time);
            output.Write(X);
            output.Write(Y);
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace RotMG_Net_Lib.Networking.Packets
{
    public class PacketOutput : BinaryWriter
    {
        public PacketOutput(Stream s) : base(s)
        {
        }

        public override void Write(short value)
        {
            base.Write(IPAddress.NetworkToHostOrder(value));
        }

        public override void Write(ushort value)
        {
            base.Write((ushort)IPAddress.HostToNetworkOrder((short)value));
        }

        public override void Write(int value)
        {
            base.Write(IPAddress.NetworkToHostOrder(value));
        }

        public override void Write(float value)
        {
            byte[] b = BitConverter.GetBytes(value);
            Array.Reverse(b);
            base.Write(b);
        }

        public void WriteUTF(string s)
        {
            Write((short)s.Length);
            base.Write(Encoding.UTF8.GetBytes(s));
        }

        public void WriteUTF32(string s)
        {
            Write(s.Length);
            base.Write(Encoding.UTF8.GetBytes(s));
        }
    }
}

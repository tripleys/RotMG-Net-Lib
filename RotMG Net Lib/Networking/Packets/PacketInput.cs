using System;
using System.IO;
using System.Net;
using System.Text;

namespace RotMG_Net_Lib.Networking.Packets
{
    public class PacketInput : BinaryReader
    {
        public PacketInput(Stream s) : base(s)
        {
            
        }

        public override short ReadInt16()
        {
            return IPAddress.NetworkToHostOrder(base.ReadInt16());
        }

        public override ushort ReadUInt16()
        {
            return (ushort)IPAddress.NetworkToHostOrder((short)base.ReadUInt16());
        }

        public override int ReadInt32()
        {
            return IPAddress.NetworkToHostOrder(base.ReadInt32());
        }

        public override float ReadSingle()
        {
            byte[] arr = base.ReadBytes(4);
            Array.Reverse(arr);
            return BitConverter.ToSingle(arr, 0);
        }

        public string ReadUTF()
        {
            return Encoding.UTF8.GetString(ReadBytes(ReadInt16()));
        }

        public string ReadUTF32()
        {
            return Encoding.UTF8.GetString(ReadBytes(ReadInt32()));
        }

        public int Remaining()
        {
            return (int) (BaseStream.Length - BaseStream.Position);
        }
    }
}

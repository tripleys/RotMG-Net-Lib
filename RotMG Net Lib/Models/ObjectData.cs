using RotMG_Net_Lib.Networking.Packets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotMG_Net_Lib.Models
{
    public class ObjectData
    {
        public ushort ObjectType;
        public ObjectStatusData Status;

        public void Read(PacketInput input)
        {
            ObjectType = input.ReadUInt16();
            (Status = new ObjectStatusData()).Read(input);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotMG_Net_Lib.Networking.Packets
{
    public abstract class OutgoingPacket
    {
        public abstract PacketType GetPacketType();

        public abstract void Write(PacketOutput output);
    }
}

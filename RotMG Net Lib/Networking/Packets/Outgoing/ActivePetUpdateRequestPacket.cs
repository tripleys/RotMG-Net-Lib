using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotMG_Net_Lib.Networking.Packets.Outgoing
{
    public class ActivePetUpdateRequestPacket : OutgoingPacket
    {
        public byte CommandType;
        public uint InstanceId;

        public override PacketType GetPacketType() => PacketType.ActivePetUpdateRequest;

        public override void Write(PacketOutput output)
        {
            output.Write(CommandType);
            output.Write(InstanceId);
        }
    }
}

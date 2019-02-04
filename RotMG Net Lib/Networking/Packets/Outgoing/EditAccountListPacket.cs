using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotMG_Net_Lib.Networking.Packets.Outgoing
{
    public class EditAccountListPacket : OutgoingPacket
    {
        public int AccountListId;
        public bool Add;
        public int ObjectId;

        public override PacketType GetPacketType() => PacketType.EditAccountList;

        public override void Write(PacketOutput output)
        {
            output.Write(AccountListId);
            output.Write(Add);
            output.Write(ObjectId);
        }
    }
}

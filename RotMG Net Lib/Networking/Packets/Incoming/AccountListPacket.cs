using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotMG_Net_Lib.Networking.Packets.Incoming
{
    public class AccountListPacket : IncomingPacket
    {
        public int AccountListId;
        public string[] AccountIds;
        public int LockAction;

        public override PacketType GetPacketType() => PacketType.AccountList;

        public override void Read(PacketInput input)
        {
            AccountListId = input.ReadInt32();
            AccountIds = new string[input.ReadInt16()];
            for(int i = 0; i < AccountIds.Length; i++)
            {
                AccountIds[i] = input.ReadUTF();
            }
            LockAction = input.ReadInt32();
        }
    }
}

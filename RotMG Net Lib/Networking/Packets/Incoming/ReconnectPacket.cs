using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotMG_Net_Lib.Networking.Packets.Incoming
{
    public class ReconnectPacket : IncomingPacket
    {
        public string Name;
        public string Host;
        public string Stats;
        public int Port;
        public int GameId;
        public int KeyTime;
        public byte[] Key;
        public bool IsFromArena;

        public override PacketType GetPacketType() => PacketType.Reconnect;

        public override void Read(PacketInput input)
        {
            Name = input.ReadUTF();
            Host = input.ReadUTF();
            Stats = input.ReadUTF();
            Port = input.ReadInt32();
            GameId = input.ReadInt32();
            KeyTime = input.ReadInt32();
            IsFromArena = input.ReadBoolean();
            Key = input.ReadBytes(input.ReadInt16());
        }
    }
}

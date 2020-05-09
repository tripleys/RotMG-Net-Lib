using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotMG_Net_Lib.Networking.Packets.Incoming
{
    public class MapInfoPacket : IncomingPacket
    {
        public int Width;
        public int Height;
        public string Name;
        public string DisplayName;
        public string RealmName;
        public int Difficulty;
        public uint Fp;
        public int Background;
        public bool AllowPlayerTeleport;
        public bool ShowDisplays;
        public string ConnectionGuid;
        public int MaxPlayers;

        public override PacketType GetPacketType() => PacketType.MapInfo;

        public override void Read(PacketInput input)
        {
            Width = input.ReadInt32();
            Height = input.ReadInt32();
            Name = input.ReadUTF();
            DisplayName = input.ReadUTF();
            RealmName = input.ReadUTF();
            Fp = input.ReadUInt32();
            Background = input.ReadInt32();
            Difficulty = input.ReadInt32();
            AllowPlayerTeleport = input.ReadBoolean();
            ShowDisplays = input.ReadBoolean();
            MaxPlayers = input.ReadInt16();
            ConnectionGuid = input.ReadUTF();
        }
    }
}
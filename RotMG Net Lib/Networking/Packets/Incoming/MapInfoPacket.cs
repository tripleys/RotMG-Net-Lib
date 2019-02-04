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
        public int Difficulty;
        public uint Seed;
        public int Background;
        public bool AllowPlayerTeleport;
        public bool ShowDisplays;
        public string[] ClientXML;
        public string[] ExtraXML;

        public override PacketType GetPacketType() => PacketType.MapInfo;

        public override void Read(PacketInput input)
        {
            Width = input.ReadInt32();
            Height = input.ReadInt32();
            Name = input.ReadUTF();
            DisplayName = input.ReadUTF();
            Seed = input.ReadUInt32();
            Background = input.ReadInt32();
            Difficulty = input.ReadInt32();
            AllowPlayerTeleport = input.ReadBoolean();
            ShowDisplays = input.ReadBoolean();
            ClientXML = new string[input.ReadInt16()];
            for (int i = 0; i < ClientXML.Length; i++)
                ClientXML[i] = input.ReadUTF32();
            ExtraXML = new string[input.ReadInt16()];
            for (int i = 0; i < ExtraXML.Length; i++)
                ExtraXML[i] = input.ReadUTF32();
        }
    }
}

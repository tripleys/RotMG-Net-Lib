using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotMG_Net_Lib.Networking.Packets
{

    public static class Packets
    {
        public static Dictionary<PacketType, byte> Ids = new Dictionary<PacketType, byte>();
        public static Dictionary<byte, PacketType> Types = new Dictionary<byte, PacketType>();

        public static void Load(string path)
        {
            PacketData[] data = JsonConvert.DeserializeObject<PacketData[]>(File.ReadAllText(path));
            foreach(var p in data)
            {
                PacketType type = (PacketType)Enum.Parse(typeof(PacketType), p.Type);
                Ids.Add(type, p.Id);
                Types.Add(p.Id, type);
            }
        }

        public static byte ToId(this PacketType type)
        {
            return Ids[type];
        }

        public static PacketType ToPacketType(this byte id)
        {
            return Types[id];
        }

    }

    class PacketData
    {
        public string Type;
        public byte Id;
    }
}

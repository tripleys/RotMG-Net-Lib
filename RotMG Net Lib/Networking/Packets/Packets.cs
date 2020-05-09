using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;

namespace RotMG_Net_Lib.Networking.Packets
{

    public static class Packets
    {
        private static readonly Logger Log = LogManager.GetCurrentClassLogger();

        private static Dictionary<byte, PacketType> PacketTypes = new Dictionary<byte, PacketType>();

        static Packets()
        {
            foreach (Type i in typeof(OutgoingPacket).Assembly.GetTypes())
            {
                if (typeof(OutgoingPacket).IsAssignableFrom(i) && !i.IsAbstract)
                {
                    OutgoingPacket pkt = (OutgoingPacket) Activator.CreateInstance(i);
                    PacketTypes[(byte) pkt.GetPacketType()] = pkt.GetPacketType();
                }
            }

            foreach (Type i in typeof(IncomingPacket).Assembly.GetTypes())
            {
                if (typeof(IncomingPacket).IsAssignableFrom(i) && !i.IsAbstract)
                {
                    IncomingPacket pkt = (IncomingPacket) Activator.CreateInstance(i);
                    PacketTypes[(byte) pkt.GetPacketType()] = pkt.GetPacketType();
                }
            }

            Log.Info("Added " + PacketTypes.Count + " packets.");
        }

        public static byte ToId(this PacketType type)
        {
            return (byte) PacketTypes[(byte) type];
        }

        public static PacketType ToPacketType(this byte id)
        {
            if (!PacketTypes.ContainsKey(id))
            {
                Log.Error("Fatal, packet id '" + id + "' not found.");
            }

            return PacketTypes[id];
        }

    }
}
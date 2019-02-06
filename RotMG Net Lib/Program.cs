using RotMG_Net_Lib.Crypto;
using RotMG_Net_Lib.Data;
using RotMG_Net_Lib.Networking;
using RotMG_Net_Lib.Networking.Packets;
using RotMG_Net_Lib.Networking.Packets.Incoming;
using RotMG_Net_Lib.Networking.Packets.Outgoing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace RotMG_Net_Lib
{
    class Program
    {
        static void Main(string[] args)
        {
            Reconnect reconnect = new Reconnect()
            {
                Host = "54.93.78.148",
                Port = 2050,
                GameId = -2,
                KeyTime = 0,
                Key = new byte[0]
            };
            NetClient client = new NetClient(reconnect);
            client.Hook(PacketType.Failure, (p) =>
            {
                Console.WriteLine("Failure: " + ((FailurePacket)p).ErrorDescription);
            });
            client.Hook(PacketType.MapInfo, (p) =>
            {
                LoadPacket load = new LoadPacket()
                {
                    CharId = 2,
                    IsFromArena = false
                };
                client.SendPacket(load);
            });
            client.Hook(PacketType.Update, (p) =>
            {
                client.SendPacket(new UpdateAckPacket());
            });
            client.Hook(PacketType.NewTick, (p) =>
            {
                Console.WriteLine("NEW_TICK, id: " + ((NewTickPacket) p).TickId);
            });
            HelloPacket hello = new HelloPacket()
            {
                BuildVersion = "X31.2.3",
                GameId = reconnect.GameId,
                Guid = RSA.Instance.Encrypt(""),
                Password = RSA.Instance.Encrypt(""),
                Secret = RSA.Instance.Encrypt(""),
                GameNet = "rotmg",
                PlayPlatform = "rotmg"
            };

            client.SendPacket(hello);

            Console.ReadKey();
        }
    }
}

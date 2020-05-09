using RotMG_Net_Lib.Crypto;
using RotMG_Net_Lib.Data;
using RotMG_Net_Lib.Networking;
using RotMG_Net_Lib.Networking.Packets;
using RotMG_Net_Lib.Networking.Packets.Incoming;
using RotMG_Net_Lib.Networking.Packets.Outgoing;
using System;
using NLog;

namespace RotMG_Net_Lib
{
    class Program
    {
        private static readonly Logger Log = LogManager.GetCurrentClassLogger();

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

            NetClient client = new NetClient();

            client.Hook(PacketType.FAILURE, (p) => { Log.Error("Failure: " + ((FailurePacket) p).ErrorDescription); });
            client.Hook(PacketType.MAPINFO, (p) =>
            {
                LoadPacket load = new LoadPacket()
                {
                    CharId = 2,
                    IsFromArena = false
                };
                client.SendPacket(load);
            });
            client.Hook(PacketType.UPDATE, (p) => { client.SendPacket(new UpdateAckPacket()); });
            client.Hook(PacketType.NEWTICK, (p) => { Log.Debug("NEW_TICK, id: " + ((NewTickPacket) p).TickId); });
            HelloPacket hello = new HelloPacket()
            {
                BuildVersion = Constants.Game.Version,
                GameId = reconnect.GameId,
                Guid = RSA.Instance.Encrypt(""),
                Password = RSA.Instance.Encrypt(""),
                Secret = RSA.Instance.Encrypt(""),
                GameNet = "rotmg",
                PlayPlatform = "rotmg"
            };

            client.Connect(reconnect);
            client.SendPacket(hello);
            Console.ReadKey();
        }
    }
}
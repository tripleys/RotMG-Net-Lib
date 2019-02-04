using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotMG_Net_Lib.Networking.Packets.Outgoing
{
    public class HelloPacket : OutgoingPacket
    {

        public string BuildVersion;
        public int GameId;
        public string Guid;
        public string Password;
        public string Secret;
        public int KeyTime;
        public byte[] Key;
        public string MapJSON;
        public string EntryTag;
        public string GameNet;
        public string GameNetUserId;
        public string PlayPlatform;
        public string PlatformToken;
        public string UserToken;

        public HelloPacket()
        {
            GameId = 0;
            KeyTime = 0;
            Secret = string.Empty;
            Key = new byte[0];
            MapJSON = string.Empty;
            EntryTag = string.Empty;
            GameNet = string.Empty;
            GameNetUserId = string.Empty;
            PlayPlatform = string.Empty;
            PlatformToken = string.Empty;
            UserToken = string.Empty;
        }

        public override PacketType GetPacketType() => PacketType.Hello;

        public override void Write(PacketOutput output)
        {
            output.WriteUTF(BuildVersion);
            output.Write(GameId);
            output.WriteUTF(Guid);
            Random random = new Random();
            output.Write(random.Next(1000000000));
            output.WriteUTF(Password);
            output.Write(random.Next(1000000000));
            output.WriteUTF(Secret);
            output.Write(KeyTime);
            output.Write((short) Key.Length);
            output.Write(Key);
            output.WriteUTF32(MapJSON);
            output.WriteUTF(EntryTag);
            output.WriteUTF(GameNet);
            output.WriteUTF(GameNetUserId);
            output.WriteUTF(PlayPlatform);
            output.WriteUTF(PlatformToken);
            output.WriteUTF(UserToken);
        }
    }
}

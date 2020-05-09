using RotMG_Net_Lib.Networking.Packets.Incoming;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotMG_Net_Lib.Networking.Packets
{
    public abstract class IncomingPacket
    {
        public static IncomingPacket Create(PacketType type)
        {
            switch(type)
            {
                case PacketType.Failure:
                    return new FailurePacket();
                case PacketType.MapInfo:
                    return new MapInfoPacket();
                case PacketType.Update:
                    return new UpdatePacket();
                case PacketType.NewTick:
                    return new NewTickPacket();
                case PacketType.Goto:
                    return new GotoPacket();
                case PacketType.Ping:
                    return new PingPacket();
                case PacketType.CreateSuccess:
                    return new CreateSuccessPacket();
                case PacketType.Notification:
                    return new NotificationPacket();
                case PacketType.Damage:
                    return new DamagePacket();
                case PacketType.Text:
                    return new TextPacket();
                case PacketType.Reconnect:
                    return new ReconnectPacket();
                case PacketType.AccountList:
                    return new AccountListPacket();
                case PacketType.ServerPlayerShoot:
                    return new ServerPlayerShootPacket();
                case PacketType.TradeRequested:
                    return new TradeRequestedPacket();
                case PacketType.TradeStart:
                    return new TradeStartPacket();
                case PacketType.TradeDone:
                    return new TradeDonePacket();
                case PacketType.TradeChanged:
                    return new TradeChangedPacket();
                case PacketType.TradeAccepted:
                    return new TradeAcceptedPacket();
                case PacketType.Death:
                    return new DeathPacket();
                case PacketType.Aoe:
                    return new AoePacket();
                case PacketType.ClientStat:
                    return new ClientStatPacket();
                case PacketType.NameResult:
                    return new NameResultPacket();
                case PacketType.ShowEffect:
                    return new ShowEffectPacket();
                case PacketType.GlobalNotification:
                    return new GlobalNotificationPacket();
                case PacketType.QuestRedeemResponse:
                    return new QuestRedeemResponsePacket();
                case PacketType.QuestObjId:
                    return new QuestObjIdPacket();
                case PacketType.VerifyEmail:
                    return new VerifyEmailPacket();
                case PacketType.RealmHeroLeftMsg:
                    return new RealmHeroesResponsePacket();
                case PacketType.GuildResult:
                    return new GuildResultPacket();
                case PacketType.AllyShoot:
                    return new AllyShootPacket();
                case PacketType.KeyInfoResponse:
                    return new KeyInfoResponsePacket();
                case PacketType.ReskinUnlock:
                    return new ReskinUnlockPacket();
                case PacketType.PlaySound:
                    return new PlaySoundPacket();
                default:
                    return null;
            }
        }

        public abstract PacketType GetPacketType();

        public abstract void Read(PacketInput input);
    }
}

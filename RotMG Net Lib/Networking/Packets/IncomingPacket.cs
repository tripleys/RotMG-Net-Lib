using RotMG_Net_Lib.Networking.Packets.Incoming;

namespace RotMG_Net_Lib.Networking.Packets
{
    public abstract class IncomingPacket
    {
        public static IncomingPacket Create(PacketType type)
        {
            switch (type)
            {
                case PacketType.FAILURE:
                    return new FailurePacket();
                case PacketType.MAPINFO:
                    return new MapInfoPacket();
                case PacketType.UPDATE:
                    return new UpdatePacket();
                case PacketType.NEWTICK:
                    return new NewTickPacket();
                case PacketType.GOTO:
                    return new GotoPacket();
                case PacketType.PING:
                    return new PingPacket();
                case PacketType.CREATE_SUCCESS:
                    return new CreateSuccessPacket();
                case PacketType.NOTIFICATION:
                    return new NotificationPacket();
                case PacketType.DAMAGE:
                    return new DamagePacket();
                case PacketType.TEXT:
                    return new TextPacket();
                case PacketType.RECONNECT:
                    return new ReconnectPacket();
                case PacketType.ACCOUNTLIST:
                    return new AccountListPacket();
                case PacketType.SERVERPLAYERSHOOT:
                    return new ServerPlayerShootPacket();
                case PacketType.TRADEREQUESTED:
                    return new TradeRequestedPacket();
                case PacketType.TRADESTART:
                    return new TradeStartPacket();
                case PacketType.TRADEDONE:
                    return new TradeDonePacket();
                case PacketType.TRADECHANGED:
                    return new TradeChangedPacket();
                case PacketType.TRADEACCEPTED:
                    return new TradeAcceptedPacket();
                case PacketType.DEATH:
                    return new DeathPacket();
                case PacketType.AOE:
                    return new AoePacket();
                case PacketType.CLIENTSTAT:
                    return new ClientStatPacket();
                case PacketType.NAMERESULT:
                    return new NameResultPacket();
                case PacketType.SHOWEFFECT:
                    return new ShowEffectPacket();
                case PacketType.GLOBAL_NOTIFICATION:
                    return new GlobalNotificationPacket();
                case PacketType.QUEST_REDEEM_RESPONSE:
                    return new QuestRedeemResponsePacket();
                case PacketType.QUESTOBJID:
                    return new QuestObjIdPacket();
                case PacketType.VERIFY_EMAIL:
                    return new VerifyEmailPacket();
                case PacketType.REALM_HERO_LEFT_MSG:
                    return new RealmHeroesResponsePacket();
                case PacketType.GUILDRESULT:
                    return new GuildResultPacket();
                case PacketType.ALLYSHOOT:
                    return new AllyShootPacket();
                case PacketType.KEY_INFO_RESPONSE:
                    return new KeyInfoResponsePacket();
                case PacketType.RESKIN_UNLOCK:
                    return new ReskinUnlockPacket();
                case PacketType.PLAYSOUND:
                    return new PlaySoundPacket();
                default:
                    return null;
            }
        }

        public abstract PacketType GetPacketType();

        public abstract void Read(PacketInput input);
    }
}
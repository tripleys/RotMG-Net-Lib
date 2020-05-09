namespace RotMG_Net_Lib.Networking.Packets.Incoming
{
    public class RealmHeroesResponsePacket : IncomingPacket
    {
        public int NumberOfRealmHeroes;

        public override PacketType GetPacketType() => PacketType.REALM_HERO_LEFT_MSG;

        public override void Read(PacketInput input)
        {
            NumberOfRealmHeroes = input.ReadInt32();
        }
    }
}

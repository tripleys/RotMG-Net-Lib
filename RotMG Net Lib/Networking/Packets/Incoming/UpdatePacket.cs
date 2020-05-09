namespace RotMG_Net_Lib.Networking.Packets.Incoming
{
    public class UpdatePacket : IncomingPacket
    {

        public GroundTileData[] Tiles;

        public ObjectData[] NewObjects;

        public int[] Drops;

        public override PacketType GetPacketType() => PacketType.UPDATE;

        public override void Read(PacketInput input)
        {
            Tiles = new GroundTileData[input.ReadInt16()];
            for(int i = 0; i < Tiles.Length; i++)
            {
                (Tiles[i] = new GroundTileData()).Read(input);
            }
            NewObjects = new ObjectData[input.ReadInt16()];
            for(int i = 0; i < NewObjects.Length; i++)
            {
                (NewObjects[i] = new ObjectData()).Read(input);
            }
            Drops = new int[input.ReadInt16()];
            for(int i = 0; i < Drops.Length; i++)
            {
                Drops[i] = input.ReadInt32();
            }
        }
    }
}

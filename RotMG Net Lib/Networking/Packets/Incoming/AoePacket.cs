using RotMG_Net_Lib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotMG_Net_Lib.Networking.Packets.Incoming
{
    public class AoePacket : IncomingPacket
    {
        public WorldPosData Pos;
        public float Radius;
        public ushort Damage;
        public byte Effect;
        public float Duration;
        public ushort OrigType;
        public int Color;
        public bool ArmorPierce;

        public override PacketType GetPacketType() => PacketType.Aoe;

        public override void Read(PacketInput input)
        {
            Pos = new WorldPosData().Read(input);
            Radius = input.ReadSingle();
            Damage = input.ReadUInt16();
            Effect = input.ReadByte();
            Duration = input.ReadSingle();
            OrigType = input.ReadUInt16();
            Color = input.ReadInt32();
            ArmorPierce = input.ReadBoolean();
        }
    }
}

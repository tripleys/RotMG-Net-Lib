using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotMG_Net_Lib.Networking.Packets.Incoming
{
    public class DamagePacket : IncomingPacket
    {
        public int TargetId;
        public byte[] Effects;
        public ushort DamageAmount;
        public bool Kill;
        public bool ArmorPierce;
        public byte BulletId;
        public int ObjectId;

        public override PacketType GetPacketType() => PacketType.Damage;

        public override void Read(PacketInput input)
        {
            TargetId = input.ReadInt32();
            Effects = new byte[input.ReadByte()];
            for (byte i = 0; i < Effects.Length; i++)
                Effects[i] = input.ReadByte();
            DamageAmount = input.ReadUInt16();
            Kill = input.ReadBoolean();
            ArmorPierce = input.ReadBoolean();
            BulletId = input.ReadByte();
            ObjectId = input.ReadInt32();
        }
    }
}

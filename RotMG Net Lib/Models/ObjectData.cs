using RotMG_Net_Lib.Networking.Packets;

namespace RotMG_Net_Lib.Models
{
    public class ObjectData
    {
        public ushort ObjectType;
        public ObjectStatusData Status;

        public void Read(PacketInput input)
        {
            ObjectType = input.ReadUInt16();
            (Status = new ObjectStatusData()).Read(input);
        }
    }
}

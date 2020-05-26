namespace RotMG_Net_Lib.Constants
{
    public class Class
    {
        public static readonly Class Rogue = new Class(0x0300, "Rogue");
        public static readonly Class Archer = new Class(0x0307, "Archer");
        public static readonly Class Wizard = new Class(0x030e, "Wizard");
        public static readonly Class Priest = new Class(0x0310, "Priest");
        public static readonly Class Warrior = new Class(0x031d, "Warrior");
        public static readonly Class Knight = new Class(0x031e, "Knight");
        public static readonly Class Paladin = new Class(0x031f, "Paladin");
        public static readonly Class Assassin = new Class(0x0320, "Assassin");
        public static readonly Class Necromancer = new Class(0x0321, "Necromancer");
        public static readonly Class Huntress = new Class(0x0322, "Huntress");
        public static readonly Class Mystic = new Class(0x0323, "Mystic");
        public static readonly Class Trickster = new Class(0x0324, "Trickster");
        public static readonly Class Sorcerer = new Class(0x0325, "Sorcerer");
        public static readonly Class Ninja = new Class(0x0326, "Ninja");
        public static readonly Class Samurai = new Class(0x0311, "Samurai");

        public short Id;
        public string Name;

        public Class(short id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
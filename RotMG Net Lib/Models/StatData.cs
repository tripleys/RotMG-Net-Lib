using RotMG_Net_Lib.Networking.Packets;

namespace RotMG_Net_Lib.Models
{
    public class StatData
    {
        public const int MAX_HP_STAT = 0;

        public const int HP_STAT = 1;

        public const int SIZE_STAT = 2;

        public const int MAX_MP_STAT = 3;

        public const int MP_STAT = 4;

        public const int NEXT_LEVEL_EXP_STAT = 5;

        public const int EXP_STAT = 6;

        public const int LEVEL_STAT = 7;

        public const int ATTACK_STAT = 20;

        public const int DEFENSE_STAT = 21;

        public const int SPEED_STAT = 22;

        public const int INVENTORY_0_STAT = 8;

        public const int INVENTORY_1_STAT = 9;

        public const int INVENTORY_2_STAT = 10;

        public const int INVENTORY_3_STAT = 11;

        public const int INVENTORY_4_STAT = 12;

        public const int INVENTORY_5_STAT = 13;

        public const int INVENTORY_6_STAT = 14;

        public const int INVENTORY_7_STAT = 15;

        public const int INVENTORY_8_STAT = 16;

        public const int INVENTORY_9_STAT = 17;

        public const int INVENTORY_10_STAT = 18;

        public const int INVENTORY_11_STAT = 19;

        public const int VITALITY_STAT = 26;

        public const int WISDOM_STAT = 27;

        public const int DEXTERITY_STAT = 28;

        public const int CONDITION_STAT = 29;

        public const int NUM_STARS_STAT = 30;

        public const int NAME_STAT = 31;

        public const int TEX1_STAT = 32;

        public const int TEX2_STAT = 33;

        public const int MERCHANDISE_TYPE_STAT = 34;

        public const int CREDITS_STAT = 35;

        public const int MERCHANDISE_PRICE_STAT = 36;

        public const int ACTIVE_STAT = 37;

        public const int ACCOUNT_ID_STAT = 38;

        public const int FAME_STAT = 39;

        public const int MERCHANDISE_CURRENCY_STAT = 40;

        public const int CONNECT_STAT = 41;

        public const int MERCHANDISE_COUNT_STAT = 42;

        public const int MERCHANDISE_MINS_LEFT_STAT = 43;

        public const int MERCHANDISE_DISCOUNT_STAT = 44;

        public const int MERCHANDISE_RANK_REQ_STAT = 45;

        public const int MAX_HP_BOOST_STAT = 46;

        public const int MAX_MP_BOOST_STAT = 47;

        public const int ATTACK_BOOST_STAT = 48;

        public const int DEFENSE_BOOST_STAT = 49;

        public const int SPEED_BOOST_STAT = 50;

        public const int VITALITY_BOOST_STAT = 51;

        public const int WISDOM_BOOST_STAT = 52;

        public const int DEXTERITY_BOOST_STAT = 53;

        public const int OWNER_ACCOUNT_ID_STAT = 54;

        public const int RANK_REQUIRED_STAT = 55;

        public const int NAME_CHOSEN_STAT = 56;

        public const int CURR_FAME_STAT = 57;

        public const int NEXT_CLASS_QUEST_FAME_STAT = 58;

        public const int LEGENDARY_RANK_STAT = 59;

        public const int SINK_LEVEL_STAT = 60;

        public const int ALT_TEXTURE_STAT = 61;

        public const int GUILD_NAME_STAT = 62;

        public const int GUILD_RANK_STAT = 63;

        public const int BREATH_STAT = 64;

        public const int XP_BOOSTED_STAT = 65;

        public const int XP_TIMER_STAT = 66;

        public const int LD_TIMER_STAT = 67;

        public const int LT_TIMER_STAT = 68;

        public const int HEALTH_POTION_STACK_STAT = 69;

        public const int MAGIC_POTION_STACK_STAT = 70;

        public const int BACKPACK_0_STAT = 71;

        public const int BACKPACK_1_STAT = 72;

        public const int BACKPACK_2_STAT = 73;

        public const int BACKPACK_3_STAT = 74;

        public const int BACKPACK_4_STAT = 75;

        public const int BACKPACK_5_STAT = 76;

        public const int BACKPACK_6_STAT = 77;

        public const int BACKPACK_7_STAT = 78;

        public const int HASBACKPACK_STAT = 79;

        public const int TEXTURE_STAT = 80;

        public const int PET_INSTANCEID_STAT = 81;

        public const int PET_NAME_STAT = 82;

        public const int PET_TYPE_STAT = 83;

        public const int PET_RARITY_STAT = 84;

        public const int PET_MAXABILITYPOWER_STAT = 85;

        public const int PET_FAMILY_STAT = 86;

        public const int PET_FIRSTABILITY_POINT_STAT = 87;

        public const int PET_SECONDABILITY_POINT_STAT = 88;

        public const int PET_THIRDABILITY_POINT_STAT = 89;

        public const int PET_FIRSTABILITY_POWER_STAT = 90;

        public const int PET_SECONDABILITY_POWER_STAT = 91;

        public const int PET_THIRDABILITY_POWER_STAT = 92;

        public const int PET_FIRSTABILITY_TYPE_STAT = 93;

        public const int PET_SECONDABILITY_TYPE_STAT = 94;

        public const int PET_THIRDABILITY_TYPE_STAT = 95;

        public const int NEW_CON_STAT = 96;

        public const int FORTUNE_TOKEN_STAT = 97;

        public const int SUPPORTER_POINTS_STAT = 98;

        public const int SUPPORTER_STAT = 99;

        public byte StatType = 0;
        public int StatValue;
        public string StringValue;

        public bool IsStringStat()
        {
            switch (StatType)
            {
                case NAME_STAT:
                case GUILD_NAME_STAT:
                case PET_NAME_STAT:
                case ACCOUNT_ID_STAT:
                case OWNER_ACCOUNT_ID_STAT:
                    return true;
                default:
                    return false;
            }
        }

        public void Read(PacketInput input)
        {
            StatType = input.ReadByte();
            if (!IsStringStat())
            {
                StatValue = input.ReadInt32();
            }
            else
            {
                StringValue = input.ReadUTF();
            }
        }
    }
}

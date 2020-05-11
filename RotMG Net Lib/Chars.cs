using System.Collections.Generic;
using System.Xml.Serialization;

namespace RotMG_Net_Lib
{
    [XmlRoot(ElementName = "Ability")]
    public class Ability
    {
        [XmlAttribute(AttributeName = "type")] public string Type { get; set; }

        [XmlAttribute(AttributeName = "power")]
        public string Power { get; set; }

        [XmlAttribute(AttributeName = "points")]
        public string Points { get; set; }
    }

    [XmlRoot(ElementName = "Abilities")]
    public class Abilities
    {
        [XmlElement(ElementName = "Ability")] public List<Ability> Ability { get; set; }
    }

    [XmlRoot(ElementName = "Pet")]
    public class Pet
    {
        [XmlElement(ElementName = "Abilities")]
        public Abilities Abilities { get; set; }

        [XmlAttribute(AttributeName = "name")] public string Name { get; set; }
        [XmlAttribute(AttributeName = "type")] public string Type { get; set; }

        [XmlAttribute(AttributeName = "instanceId")]
        public string InstanceId { get; set; }

        [XmlAttribute(AttributeName = "rarity")]
        public string Rarity { get; set; }

        [XmlAttribute(AttributeName = "maxAbilityPower")]
        public string MaxAbilityPower { get; set; }

        [XmlAttribute(AttributeName = "skin")] public string Skin { get; set; }
    }

    [XmlRoot(ElementName = "Account")]
    public class Account
    {
        [XmlElement(ElementName = "Name")] public string Name { get; set; }
        [XmlElement(ElementName = "Credits")] public string Credits { get; set; }

        [XmlElement(ElementName = "RemainingLives")]
        public string RemainingLives { get; set; }

        [XmlElement(ElementName = "FortuneToken")]
        public string FortuneToken { get; set; }

        [XmlElement(ElementName = "UnityCampaignPoints")]
        public string UnityCampaignPoints { get; set; }

        [XmlElement(ElementName = "NextCharSlotPrice")]
        public string NextCharSlotPrice { get; set; }

        [XmlElement(ElementName = "EarlyGameEventTracker")]
        public string EarlyGameEventTracker { get; set; }

        [XmlElement(ElementName = "AccountId")]
        public string AccountId { get; set; }

        [XmlElement(ElementName = "CreationTimestamp")]
        public string CreationTimestamp { get; set; }

        [XmlElement(ElementName = "VerifiedEmail")]
        public string VerifiedEmail { get; set; }

        [XmlElement(ElementName = "Originating")]
        public string Originating { get; set; }

        [XmlElement(ElementName = "PetYardType")]
        public string PetYardType { get; set; }

        [XmlElement(ElementName = "Campaigns")]
        public Campaigns Campaigns { get; set; }

        [XmlElement(ElementName = "cleanPasswordStatus")]
        public string CleanPasswordStatus { get; set; }

        [XmlElement(ElementName = "NameChosen")]
        public string NameChosen { get; set; }

        [XmlElement(ElementName = "PaymentProvider")]
        public string PaymentProvider { get; set; }

        [XmlElement(ElementName = "Converted")]
        public string Converted { get; set; }

        [XmlElement(ElementName = "IsAgeVerified")]
        public string IsAgeVerified { get; set; }

        [XmlElement(ElementName = "token")] public string Token { get; set; }

        [XmlElement(ElementName = "SecurityQuestions")]
        public SecurityQuestions SecurityQuestions { get; set; }

        [XmlElement(ElementName = "Stats")] public Stats Stats { get; set; }
        [XmlElement(ElementName = "Guild")] public Guild Guild { get; set; }
    }

    [XmlRoot(ElementName = "Char")]
    public class Char
    {
        [XmlElement(ElementName = "ObjectType")]
        public string ObjectType { get; set; }

        [XmlElement(ElementName = "Level")] public string Level { get; set; }
        [XmlElement(ElementName = "Exp")] public string Exp { get; set; }

        [XmlElement(ElementName = "CurrentFame")]
        public string CurrentFame { get; set; }

        [XmlElement(ElementName = "Equipment")]
        public string Equipment { get; set; }

        [XmlElement(ElementName = "MaxHitPoints")]
        public string MaxHitPoints { get; set; }

        [XmlElement(ElementName = "HitPoints")]
        public string HitPoints { get; set; }

        [XmlElement(ElementName = "MaxMagicPoints")]
        public string MaxMagicPoints { get; set; }

        [XmlElement(ElementName = "MagicPoints")]
        public string MagicPoints { get; set; }

        [XmlElement(ElementName = "Attack")] public string Attack { get; set; }
        [XmlElement(ElementName = "Defense")] public string Defense { get; set; }
        [XmlElement(ElementName = "Speed")] public string Speed { get; set; }

        [XmlElement(ElementName = "Dexterity")]
        public string Dexterity { get; set; }

        [XmlElement(ElementName = "HpRegen")] public string HpRegen { get; set; }
        [XmlElement(ElementName = "MpRegen")] public string MpRegen { get; set; }
        [XmlElement(ElementName = "PCStats")] public string PCStats { get; set; }

        [XmlElement(ElementName = "HealthStackCount")]
        public string HealthStackCount { get; set; }

        [XmlElement(ElementName = "MagicStackCount")]
        public string MagicStackCount { get; set; }

        [XmlElement(ElementName = "Dead")] public string Dead { get; set; }
        [XmlElement(ElementName = "Pet")] public Pet Pet { get; set; }
        [XmlElement(ElementName = "casToken")] public string CasToken { get; set; }
        [XmlElement(ElementName = "Account")] public Account Account { get; set; }
        [XmlElement(ElementName = "Tex1")] public string Tex1 { get; set; }
        [XmlElement(ElementName = "Tex2")] public string Tex2 { get; set; }

        [XmlElement(ElementName = "XpBoosted")]
        public string XpBoosted { get; set; }

        [XmlElement(ElementName = "XpTimer")] public string XpTimer { get; set; }
        [XmlElement(ElementName = "LDTimer")] public string LDTimer { get; set; }
        [XmlElement(ElementName = "LTTimer")] public string LTTimer { get; set; }

        [XmlElement(ElementName = "HasBackpack")]
        public string HasBackpack { get; set; }

        [XmlElement(ElementName = "IsChallenger")]
        public string IsChallenger { get; set; }

        [XmlElement(ElementName = "StarBackground")]
        public string StarBackground { get; set; }

        [XmlAttribute(AttributeName = "id")] public int Id { get; set; }
        [XmlElement(ElementName = "Texture")] public string Texture { get; set; }

        [XmlElement(ElementName = "CreationDate")]
        public string CreationDate { get; set; }
    }

    [XmlRoot(ElementName = "CampaignProgress")]
    public class CampaignProgress
    {
        [XmlElement(ElementName = "Points")] public string Points { get; set; }
    }

    [XmlRoot(ElementName = "Campaigns")]
    public class Campaigns
    {
        [XmlElement(ElementName = "CampaignProgress")]
        public CampaignProgress CampaignProgress { get; set; }
    }

    [XmlRoot(ElementName = "SecurityQuestionsKeys")]
    public class SecurityQuestionsKeys
    {
        [XmlElement(ElementName = "SecurityQuestionsKey")]
        public List<string> SecurityQuestionsKey { get; set; }
    }

    [XmlRoot(ElementName = "SecurityQuestions")]
    public class SecurityQuestions
    {
        [XmlElement(ElementName = "HasSecurityQuestions")]
        public string HasSecurityQuestions { get; set; }

        [XmlElement(ElementName = "ShowSecurityQuestionsDialog")]
        public string ShowSecurityQuestionsDialog { get; set; }

        [XmlElement(ElementName = "SecurityQuestionsKeys")]
        public SecurityQuestionsKeys SecurityQuestionsKeys { get; set; }
    }

    [XmlRoot(ElementName = "ClassStats")]
    public class ClassStats
    {
        [XmlElement(ElementName = "BestLevel")]
        public string BestLevel { get; set; }

        [XmlElement(ElementName = "BestFame")] public string BestFame { get; set; }

        [XmlAttribute(AttributeName = "objectType")]
        public string ObjectType { get; set; }
    }

    [XmlRoot(ElementName = "Stats")]
    public class Stats
    {
        [XmlElement(ElementName = "ClassStats")]
        public List<ClassStats> ClassStats { get; set; }

        [XmlElement(ElementName = "BestCharFame")]
        public string BestCharFame { get; set; }

        [XmlElement(ElementName = "TotalFame")]
        public string TotalFame { get; set; }

        [XmlElement(ElementName = "Fame")] public string Fame { get; set; }
    }

    [XmlRoot(ElementName = "Guild")]
    public class Guild
    {
        [XmlElement(ElementName = "Name")] public string Name { get; set; }
        [XmlElement(ElementName = "Rank")] public string Rank { get; set; }
        [XmlAttribute(AttributeName = "id")] public string Id { get; set; }
    }

    [XmlRoot(ElementName = "Item")]
    public class Item
    {
        [XmlElement(ElementName = "Icon")] public string Icon { get; set; }
        [XmlElement(ElementName = "Title")] public string Title { get; set; }
        [XmlElement(ElementName = "TagLine")] public string TagLine { get; set; }
        [XmlElement(ElementName = "Link")] public string Link { get; set; }
        [XmlElement(ElementName = "Date")] public string Date { get; set; }
    }

    [XmlRoot(ElementName = "News")]
    public class News
    {
        [XmlElement(ElementName = "Item")] public List<Item> Item { get; set; }
    }

    [XmlRoot(ElementName = "Server")]
    public class Server
    {
        [XmlElement(ElementName = "Name")] public string Name { get; set; }
        [XmlElement(ElementName = "DNS")] public string DNS { get; set; }
        [XmlElement(ElementName = "Lat")] public string Lat { get; set; }
        [XmlElement(ElementName = "Long")] public string Long { get; set; }
        [XmlElement(ElementName = "Usage")] public string Usage { get; set; }
    }

    [XmlRoot(ElementName = "Servers")]
    public class Servers
    {
        [XmlElement(ElementName = "Server")] public List<Server> Server { get; set; }
    }

    [XmlRoot(ElementName = "ClassAvailability")]
    public class ClassAvailability
    {
        [XmlAttribute(AttributeName = "id")] public string Id { get; set; }
        [XmlText] public string Text { get; set; }
    }

    [XmlRoot(ElementName = "ClassAvailabilityList")]
    public class ClassAvailabilityList
    {
        [XmlElement(ElementName = "ClassAvailability")]
        public List<ClassAvailability> ClassAvailability { get; set; }
    }

    [XmlRoot(ElementName = "ItemCost")]
    public class ItemCost
    {
        [XmlAttribute(AttributeName = "type")] public string Type { get; set; }

        [XmlAttribute(AttributeName = "purchasable")]
        public string Purchasable { get; set; }

        [XmlAttribute(AttributeName = "expires")]
        public string Expires { get; set; }

        [XmlText] public string Text { get; set; }
    }

    [XmlRoot(ElementName = "ItemCosts")]
    public class ItemCosts
    {
        [XmlElement(ElementName = "ItemCost")] public List<ItemCost> ItemCost { get; set; }
    }

    [XmlRoot(ElementName = "MaxClassLevel")]
    public class MaxClassLevel
    {
        [XmlAttribute(AttributeName = "classType")]
        public string ClassType { get; set; }

        [XmlAttribute(AttributeName = "maxLevel")]
        public string MaxLevel { get; set; }
    }

    [XmlRoot(ElementName = "MaxClassLevelList")]
    public class MaxClassLevelList
    {
        [XmlElement(ElementName = "MaxClassLevel")]
        public List<MaxClassLevel> MaxClassLevel { get; set; }
    }

    [XmlRoot(ElementName = "Chars")]
    public class Chars
    {
        [XmlElement(ElementName = "Char")] public List<Char> Char { get; set; }
        [XmlElement(ElementName = "Account")] public Account Account { get; set; }
        [XmlElement(ElementName = "News")] public News News { get; set; }
        [XmlElement(ElementName = "Servers")] public Servers Servers { get; set; }
        [XmlElement(ElementName = "Lat")] public string Lat { get; set; }
        [XmlElement(ElementName = "Long")] public string Long { get; set; }

        [XmlElement(ElementName = "ClassAvailabilityList")]
        public ClassAvailabilityList ClassAvailabilityList { get; set; }

        [XmlElement(ElementName = "OwnedSkins")]
        public string OwnedSkins { get; set; }

        [XmlElement(ElementName = "ItemCosts")]
        public ItemCosts ItemCosts { get; set; }

        [XmlElement(ElementName = "SalesForce")]
        public string SalesForce { get; set; }

        [XmlElement(ElementName = "MaxClassLevelList")]
        public MaxClassLevelList MaxClassLevelList { get; set; }

        [XmlAttribute(AttributeName = "nextCharId")]
        public int NextCharId { get; set; }

        [XmlAttribute(AttributeName = "maxNumChars")]
        public string MaxNumChars { get; set; }
    }
}
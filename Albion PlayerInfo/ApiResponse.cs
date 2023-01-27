using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Albion_PlayerInfo
{

    public class Search
    {
        public List<object> guilds { get; set; }
        public List<Player> players { get; set; }

        public class Player
        {
            public string Id { get; set; }
            public string Name { get; set; }
            public string GuildId { get; set; }
            public string GuildName { get; set; }
            public string AllianceId { get; set; }
            public string AllianceName { get; set; }
            public string Avatar { get; set; }
            public string AvatarRing { get; set; }
            public int KillFame { get; set; }
            public int DeathFame { get; set; }
            public double FameRatio { get; set; }
            public object totalKills { get; set; }
            public object gvgKills { get; set; }
            public object gvgWon { get; set; }
        }



    }

    public class Deaths
    {
        public int groupMemberCount { get; set; }
        public int numberOfParticipants { get; set; }
        public int EventId { get; set; }
        public object TimeStamp { get; set; }
        public int Version { get; set; }
        
        public Killer killer { get; set; }
        public Victim victim { get; set; }
        public int TotalVictimKillFame { get; set; }
        public object Location { get; set; }
        public List<Participant> Participants { get; set; }
        public List<GroupMember> GroupMembers { get; set; }
        public object GvGMatch { get; set; }
        public int BattleId { get; set; }
        public string KillArea { get; set; }
        public object Category { get; set; }
        public string Type { get; set; }

        public class All
        {
            public int Total { get; set; }
            public int Royal { get; set; }
            public int Outlands { get; set; }
            public int Avalon { get; set; }
        }

        public class Armor
        {
            public string Type { get; set; }
            public int Count { get; set; }
            public int Quality { get; set; }
            public List<object> ActiveSpells { get; set; }
            public List<object> PassiveSpells { get; set; }
        }

        public class Bag
        {
            public string Type { get; set; }
            public int Count { get; set; }
            public int Quality { get; set; }
            public List<object> ActiveSpells { get; set; }
            public List<object> PassiveSpells { get; set; }
        }

        public class Cape
        {
            public string Type { get; set; }
            public int Count { get; set; }
            public int Quality { get; set; }
            public List<object> ActiveSpells { get; set; }
            public List<object> PassiveSpells { get; set; }
        }

        public class Crafting
        {
            public int Total { get; set; }
            public int Royal { get; set; }
            public int Outlands { get; set; }
            public int Avalon { get; set; }
        }

        public class Equipment
        {
            public MainHand MainHand { get; set; }
            public OffHand OffHand { get; set; }
            public Head Head { get; set; }
            public Armor Armor { get; set; }
            public Shoes Shoes { get; set; }
            public Bag Bag { get; set; }
            public Cape Cape { get; set; }
            public Mount Mount { get; set; }
            public Potion Potion { get; set; }
            public Food Food { get; set; }
        }

        public class Fiber
        {
            public int Total { get; set; }
            public int Royal { get; set; }
            public int Outlands { get; set; }
            public int Avalon { get; set; }
        }

        public class Food
        {
            public string Type { get; set; }
            public int Count { get; set; }
            public int Quality { get; set; }
            public List<object> ActiveSpells { get; set; }
            public List<object> PassiveSpells { get; set; }
        }

        public class Gathering
        {
            public Fiber Fiber { get; set; }
            public Hide Hide { get; set; }
            public Ore Ore { get; set; }
            public Rock Rock { get; set; }
            public Wood Wood { get; set; }
            public All All { get; set; }
        }

        public class GroupMember
        {
            public double AverageItemPower { get; set; }
            public Equipment Equipment { get; set; }
            public List<object> Inventory { get; set; }
            public string Name { get; set; }
            public string Id { get; set; }
            public string GuildName { get; set; }
            public string GuildId { get; set; }
            public string AllianceName { get; set; }
            public string AllianceId { get; set; }
            public string AllianceTag { get; set; }
            public string Avatar { get; set; }
            public string AvatarRing { get; set; }
            public int DeathFame { get; set; }
            public int KillFame { get; set; }
            public double FameRatio { get; set; }
            public LifetimeStatistics LifetimeStatistics { get; set; }
        }

        public class Head
        {
            public string Type { get; set; }
            public int Count { get; set; }
            public int Quality { get; set; }
            public List<object> ActiveSpells { get; set; }
            public List<object> PassiveSpells { get; set; }
        }

        public class Hide
        {
            public int Total { get; set; }
            public int Royal { get; set; }
            public int Outlands { get; set; }
            public int Avalon { get; set; }
        }

        public class Inventory
        {
            public string Type { get; set; }
            public int Count { get; set; }
            public int Quality { get; set; }
            public List<object> ActiveSpells { get; set; }
            public List<object> PassiveSpells { get; set; }
        }

        public class Killer
        {
            public double AverageItemPower { get; set; }
            public Equipment Equipment { get; set; }
            public List<object> Inventory { get; set; }
            public string Name { get; set; }
            public string Id { get; set; }
            public string GuildName { get; set; }
            public string GuildId { get; set; }
            public string AllianceName { get; set; }
            public string AllianceId { get; set; }
            public string AllianceTag { get; set; }
            public string Avatar { get; set; }
            public string AvatarRing { get; set; }
            public int DeathFame { get; set; }
            public int KillFame { get; set; }
            public double FameRatio { get; set; }
            public LifetimeStatistics LifetimeStatistics { get; set; }
        }

        public class LifetimeStatistics
        {
            public PvE PvE { get; set; }
            public Gathering Gathering { get; set; }
            public Crafting Crafting { get; set; }
            public int CrystalLeague { get; set; }
            public int FishingFame { get; set; }
            public int FarmingFame { get; set; }
            public object Timestamp { get; set; }
        }

        public class MainHand
        {
            public string Type { get; set; }
            public int Count { get; set; }
            public int Quality { get; set; }
            public List<object> ActiveSpells { get; set; }
            public List<object> PassiveSpells { get; set; }
        }

        public class Mount
        {
            public string Type { get; set; }
            public int Count { get; set; }
            public int Quality { get; set; }
            public List<object> ActiveSpells { get; set; }
            public List<object> PassiveSpells { get; set; }
        }

        public class OffHand
        {
            public string Type { get; set; }
            public int Count { get; set; }
            public int Quality { get; set; }
            public List<object> ActiveSpells { get; set; }
            public List<object> PassiveSpells { get; set; }
        }

        public class Ore
        {
            public int Total { get; set; }
            public int Royal { get; set; }
            public int Outlands { get; set; }
            public int Avalon { get; set; }
        }

        public class Participant
        {
            public double AverageItemPower { get; set; }
            public Equipment Equipment { get; set; }
            public List<object> Inventory { get; set; }
            public string Name { get; set; }
            public string Id { get; set; }
            public string GuildName { get; set; }
            public string GuildId { get; set; }
            public string AllianceName { get; set; }
            public string AllianceId { get; set; }
            public string AllianceTag { get; set; }
            public string Avatar { get; set; }
            public string AvatarRing { get; set; }
            public int DeathFame { get; set; }
            public int KillFame { get; set; }
            public double FameRatio { get; set; }
            public LifetimeStatistics LifetimeStatistics { get; set; }
            public double DamageDone { get; set; }
            public double SupportHealingDone { get; set; }
        }

        public class Potion
        {
            public string Type { get; set; }
            public int Count { get; set; }
            public int Quality { get; set; }
            public List<object> ActiveSpells { get; set; }
            public List<object> PassiveSpells { get; set; }
        }

        public class PvE
        {
            public int Total { get; set; }
            public int Royal { get; set; }
            public int Outlands { get; set; }
            public int Avalon { get; set; }
            public int Hellgate { get; set; }
            public int CorruptedDungeon { get; set; }
        }

        public class Rock
        {
            public int Total { get; set; }
            public int Royal { get; set; }
            public int Outlands { get; set; }
            public int Avalon { get; set; }
        }

      

        public class Shoes
        {
            public string Type { get; set; }
            public int Count { get; set; }
            public int Quality { get; set; }
            public List<object> ActiveSpells { get; set; }
            public List<object> PassiveSpells { get; set; }
        }

        public class Victim
        {
            public double AverageItemPower { get; set; }
            public Equipment Equipment { get; set; }
            public List<Inventory> Inventory { get; set; }
            public string Name { get; set; }
            public string Id { get; set; }
            public string GuildName { get; set; }
            public string GuildId { get; set; }
            public string AllianceName { get; set; }
            public string AllianceId { get; set; }
            public string AllianceTag { get; set; }
            public string Avatar { get; set; }
            public string AvatarRing { get; set; }
            public int DeathFame { get; set; }
            public int KillFame { get; set; }
            public double FameRatio { get; set; }
            public LifetimeStatistics LifetimeStatistics { get; set; }
        }

        public class Wood
        {
            public int Total { get; set; }
            public int Royal { get; set; }
            public int Outlands { get; set; }
            public int Avalon { get; set; }
        }


    }
}

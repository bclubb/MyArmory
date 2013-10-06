using System;
using System.ComponentModel.DataAnnotations;

namespace MyArmoryLibrary.Models
{
    public class Character
    {
        private int m_level;
        private string m_name;
        private CharacterRace m_race;
        private CharacterClass m_class;
        private CharacterFaction m_faction;

        #region Methods

        public override string ToString()
        {
            return string.Format("{0}, level {1} {2} {3}", m_name, m_level, m_race, m_class);
        }

        #endregion

        #region Properties

        [Key]
        public string Name
        {
            get
            {
                return m_name;
            }

            set
            {
                m_name = value;
            }
        }

        public int Level
        {
            get
            {
                return m_level;
            }

            set
            {
                m_level = value;
            }
        }

        public CharacterRace Race
        {
            get
            {
                return m_race;
            }

            set
            {
                m_race = value;
            }
        }

        public CharacterClass Class
        {
            get
            {
                return m_class;
            }

            set
            {
                m_class = value;
            }
        }

        public CharacterFaction Faction
        {
            get
            {
                return m_faction;
            }

            set
            {
                m_faction = value;
            }
        }

        #endregion
    }

    public enum CharacterRace
    {
        Orc,
        Gnome,
        Human,
        Worgen,
        Tauren,
        BloodElf
    }

    public enum CharacterClass
    {
        Mage,
        Druid,
        Warrior,
        DeathKnight
    }

    public enum CharacterFaction
    {
        Horde,
        Alliance
    }
}

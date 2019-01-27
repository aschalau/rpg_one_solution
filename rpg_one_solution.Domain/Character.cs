using System;

namespace rpg_one_solution.Domain
{
    public class Character
    {
        private int _strength, 
                    _dexterity,
                    _constitution,
                    _intelligence,
                    _wisdom,
                    _charisma,
                    _acrobatics,
                    _animal_handling,
                    _arcana,
                    _athletics,
                    _deception,
                    _history,
                    _insight,
                    _intimidation,
                    _investigation,
                    _medicine,
                    _nature,
                    _perception,
                    _performance,
                    _persuasion,
                    _religion,
                    _sleight_of_hand,
                    _stealth,
                    _survival,
                    _armor_class;

        public Character()
        {
            _strength = 0;
            _dexterity = 0;
            _constitution = 0;
            _intelligence = 0;
            _wisdom = 0;
            _charisma = 0;
            _acrobatics = 0;
            _animal_handling = 0;
            _arcana = 0;
            _athletics = 0;
            _deception = 0;
            _history = 0;
            _insight = 0;
            _intimidation = 0;
            _investigation = 0;
            _medicine = 0;
            _nature = 0;
            _perception = 0;
            _performance = 0;
            _persuasion = 0;
            _religion = 0;
            _sleight_of_hand = 0;
            _stealth = 0;
            _survival = 0;
            _armor_class = 0;
            
        }

        public Character(int strength, int dexterity, int constitution, int intelligence, int wisdom, int charisma)
        {
            _strength = strength;
            _dexterity = dexterity;
            _constitution = constitution;
            _intelligence = intelligence;
            _wisdom = wisdom;
            _charisma = charisma;
        }

        public int strength { get; set; }

        public int dexterity { get; set; }

        public int constitution { get; set; }

        public int intelligence { get; set; }

        public int wisdom { get; set; }

        public int charisma { get; set; }

        public int AbilityModifiers(int number)
        {
            switch(number)
            {
                case 1:
                    return -5;
                case 2:
                case 3:
                    return -4;
                case 4:
                case 5:
                    return -3;
                case 6:
                case 7:
                    return -2;
                case 8:
                case 9:
                    return -1;
                case 10:
                case 11:
                    return 0;
                case 12:
                case 13:
                    return 1;
                case 14:
                case 15:
                    return 2;
                case 16:
                case 17:
                    return 3;
                case 18:
                case 19:
                    return 4;
                case 20:
                case 21:
                    return 5;
                case 22:
                case 23:
                    return 6;
                case 24:
                case 25:
                    return 7;
                case 26:
                case 27:
                    return 8;
                case 28:
                case 29:
                    return 9;
                case 30:
                    return 10;
                default:
                    Console.WriteLine("UNKNOWN");
                    break;
            }
            return 0;
        }
    }
}
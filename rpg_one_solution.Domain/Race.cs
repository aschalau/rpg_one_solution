// TODO: Thoughts - Base Race Class should potentially be static / abstract for the races below?
// TODO: create all these (sub)races with the correct attribute modifiers:
//          - Dwarf +2 Con
//              - Mountain +2 Str
//              - Hill +1 Wis
//          - Elf +2 Dex
//              - Drow +1 Cha
//              - High +1 Int
//              - Wood +1 Wis
//          - Halfling +2 Dex
//              - Lightfoot +1 Cha
//              - Stout +1 Con
//          - Human +1 Str, +1 Dex, +1 Con, +1 Int, +1 Wis, +1 Cha
//          - Dragonborn +2 Str, +1 Cha
//          - Gnome +2 Int
//              - Forest +2 Dex
//              - Rock +1 Con
//          - Half-Elf +2 Str, +2 Cha
//          - Half-Orc + 1 Con
//          - Tiefling +1 Int, +2 Cha
// TODO: Make RaceModifiers return multiple types
//          - Human, Dragonborn, Half-Elf, and Tiefling all have multiple stat boosts
namespace rpg_one_solution
{
    public abstract class Race : Domain.Character
    {
        abstract public int RaceModifiers();
    }

    // Dwarf +2 Con 
    public class Dwarf : Race
    {
        public override int RaceModifiers()
        {
            return 2;
        }
    }

    // Mountain +2 Str
    public class MountainDwarf : Dwarf
    {
        public override int RaceModifiers()
        {
            return 2;
        }
    }

    // Hill +1 Wis
    public class HillDwarf : Dwarf
    {
        public override int RaceModifiers()
        {
            return 1;
        }
    }

    // Elf +2 Dex
    public class Elf : Race
    {
        public override int RaceModifiers()
        {
            return 2;
        }
    }

    // Drow +1 Cha
    public class Drow : Elf
    {
        public override int RaceModifiers()
        {
            return 1;
        }
    }

    // High +1 Int
    public class High : Elf
    {
        public override int RaceModifiers()
        {
            return 1;
        }
    }

    // Wood +1 Wis
    public class Wood : Elf
    {
        public override int RaceModifiers()
        {
            return 1;
        }
    }

    // Halfling +2 Dex
    public class Halfling : Race
    {
        public override int RaceModifiers()
        {
            return 2;
        }
    }

    // Lightfoot +1 Cha
    public class Lightfoot : Halfling
    {
        public override int RaceModifiers()
        {
            return 1;
        }
    }

    // Stout +1 Con
    public class Stout : Halfling
    {
        public override int RaceModifiers()
        {
            return 1;
        }
    }
    
    // Human +1 Str, +1 Dex, +1 Con, +1 Int, +1 Wis, +1 Cha
    // TODO: How do I deal with this?
    public class Human : Race
    {
        public override int RaceModifiers()
        {
            return 1;
            // return new[] {1, 1, 1, 1, 1, 1};
        }
    }

    // Dragonborn +2 Str, +1 Cha
    // TODO: How do I deal with this?
    public class Dragonborn : Race
    {
        public override int RaceModifiers()
        {
            return 1;
        }
    }
    
    // Gnome +2 Int
    public class Gnome : Race
    {
        public override int RaceModifiers()
        {
            return 2;
        }
    }

    // Forest +2 Dex
    public class Forest : Gnome
    {
        public override int RaceModifiers()
        {
            return 2;
        }
    }
    
    // Rock +1 Con
    public class Rock : Gnome
    {
        public override int RaceModifiers()
        {
            return 1;
        }
    }
    
    // Half-Elf +2 Str, +2 Cha
    // TODO: How do I deal with this?
    public class Half_Elf : Race
    {
        public override int RaceModifiers()
        {
            return 2;
        }
    }
    
    // Half-Orc + 1 Con
    public class Half_Orc : Race
    {
        public override int RaceModifiers()
        {
            return 1;
        }
    }
    
    // Tiefling +1 Int, +2 Cha
    // TODO: How do I deal with this?
    public class Tiefling : Race
    {
        public override int RaceModifiers()
        {
            return 1;
        }
    }
}

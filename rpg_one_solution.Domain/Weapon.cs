using System;

namespace rpg_one_solution.Domain
{
    public abstract class Weapon // : Domain.Dice
    {
        abstract public int AttackModifier();
    }

    //Dagger
    public class Dagger : Weapon
    {
        public override int AttackModifier() => new Dice(4).Roll();
    }

    public class ShortSword : Weapon
    {
        public override int AttackModifier() => new Dice(6).Roll();
    }

    public class LongSword : Weapon
    {
        public override int AttackModifier() => new Dice(8).Roll();
    }
}
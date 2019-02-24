using System;
using System.Collections.Generic;
using System.Linq;

namespace rpg_one_solution.Domain
{
    public class Dice
    {
        private int _min_value;
        private int _sides_of_die;

        public Dice() 
        {
            _min_value = 0;
            _sides_of_die = 2;
        }

        public Dice(int sides)
        {
            _min_value = 1;
            _sides_of_die = sides + 1;
        }

        public int Roll()
        {
            Random rnd = new Random();
            return rnd.Next(_min_value, _sides_of_die);
        }

        public double RollAverage(Dice die, int times)
        {
            List<int> dice_collection = new List<int>();
            double average = 0;
            for(int i = 0; i < times; i++)
            {
                dice_collection.Add(die.Roll());
            }

            dice_collection.ForEach(delegate(int roll) 
            { 
                average += roll;
            });

            return average / times;
        }

        public int RollFourD6TakeTopThree(Dice die)
        {
            List<int> dice_collection = new List<int>();
            for(int i = 0; i < 4; i++)
            {
                dice_collection.Add(die.Roll());
            }

            dice_collection.Sort();
            dice_collection.RemoveAt(0);
            
            return dice_collection.Sum();
        }

        public List<int> StandardStatPoints()
        {
            return new List<int>(){15, 14, 13, 12, 10, 8};
        }
    }
}

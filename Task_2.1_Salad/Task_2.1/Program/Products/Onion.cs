using System;

namespace Task_2_part_1
{
    public class Onion : VegetableAndDressing
    {
        public const double WATER = 89.8;
        public const double PROTEINS = 1.8;
        public const double FATS = 0.2;
        public const double CARBOHYDRATES = 7.3;

        public override double Water
        {
            get { return WATER; }
        }

        public override double Proteins
        {
            get { return PROTEINS; }
        }

        public override double Fats
        {
            get { return FATS; }
        }

        public override double Carbohydrates
        {
            get { return CARBOHYDRATES; }
        }

        public Onion(String name, String colour, double weight) : base(name, colour, weight)
        {

        }

        public override void Eat()
        {
            Console.WriteLine("\"" + this + "\" has been digested!");
        }
    }
}

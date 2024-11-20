using System;

namespace Task_2_part_1
{
    public class Mayonnaise : VegetableAndDressing
    {
        public const double WATER = 25;
        public const double PROTEINS = 2.8;
        public const double FATS = 67;
        public const double CARBOHYDRATES = 3.7;
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

        public Mayonnaise(String name, String colour, double weight) : base(name, colour, weight)
        {

        }

        public override string ToString()
        {
            return "Dressing [name=" + GetName() + ", value: " + value + ", weight="
                    + GetWeight() + "]";
        }

        public override void Eat()
        {
            Console.WriteLine("\"" + this + "\" has been digested!");
        }
    }
}

using System;

namespace Task_4._2.Salad.Products
{
    public class Mayonnaise : VegetableAndDressing
    {
        private const double AmountOfWater = 25;
        private const double AmountOfProteins = 2.8;
        private const double AmountOfFats = 67;
        private const double AmountOfCarbohydrates = 3.7;

        public override double Water
        {
            get
            {
                return AmountOfWater;
            }

        }

        public override double Proteins
        {
            get
            {
                return AmountOfProteins;
            }
        }

        public override double Fats
        {
            get
            {
                return AmountOfFats;
            }
        }

        public override double Carbohydrates
        {
            get
            {
                return AmountOfCarbohydrates;
            }
        }

        public Mayonnaise(string name, string colour, double weight) : base(name, colour, weight)
        {

        }

        public override string ToString()
        {
            return "Dressing [Name=" + GetName() + ", Value: " + Value + ", Weight="
                    + GetWeight() + "]";
        }

        public override void Eat()
        {
            Console.WriteLine("\"" + this + "\" has been digested!");
        }
    }
}

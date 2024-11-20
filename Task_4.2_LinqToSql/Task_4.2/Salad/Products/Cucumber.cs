using System;

namespace Task_4._2.Salad.Products
{
    public class Cucumber : VegetableAndDressing
    {
        private const double AmountOfWater = 95;
        private const double AmountOfProteins = 0.8;
        private const double AmountOfFats = 0.1;
        private const double AmountOfCarbohydrates = 2.5;

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

        public Cucumber(string name, string colour, double weight) : base(name, colour, weight)
        {
        }

        public override void Eat()
        {
            Console.WriteLine("\"" + this + "\" has been digested!");
        }
    }

}

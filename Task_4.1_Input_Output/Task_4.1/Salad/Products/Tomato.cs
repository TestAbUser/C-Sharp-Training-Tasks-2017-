using System;

namespace Task_4._1.Salad.Products
{
    public class Tomato : VegetableAndDressing
    {
        private const double AmountOfWater = 92;
        private const double AmountOfProteins = 1.1;
        private const double AmountOfFats = 0.2;
        private const double AmountOfCarbohydrates = 3.8;

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

        public Tomato(string name, string colour, double weight) : base(name, colour, weight)
        {
        }

        public override void Eat()
        {
            Console.WriteLine("\"" + this + "\" has been digested!");
        }
    }
}

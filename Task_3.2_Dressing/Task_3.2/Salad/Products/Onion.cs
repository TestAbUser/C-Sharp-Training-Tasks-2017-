using System;

namespace Task_3._2.Salad.Products
{
    public class Onion : VegetableAndDressing
    {
        private const double AmountOfWater = 89.8;
        private const double AmountOfProteins = 1.8;
        private const double AmountOfFats = 0.2;
        private const double AmountOfCarbohydrates = 7.3;

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

        public Onion(String name, String colour, double weight) : base(name, colour, weight)
        {
        }

        public override void Eat()
        {
            Console.WriteLine("\"" + this + "\" has been digested!");
        }
    }
}

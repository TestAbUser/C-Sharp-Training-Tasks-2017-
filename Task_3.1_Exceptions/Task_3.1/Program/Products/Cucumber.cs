using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3._1.Program.Products
{
    public class Cucumber : VegetableAndDressing
    {
        public const double WATER = 95;
        public const double PROTEINS = 0.8;
        public const double FATS = 0.1;
        public const double CARBOHYDRATES = 2.5;

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

        public Cucumber(String name, String colour, double weight) : base(name, colour, weight)
        {

        }

        public override void Eat()
        {
            Console.WriteLine("\"" + this + "\" has been digested!");
        }
    }

}

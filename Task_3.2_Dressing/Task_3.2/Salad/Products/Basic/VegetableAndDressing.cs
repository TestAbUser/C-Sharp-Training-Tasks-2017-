using System;
using Task_3._2.Salad.Products.Basic;
using Task_3._2.Salad.Interfaces;

namespace Task_3._2.Salad.Products
{
    // Here properties and methods common to all ingredients are described
    public abstract class VegetableAndDressing : NutritionalValue, IEatable, ICooked,
            IComparable<VegetableAndDressing>
    {
        public abstract double Water { get; }
        public abstract double Proteins { get; }
        public abstract double Fats { get; }
        public abstract double Carbohydrates { get; }
        private string Name;
        private string Colour;
        protected NutritionalValue Value;
        private double Weight;

        public VegetableAndDressing(string name, string colour, double weight)
        {
            Value = new NutritionalValue();
            Name = name;
            Colour = colour;
            Weight = weight;
            Cook();
        }

        public virtual void Eat()
        {
        }

        public String GetName()
        {
            return Name;
        }

        public String GetColour()
        {
            return Colour;
        }

        public double GetWeight()
        {
            return Weight;
        }

        public NutritionalValue GetValue()
        {
            return Value;
        }

        // Calculating the calories existing in each ingredient
        public double GetEnergy()
        {
            double kcalOfProteins = Value.GetProteins() / MassFractionGrams * Weight * EnergyKcalCountInOneGramOfProteins;
            double kcalOfFats = Value.GetFats() / MassFractionGrams * Weight * EnergyKcalCountInOneGramOfFats;
            double kcalOfCarbohydrates = Value.GetCarbohydrates() / MassFractionGrams * Weight * EnergyKcalCountInOneGramOfCarbohydrates;
            return kcalOfProteins + kcalOfFats + kcalOfCarbohydrates;
        }

        public virtual void Cook()
        {
            Value.SetWater(Water);
            Value.SetCarbohydrates(Carbohydrates);
            Value.SetFats(Fats);
            Value.SetProteins(Proteins);
        }

        public override string ToString()
        {
            return "Vegetable [Name=" + Name + ", Value: " + Value + ", Weight="
                    + Weight + "]";
        }

        //sorting by Weight
        public int CompareTo(VegetableAndDressing vegetables)
        {
            return (int)(Weight - vegetables.Weight);

        }

    }
}

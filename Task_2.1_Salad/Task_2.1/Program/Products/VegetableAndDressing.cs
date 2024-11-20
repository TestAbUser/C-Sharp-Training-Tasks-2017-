using System;


namespace Task_2_part_1
{// Here properties and methods common to all ingredients are described
    public abstract class VegetableAndDressing : NutritionalValue, IEatable, ICooked,
            IComparable<VegetableAndDressing>
    {
        public abstract double Water { get; }
        public abstract double Proteins { get; }
        public abstract double Fats { get; }
        public abstract double Carbohydrates { get; }
        private string name;
        private string colour;
        protected NutritionalValue value;
        private double weight;

        public VegetableAndDressing(String name, String colour, double weight)
        {
            value = new NutritionalValue();
            this.name = name;
            this.colour = colour;
            this.weight = weight;
            Cook();
        }

        public virtual void Eat()
        {

        }

        public String GetName()
        {
            return name;
        }

        public String GetColour()
        {
            return colour;
        }

        public double GetWeight()
        {
            return weight;
        }

        public NutritionalValue GetValue()
        {
            return value;
        }

        // Calculating the calories existing in each ingredient
        public double GetEnergy()
        {
            double kcalOfProteins = value.GetProteins()
                    / NutritionalValue.MASS_FRACTION_GRAMS * weight
                    * NutritionalValue.ENERGY_KCAL_COUNT_IN_ONE_GRAM_OF_PROTEINS;
            double kcalOfFats = value.GetFats()
                    / NutritionalValue.MASS_FRACTION_GRAMS * weight
                    * NutritionalValue.ENERGY_KCAL_COUNT_IN_ONE_GRAM_OF_FATS;
            double kcalOfCarbohydrates = value.GetCarbohydrates()
                    / NutritionalValue.MASS_FRACTION_GRAMS
                    * weight
                    * NutritionalValue.ENERGY_KCAL_COUNT_IN_ONE_GRAM_OF_CARBOHYDRAES;
            return kcalOfProteins + kcalOfFats + kcalOfCarbohydrates;
        }

        public virtual void Cook()
        {
            value.SetWater(Water);
            value.SetCarbohydrates(Carbohydrates);
            value.SetFats(Fats);
            value.SetProteins(Proteins);
        }

        public override string ToString()
        {
            return "Vegetable [name=" + name + ", value: " + value + ", weight="
                    + weight + "]";
        }

        //sorting by weight
        public int CompareTo(VegetableAndDressing vegetables)
        {
            return (int)(weight - vegetables.weight);

        }

    }
}

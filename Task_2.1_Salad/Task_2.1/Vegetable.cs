using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TAM_Pre_Selection_dotNET_p2
{
    public abstract class Vegetable : Eatable, Cooked,
            IComparable<Vegetable>
    {
        private String name;
        private String colour;
        protected NutritionalValue value;
        private double weight;

        public Vegetable(String name, String colour, double weight)
        {
            this.value = new NutritionalValue();
            this.name = name;
            this.colour = colour;
            this.weight = weight;
            cook();
        }
        public virtual void eat()
        {

        }


        public virtual void cook()
        {

        }

        public String getName()
        {
            return name;
        }

        public String getColour()
        {
            return colour;
        }

        public double getWeight()
        {
            return weight;
        }

        public NutritionalValue getValue()
        {
            return value;
        }


        public double getEnergy()
        {
            double kcalOfProteins = value.getProteins()
                    / NutritionalValue.MASS_FRACTION_GRAMS * weight
                    * NutritionalValue.ENERGY_KCAL_COUNT_IN_ONE_GRAM_OF_PROTEINS;
            double kcalOfFats = value.getFats()
                    / NutritionalValue.MASS_FRACTION_GRAMS * weight
                    * NutritionalValue.ENERGY_KCAL_COUNT_IN_ONE_GRAM_OF_FATS;
            double kcalOfCarbohydrates = value.getCarbohydrates()
                    / NutritionalValue.MASS_FRACTION_GRAMS
                    * weight
                    * NutritionalValue.ENERGY_KCAL_COUNT_IN_ONE_GRAM_OF_CARBOHYDRAES;
            return kcalOfProteins + kcalOfFats + kcalOfCarbohydrates;
        }


        public override String ToString()
        {
            return "Vegetable [name=" + name + ", value=" + value + ", weight="
                    + weight + "]";
        }

        //sorting by weight

        public int CompareTo(Vegetable vegetables)
        {
            return (int)(this.weight - vegetables.weight);

        }

    }
}

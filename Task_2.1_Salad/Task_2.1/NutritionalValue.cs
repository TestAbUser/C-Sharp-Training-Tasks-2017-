using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TAM_Pre_Selection_dotNET_p2
{
    public class NutritionalValue
    {
        public const double MASS_FRACTION_GRAMS = 100.0;
        public const double ENERGY_KCAL_COUNT_IN_ONE_GRAM_OF_PROTEINS = 4.1;
        public const double ENERGY_KCAL_COUNT_IN_ONE_GRAM_OF_FATS = 4.1;
        public const double ENERGY_KCAL_COUNT_IN_ONE_GRAM_OF_CARBOHYDRAES = 9.3;

        private double proteins;
        private double fats;
        private double carbohydrates;
        private double water;

        public double getWater()
        {
            return water;
        }

        public double getProteins()
        {
            return proteins;
        }

        public void setProteins(double proteins)
        {
            this.proteins = proteins;
        }

        public double getFats()
        {
            return fats;
        }

        public void setFats(double fats)
        {
            this.fats = fats;
        }

        public double getCarbohydrates()
        {
            return carbohydrates;
        }

        public void setCarbohydrates(double carbohydrates)
        {
            this.carbohydrates = carbohydrates;
        }

        public void setWater(double water)
        {
            this.water = water;
        }

        public override string ToString()
        {
            return "proteins=" + proteins + ", fats=" + fats + ", carbohydrates="
                    + carbohydrates + ", water=" + water;
        }

    }
}

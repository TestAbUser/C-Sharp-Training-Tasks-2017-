
namespace Task_3._1.Program.Products.Basic
{
    //This class is used to define and help to calculate the amount of calories existing in the ingredients
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

        public double GetWater()
        {
            return water;
        }

        public double GetProteins()
        {
            return proteins;
        }

        public void SetProteins(double proteins)
        {
            this.proteins = proteins;
        }

        public double GetFats()
        {
            return fats;
        }

        public void SetFats(double fats)
        {
            this.fats = fats;
        }

        public double GetCarbohydrates()
        {
            return carbohydrates;
        }

        public void SetCarbohydrates(double carbohydrates)
        {
            this.carbohydrates = carbohydrates;
        }

        public void SetWater(double water)
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


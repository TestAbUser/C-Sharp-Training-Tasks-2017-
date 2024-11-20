
namespace Task_3._2.Salad.Products.Basic
{
    //This class is used to define and help to calculate the amount of calories existing in the ingredients
    public class NutritionalValue
    {
        protected const double MassFractionGrams = 100.0;
        protected const double EnergyKcalCountInOneGramOfProteins = 4.1;
        protected const double EnergyKcalCountInOneGramOfFats = 4.1;
        protected const double EnergyKcalCountInOneGramOfCarbohydrates = 9.3;

        private double Proteins;
        private double Fats;
        private double Carbohydrates;
        private double Water;

        public double GetWater()
        {
            return Water;
        }

        public double GetProteins()
        {
            return Proteins;
        }

        public void SetProteins(double proteins)
        {
            Proteins = proteins;
        }

        public double GetFats()
        {
            return Fats;
        }

        public void SetFats(double fats)
        {
            Fats = fats;
        }

        public double GetCarbohydrates()
        {
            return Carbohydrates;
        }

        public void SetCarbohydrates(double carbohydrates)
        {
            Carbohydrates = carbohydrates;
        }

        public void SetWater(double water)
        {
            Water = water;
        }

        public override string ToString()
        {
            return "Proteins=" + Proteins + ", Fats=" + Fats + ", carbohydrates="
                    + Carbohydrates + ", water=" + Water;
        }
    }
}


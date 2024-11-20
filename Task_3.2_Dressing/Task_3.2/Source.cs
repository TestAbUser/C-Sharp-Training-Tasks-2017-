using Task_3._2.Salad.Products;

namespace Task_3._2.Salad
{
    // The number of vegetables and dressings is defined. Instances of vegetables and dressings are
    // created
    class Source
    {
        private const int InitialVegetableCount = 3;
        private const int InitialDressingCount = 1;

        private Source()
        {
        }

        public static VegetableAndDressing[] GetDressing()
        {
            VegetableAndDressing[] dressings = new VegetableAndDressing[InitialDressingCount];
            dressings[0] = new Mayonnaise("Mayonnaise", "yellow", 50);
            return dressings;
        }

        public static VegetableAndDressing[] GetSalad()
        {
            GetDressing();
            VegetableAndDressing[] vegetables = new VegetableAndDressing[InitialVegetableCount];
            vegetables[0] = new Cucumber("Cucumber", "green", 100);
            vegetables[1] = new Tomato("Tomato", "red", 150);
            vegetables[2] = new Onion("Onion", "green", 50);
            return vegetables;
        }
    }
}

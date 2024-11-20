using System;

namespace Task_4._2.Salad.Products
{
    [Serializable()]
    public class SaladToMake
    {
        private static VegetableAndDressing[] Vegetables;
        private static VegetableAndDressing[] Dressings;
        private const string Red = "red";
        private const string Green = "green";
        private const string Yellow = "yellow";
        private const double Fifty = 50;

        public SaladToMake()
        {
            MakeSalad();
        }

        //This method is used to display the list of ingridients used in the salad
        private void MakeSalad()
        {
            Vegetables = Source.GetSalad();
            Dressings = Source.GetDressing();
            var application = new SaladToMake();
            application.StartApplication();
            FileReaderWriter.WriteAndRead();
            Console.ReadLine();
        }

        public static void Main(string[] args)
        {
            Queries newQuery = new Queries();
            newQuery.QueriesRunner();
        }

        //Searching for the vegetables with necessary parameters. 
        public static void FindVegetables()
        {
            int count = 0;
            Console.WriteLine("All the vegetables of green and red Colour with Weight more than 50 gramms: ");
            foreach (VegetableAndDressing vegetable in Vegetables)
            {
                if
                        (vegetable.GetColour() == Red || vegetable
                                .GetColour() == Green)
                {
                    if (vegetable.GetWeight() >= Fifty)
                    {
                        Console.WriteLine(++count + ". \"" + vegetable.GetName()
                                + "\"");
                    }
                }
            }
            Console.WriteLine();
        }

        // Displaying in the console the sorted vegetables with their weights
        public void SortByWeight()
        {
            Console.WriteLine("Vegetables sorted by Weight:");
            foreach (VegetableAndDressing Vegetable in Vegetables)
            {
                Console.WriteLine(Vegetable.GetName() + " "
                        + Vegetable.GetWeight());
            }
            Console.WriteLine();
        }

        //Calculating the calories received after consumption of the salad and displaying the results in the console 

        delegate double TestDelegate(VegetableAndDressing[] Vegetables);

        TestDelegate newDelegate = (VegetableAndDressing[] Vegetables) =>
        {
            double energy = 0.0;
            foreach (VegetableAndDressing vegetable in Vegetables)
            {
                Console.WriteLine(vegetable);
                vegetable.Eat();
                energy += vegetable.GetEnergy();
                Console.WriteLine("You have eaten " + vegetable.GetWeight()
                        + " grammes of " + vegetable.GetName()
                        + ". As a result you have got " + vegetable.GetEnergy()
                        + " kcal.\n");
            }
            return energy;
        };

        public void StartApplication()
        {
            Console.WriteLine("SaladToMake is ready: ");
            Console.WriteLine();
            int count = 0;
            foreach (VegetableAndDressing vegetable in Vegetables)
            {
                Console.WriteLine(++count + ". \"" + vegetable.GetName() + "\"");
            }

            foreach (VegetableAndDressing dressing in Dressings)
            {
                Console.WriteLine(++count + ". \"" + dressing.GetName() + "\"");
            }
            Console.WriteLine();
            double energy = newDelegate(Dressings) + newDelegate(Vegetables);
            Console.WriteLine("Caloricity of the salad " + energy + " kcal.");
            Console.WriteLine();
            Array.Sort(Vegetables);
            SortByWeight();
            FindVegetables();
        }
    }
}

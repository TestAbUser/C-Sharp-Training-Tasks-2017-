using System;

namespace Task_2_part_1
{
    class Salad
    {
        const String RED = "red";
        const String GREEN = "green";
        const String YELLOW = "yellow";
        const double FIFTY = 50;
        private static VegetableAndDressing[] Vegetables;
        private static VegetableAndDressing[] Dressings;

        public Salad()
        {
            MakeSalad();
        }

        //This method is used to display the list of ingridients used in the salad
        private void MakeSalad()
        {
            Vegetables = Source.GetSalad();
            Dressings = Source.GetDressing();
            Console.WriteLine("Salad is ready: ");
            Console.WriteLine();
            int count = 0;
            foreach (VegetableAndDressing Vegetable in Vegetables)
            {
                Console.WriteLine(++count + ". \"" + Vegetable.GetName() + "\"");
            }

            foreach (VegetableAndDressing Dressing in Dressings)
            {
                Console.WriteLine(++count + ". \"" + Dressing.GetName() + "\"");
            }
            Console.WriteLine();
        }

        // initializing the program by creating a new instance of class Salad
        public static void Main(String[] args)
        {
            Salad app = new Salad();
            app.StartApp();
            Console.ReadLine();
        }

        //Searching for the vegetables with necessary parameters. 
        public static void FindVegetables()
        {
            int count = 0;
            Console.WriteLine("All the vegetables of green and red colour with weight more than 50 gramms: ");
            foreach (VegetableAndDressing vegetable in Vegetables)
            {
                if
                        (vegetable.GetColour() == RED || vegetable
                                .GetColour() == GREEN)
                {
                    if (vegetable.GetWeight() >= FIFTY)
                    {
                        Console.WriteLine(++count + ". \"" + vegetable.GetName()
                                + "\"");
                    }
                }
            }
        }
        // Displaying in the console the sorted vegetables with their weights
        public void SortByWeight()
        {
            Console.WriteLine("Vegetables sorted by weight:");
            foreach (VegetableAndDressing Vegetable in Vegetables)
            {
                Console.WriteLine(Vegetable.GetName() + " "
                        + Vegetable.GetWeight());
            }
            Console.WriteLine();
        }

        //Calculating the calories received after consumption of the salad and displaying the results in the console 
        public void StartApp()
        {
            double energy = 0.0;
            foreach (VegetableAndDressing Vegetable in Vegetables)
            {
                Console.WriteLine(Vegetable);
                Vegetable.Eat();
                energy += Vegetable.GetEnergy();
                Console.WriteLine("You have eaten " + Vegetable.GetWeight()
                        + " grammes of " + Vegetable.GetName()
                        + ". As a result you have got " + Vegetable.GetEnergy()
                        + " kcal.\n");
            }

            foreach (VegetableAndDressing Dressing in Dressings)
            {
                Console.WriteLine(Dressing);
                Dressing.Eat();
                energy += Dressing.GetEnergy();
                Console.WriteLine("You have eaten " + Dressing.GetWeight()
                        + " grammes of " + Dressing.GetName()
                        + ". As a result you have got " + Dressing.GetEnergy()
                        + " kcal.\n");
            }
            Console.WriteLine("Caloricity of the salad " + energy + " kcal.");
            Console.WriteLine();
            Array.Sort(Vegetables);
            SortByWeight();
            FindVegetables();
        }
    }

    //Here the number of ingredients is defined and instances of each ingredient are created 
    class Source
    {
        private const int INIT_VEGETABLE_COUNT = 3;
        private const int INIT_DRESSING_COUNT = 1;

        private Source()
        {

        }

        public static VegetableAndDressing[] GetDressing()
        {
            VegetableAndDressing[] dressings = new VegetableAndDressing[INIT_DRESSING_COUNT];
            dressings[0] = new Mayonnaise("Mayonnaise", "yellow", 50);
            return dressings;
        }

        public static VegetableAndDressing[] GetSalad()
        {
            GetDressing();
            VegetableAndDressing[] vegetables = new VegetableAndDressing[INIT_VEGETABLE_COUNT];
            vegetables[0] = new Cucumber("Cucumber", "green", 100);
            vegetables[1] = new Tomato("Tomato", "red", 150);
            vegetables[2] = new Onion("Onion", "green", 50);
            return vegetables;
        }
    }
}

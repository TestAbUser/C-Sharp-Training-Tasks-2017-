using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TAM_Pre_Selection_dotNET_p2
{
    class Salad
    {
        private static Vegetable[] vegetables;

        public Salad()
        {
            makeSalad();
        }

        private void makeSalad()
        {
            vegetables = Source.getSalad();
            Console.WriteLine("Salad is ready: ");
            int count = 0;
            foreach (Vegetable vegetable in vegetables)
            {
                Console.WriteLine(++count + ". \"" + vegetable.getName() + "\"");
            }
            Console.WriteLine();
        }

        public static void Main(String[] args)
        {
            try
            {
                try
                {
                    Salad app = new Salad();
                    app.startApp();
                }
                catch (Exception e) when (e is OverflowException)

                //    || ArrayIndexOutOfBoundsException || NullPointerException)
                {
                    // All these exceptions show that something is wrong with the
                    // number
                    // of vegetables, so I have swapped them for NotThreeVegetablesException
                    throw new NotThreeVegetablesException(
                            "Three vegetables should be used for the salad!");
                }
            }
            catch (NotThreeVegetablesException exc)
            {
                Console.Error.WriteLine(exc);
            }
            Console.ReadLine();
        }


        public static void findVegetables()
        {
            const String RED = "red";
            const String GREEN = "green";
            const double FIFTY = 50;
            int count = 0;
            Console.WriteLine("All the vegetables of green and red colour with weight more than 50 gramms: ");
            foreach (Vegetable vegetable in vegetables)
            {
                try
                {
                    if ((vegetable.getWeight() >= FIFTY)
                            && (vegetable.getColour() == RED || vegetable
                                    .getColour() == GREEN))
                    {
                        Console.WriteLine(++count + ". \"" + vegetable.getName()
                                + "\"");
                    }
                    else
                    {
                        throw new WrongWeightAndOrColourException(
                                "Colour should be red or green! Weight should be more than 50 gramms!  ");
                    }
                }
                catch (WrongWeightAndOrColourException e)
                {
                    Console.WriteLine(e);
                }
            }
        }

        public void sortByWeight()
        {
            Console.WriteLine("Vegetables sorted by weight:");
            foreach (Vegetable vegetable in vegetables)
            {
                Console.WriteLine(vegetable.getName() + " "
                        + vegetable.getWeight());
            }
            Console.WriteLine();
        }

        public void startApp()
        {
            double energy = 0.0;
            foreach (Vegetable vegetable in vegetables)
            {
                Console.WriteLine(vegetable);
                vegetable.eat();
                energy += vegetable.getEnergy();
                Console.WriteLine("You have eaten " + vegetable.getWeight()
                        + " grammes of " + vegetable.getName()
                        + ". As a result you have got " + vegetable.getEnergy()
                        + " kcal.\n");
            }
            Console.WriteLine("Caloricity of the salad " + energy + " kcal.");
            Console.WriteLine();
            Array.Sort(vegetables);
            sortByWeight();
            findVegetables();
        }
    }

    class Source
    {
        // It is necessary to set INIT_VEGETABLE_COUNT to a value different from
        // the default to see NotThreeVegetablesException
        private const int INIT_VEGETABLE_COUNT = 3;

        private Source()
        {
        }

        public static Vegetable[] getSalad()
        {
            Vegetable[] vegetables = new Vegetable[INIT_VEGETABLE_COUNT];
            if (INIT_VEGETABLE_COUNT <= 0)
            {
                try
                {
                    throw new NotThreeVegetablesException(
                            "Three vegetables should be used for the salad!");
                }
                catch (NotThreeVegetablesException e)
                {
                }
            }
            // Changing colour to any other than red or green, or setting weight to
            // less than 50 triggers WrongWeightAndOrColourException
            vegetables[0] = new Cucumber("Cucumber", "green", 100);
            vegetables[1] = new Tomato("Tomato", "red", 150);
            vegetables[2] = new Onion("Onion", "green", 50);
            return vegetables;

        }
    }

    class NotThreeVegetablesException : Exception
    {


        private const long serialVersionUID = 1L;

        public NotThreeVegetablesException()
        {
        }

        public NotThreeVegetablesException(String message, Exception cause) : base(message, cause)
        {

        }

        public NotThreeVegetablesException(String message) : base(message)
        {

        }

        /*    public NotThreeVegetablesException(Exception cause) : base(cause)
            {

            }*/

    }

    class WrongWeightAndOrColourException : Exception
    {


        private const long serialVersionUID = 1L;

        public WrongWeightAndOrColourException()
        {
        }

        public WrongWeightAndOrColourException(String message, Exception cause) : base(message, cause)
        {

        }

        public WrongWeightAndOrColourException(String message) : base(message)
        {

        }

        /*  public WrongWeightAndOrColourException(Exception cause): base (cause)
          {
          }*/
    }

}

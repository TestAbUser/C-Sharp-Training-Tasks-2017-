using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace Task_3._2.Salad.Products
{
    [Serializable()]
    public class Salad
    {
        private static VegetableAndDressing[] Vegetables;
        private static VegetableAndDressing[] Dressings;
        private const string Red = "red";
        private const string Green = "green";
        private const string Yellow = "yellow";
        private const double Fifty = 50;

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
            foreach (VegetableAndDressing vegetable in Vegetables)
            {
                Console.WriteLine(++count + ". \"" + vegetable.GetName() + "\"");
            }

            foreach (VegetableAndDressing dressing in Dressings)
            {
                Console.WriteLine(++count + ". \"" + dressing.GetName() + "\"");
            }
            Console.WriteLine();
        }

        // initializing the program by creating a new instance of class Salad
        public static void Main(String[] args)
        {
            WriteToTxt();
            ReadFromTxt();
            DoSerializing();
            DoDeserializing();
            Console.ReadLine();
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
        public void StartApplication()
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

            foreach (VegetableAndDressing dressing in Dressings)
            {
                Console.WriteLine(dressing);
                dressing.Eat();
                energy += dressing.GetEnergy();
                Console.WriteLine("You have eaten " + dressing.GetWeight()
                        + " grammes of " + dressing.GetName()
                        + ". As a result you have got " + dressing.GetEnergy()
                        + " kcal.\n");
            }
            Console.WriteLine("Caloricity of the salad " + energy + " kcal.");
            Console.WriteLine();
            Array.Sort(Vegetables);
            SortByWeight();
            FindVegetables();
        }

        //Creating a txt file and writing the content of the console into it
        public static void WriteToTxt()
        {
            FileStream fileStream;
            StreamWriter streamWriter;
            TextWriter oldOut = Console.Out;
            try
            {
                fileStream = new FileStream("Console.txt", FileMode.OpenOrCreate, FileAccess.Write);
                streamWriter = new StreamWriter(fileStream);
            }
            catch (IOException e)
            {
                Console.WriteLine("Cannot open Console.txt for writing");
                Console.WriteLine(e.Message);
                return;
            }
            Console.SetOut(streamWriter);
            var application = new Salad();
            application.StartApplication();
            streamWriter.Close();
            Console.SetOut(oldOut);
            fileStream.Close();
            Console.WriteLine("The content of Console is written into Console.txt");
            Console.WriteLine();
        }

        public static void ReadFromTxt()
        {
            try
            {   // Open the text file using a stream reader.
                using (StreamReader streamReader = new StreamReader("Console.txt"))
                {
                    // Read the stream to a string, and write the string to the console.
                    string line = streamReader.ReadToEnd();
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }

        //Serializing an instance of class Salad and writing it into a binary file
        static void DoSerializing()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream fileStream = new FileStream("Binary.bin", FileMode.OpenOrCreate, FileAccess.Write);
            try
            {
                var application = new Salad();
                formatter.Serialize(fileStream, application);
            }
            catch (SerializationException e)
            {
                Console.WriteLine("Failed to serialize. Reason: " + e.Message);
                throw;
            }
            finally
            {
                fileStream.Close();
            }
        }

        //Deserializing the object of class Salad
        static void DoDeserializing()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream fileStream = new FileStream("Binary.bin", FileMode.Open, FileAccess.Read);
            var application = (Salad)formatter.Deserialize(fileStream);
            application.StartApplication();
            Console.ReadLine();
        }
    }
}

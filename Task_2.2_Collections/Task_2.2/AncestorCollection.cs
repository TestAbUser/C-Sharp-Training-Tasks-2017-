using System;
using System.Diagnostics;

namespace Task_2_part_2
{ //As all of the collections are similar, I use this abstract class to describe the necessary actions, like: adding to, searching in and clearing the collections
    public abstract class AncestorCollection
    {
        // This method displays the name of the collections
        public virtual void DisplayCollectionName()
        {

        }
        //Here the collections are filled with elements
        public virtual void AddTo()
        {
            DisplayCollectionName();
            for (int i = 0; i < Program.ELEMENT; i++)
            {
                AddElements(i);
            }
            Console.WriteLine("count= " + CountArray());

        }
        //In this method the necessary element is searched for
        public virtual void Search(int i)
        {
            if (Find(i))
            {
                Console.WriteLine("ArrayList contains " + i + " =  " + Find(i));
            }
        }
        // This metod clears all the collections
        public virtual void Remove()
        {

        }
        // Here the number of elements is calculated
        public virtual int CountArray()
        {
            int c = 0;
            return c;
        }
        // this is the method responsible for adding elements to the collections. It is overwritten in each of the derived classes
        public virtual void AddElements(int i)
        { }
        //This method returns "true" if the searched element  is found
        public virtual bool Find(int i)
        {
            bool Truth = true;
            return Truth;
        }

        // Here the three main methods (adding to, searching in and clearing the collection) are launched
        public virtual void ManipulateCollection(int i)
        {
            switch (i)
            {
                case 0:
                    AddTo();
                    Console.Write("Adding: ");
                    break;
                case 1:
                    Search(Program.FIVE_K);
                    Console.Write("Searching: ");
                    break;
                case 2:
                    Remove();
                    Console.Write("Removing: ");
                    break;
            }
        }
        // This method calculates the time spent on execution of the three main procedures: adding to, searching in and clearing the collection 
        public void TimeElapsed()
        {
            for (int i = 0; i < Program.ACTIONS_NUMBER; i++)
            {
                var s1 = Stopwatch.StartNew();
                ManipulateCollection(i);
                s1.Stop();
                Console.WriteLine("Time elapsed = " + ((double)(s1.Elapsed.TotalMilliseconds * 1000000) /
               Program.ELEMENT).ToString("0.00 ns"));
            }
            Console.WriteLine();
        }
    }

}


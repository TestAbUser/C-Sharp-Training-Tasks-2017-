using System;
using System.Collections;

namespace Task_2_part_2
{

    public class HashtableLst : AncestorCollection
    {
        Hashtable hashtable = new Hashtable();

        public override void DisplayCollectionName()
        {
            Console.WriteLine("Hashtable");
            Console.WriteLine();
        }

        public override void AddElements(int i)
        {
            hashtable[i] = 1;
        }

        public override int CountArray()
        {
            int c = hashtable.Count;
            return c;
        }

        public override bool Find(int i)
        {
            return hashtable.Contains(i);
        }

        public override void Remove()
        {
            hashtable.Clear();
        }
    }
}

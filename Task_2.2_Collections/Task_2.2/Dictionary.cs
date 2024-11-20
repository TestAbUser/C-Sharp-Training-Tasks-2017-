using System;
using System.Collections.Generic;

namespace Task_2_part_2
{

    public class DictionaryLst : AncestorCollection
    {
        Dictionary<int, int> dictionary = new Dictionary<int, int>();


        public override void DisplayCollectionName()
        {
            Console.WriteLine("Dictionary");
            Console.WriteLine();
        }

        public override void AddElements(int i)
        {
            dictionary[i] = 1;
        }

        public override int CountArray()
        {
            int c = dictionary.Count;
            return c;
        }

        public override bool Find(int i)
        {
            return dictionary.ContainsKey(i);
        }

        public override void Remove()
        {
            dictionary.Clear();
        }
    }
}

using System;
using System.Collections.Generic;

namespace Task_2_part_2
{
    public class LinkList : AncestorCollection
    {
        LinkedList<int> Linked = new LinkedList<int>();

        public override void DisplayCollectionName()
        {
            Console.WriteLine("LinkedList");
            Console.WriteLine();
        }
        public override void AddElements(int i)
        {
            Linked.AddLast(i);
        }

        public override int CountArray()
        {
            int c = Linked.Count;
            return c;
        }

        public override bool Find(int i)
        {
            return Linked.Contains(i);
        }

        public override void Remove()
        {
            Linked.Clear();
        }
    }
}


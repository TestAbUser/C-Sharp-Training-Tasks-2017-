using System;
using System.Collections.Generic;

namespace Task_2_part_2
{
    public class StackLst : AncestorCollection
    {
        Stack<int> stack = new Stack<int>();

        public override void DisplayCollectionName()
        {
            Console.WriteLine("Stack");
            Console.WriteLine();
        }

        public override void AddElements(int i)
        {
            stack.Push(i);
        }

        public override int CountArray()
        {
            int c = stack.Count;
            return c;
        }

        public override bool Find(int i)
        {
            return stack.Contains(i);
        }

        public override void Remove()
        {
            stack.Clear();
        }
    }
}

using System;
using System.Collections.Generic;

namespace Task_2_part_2
{
    public class QueueLst: AncestorCollection
    {
        Queue<int> queue = new Queue<int>();

        public override void DisplayCollectionName()
        {
            Console.WriteLine("Queue");
            Console.WriteLine();
        }

        public override void AddElements(int i)
        {
                queue.Enqueue(i);
        }

        public override int CountArray()
        {
            int c = queue.Count;
            return c;
        }

        public override bool Find(int i)
        {
            return queue.Contains(i);
        }

        static void Remove(Queue<int> queue)
        {
            queue.Clear();
        }
    }
}

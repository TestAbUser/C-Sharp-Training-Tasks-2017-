using System;

namespace Task_2_part_2
{//In this class new instances of all of the collections are created and then it is calculated
 //for each one how long it takes to fill it with elements, find the necessary element and then clear it.

    class Program
    {
        public const int ACTIONS_NUMBER = 3;
        public const int ELEMENT = 1000000;
        public const int FIVE_K = 500000;
        static void Main(string[] args)
        {
            ArrayLst list = new ArrayLst();
            LinkList linked = new LinkList();
            StackLst stack = new StackLst();
            QueueLst queue = new QueueLst();
            HashtableLst hashtable = new HashtableLst();
            DictionaryLst dictionary = new DictionaryLst();
            list.TimeElapsed();
            linked.TimeElapsed();
            stack.TimeElapsed();
            queue.TimeElapsed();
            hashtable.TimeElapsed();
            dictionary.TimeElapsed();
            Console.ReadLine();
        }
    }
}



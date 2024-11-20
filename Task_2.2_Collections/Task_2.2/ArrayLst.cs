using System;
using System.Collections;

namespace Task_2_part_2
{
    public class ArrayLst : AncestorCollection
    {
        ArrayList list = new ArrayList();
   
       public override void DisplayCollectionName()
        {
           Console.WriteLine("ArrayList");
            Console.WriteLine();
        }
    public override void AddElements(int i)
    {
        list.Add(i);
    }

    public override int CountArray()
    {
        int c = list.Count;
        return c;
    }
    public override bool Find(int i)
    {
        return list.Contains(i);
    }

    public override void Remove()
    {
        list.Clear();
    }
}
}


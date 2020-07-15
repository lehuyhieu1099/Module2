using System;
using System.Collections;

namespace Bai9.Collection
{
    class Program
    {
        static void Main(string[] args)

        {
            SortedList sortedlist = new SortedList();

            sortedlist.Add(3, "Hieu");
            sortedlist.Add(1, "An");
            sortedlist.Add(2, "Long");
            foreach (var key in sortedlist.Keys)
            {
                Console.WriteLine(sortedlist[key]);
            }
            Console.WriteLine(sortedlist.Count);
            sortedlist.RemoveAt(2);
            foreach (var key in sortedlist.Keys)
            {
                Console.WriteLine(sortedlist[key]);
            }

        }
    }
}

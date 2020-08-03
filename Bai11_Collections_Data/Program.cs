using System;

namespace Bai11_NET_Collections__Data_Structures
{
    class Program
    {
        static void Main(string[] args)
        {
            Compareable<int> compareable = new Compareable<int>();
            bool bools = compareable.Compare(8, 9);
            Console.WriteLine(bools);
        }
    }
}


using System;
using System.Collections.Generic;
using System.Text;

namespace Bai11_NET_Collections__Data_Structures
{

    class ListMethod
    {
        List<string> animals = new List<string>();
        public void Method()
        {
            animals.Add("lion");
            animals.Add("cat");
            animals.Add("dog");
            animals.Add("elephant");
            animals.Remove("dog");
            Array.Sort(animals.ToArray());
            foreach (string animal in animals)
            {
                Console.WriteLine(animal);
            }
            int index = animals.IndexOf("cat");
            Console.WriteLine(index);
        }
        
    }
}

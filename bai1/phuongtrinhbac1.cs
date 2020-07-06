using System;
using System.Collections.Generic;
using System.Text;

namespace bai1
{
    class phuongtrinhbac1
    {
        public void giaiPT()
        {
            Console.Write("a: ");
            int a = Int32.Parse(Console.ReadLine());
            Console.Write("b: ");
            int b = Int32.Parse(Console.ReadLine());
            if (a != 0)
            {
                double x = - b / a;
                Console.Write("The solution is: {0}!", x);
            }
            else
            {
                if (b == 0)
                {
                    Console.Write("PT vo so nghiem!");
                }
                else
                {
                    Console.Write("PT vo nghiem");
                }
            }
        }
    }
}

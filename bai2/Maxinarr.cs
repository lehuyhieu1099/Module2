using System;
using System.Collections.Generic;
using System.Text;

namespace bai2
{
    class Maxinarr
    {
        public int getMax()
        {
            int n;
            Console.WriteLine("Nhap so ty phu");
            n = Int32.Parse(Console.ReadLine());
            while (n > 20)
            {
                Console.WriteLine("Nhap so k qua 20 thoi nhe!");
                Console.WriteLine("Nhap so ty phu");
                n = Int32.Parse(Console.ReadLine());

            }
            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap so tien cua ty phu so " + i);
                numbers[i] = Int32.Parse(Console.ReadLine());
            }
            int max = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (max < numbers[i])
                {
                    max = numbers[i];
                }
            }
            return max;
        }
    }
}

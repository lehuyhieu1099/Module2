using System;
using System.Collections.Generic;
using System.Text;

namespace bai2
{
    class daoNguocMang
    {
        public void daoNguoc()
        {
            int n;
            Console.WriteLine("Nhap so phan tu cua mang");
            n = Int32.Parse(Console.ReadLine());
            while (n > 20)
            {
                Console.WriteLine("Nhap so k qua 20 thoi nhe!");
                Console.WriteLine("Nhap so phan tu cua mang");
                n = Int32.Parse(Console.ReadLine());
            }
            int[] numbers = new int[n];
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Nhap phan tu " + i + " cua mang:");
                numbers[i] = Int32.Parse(Console.ReadLine());
            }
            for (int j = 0; j < numbers.Length; j++)
            {
                Console.Write(numbers[j] + ", ");
            }
            for (int j = 0; j < numbers.Length / 2; j++)
            {
                int temp = numbers[j];
                numbers[j] = numbers[numbers.Length - 1 - j];
                numbers[numbers.Length - 1 - j] = temp;
            }
            Console.WriteLine("Reverse array: ", "");
            for (int j = 0; j < numbers.Length; j++)
            {
                Console.Write(numbers[j] + ", ");
            }



        }
    }
}

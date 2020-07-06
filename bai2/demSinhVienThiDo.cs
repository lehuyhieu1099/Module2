using System;
using System.Collections.Generic;
using System.Text;

namespace bai2
{
    class demSinhVienThiDo
    {
        public int dem()
        {
            int n;
            Console.WriteLine("Nhap so sinh vien");
            n = Int32.Parse(Console.ReadLine());
            while (n > 30)
            {
                Console.WriteLine("Nhap so k qua 30 thoi nhe!");
                Console.WriteLine("Nhap so sinh vien");
                n = Int32.Parse(Console.ReadLine());

            }
            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("Nhap diem sinh vien so " + i);
                    numbers[i] = Int32.Parse(Console.ReadLine());
                }
            int count = 0;
            for (int j = 0; j < n; j++)
            {
                if (numbers[j] >= 5)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace bai2
{
    class thaoTacVoiMang
    {
        public void tinhTong()
        {
            int[] numbers = new int[5];
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Nhap phan tu " + i + " cua mang:");
                numbers[i] = Int32.Parse(Console.ReadLine());
            }
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine(sum);
        }
    }
}

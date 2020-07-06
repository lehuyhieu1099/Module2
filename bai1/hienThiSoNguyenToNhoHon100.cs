using System;
using System.Collections.Generic;
using System.Text;

namespace bai1
{
    class hienThiSoNguyenToNhoHon100
    {
        public void hienthi()
        {
            int count = 0;
            int number = 2;
            while (number < 100)
            {
                kiemtrasonguyento kiemtra = new kiemtrasonguyento();
                if (kiemtra.kiemtra(number))
                {
                    count++;
                    Console.WriteLine(number);
                }
                number++;
            }
            

        }
    }
}

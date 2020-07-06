using System;
using System.Collections.Generic;
using System.Text;

namespace bai1
{
    class hienthi20soNTdautien
    {
        public void hienthi()
        {
            int count = 0;
            int number = 2;
            while (count != 20)
            {
                kiemtrasonguyento kiemtra = new kiemtrasonguyento();
                if (kiemtra.kiemtra(number))
                {
                    Console.WriteLine(number);
                    count++;
                }
                number++;
            }
        }
    }
}

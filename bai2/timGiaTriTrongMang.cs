using System;
using System.Collections.Generic;
using System.Text;

namespace bai2
{
    class timGiaTriTrongMang
    {
        public void timGiaTri()
        {
            string[] students = { "Christian", "Michael", "Camila", "Sienna", "Tanya", "Connor", "Zachariah", "Mallory", "Zoe", "Emily" };
            Console.WriteLine("Nhap ten can tim:");
            string ten = Console.ReadLine();
            for(int i = 0; i < students.Length; i++)
            {
                if (students[i] == ten)
                {
                    Console.WriteLine("vi tri so "+i);
                    break;
                } else
                {
                    Console.WriteLine("Khong co");
                    break;
                }
            }
        }
    }
}

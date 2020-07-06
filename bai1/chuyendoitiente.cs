using System;
using System.Collections.Generic;
using System.Text;

namespace bai1
{
    class chuyendoitiente
    {
        public void chuyendoi()
        {
            Console.WriteLine("Nhap ti gia: ");
            double tiGia = Double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap USD: ");
            int USD = Int32.Parse(Console.ReadLine());
            Console.WriteLine(USD + " USD = " + USD * tiGia + " VNĐ");


        }
    }
}

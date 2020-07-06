using System;
using System.Collections.Generic;
using System.Text;

namespace bai1
{
    class tinhChiSoCanNang
    {
        public void tinh()
        {
            double height, weight;
            Console.WriteLine("Nhap chieu cao");
            height = Double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap can nang");
            weight = Double.Parse(Console.ReadLine());
            double bmi = weight / (height * height);
            if (bmi >= 30)
            {
                Console.WriteLine("Obese");
            } 
            else if (bmi>=25)
            {
                Console.WriteLine("Overweight");
            } 
            else if (bmi >= 18.5)
            {
                Console.WriteLine("Normal");
            }
            else 
            {
                Console.WriteLine("Underweight");
            }



        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace bai2
{
    class ChuyenDoiNhietDo
    {
        public void chuyenDoi()
        {
            int choice;
            double nhietDo;
            Console.WriteLine("Convert:");
            Console.WriteLine("1. C to F");
            Console.WriteLine("2. F to C");
            Console.WriteLine("0. Exit");
            Console.WriteLine("Enter your choice: ");
            choice = Int32.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Nhap do C" );
                    nhietDo = double.Parse(Console.ReadLine());
                    Console.WriteLine(ConvertCtoF(nhietDo));
                    
                    break;
                case 2:
                    Console.WriteLine("Nhap do F");
                    nhietDo = double.Parse(Console.ReadLine());
                    Console.WriteLine(ConvertFtoC(nhietDo));
                    break;
                case 3:
                    Environment.Exit(0);
                    break;
                default:
                    break;
            }
        }
        public static double ConvertCtoF(double C)
        {
            return (C + 32) * 1.8;
        }
        public static double ConvertFtoC(double F)
        {
            return (F - 32) / 1.8;
        }
    }
}

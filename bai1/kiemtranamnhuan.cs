using System;
namespace bai1
{
    class kiemTraNamNhuan
    {
         public void kiemtra()
        {
            int year;
            bool isLeapYear = false;
            Console.WriteLine("Enter a year: ");
            year = Convert.ToInt32(Console.ReadLine());

            if (year % 4 == 0 && year % 100 != 0)
            {
                isLeapYear = true;
            }
            else
            {
                if (year % 100 == 0 && year % 400 == 0)
                {
                    isLeapYear = true;
                }
                else
                {
                    isLeapYear = false;
                }
            }
            if (isLeapYear)
            {
                Console.WriteLine(year + " la nam nhuan");
            }
            else
            {
                Console.WriteLine(year + " khong phai nam nhuan");
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace bai1
{
    class hienthicacloaihinh
    {
        public void hienthi()
        {
            int choice;
            Console.WriteLine("Menu");
            Console.WriteLine("1. Ve hinh chu nhat");
            Console.WriteLine("2. Ve tam giac can");
            Console.WriteLine("3. Ve tam giac vuong");
            Console.WriteLine("0. Exit");
            Console.WriteLine("Enter your choice: ");
            choice = Int32.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Ve hinh chu nhat");
                    Console.WriteLine("Nhap chieu dai");
                    int width = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Nhap chieu rong");
                    int height = Int32.Parse(Console.ReadLine());
                    for (int i = 0; i < height; i++)
                    {
                        for (int j = 0; j < width; j++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                    }
                    break;
                case 2:
                    Console.WriteLine("Ve tam giac can");
                    
                    
            
                            break;
                case 3:
                    Console.WriteLine("Ve tam giac vuong");
                    for (int i = 1; i <= 5; i++)
                    {
                        for (int j = 1; j < i; j++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                    }
                        break;
                case 0:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("No choice!");
                    break;
            }
        }
    }
}

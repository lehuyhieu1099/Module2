using System;
using System.Collections.Generic;
using System.Text;

namespace Management
{
    class CreateMenu
    {
        public void Menu()
        {
            int choice;
            Console.WriteLine("Menu");
            Console.WriteLine("1. Doing p1");
            Console.WriteLine("2. Doing p2");
            Console.WriteLine("3. Doing p3");
            Console.WriteLine("0. Exit");
            Console.WriteLine("Enter your choice: ");
            choice = Int32.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    
                    break;
                case 2:
                    
                    break;
                case 3:
                    
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

using System;
using System.Collections.Generic;
using System.Text;

namespace Product_Management
{
    class Menu
    {
        public static ProductService productService = new ProductService();


        public static void ShowMenu()
        {
            

            string choice;

            Console.WriteLine("Menu");
            Console.WriteLine("1. ShowProducts");
            Console.WriteLine("2. AddProduct");
            Console.WriteLine("3. RemoveProduct");
            Console.WriteLine("4. EditProduct");
            Console.WriteLine("0. Exit");
            
            Console.WriteLine("Enter your choice: ");
            choice = Console.ReadLine();
           
            switch (choice)
            {
                case "1":
                    Console.WriteLine("Product List:");
                    productService.Show();
                    break;

                case "2":
                    Console.WriteLine("Enter ProductInfo bellow:");
                    Console.Write("Enter Name:");
                    string name = Console.ReadLine();
                    Console.Write("Enter code:");
                    string code = Console.ReadLine();
                    Console.Write("Enter price:");
                    int price = int.Parse(Console.ReadLine());
                    Console.Write("Enter date:");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    Console.Write("Enter manufatory:");
                    string manufactory = Console.ReadLine();
                    Product product = new Product();
                    product.Code = code;
                    product.Date = date;
                    product.Manufactory = manufactory;
                    product.Name = name;
                    product.Price = price;
                    productService.Add(product);
                    productService.Show();
                    break;

                case "3":
                    Console.Write("Enter code: ");
                    var code1 = Console.ReadLine();
                   
                    productService.Delete(code1);
                    productService.Show();
                    break;

                case "4":
                    Console.Write("Enter product'code need to change:");
                    string code_ = Console.ReadLine();
                   
                    if (productService.FindProduct(code_) != -1)
                    {
                        productService.Edit(code_);
                        productService.Show();
                    }
                    else
                    {
                        Console.WriteLine("Not found!");
                    }
                    break;

                case "0":
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("No choice!");
                    break;
            }
        }

    }
}

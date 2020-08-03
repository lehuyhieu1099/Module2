using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Product_Management
{

    class ProductService
    {
        public Product[] products = new Product[0];
       
        public void Add(Product product)
        {
            Array.Resize(ref products, products.Length + 1);
           
            products[products.Length - 1] = product;

            Console.WriteLine(products.Length);
        }
         
        public void Edit(string code)
        {
            var pos = FindProduct(code);
            if (pos != -1)
            {
                Console.Write("Enter newName:");
                string name = Console.ReadLine();

                Console.Write("Enter newCode:");
                string _code = Console.ReadLine();

                Console.Write("Enter newPrice:");
                double price = double.Parse(Console.ReadLine());

                Console.Write("Enter newDate:");
                DateTime date = DateTime.Parse(Console.ReadLine());

                Console.Write("Enter newManufactory:");
                string manufatory = Console.ReadLine();

                Product product = new Product();

                product.Name = name;
                product.Code = _code;
                product.Price = price;
                product.Date = date;
                product.Manufactory = manufatory;
                products[pos] = product;
            }
            else
            {
                Console.WriteLine($"Code: {code} not found");
            }
        }

        public void Delete(string code)
        {
            var pos = FindProduct(code);
            if (pos != -1)
            {
                for (int i = pos; i < products.Length - 1; i++)
                {
                    products[i] = products[i + 1];
                }
                Array.Resize(ref products, products.Length - 1);
            }
            else
            {
                Console.WriteLine($"Code: {code} not found");
            }
        }

        public void Show()
        {
            string table = $"Name\tCode\tPrice\tDate\t\t\tManufactory";
            for (int i = 0; i < products.Length; i++)
            {
                table = table + $"\n" + products[i].ShowProductInfo();
            }
            Console.WriteLine(table);
        }

        public  int FindProduct(string code)
        {
            for (int i = 0; i < products.Length; i++)
            {
                if (products[i].Code.ToUpper() == code.ToUpper())
                {
                    return i;
                }
            }
            return -1;
        }
        
            
       
    }



}


using System;
using System.Collections.Generic;
using System.Text;

namespace Bai5
{
    
    class Triangle : Shape
    {
        private double side1, side2, side3;
        public Triangle()
        {
            side1 = 1.0;
            side2 = 1.0;
            side3 = 1.0;
        }
        public Triangle(double side1, double side2, double side3,string color,bool filled) :base(color,filled)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }
        public double Side1 { get => side1; set => side1 = value; }
        public double Side2 { get => side2; set => side2 = value; }
        public double Side3 { get => side3; set => side3 = value; }
        public double[] GetSide()
        {
            double[] arr = { side1, side2, side3 };
            return arr;

        }
        public void SetSide(double side1, double side2, double side3)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }
        public double GetPerimeter()
        {
            double p = (side1 + side2 + side3) ;
            return p;
        }
        public override double GetArea()
        {
            double p2 = (side1 + side2 + side3) / 2;
            return Math.Sqrt(p2 * (p2 - side1) * (p2 - side2) * (p2 - side3));
        }
        public override string ToString()
        {
            return $"A Triangle with side1= {side1}, side2= {side2} and side3= {side3}, which is a subclass of{base.ToString()}";
        }


        public static void CreateTraingle()
        {
            do
            {
                Console.WriteLine("enter side1/press 0 to close: ");
                double side1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("enter side2/press 0 to close: ");
                double side2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("enter side3/press 0 to close: ");
                double side3 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("enter color for traiangle/press 0 to close: ");
                string color = Console.ReadLine();

                Console.WriteLine("Is it filled?/press 0 to close: ");
                bool filled = bool.Parse(Console.ReadLine());
           
                Triangle triangle = new Triangle(side1, side2, side3, color, filled);
                Console.WriteLine(triangle);

                Console.WriteLine($"area: {triangle.GetArea()} and Perimeter: {triangle.GetPerimeter()}");

                Console.WriteLine("enter 0 to close/anynumber to continute: ");

                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 0)
                {
                    break;
                }
            } while (true);
        }



    }
}

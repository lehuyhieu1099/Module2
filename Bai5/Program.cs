using System;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

namespace Bai5
{
    class Program
    {
        public static void Main(string[] args)
        {

            Shape[] shapes = new Shape[3];
            shapes[0] = new Circle(5.0, "green", true);
            shapes[1] = new Square("blue", false, 5.0);
            shapes[2] = new Rectangle(7.0, 5.0);

            Console.WriteLine("Pre-color:");
            for (int i = 0; i < shapes.Length; i++)
            {
                Console.WriteLine($"Area is: {shapes[i].GetArea()}");
                if (shapes[i] is Square)
                {
                    shapes[i].HowToColor();
                }
            }
           

        }
    }



}

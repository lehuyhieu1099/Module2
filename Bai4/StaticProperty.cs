using System;
using System.Collections.Generic;
using System.Text;

namespace Bai4
{
        public class Car
        {

            private string name;
            private string engine;
            public static int numberOfCars;
            public string Name { get => name; set => name = value; }
            public string Engine { get => engine; set => name = value; }

            public Car(string name, string engine)
            {
                this.name = name;
                this.engine = engine;
                numberOfCars++;
            }
           

        }
        //public class Program
        //{
        //    public static void Main(string[] args)
        //    {
        //        Car car1 = new Car("Mazda 3", "Skyactiv 3");
        //        Console.WriteLine(Car.numberOfCars);
        //        Car car2 = new Car("Mazda 6", "Skyactiv 6");
        //        Console.WriteLine(Car.numberOfCars);
        //        Console.ReadLine();
        //    }
        //}
    
}

﻿using System;


namespace Bai4
{
    public class Program
    { 
        public static void Main()
        {
            var packard = new Automobile("Packard", "Custom Eight", 1948);
            Console.WriteLine(packard); // In ra: 1948 Packard Custom Eight
        }
        public class Automobile
        {
            public Automobile(string make, string model, int year)
            {
                if (make == null)
                    throw new ArgumentNullException("The make cannot be null.");
                else if (String.IsNullOrWhiteSpace(make))
                    throw new ArgumentException("make cannot be an empty string or have space characters only.");
                Make = make;

                if (model == null)
                    throw new ArgumentNullException("The model cannot be null.");
                else if (String.IsNullOrWhiteSpace(model))
                    throw new ArgumentException("model cannot be an empty string or have space characters only.");
                Model = model;

                if (year < 1857 || year > DateTime.Now.Year + 2)
                    throw new ArgumentException("The year is out of range.");
                Year = year;
            }

            public string Make { get; }

            public string Model { get; }

            public int Year { get; }

            public override string ToString() => $"{Year} {Make} {Model}";
        }

    }

}

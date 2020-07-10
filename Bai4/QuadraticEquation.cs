using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Bai4
{
    public class QuadraticEquation
    {
        private double a, b, c, delta;
        public QuadraticEquation()
        {

        }
        public QuadraticEquation(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public double A { get => a; set => a = value; }
        public double B { get => b; set => b = value; }
        public double C { get => c; set => c = value; }
        public double Delta { get => delta; }
        public double GetDiscriminant()
        {
            delta = b * b - 4 * a * c;
            return delta;
        }
        public string GetRoot1()
        {
            
            if (delta > 0)
            {
                return  $"{(-b + Math.Pow(delta, 0.5)) / (2 * a)}";
            } 
            if (delta == 0)
            {
                return  $"Nghiem kep:";
            }
            return "0";
        }
        public string GetRoot2()
        {
            if (delta > 0)
            {
                return $"{(-b - Math.Pow(delta, 0.5)) / (2 * a)}";
            }
            if (delta == 0)
            {
                return $"{-b / (2 * a)}";
            }
            return "0";
        }
       
 


    }
}

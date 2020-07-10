using System;
using System.Collections.Generic;
using System.Text;


namespace Bai5
{
    public class Circle : Shape 
    {
        public double radius { get; set; }
        public Circle()
        {
            this.radius = 1.0;
        }

        public Circle(double radius)
        {
            this.radius = radius;
        }
        public Circle(string color, bool filled, double radius) : base(color, filled)
        {
            this.radius = radius;
        }

        public Circle(double radius, string color, bool filled) : this(radius)
        {
            this.color = color;
            this.filled = filled;
        }

        public string _Color { get => color; set => color = value; }
        public bool _Filled { get => filled; set => filled = value; }
        public double _Radius { get => radius; set => radius = value; }
        public double GetRadius()
        {
            return radius;
        }
        public override double GetArea()
        {
            return radius * radius * 3.14;
        }
        public double GetPerimeter()
        {
            return 2 * 3.14 * radius;
        }
        public override string ToString()
        {
            return $" A Circle with {radius}, which is a subclass of {base.ToString()}";
        }
        interface IComparer
        {
            public int Compare();
        }
        public class CircleComparator : IComparer<Circle>
        {
            public int Compare(Circle c1, Circle c2)
            {
                if (c1.GetRadius() > c2.GetRadius()) return 1;
                else if (c1.GetRadius() < c2.GetRadius()) return -1;
                else return 0;
            }

        }
        
        //public interface IResize
        //{
        //    public void Resize(double percent);
        //}
        //public void Resize(double percent)
        //{
        //    radius += radius * percent;
        //}


    }
}

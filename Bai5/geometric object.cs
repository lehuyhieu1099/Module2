using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Bai5
{

    public abstract class Shape : IColorable
    {
        public string color { get; set; }
        public bool filled { get; set; }

        public Shape()
        {
            this.color = "green";
            this.filled = true;
        }
        public Shape(string color, bool filled)
        {
            this.color = color;
            this.filled = filled;
        }
        public string Color { get => color; set => color = value; }
        public bool Filled { get => filled; set => filled = value; }

        public abstract double GetArea();

        public override string ToString()
        {
            return $"A Shape with color of {color} and {((filled) ? "filled" : "not filled")}";
        }

        public void HowToColor()
        {
            Console.WriteLine("Color all four sides.");
        }
    }

















    //public class Circle : Shape
    //{
    //    public double radius { get; set; }
    //    public Circle()
    //    {
    //        this.radius = 1.0;
    //    }

    //    public Circle(double radius)
    //    {
    //        this.radius = radius;
    //    }
    //    public Circle(string color, bool filled, double radius) : base(color, filled)
    //    {
    //        this.radius = radius;
    //    }

    //    public string _Color { get => color; set => color = value; }
    //    public bool _Filled { get => filled; set => filled = value; }
    //    public double _Radius { get => radius; set => radius = value; }
    //    public double GetArea()
    //    {
    //        return radius * radius * 3.14;
    //    }
    //    public double GetPerimeter()
    //    {
    //        return 2 * 3.14 * radius;
    //    }
    //    public override string ToString()
    //    {
    //        return $" A Circle with {radius}, which is a subclass of {base.ToString()}";
    //    }
    //}
    //public class Rectangle : Shape
    //{
    //    public double width { get; set; }
    //    public double height { get; set; }
    //    public Rectangle()
    //    {
    //        this.width = 1.0;
    //        this.height = 1.0;
    //    }

    //    public Rectangle(double width, double height)
    //    {
    //        this.width = width;
    //        this.height = height;
    //    }
    //    public Rectangle(string color, bool filled, double width, double height) : base(color, filled)
    //    {
    //        this.width = width;
    //        this.height = height;
    //    }
    //    public string _color { get => color; set => color = value; }
    //    public bool _filled { get => filled; set => filled = value; }
    //    public double _width { get => width; set => width = value; }
    //    public double _height { get => height; set => height = value; }

    //    public double GetArea()
    //    {
    //        return width * height;
    //    }
    //    public double GetPerimeter()
    //    {
    //        return (width + height) * 2;
    //    }
    //    public override string ToString()
    //    {
    //        return $" A Rectangle with width= {height} and length= {width}, which is a subclass of {base.ToString()}";
    //    }
    //}
    //public class Square : Rectangle
    //{
    //    public double side { get; set; }
    //    public Square()
    //    {
    //        this.side = 1.0;
    //    }
    //    public Square(double side)
    //    {
    //        this.side = side;
    //    }
    //    public double Size { get => Size; set => Size = value; }
    //    public void SetWidth()
    //    {
    //        this.width = side;
    //        this.height = side;
    //    }
    //    public double GettWidth()
    //    {
    //        return side;

    //    }
    //    public override string ToString()
    //    {
    //        return $"A Square with side= {side}, which is a subclass of {base.ToString()}";
    //    }

    //}
    //public class Cylinder : Circle
    //{
    //    public double height { get; set; }
    //    public Cylinder(double height)
    //    {
    //        this.height = height;
    //    }
    //    public string GetVolume()
    //    {
    //        double volume = base.GetArea() * height;
    //        return $"Volume's Cylinder is: {volume}";
    //    }
    //    public override string ToString()
    //    {
    //        return $"A Cylinder with height= {height}, which is a subclass of {base.ToString()}";
    //    }
    //}

}

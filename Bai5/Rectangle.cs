using System;
using System.Collections.Generic;
using System.Text;

namespace Bai5
{
    public class Rectangle : Shape, IResize
    {
        public double width { get; set; }
        public double height { get; set; }
        public Rectangle()
        {
            this.width = 1.0;
            this.height = 1.0;
        }

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }
        public Rectangle(string color, bool filled, double width, double height) : base(color, filled)
        {
            this.width = width;
            this.height = height;
        }

        public Rectangle(string color, bool filled)
        {
            this.color = color;
            this.filled = filled;
        }

        public string _color { get => color; set => color = value; }
        public bool _filled { get => filled; set => filled = value; }
        public double _width { get => width; set => width = value; }
        public double _height { get => height; set => height = value; }

        public override double GetArea()
        {
            return width * height;
        }
        public double GetPerimeter()
        {
            return (width + height) * 2;
        }
        public override string ToString()
        {
            return $" A Rectangle with width= {height} and length= {width}, which is a subclass of {base.ToString()}";
        }

        public void Resize(double percent)
        {
            width += width * percent;
            height += height * percent;
        }
    }
}

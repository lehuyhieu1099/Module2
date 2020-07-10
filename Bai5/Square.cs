using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Bai5
{
    public class Square : Rectangle, IResize, IColorable
    {
        private double side = 1.0;
        public Square()
        {
            this.side = 1.0;
        }
        public Square(double side)
        {
            this.side = side;
        }
        public Square(string color, bool filled, double side) : base(color, filled)
        {
            this.side = side;
        }
        public double Side { get => side; set => side = value; }
        public void SetSide(double side)
        {
            this.width = side;
            this.height = side;
        }
        public double GetSide()
        {
            return side;

        }
        public override double GetArea()
        {
            return side * side;
        }
        public override string ToString()
        {
            return $"A Square with side= {side}, which is a subclass of {base.ToString()}";
        }

        public new void Resize(double percent)
        {
            side += side * percent;
        }
       

        void IColorable.HowToColor()
        {
            Console.WriteLine("Colorful");
        }
    }
}

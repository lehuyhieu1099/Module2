using System;
using System.Collections.Generic;
using System.Text;

namespace Bai5
{
    public class Cylinder : Circle
    {
        public double height { get; set; }
        public Cylinder(double height)
        {
            this.height = height;
        }
        public string GetVolume()
        {
            double volume = base.GetArea() * height;
            return $"Volume's Cylinder is: {volume}";
        }
        public override string ToString()
        {
            return $"A Cylinder with height= {height}, which is a subclass of {base.ToString()}";
        }
    }
}

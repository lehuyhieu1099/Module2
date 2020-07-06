using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace Bai3
{
    class Fan
    {
        // Tốc độ quạt
        const int SLOW = 1;
        const int MEDIUM = 2;
        const int FAST = 3;
        private int speed = 1;
        private bool on;
        private double radius;
        private string color;
        public int Speed { get => speed; set => speed = value; }
        public bool On { get => on; set => on = value; }
        public double Radius { get => radius; set => radius = value; }
        public string Color { get => color; set => color = value; }

        public Fan()
        {

        }
        public Fan(bool on,int speed,string color,double radius)
        {
            this.speed = speed;
            this.on = on;
            this.radius = radius;
            this.color = color;
        }

        public void toString()
        {
            if (on)
            {
               Console.WriteLine($"Fan is on, speed : {speed} , color : {color} , radius : {radius}");
            }
            if (!on)
            {
                Console.WriteLine($"Fan is off,  color : {color} , radius : {radius}");
            }
        }
    }
}

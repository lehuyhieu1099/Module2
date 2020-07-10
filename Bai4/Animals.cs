using System;
using System.Collections.Generic;
using System.Text;

namespace Bai4
{
    public abstract class Animals
    {
        protected string Weight { get; set; }
        protected string Height { get; set; }

        public Animals(string weight, string height)
        {
            this.Weight = weight;
            this.Height = height;
        }
        public abstract void PrintInfo();
        
    }
    public class Cat : Animals
    {
        private string Name { get; set; }
        public Cat(string weight, string height, string name)
        : base(weight, height)
        {
            this.Name = name;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Weight {this.Weight}, Height: {this.Height} Name:{this.Name}");
        }
    }
}

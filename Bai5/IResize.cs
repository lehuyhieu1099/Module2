using System;
using System.Collections.Generic;
using System.Text;

namespace Bai5
{
    public interface IResize
    {
        public void Resize(double percent);
    }
    //static void Main(string[] args)
    //{
    //    ComperableCircle[] circles = new ComperableCircle[3];
    //    circles[0] = new ComperableCircle(5.0);
    //    circles[1] = new ComperableCircle(10.0);
    //    circles[2] = new ComperableCircle(7.0);

    //    Console.WriteLine("Pre-rezed:");
    //    foreach (ComperableCircle circle in circles)
    //    {
    //        Console.WriteLine(circle);
    //    }

    //    for (var i = 0; i < circles.Length; i++)
    //    {
    //        circles[i].Resize(0.5);
    //    }

    //    Console.WriteLine("After-rezed:");
    //    foreach (ComperableCircle circle in circles)
    //    {
    //        Console.WriteLine(circle);
    //    }
    //}
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Bai5
{
    //static void Main(string[] args)
    //{
    //    MoveablePoint move = new MoveablePoint(5.5f, 6.5f);

    //    float[] arr = move.Move(1.0f, 1.0f);
    //    foreach (var item in arr)
    //    {
    //        Console.WriteLine(item + ", ");
    //    }


    //}

    class MoveablePoint : Point2D
    {
        private float xSpeed { get; set; }
        private float ySpeed { get; set; }
        public MoveablePoint()
        {
            xSpeed = 0.0f;
            ySpeed = 0.0f;
        }
        public MoveablePoint(float xspeed, float yspeed)
        {
            xSpeed = xspeed;
            ySpeed = yspeed;
        }
        public float GetxSpeed()
        {
            return xSpeed;
        }
        public void SetxSpeed(float xspeed)
        {
            xSpeed = xspeed;
        }
        public float GetySpeed()
        {
            return ySpeed;
        }
        public void SetySpeed(float yspeed)
        {
            ySpeed = yspeed;
        }
        public float[] GetSpeed()
        {
            float[] arr = { xSpeed, ySpeed };
            return arr;
        }
        public void SetSpeed(float xspeed,float yspeed)
        {
            xSpeed = xspeed;
            ySpeed = yspeed;
        }
        public override string ToString()
        {
            return $"{xSpeed},{ySpeed}";
        }
        public  MoveablePoint Move() 
        {
            X += xSpeed;
            Y += ySpeed;
            
            return this;
        }
    } 
}

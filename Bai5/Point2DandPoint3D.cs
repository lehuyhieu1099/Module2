using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Bai5
{
    public class Point2D
    {
        private float x { get; set; }
        private float y { get; set; }
        public Point2D()
        {
            this.x = 0.0f;
            this.y = 0.0f;
        }
        public Point2D(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
        public float X { get => x; set => x = value; }
        public float Y { get => y; set => y = value; }
        public float GetX()
        {
            return x;
        }
        public void SetX(float x)
        {
            this.x = x;
        }
        public float GetY()
        {
            return y;
        }
        public void SetY(float y)
        {
            this.y = y;
        }
        public  float[] GetXY()
        {
            float[] arr = { x, y };
            return arr;

        }
        public void SetXY(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
        public override string ToString()
        {
            return $"{x}, {y}";
        }
    }
    public class Point3D : Point2D
    {
        private float z { get; set; }
        public Point3D()
        {
            this.z = 0.0f;
        }
        public Point3D(float x, float y, float z) : base(x, y)
        {
            this.z = z;
        }
        public float GetZ()
        {
            return z;
        }
        public void SetZ(float z)
        {
            this.z = z;
        }
        public void SetXYZ(float x, float y, float z) 
        {
            X = x;
            Y = y;
            this.z = z;
        }
        public float[] GetXYZ() 
        {
            float[] arr = { X, Y, z };
            return arr;
        }
        public override string ToString()
        {
            return $"{ base.ToString()}, {z}";
        }


    }

}

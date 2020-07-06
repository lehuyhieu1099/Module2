using System;
namespace bai1
{
    public class suDungToanTu
    {
        public void toantu()
        {
            float width;
            float height; 
            Console.Write("Enter width: ");
            width = float.Parse(Console.ReadLine());
            Console.Write("Enter height: ");
            height = float.Parse(Console.ReadLine());
            float area = width * height;
            Console.WriteLine("Area is: " + area);
        }
    }
}
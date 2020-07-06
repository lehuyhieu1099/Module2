using System;

namespace bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            sumOfMainDiagonal mang = new sumOfMainDiagonal();
            var matrix = mang.CrerateMatrix(5,5);
            mang.PrintMatrix(matrix);
            Console.WriteLine(mang.getSum());

        }
       
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace bai2
{
    class sumOfMainDiagonal
    {
        public double[,] matrix;
        public double[,] CrerateMatrix(int row, int col)
        {
            matrix = new double[row, col];
            Random rnd = new Random();
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    matrix[i, j] = rnd.Next(10, 90);
                }
            }
            return matrix;
        }
        public double getSum()
        {
            double sum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {      
                sum += matrix[i, i];     
            }
            return sum;
        }
        public void PrintMatrix(double[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"{arr[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}

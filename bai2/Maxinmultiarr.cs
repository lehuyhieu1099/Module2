using System;
using System.Collections.Generic;
using System.Text;

namespace bai2
{
    class MaxInMultiArr
    {
        //MaxInMultiArr mang2chieu = new MaxInMultiArr();
        //int[,] arr2chieu = mang2chieu.CrerateMatrix(5, 5);
        //mang2chieu.PrintMatrix(arr2chieu);
        // Console.WriteLine(mang2chieu.getMax());
        public  int[,] matrix;
        public int[,] CrerateMatrix(int row,int col)
        {
            matrix = new int[row, col];
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
        public int getMax()
        {
            int max = matrix[0,0];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (max < matrix[i,j])
                    {
                        max = matrix[i,j];
                    }
                } 
            }return max;
        }
        public  void PrintMatrix(int[,] arr)
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

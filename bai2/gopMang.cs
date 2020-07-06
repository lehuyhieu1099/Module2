using System;
using System.Collections.Generic;
using System.Text;

namespace bai2
{
    class gopMang
    {
        public int[] MergeArr(int[]arr1, int[] arr2)
        {
            int[] arr3 = new int[arr1.Length + arr2.Length];
            for (int i = 0; i < arr1.Length; i++)
            {
                arr3[i] = arr1[i];
            }
            for (int i = 0; i < arr2.Length; i++)
            {
                arr3[arr1.Length + i] = arr2[i]; 
            }
            return arr3;

        }
        public void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();
        }
        public  int[] CrerateArray(int size)
        {
            int[] arr = new int[size];
            Random rnd = new Random();
            for (int i = 0; i < size; i++)
            {
                arr[i] = rnd.Next(10, 90);
            }
            return arr;
        }
    }

}

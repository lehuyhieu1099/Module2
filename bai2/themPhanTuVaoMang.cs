using System;
using System.Collections.Generic;
using System.Text;

namespace bai2
{
    class themPhanTuVaoMang
    {
        //themPhanTuVaoMang mang = new themPhanTuVaoMang();
        // var arr = mang.CreateArray(10);
        // Console.WriteLine(mang.thanhChuoi());
        // mang.push(1000, 5);
        //Console.WriteLine(mang.thanhChuoi());
        public int[] arr;
        public  int[] CreateArray(int N)
        {
            arr = new int[N];
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(50, 100);
            }
            return arr;
        }
        public  void push(int x, int index)
        {
            int [] temp = new int[arr.Length + 1];
            if (index == 0 && arr.Length == 0)
            {
                temp[index] = x;
            }
            else
            {
                for (int i = 0; i < temp.Length; i++)
                {
                    if (i < index)
                    {
                        temp[i] = arr[i];
                    }
                    else if (i > index)
                    {
                        temp[i] = arr[i - 1];
                    }
                    else
                    {
                        temp[i] = x;
                    }
                }
            }

            arr = temp;
        }
        public string thanhChuoi()
        {
            string s = "";
            for (int i = 0; i < arr.Length;i++)
            {
                s += arr[i] + ", ";
            }

                return s;
        }
    }
}
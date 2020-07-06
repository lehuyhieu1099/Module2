using System;
using System.Collections.Generic;
using System.Text;

namespace bai2
{
    class CountChar
    {
        
        public int Count(char kitu,string str)
        {
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == kitu)
                {
                    count++;
                }
            }
            return count;
        }
        


    }
}

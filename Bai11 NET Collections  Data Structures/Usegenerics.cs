using System;
using System.Collections.Generic;
using System.Text;

namespace Bai11_NET_Collections__Data_Structures
{
    
       
    public class Compareable<T> 
    {

        public bool Compare(T value1, T value2)
        {
            if (value1.Equals(value2))
                return true;
            return false;
        }
    }
    
}

using System;
using System.Collections.Generic;
using System.Text;

namespace B14_Errors_Exceptions
{
    class UseOverflowException
    {
        static void Main()
        {
            try
            {
                int num1 = 111111111;
                int num2 = 999999999;
                int result = num1 * num2;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
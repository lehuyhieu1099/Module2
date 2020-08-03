using System;
using System.Collections.Generic;
using System.Text;

namespace B14_Errors_Exceptions
{
    class UseDivideByZeroException
    {
        public static void Main()
        {
            int number1 = 3000;
            int number2 = 0;
            try
            {
                int result = number1 / number2;
                Console.WriteLine(result);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}

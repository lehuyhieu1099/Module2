using System;
using System.Collections.Generic;
using System.Text;

namespace B14_Errors_Exceptions
{
    class UseFormatException
    {
        static void Main()
        {
            try
            {
                decimal price = 169.32m;
                Console.WriteLine("The cost is {0:Q2}.", price);
            }
            catch (System.FormatException ex)
            {
                System.Console.WriteLine(ex);
            }
        }
    }
}

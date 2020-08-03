using System;
using System.Collections.Generic;
using System.Text;

namespace B14_Errors_Exceptions
{
    class UseIndexOutOfRangeException
    {
        static void Main()
        {
            try
            {
                List<char> characters = new List<char>();
                characters.InsertRange(0, new Char[] { 'a', 'b', 'c', 'd', 'e', 'f' });
                int value = characters[6];
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}

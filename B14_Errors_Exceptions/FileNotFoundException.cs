using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace B14_Errors_Exceptions
{
    class UseFileNotFoundException
    {
        static void Main()
        {
            try
            {
                // Read in nonexistent file.
                using (StreamReader reader = new StreamReader("not-there.txt"))
                {
                    reader.ReadToEnd();
                }
            }
            catch (FileNotFoundException ex)
            {
                // Write error.
                Console.WriteLine(ex);
            }
        }
    }
}

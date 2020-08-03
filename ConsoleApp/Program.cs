using System;


namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            PublicLib.PublicLib pc = new PublicLib.PublicLib();
            int sum = pc.Sum(1, 2);
            InternalLib.InternalLib ic = new InternalLib.InternalLib();
            sum = ic.Sum(1, 2);

        }
    }
}

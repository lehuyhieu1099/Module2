using System;

namespace Bai3
{
    using System;

    namespace dotnet_rectangle
    {
        class Program
        {
            static void Main(string[] args)
            {
                Fan fan1 = new Fan(true,3,"yellow",10);
                Fan fan2 = new Fan(false,2,"blue",5);
                fan1.toString();
                fan2.toString();
            }
        }
    }

               
}

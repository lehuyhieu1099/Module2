using System;
namespace bai1
{
    public class kiemtrasonguyento
    {
        public bool kiemtra(int number)
        {
            if (number < 2){
                return false;
            }
            else {
                int i = 2;
                bool check = true;
                while (i <= Math.Sqrt(number))
                {
                    if (number % i == 0)
                    {
                        check = false;
                        break;
                    }
                    i++;
                }
                if (check)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }
        
    }
}
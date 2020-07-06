using System;
namespace bai1
{
    public class uocSoChungLonNhat
    {
        public void uCLN()
        {
            int a,b;
            Console.WriteLine("Nhap so a");
            a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so b");
            b = Int32.Parse(Console.ReadLine());
            if (a==0 || b==0 ){
                Console.WriteLine("Khong co uoc chung");
            } else { while (a != b){
                if (a>b){
                a = a - b;
                } else {
                    b = b - a;
                }
            }
            Console.WriteLine("UCLN la " + a);
            }
        }
    }
}

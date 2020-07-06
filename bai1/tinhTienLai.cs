using System;
namespace bai1
{
    public class tinhTienLai
    {
        public void tinh()
        {
            double tienGui = 1.0;
            int month = 1;
            double laiSuat = 1.0;
             Console.WriteLine("Nhap so tien gui: ");
            tienGui = Double.Parse(Console.ReadLine());
             Console.WriteLine("Nhap so thang gui: ");
            month = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Nhap lai suat: ");
            laiSuat = Double.Parse(Console.ReadLine());
            Console.WriteLine("So tien lai sau "+ month +" thang la "+ tienGui * laiSuat / 12 * month);
        }
    }
}
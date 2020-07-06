using System;
namespace bai1
{
    public class tinhSoNgayTrongThang
    {
        public void tinh()
        {
            int month;
            
            Console.WriteLine("Nhap thang ban muon");
            month = Int32.Parse(Console.ReadLine());
            string soNgay = "";
            switch(month)
            {
                case 2:
                   soNgay = "28 hoac 29";
                    break;
                case 1:
                case 3:
                case 5:
                case 7: 
                case 8:
                case 10:
                case 12:
                    soNgay = "31";
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    soNgay = "30";
                    break;
                default: 
                    Console.WriteLine("Ban nhap sai roi");
                    break;
            }
            Console.WriteLine("Thang " + month + " co " + soNgay + " ngay");
           
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace bai1
{
    class docsothanhchu
    {
        public void doc() {
            Console.WriteLine("Enter your number: ");

            int number = Int32.Parse(Console.ReadLine());
            string chuSo = "";
            string[] sonho = {"Khong", "Mot", "Hai", "Ba", "Bon", "Nam", "Sau", "Bay", "Tam", "Chin", "Muoi", "Muoi mot", "Muoi hai", "Muoi ba", "Muoi bon", "Muoi lam", "Muoi sau", "Muoi bay", "Muoi tam", "Muoi chin" };
            string[] hangchuc = { "Muoi", "Hai muoi", "Ba muoi", "Bon muoi", "Nam muoi", "Sau muoi", "Bay muoi", "Tam muoi", "Chin muoi" };
            if (number >= 0 && number < 20)
            {
                chuSo +=  sonho[number];
            }
            if (number > 20 && number < 100)
            {
                int i = number / 10;
                chuSo +=  hangchuc[i-1] + " ";
                number = number % 10;
                chuSo += sonho[number];
            }
            if (number > 99 && number < 1000)
            {
                int i = number / 100;
                chuSo += sonho[i] + " Trăm ";
                number = number % 100;
                chuSo += hangchuc[ number%10 - 1]+" ";
                number = number % 10;
                chuSo += sonho[number];
            }
            Console.WriteLine(chuSo);
        }
    }
}

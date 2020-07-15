using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;
using bai1;


namespace Bai8
{
    public class FizzBuzz
    {
        public string FizzorBuzz(int number)
        {

            bool fizz = number % 3 == 0;
            bool buzz = number % 5 == 0;
            if (number > 0)
            {
                if (fizz && buzz)
                {
                    return "FizzBuzz";
                }
                if (fizz)
                {
                    return "Fizz";
                }
                if (buzz)
                {
                    return "Buzz";
                }
                Docsothanhchu docsothanhchu = new Docsothanhchu();
                string result = docsothanhchu.doc(number);
                return result;
            }
            return "so cua ban nhap khong hop le ";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Bai4
{
    public class Student1
    {
        private int rollno;
        private string name;
        private static string college = "BBDIT";
        public Student1(int r, string n)
        {
            rollno = r;
            name = n;
        }
        public static void Change()
        {
            college = "CODEGYM";
        }
        public void Display()
        {
            Console.WriteLine(rollno + " " + name + " " + college);
        }
    }
    //public class Program
    //{
    //    public static void Main(string[] args)
    //    {
    //        Student1.Change();
    //        Student s1 = new Student1(111, "Hoang");
    //        Student s2 = new Student1(222, "Khanh");
    //        Student s3 = new Student1(333, "Nam");
            
    //        s1.Display();
    //        s2.Display();
    //        s3.Display();
    //    }
    //}
}

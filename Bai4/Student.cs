using System;
using System.Collections.Generic;
using System.Text;

namespace Bai4
{
     public class Student
    {
        private int id;
        private string name;
        private string address;
        private int age;
        public Student() { }
        public Student(int id, string name, string address, int age)
        {
            this.id = id;
            this.name = name;
            this.address = address;
            this.age = age;
        }
        public int Id { get => id; set => id = value; }
        public string Address { get => address; set => address = value; }
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public override string ToString()
        {
            return $"Id : {id}, Name: {name}, Address: {address}, Age: {age}";
        }
        //public static void Main(string[] args)
        //{
        //    Student student1 = new Student(1, "M. Công", "Hà Nội", 30);

        //    Student student2 = new Student();
        //    student2.Id(2);
        //    student2.Name("Ph. Quang Khánh");
        //    student2.Address("Lạng Sơn");
        //    student2.Age(25);

        //    Console.WriteLine(student1.ToString());
        //    Console.WriteLine(student2.ToString());
        //    Console.Read();
        //}


    }
             
}

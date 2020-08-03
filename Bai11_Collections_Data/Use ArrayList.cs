using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Bai11_NET_Collections__Data_Structures
{
    public class Student
    {
        public string name { get; set; }
        public int age { get; set; }
        public Student(){}
        public Student(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }
    public class StudentManagement
    {
        static void Main(string[] args)
        {
            ArrayList students = new ArrayList();
            students.Add(new Student("Le", 21));
            students.Add(new Student("Huy", 20));
            students.Add(new Student("Hieu", 22));
            students.RemoveAt(2);
            students[1] = new Student("Le Huy Hieu", 21);
            students.RemoveAt(1);

            Console.WriteLine("Remove student at a specific index");
            foreach (Student student in students)
                Console.WriteLine(student.name + " " + student.age);
        }
        
        

    }
}

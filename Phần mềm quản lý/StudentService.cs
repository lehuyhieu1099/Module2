using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Transactions;

namespace Phần_mềm_quản_lý
{
    class StudentManagement
    {
        public ArrayList students = new ArrayList();
        public void AddStudent(Student student)
        {
            students.Add(student);
        }
        public void RemoveStudent(Student student)
        {
            if (FindStudent(student.FullName))
            {
                students.Remove(student);
            }
            else Console.WriteLine("Not found!");

        }
        public bool FindStudent(string FullName)
        {
            if (students.Contains(FullName))
            {
                return true;
            }
            return false;
        }
        public void ShowProfile()
        {
            
            foreach (Student student in students)
            {
                Console.WriteLine(student.DisplayInfo());
            }
        }


    }
}

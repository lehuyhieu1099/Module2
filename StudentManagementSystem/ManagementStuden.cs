using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManagementSystem
{
    class ManagementStuden
    {
        public static List<Student> students = new List<Student>();
        public void AddStudent(Student student)
        {
            
        }
        public void RemoveStudent(string name, int ID)
        {
            
        }
        public  void UpdateStudent(Student student)
        {
            
        }

        private int FindStudent(string name, int ID)
        {
            foreach (Student student in students)
            {
                if (student.FullName == name && student.ID == ID)
                {
                    return 1;
                }
            }
            return -1;
        }


        private int FindStudentName(string name)
        {
            foreach (Student student in students)
            {
                if (student.FullName == name)
                {
                    return 1;
                }
            }
            return -1;
        }

    }
}

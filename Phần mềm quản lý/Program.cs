using System;

namespace Phần_mềm_quản_lý
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentManagement studentmanage = new StudentManagement();
            studentmanage.AddStudent(new Student()
            {
                FullName = "Le Huy Hieu",
                ID = 123,
                Address = "TP Hue",
                Class = "5A"
            });
            studentmanage.AddStudent(new Student()
            {
                FullName = "Le Huy ",
                ID = 124,
                Address = "TP Hue",
                Class = "5A"
            });
            studentmanage.AddStudent(new Student()
            {
                FullName = "Le ",
                ID = 125,
                Address = "TP Hue",
                Class = "5A"
            });
            studentmanage.ShowProfile();


        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Bai11_NET_Collections__Data_Structures
{
    class Staff
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public Staff(int id, string name, int age)
        {
            Age = age;
            Name = name;
            Id = id;
        }
        static void Main(string[] args)
        {
            ArrayList employees = new ArrayList();
            employees.Add(new Staff(1, "Nam", 24));
            employees.Add(new Staff(2, "Kiên", 21));
            employees.Add(new Staff(3, "Việt", 21));
            employees.Add(new Staff(4, "Hằng", 23));
            employees.Add(new Staff(5, "Tiến", 24));

            var result =
                from Staff employee in employees
                where employee.Age < 24
                select employee;
           
            Array.Sort(result.ToArray());
           
            foreach (Staff employee in result)
            {
                Console.WriteLine(employee.ToString());
            };
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace B14_Errors_Exceptions
{
    class UseInvalidOperationException
    {
        class Person
        {
            public string Name { get; set; }
            public byte Age { get; set; }
            public Person() { }
        }
        class Program
        {
            static void Main()
            {
                var personList = new List<Person>();
                personList.Add(new Person() { Name = "Liya", Age = 25 });
                personList.Add(new Person() { Name = "Danya", Age = 15 });

                try
                {
                    for (int i = 0; i < 5; i++)
                    {
                        personList.Remove(personList[i]);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);

                }
            }
        }
    }
}

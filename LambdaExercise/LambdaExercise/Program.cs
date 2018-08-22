using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // Employee employee = new Employee();

            List<Employee> employees = new List<Employee>();
            {
                new Employee { FirstName = "Beth", LastName = "Jones", Id = 1 };
                new Employee { FirstName = "Daniel", LastName = "Ortiz", Id = 2 };
                new Employee { FirstName = "Jennifer", LastName = "Richie", Id = 3 };
                new Employee { FirstName = "Joe", LastName = "Smith", Id = 4 };
                new Employee { FirstName = "Seth", LastName = "Gross", Id = 5 };
                new Employee { FirstName = "Sara", LastName = "Sutter", Id = 6 };
                new Employee { FirstName = "Kyle", LastName = "Peltier", Id = 7 };
                new Employee { FirstName = "Amy", LastName = "Sanders", Id = 8 };
                new Employee { FirstName = "Joe", LastName = "Walsh", Id = 9 };
                new Employee { FirstName = "Wendy", LastName = "Cook", Id = 10 };

                foreach (var emp in employees)
                {
                    Console.WriteLine("Firstname: , Lastname: , ID:  " + emp.FirstName + emp.LastName + emp.Id);
                    Console.ReadLine();
                }
            }
            //Console.WriteLine(emp);
            //Console.ReadLine();
               //List<string> firstName = new List<string>() { "Beth", "Daniel", "Jennifer", "Joe", "Seth", "Sara", "Kyle", "Amy", "Joe", "Wendy" };

            //List<string> lastName = new List<string>() { "Jones", "Ortiz", "Richie", "Smith", "Gross", "Sutter", "Peltier", "Sanders", "Walsh", "Cook" };


        }
    }
}

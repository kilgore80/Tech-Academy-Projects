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
             Employee employee = new Employee();

            List<Employee> employees = new List<Employee>();
            {
               employees.Add( new Employee { FirstName = "Beth", LastName = "Jones", Id = 1 });
               employees.Add( new Employee { FirstName = "Daniel", LastName = "Ortiz", Id = 2 });
               employees.Add( new Employee { FirstName = "Jennifer", LastName = "Richie", Id = 3 });
               employees.Add( new Employee { FirstName = "Joe", LastName = "Smith", Id = 4 });
               employees.Add( new Employee { FirstName = "Seth", LastName = "Gross", Id = 5 });
               employees.Add( new Employee { FirstName = "Sara", LastName = "Sutter", Id = 6 });
               employees.Add( new Employee { FirstName = "Kyle", LastName = "Peltier", Id = 7 });
               employees.Add( new Employee { FirstName = "Amy", LastName = "Sanders", Id = 8 });
               employees.Add( new Employee { FirstName = "Joe", LastName = "Walsh", Id = 9 });
               employees.Add( new Employee { FirstName = "Wendy", LastName = "Cook", Id = 10 });

            }
            //2.Using a foreach loop, create a new list of all employees with the first name "Joe".

            List<Employee> Joes = new List<Employee>();

            foreach (Employee fname in employees)
            {
                if (fname.FirstName == "Joe")
                {
                    Joes.Add(fname);
                    Console.WriteLine(fname.FirstName + " " + fname.LastName);                    
                }
            }
            Console.ReadLine();
            
            //3. Do the same thing again, but this time with a lambda expression.

            //List<Employee> ogl = employees.Where(x => x.FirstName == "Joe").ToList();

            //foreach (Employee name in ogl)
            //{
            //    Console.WriteLine(name.FirstName + " " + name.LastName);
            //}
            //Console.ReadLine();

            //4.Using a lambda expression, make a list of all employees with an Id number greater than 5.

            //List<Employee> ogl = employees.Where(x => x.Id > 5).ToList();

            //foreach (Employee id in ogl)
            //{
            //    Console.WriteLine(id.FirstName + " " + id.LastName);
            //}
            //Console.ReadLine();










        }
    }
}

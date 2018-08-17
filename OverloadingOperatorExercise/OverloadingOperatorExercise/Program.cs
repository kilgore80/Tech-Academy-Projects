using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingOperatorExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            //int emp1 = 45256;
            //int emp2 = 58536;

            Employee Dan = new Employee { Firstname = "Dan", Lastname = "Harrmon", Id = 1};
            Employee Jill = new Employee { Firstname = "Jill", Lastname = "Smith", Id = 2};
            bool results = (Dan == Jill);

            //bool results = employee.Equals(Dan == emp2);
            Console.WriteLine(results);
            Console.ReadLine();
        }
    }
}

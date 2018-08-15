using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExercise1
{
    class Program 
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.FirstName = new List<string>() { "Sample" };
            emp.LastName = new List<string>() { "Student" };
            emp.SayName();
            Console.ReadLine();
          
        }
    }
}

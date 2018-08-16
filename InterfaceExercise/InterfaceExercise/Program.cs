using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
   public class Program
    { 
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.FirstName = "Dan";
            employee.LastName = "Harmmon";
            employee.Quit();
            Console.ReadLine();
         
        }
    }
}

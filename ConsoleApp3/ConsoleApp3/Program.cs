using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employee = new Employee<string>();
            employee.Things = new List<string>();
            employee.Things.Add("John");
            employee.Things.Add("Sally");
            employee.Things.Add("Dan");

            


            Employee<int> age = new Employee<int>();
            age.Things = new List<int>();
            age.Things.Add(45);
            age.Things.Add(32);
            age.Things.Add(25);

            for (int i = 0; i < 3; i++ )

            Console.WriteLine(i);
            Console.ReadLine();


        }
    }
}

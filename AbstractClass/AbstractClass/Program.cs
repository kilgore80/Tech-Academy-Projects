﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.FirstName = new List<string>() { "Sample" };
            employee.LastName = new List<string>() { "Student" };
            employee.SayName();
            Console.ReadLine();

        }
    }
}

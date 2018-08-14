using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 goat = new Class1();
            Console.WriteLine("Please enter a number.");
            int input1 = Convert.ToInt32(Console.ReadLine());

            goat.NumMeth(input1);
        }
    }
}

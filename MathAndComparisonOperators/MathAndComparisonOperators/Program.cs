using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisonOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Anonymous Income Comparison Program");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Person 1");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Hourly Rate?");
            string perHour1 = Console.ReadLine();
            int ph1 = Convert.ToInt32(perHour1);
            Console.WriteLine("Hours worked per week?");
            string weekHours1 = Console.ReadLine();
            int wh1 = Convert.ToInt32(weekHours1);
            int total1 = ph1 * wh1;
            int annIncome1 = total1 * 52;
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Person 2");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Hourly Rate?");
            string perHour2 = Console.ReadLine();
            int ph2 = Convert.ToInt32(perHour2); 
            Console.WriteLine("Hours worked per week?");
            string weekHours2 = Console.ReadLine();
            int wh2 = Convert.ToInt32(weekHours2);
            int total2 = ph2 * wh2;
            int annIncome2 = total2 * 52;
            bool great = annIncome1 > annIncome2;
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Annual salary for person 1 is: " + annIncome1);
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Annual salary for person 2 is: " + annIncome2);
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Does person 1 make more money than person 2? " + great);
            Console.ReadLine();



        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogicExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            string appAge = Console.ReadLine();
            int age = Convert.ToInt32(appAge);
            Console.WriteLine("Have you ever had A DUI? true or false");
            //bool ydui = true;
            //bool ndui = false;
            //string yesDui = Convert.ToString(ydui);
            //string noDui = Convert.ToString(ndui);
            bool dui = bool.Parse(Console.ReadLine());
            Console.WriteLine("How many speeding tickets do you have?");
            string speedTix = Console.ReadLine();
            int tix = Convert.ToInt32(speedTix);
            bool qualified = (age > 15 && tix < 3 && dui == false);
            Console.Write("Are you qualified? " + qualified);
            Console.ReadLine();
             
        }
    }
}

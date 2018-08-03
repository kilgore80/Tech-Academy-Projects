using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("What is the weight of your package?");
            string lb = Console.ReadLine();
            int packWeight = Convert.ToInt32(lb);
            if (packWeight > 50)
            {
                Console.WriteLine("Package is too big to be shipped via Package Express. Have a good day");
            }
            else if (packWeight < 50)
            {
                Console.WriteLine("Please enter your package width:");
                string width = Console.ReadLine();
                int wid = Convert.ToInt32(width);
                Console.WriteLine("Please enter your package height:");
                string height = Console.ReadLine();
                int hei = Convert.ToInt32(height);
                Console.WriteLine("Please enter your package length:");
                string length = Console.ReadLine();
                int len = Convert.ToInt32(length);
                int sum1 = (wid * hei * len);
                int sum2 = sum1 * packWeight;
                int sum3 = sum2 / 100;
             if (sum1 > 50)
                    Console.WriteLine("Sorry to inform you that the package you are trying to ship is too big to be shipped via Package Express. Thank you.");
                else
                    Console.WriteLine("Your estimated total for shipping this package is: " + "$" + sum3 + " . " + " Thank you for your business. ");
            }

                Console.ReadLine();
        }
    }
}

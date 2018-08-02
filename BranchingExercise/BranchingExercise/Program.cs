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
            if (packWeight < 50)
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
                int sum = (wid + hei + len);
            };
            if (50 > (sum))
            {
                Console.WriteLine("")
            }

            


            else
            {
                Console.WriteLine("Package is too big to be shipped via Package Express. Have a good day");
            }


            Console.ReadLine();
        }
    }
}

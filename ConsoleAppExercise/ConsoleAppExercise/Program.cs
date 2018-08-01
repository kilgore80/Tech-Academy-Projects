using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Takes an input from the user, multiplies it by 50, and prints the result to the console. (Note: make sure your code can take inputs larger than 10,000,000).
            Console.WriteLine("Please enter a number.");
            string multi = Console.ReadLine();
            uint num1 = Convert.ToUInt32(multi);
            UInt32 total = num1 * 50;
            Console.WriteLine("The number you chose multiplied by 50 is: " + total);
            //2. Takes an input from the user, adds 25 to it, and prints the result to the console.
            Console.WriteLine("Please enter another number.");
            string add = Console.ReadLine();
            int num2 = Convert.ToInt32(add);
            int total2 = num2 + 25;
            Console.WriteLine("The number you chose plus 25 is: " + total2);
            //3. Takes an input from the user, divides it by 12.5, and prints the result to the console.
            Console.WriteLine("Please write another number.");
            string div = Console.ReadLine();
            int num3 = Convert.ToInt32(div);
            double total3 = num3 / 12.5;
            Console.WriteLine("The number you chose divided by 12.5 is: " + total3);
            //4. Takes an input from the user, checks if it is greater than 50, and prints the true/false result to the console.
            Console.WriteLine("Please Enter another number.");
            string great = Console.ReadLine();
            int num4 = Convert.ToInt32(great);
            bool fer = num4 > 50;
            Console.WriteLine("Your number is greater than 50: " + fer);
            //5. Takes an input from the user, divides it by 7, and prints the remainder to the console (tip: think % operator).
            Console.WriteLine("Please enter one last number.");
            string rem = Console.ReadLine();
            int num5 = Convert.ToInt32(rem);
            int mod = num5 % 7;
            Console.WriteLine("Your number divided by 7 has the remainder of: " + mod);

            Console.ReadLine();


        }
    }
}

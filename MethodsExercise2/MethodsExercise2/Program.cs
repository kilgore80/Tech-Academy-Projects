using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsExercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 Cat = new Class1();
            Console.WriteLine("Please write a number.");
            int input1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("If you'd like, enter another number.");
            string input2 = Console.ReadLine();
            if (input2 == "")
            {
                int Results = Cat.NumMethod(input1);
                Console.WriteLine(Results);
            }
            else if (input2 != "")
            {
                int input3 = Convert.ToInt32(input2);
                int Results2 = Cat.NumMethod(input1, input3);
                Console.WriteLine(Results2);
            }
            Console.ReadLine();

            //made changes
        }
    }
}

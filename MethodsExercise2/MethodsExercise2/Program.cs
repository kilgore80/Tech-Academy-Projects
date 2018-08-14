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
            int input2 = Convert.ToInt32(Console.ReadLine());

            //int input1 = 10;
            int Results = Cat.NumMethod(input1, input2);
            Console.WriteLine(Results);
            Console.ReadLine();
        }
    }
}

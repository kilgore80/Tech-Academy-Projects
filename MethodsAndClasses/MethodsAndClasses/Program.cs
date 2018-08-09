using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 NumMath = new Class1();

           
            Console.WriteLine("What number would you like to do math operations on?");
            int userInput = Convert.ToInt32(Console.ReadLine());
            int results = NumMath.Num1(userInput);
            int results2 = NumMath.Num2(userInput);
            int results3 = NumMath.Num3(userInput);
            Console.WriteLine(userInput + " Added to five is: " + results);
            Console.WriteLine(userInput + " Multiplied by eight is: " + results2);
            Console.WriteLine(userInput + " Subtracted by two: " + results3);
            //int userInput2 = Convert.ToInt32(Console.ReadLine());
            //int results2 = NumMath.Num2(userInput2);
           // Console.WriteLine(results2);
            Console.ReadLine();
        }

       

    }
}

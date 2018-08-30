using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingExercise2
{
    class Program : Age
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter your age.");
                int age1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(DateTime.Today.AddYears(-age1).Year);
                if (age1 <= 0)
                {
                    throw new ArithmeticException();
                }
            }
            catch (ArithmeticException)
            {
                Console.WriteLine("Must be greater than 0.");
                Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("An error has occured.");
                Console.ReadLine();
            }
            Console.ReadLine();
        }
    }
}

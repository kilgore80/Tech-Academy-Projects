using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> numList = new List<int>() { 21, 2, 38, 72, 96, 12 };
                Console.WriteLine("Please enter a number");
                int num1 = Convert.ToInt32(Console.ReadLine());    // error message

                foreach (int num in numList)
                {
                    Console.WriteLine(num / num1);      // error message
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("A whole number please");
                
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("We can't divide by zero");  
            }
            catch (Exception i)
            {
                Console.WriteLine(i.Message);  
            }
            finally
            {
                Console.WriteLine("You have emerged from the try/catch block. Program has proceeded to execution.");
            }
           
            Console.ReadLine();
        }

    }
}

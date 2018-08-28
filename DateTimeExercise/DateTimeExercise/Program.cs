using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now + "\nIs the Current time. Would you be so kind to enter a number?");
            int userNumber = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine(DateTime.Now.AddHours(userNumber) + " will be the time in " + userNumber +  " more hours");
            Console.ReadLine();
        }
    }
}

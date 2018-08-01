using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAndDataTypesExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("The Tech Academy");
            //Console.ReadLine();
            Console.WriteLine();
            Console.Write("Student Daily Report");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("What Course are you on? ");
            string courseName = Console.ReadLine();
            Console.WriteLine("What page number are you on?");
            string pageNumber = Console.ReadLine();
            int pageNum = Convert.ToInt32(pageNumber);
            Console.WriteLine("Do you need help with anything? Please answer true or false");
            bool helpNeeded = true;
            bool helpNotNeeded = false;
            string needHelp = Convert.ToString(helpNeeded);
            string notNeedingHelp = Convert.ToString(helpNotNeeded);
            Console.ReadLine();
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics");
            string positiveExperiences = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string feedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            string hoursWorked = Console.ReadLine();
            int workHours = Convert.ToInt32(hoursWorked);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.Read();


        }
    }
}

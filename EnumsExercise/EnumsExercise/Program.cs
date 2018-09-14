using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
           try
            { 
            Console.WriteLine("Would you please enter what day it is?");
            string x = Console.ReadLine();
            DaysOfTheWeek day = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), x);

           
                day = DaysOfTheWeek.thursday;
                Console.WriteLine(day + " Is the actual day of the week.");
                Console.ReadLine();
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Please enter an actual day of the week." + ex.Message);
                Console.ReadLine();

            }
        }
      

        public enum DaysOfTheWeek
        {
            monday,
            tuesday, 
            wednesday,
            thursday,
            friday, 
            saturday, 
            sunday
        }
    }
}

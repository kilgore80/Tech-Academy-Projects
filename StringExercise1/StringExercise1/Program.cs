using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Where do you live?");
            string home = Console.ReadLine();
            Console.WriteLine("How old are you?");
            string howOld = Console.ReadLine();
            int age = Convert.ToInt32(howOld);

            home = home.ToUpper();

            StringBuilder you = new StringBuilder();
            you.Append("I like the name " + name + ", it's one of my favorites. \nI also hear you're from " + home + "?\n" + home + " , is a great place to live.\nYou said you were " + age + " years old?\n" + age + " is a great age to be.\nThanks for telling me a little about yourself.");

            Console.WriteLine(you);
            Console.ReadLine();

        }
    }
}

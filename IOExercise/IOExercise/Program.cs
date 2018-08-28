using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IOExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Would you please enter a number?");
            string answer = Console.ReadLine();
            File.WriteAllText(@"C:\Users\kilgo\OneDrive\Documents\GitHub\Tech-Academy-Projects\IOExercise\number\number.txt", answer);
            string answer2 = File.ReadAllText(@"C:\Users\kilgo\OneDrive\Documents\GitHub\Tech-Academy-Projects\IOExercise\number\number.txt");
            Console.WriteLine("This was the number you picked: " + answer2);
            Console.ReadLine();
        }
    }
}

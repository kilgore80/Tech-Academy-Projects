using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopingExercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Whats My favorite animal?");
            string animal = Console.ReadLine();
            bool gotIt = animal == "monkey";

            do
            {
                switch (animal)
                {
                    case "tiger":
                        Console.WriteLine("You chose a tiger. Although a great animal, thats not my favorite. Hint: I like to be in trees.");
                        Console.WriteLine("Whats My favorite animal?");
                        animal = Console.ReadLine();
                        break;
                    case "shark":
                        Console.WriteLine("You chose a shark. Although a great animal, that is not my favorite. Hint: I like the land.");
                        Console.WriteLine("Whats My favorite animal?");
                        animal = Console.ReadLine();
                        break;
                    case "snake":
                        Console.WriteLine("You chose a snake. Although a great animal, that is not my favorite. Hint: I am a mammal.");
                        Console.WriteLine("Whats My favorite animal?");
                        animal = Console.ReadLine();
                        break;
                    case "elephant":
                        Console.WriteLine("You chose a elephant. Although a great animal, that is not my favorite. Hint: I am furry.");
                        Console.WriteLine("Whats My favorite animal?");
                        animal = Console.ReadLine();
                        break;
                    case "monkey":
                        Console.WriteLine("You got it! A monkey is my favorite animal!");
                        gotIt = true;
                        break;
                    default:
                        Console.WriteLine("Thats not my favorite animal.");
                        Console.WriteLine("Try again please.");
                        animal = Console.ReadLine();
                        break;




                }
            }
            while (!gotIt);
            {
              
            }
            Console.ReadLine();
        }
    }
}

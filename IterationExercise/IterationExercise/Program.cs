using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        ////1. Create a one-dimensional Array of strings. Ask the user to input some text. Create a loop that goes through each string in the Array,
        ////adding the user’s text to the string. Then create a loop that prints off each string in the Array on a separate line.

        //string[] animals = { "Horse", "Dog", "Bird", "Snake", "Fish"};
        //Console.WriteLine("Please type an adjective relating to size.");
        //string size = Console.ReadLine();

        //for (int i = 0; i < animals.Length; ++i)
        //{
        //    Console.WriteLine(size + animals[i]);
        //}

        //Console.ReadLine();

        ////2. Create an infinite loop.

        //string[] cars = { "ford", "chevy", "dodge", "vw", "honda" };

        //for (int j = 0; j < cars.Length;)
        //{
        //    Console.WriteLine(cars[j]);
        //}
        //Console.ReadLine();

        ////3. Fix the infinite loop so it will execute.

        //string[] cars = { "ford", "chevy", "dodge", "vw", "honda" };

        //for (int j = 0; j < cars.Length; j++)
        //{
        //    Console.WriteLine(cars[j]);
        //}
        //Console.ReadLine();

        ////4. Create a loop where the comparison used to determine whether to continue iterating the loop is a “<” operator.

        //int[] temp = { 50, 45, 80, 75, 64, 32, 78, 95 };

        //for (int k = 0; k < temp.Length; k++)
        //{
        //    if (temp [k] < 72)
        //    {
        //        Console.WriteLine("Time to turn on the heater: " + temp[k] +"F");
        //    }
        //}Console.ReadLine();

        ////5. Create a loop where the comparison used to determine whether to continue iterating the loop is a “<=” operator.

        //int[] he = { 54, 25, 40, 60, 14 };

        //for (int n = 0; n < he.Length; n++)
        //{
        //    if (he [n] <= 40)
        //    {
        //        Console.WriteLine("Cant go on the roller coaster: " + he[n] + " inches");
        //    } 
        //}
        //Console.ReadLine();

        ////6. Create a List of strings where each item in the list is unique. Ask the user to select text to search for in the List. 
        ////Create a loop that iterates through the loop and then displays the index of the array that contains matching text on the screen.

        //List<string> stuff = new List<string>() { "pitbull", "cola", "f-150", "eagle" };
        //Console.WriteLine("Would you like the index for cola, eagle, pitbull, f-150?");
        //string answer = Console.ReadLine();
        //foreach (string mel in stuff)
        //{
        //    if (answer == stuff[0])
        //    {
        //        Console.WriteLine(stuff.IndexOf(answer));
        //        Console.ReadLine();
        //    }
        //    if (answer == stuff[1])
        //    {
        //        Console.WriteLine(stuff.IndexOf(answer));
        //        Console.ReadLine();
        //    }
        //    if (answer == stuff[2])
        //    {
        //        Console.WriteLine(stuff.IndexOf(answer));
        //        Console.ReadLine();
        //    }
        //    if (answer == stuff[3])
        //    {
        //        Console.WriteLine(stuff.IndexOf(answer));
        //        Console.ReadLine();
        //    }
        //    else
        //        Console.WriteLine("Sorry. Please pick cola, pitbull, f-150, eagle. Thank you.");
        //    Console.ReadLine();
        //}

        ////7. Add code to that above loop that tells a user if they put in text that isn’t in the List.

        //List<string> stuff = new List<string>() { "pitbull", "cola", "f-150", "eagle" };
        //Console.WriteLine("Would you like the index for cola, eagle, pitbull, f-150?");
        //string answer = Console.ReadLine();
        //foreach (string mel in stuff)
        //{
        //    if (answer == stuff[0])
        //    {
        //        Console.WriteLine(stuff.IndexOf(answer));
        //        Console.ReadLine();
        //    }
        //    if (answer == stuff[1])
        //    {
        //        Console.WriteLine(stuff.IndexOf(answer));
        //        Console.ReadLine();
        //    }
        //    if (answer == stuff[2])
        //    {
        //        Console.WriteLine(stuff.IndexOf(answer));
        //        Console.ReadLine();
        //    }
        //    if (answer == stuff[3])
        //    {
        //        Console.WriteLine(stuff.IndexOf(answer));
        //        Console.ReadLine();
        //    }
        //    else
        //        Console.WriteLine("Sorry. Please pick cola, pitbull, f-150, eagle. Thank you.");
        //    Console.ReadLine();
        //}

        ////8. Add code to that above loop that stops it from executing once a match has been found.

        //List<string> stuff = new List<string>() { "pitbull", "cola", "f-150", "eagle" };
        //Console.WriteLine("Would you like the index for cola, eagle, pitbull, f-150?");
        //string answer = Console.ReadLine();
        //foreach (string mel in stuff)
        //{
        //    if (answer == stuff[0])
        //    {
        //        Console.WriteLine(stuff.IndexOf(answer));
        //        Console.ReadLine();
        //        break;
        //    }
        //    if (answer == stuff[1])
        //    {
        //        Console.WriteLine(stuff.IndexOf(answer));
        //        Console.ReadLine();
        //        break;
        //    }
        //    if (answer == stuff[2])
        //    {
        //        Console.WriteLine(stuff.IndexOf(answer));
        //        Console.ReadLine();
        //        break;
        //    }
        //    if (answer == stuff[3])
        //    {
        //        Console.WriteLine(stuff.IndexOf(answer));
        //        Console.ReadLine();
        //        break;
        //    }
        //    else
        //        Console.WriteLine("Sorry. Please pick cola, pitbull, f-150, eagle. Thank you.");
        //    Console.ReadLine();
        //}

        ////9. Create a List of strings that has at least two identical strings in the List. Ask the user to select text to search for in the List.
        ////Create a loop that iterates through the loop and then displays the indices of the array that contain matching text on the screen.

        //List<string> animals = new List<string>() { "lion", "monkey", "snake", "lion", "bear", "snake", "deer" };
        //Console.WriteLine("Please choose lion, monkey, snake, or deer.");
        //string choice = Console.ReadLine();


        //for (int i = 0; i < animals.Count; i++)
        //{
        //    if (choice == animals[i])
        //    {
        //        Console.WriteLine(animals[i] + " is at index " + i.ToString());

        //    }
        //}

         //Console.ReadLine();

        ////10. Add code to that above loop that tells a user if they put in text that isn’t in the List.

        //List<string> animals = new List<string>() { "lion", "monkey", "snake", "lion", "bear", "snake", "deer" };
        //Console.WriteLine("Please choose lion, monkey, snake, or deer.");
        //string choice = Console.ReadLine();


        //for (int i = 0; i < animals.Count; i++)
        //{
        //    if (choice == animals[i])
        //    {
        //        Console.WriteLine(animals[i] + " is at index " + i.ToString());
        //    }
        //    else
        //        Console.WriteLine("Sorry. Please choose from the animals above.");
        //}
        //Console.ReadLine();

        //// 11. Create a List of strings that has at least two identical strings in the List. Create a foreach loop that evaluates each item in the 
        //// list, and displays a message showing the string and whether or not it has already appeared in the list.

        List<string> food = new List<string>() { "pizza", "burger", "salad", "burger", "fruit" };
        Console.WriteLine("Please choose pizza, burger, salad, fruit.");
        string yum = Console.ReadLine();
        foreach (string eat in food)
        {
            if (yum == "pizza")
            {
                Console.WriteLine(yum + " has not already appeared");
                Console.ReadLine();
            }
            //if (yum == "burger")
            //{
            //    Console.WriteLine(yum + "has not already appeared");
            //}
            if (yum == "salad")
            {
                Console.WriteLine(yum + " has not already appeared");
                Console.ReadLine();
            }
            if (yum == "burger")
            {
                Console.WriteLine(yum + " has already appeared");
                Console.ReadLine();
            }
            if (yum == "fruit")
            {
                Console.WriteLine(yum + " has not already appeared");
                Console.ReadLine();
            }
        }
        Console.ReadLine();
    }

    
}

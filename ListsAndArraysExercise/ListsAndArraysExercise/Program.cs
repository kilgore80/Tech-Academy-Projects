using System;
using System.Collections.Generic;


    class Program
    {
    static void Main()
    {
        string[] stringArray1 = { "Hello", "Thanks", "You're welcome", "Good bye" };
        int[] numArray1 = { 20, 40, 60, 80, 100 };
        List<string> animals = new List<string>
        (new string[]{ "dog", "cat", "bird", "chicken", "snake"});
        Console.WriteLine("Whould you please pick an index 0-3?");
        string arr1 = Console.ReadLine();
        int array1 = Convert.ToInt32(arr1);
        if(array1 > 3)
        {
            Console.WriteLine("Please choose an index beetween 0 and 3.");
            string wa = Console.ReadLine();
            int wrong = Convert.ToInt32(wa);
            Console.WriteLine(stringArray1[wrong] + " was the value indexed at " + wrong + ".");   
        }
        else if(array1 <= 3)
        {
            Console.WriteLine(stringArray1[array1] + " was the value indexed at " + array1 + ".");
        }
        Console.WriteLine("Would you please pick an index 0-4?");
        string arr2 = Console.ReadLine();
        int array2 = Convert.ToInt32(arr2);
        if (array2 > 4)
        {
            Console.WriteLine("Please choose an index between 0 and 4.");
            string wa2 = Console.ReadLine();
            int wrong2 = Convert.ToInt32(wa2);
            Console.WriteLine(numArray1[wrong2] + " was the value indexed at " + wrong2 + ".");
        }
        else if (array2 <= 4)
        {
            Console.WriteLine(numArray1[array2] + " was the value indexed at " + array2);
        }
        Console.WriteLine("Would you please choose an index 0-4?");
        string list1 = Console.ReadLine();
        int lis = Convert.ToInt32(list1);
        if(lis > 4)
        {
            Console.WriteLine("Wrong. Please choose an index that is between 0 and 4.");
            string wa3 = Console.ReadLine();
            int wrong3 = Convert.ToInt32(wa3);
            Console.WriteLine(animals[wrong3] + " was the value indexed at " + wrong3 + ".");
        }
        else if(lis < 4)
        {
            Console.WriteLine(animals[lis] + " was the value indexed at " + lis + ".");
        }

        Console.ReadLine();
    }
    }


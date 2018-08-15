using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethods
{
    class Program
    {
        static void Main(string[] args)
        //{
        //Class1 goat = new Class1();
        //    Console.WriteLine("Please enter a number.");
        //    int input1 = Convert.ToInt32(Console.ReadLine());

        //    goat.NumMeth(input1);
        //}

        //4. Create a method =  with output parameters.

        //{
        //  Class1 goat = new Class1();

        //  int a, b;
        //  goat.NumMeth2(out a, out b);
        //  Console.WriteLine("a Value: {0}", a);
        //  Console.WriteLine("b Value: {0}", b);
        //  Console.ReadLine();
        //}

        //5. Overload a method.
        // {
        //Class1 goat = new Class1();

        //int input1 = 20;
        //int input2 = 10;
        //int Answer1 = goat.NumMeth3(input1, input2);
        //Console.WriteLine("The integer answer is: " + Answer1);
        //Console.ReadLine();

        //float input3 = 24.5f;
        //float input4 = 2.5f;
        //float Answer2 = goat.NumMeth3(input3, input4);
        //Console.WriteLine("The float answer is: " + Answer2);
        //Console.ReadLine();

        //string input5 = "Whats's";
        //string input6 = " up you?";
        //string Answer3 = goat.NumMeth3(input5, input6);
        //Console.WriteLine("The string answer is: " +  Answer3);
        //Console.ReadLine();
        //6. Declare a class to be static

        {
            int x = 10;
            int y = 5;
            int Answer4 =  StaticClass1.Dang(x, y);
            Console.WriteLine("Your static class answer is : " + Answer4);
            Console.ReadLine();

        }
        //}




    }
}

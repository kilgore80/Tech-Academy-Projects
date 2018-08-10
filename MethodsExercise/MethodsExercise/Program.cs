using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsExercise
{
    class Program 
    {
        static void Main(string[] args)
        {
            ////Method One

            ClassNum Dog = new ClassNum();
            //int input1 = 8;
            //int Results = Dog.NumMethod(input1);
            //Console.WriteLine(Results);
            //Console.ReadLine();

            //Method Two

            float input2 = 4.25f;
            float Results2 = Dog.NumMethod(input2);
            Console.WriteLine(Results2);
            Console.ReadLine();

            //Method Three

            string input3 = "20";
            //int ren = Convert.ToInt32(input3);
            int Results3 = Dog.NumMethod(input3);
            Console.WriteLine(Results3);
            Console.ReadLine();

        }
    }
}

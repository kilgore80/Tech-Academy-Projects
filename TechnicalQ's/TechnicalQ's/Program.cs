using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalQ_s
{
    class Program
    {
        static void Main(string[] args)
        {


            //1. Given an array of integers, write a method to total the odd numbers.

            //int sum = 0;
            //int[] oddNums = new int[5] { 25, 32, 36, 17, 8}
            //for (int i = 0; i < oddNums.Length; i++)
            //{
            //    if (oddNums[i] % 2 != 0)
            //        sum = sum + oddNums[i];

            //}
            //Console.WriteLine(sum);
            //Console.ReadLine();

            //2.Given an array of integers, write a method to sum the elements in the array,
            //knowing that some of the elements may be very large integers.

            //int sum = 0;
            //int[] oddNums = new int[5] { 25, 32, 36, 17, 8 };
            //for (int i = 0; i < oddNums.Length; i++)
            //{
            //    sum += oddNums[i];
            //}
            //Console.WriteLine(sum);
            //Console.ReadLine();

            //3. Given a string, reverse it.

            //Console.WriteLine("Enter a string: ");
            //string word = Console.ReadLine();
            //char[] rs = word.ToArray();
            //Array.Reverse(rs);
            //Console.WriteLine(rs);
            //Console.ReadKey();

            //4. Given a string, remove any repeated letters.

            //Console.WriteLine("Enter a string: ");
            //string value = Console.ReadLine();
            //string op = string.Empty;
            //foreach (char c in value)
            //{
            //    if (op.IndexOf(c) == -1)
            //    {
            //        op += c.ToString();
            //    }
            //}
            //Console.Write(op);
            //Console.ReadLine();

            //5. FizzBuzz (Look this one up and try it out)

            for (int i = 1; i <= 200; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }

                Console.ReadLine();
            }


        }
    }
}

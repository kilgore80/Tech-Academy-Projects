using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExercise1
{
    public class Person
    {
                                  
        public List<string> FirstName { get; set; }
        public List<string> LastName { get; set; }

        public void SayName()
        {
             foreach (string fName in FirstName)
            {
                //Console.WriteLine("Full name: " + fName);
            
             foreach (string lName in LastName)
            
                Console.WriteLine("Full Name : " + fName + " " + lName );
            }
           
            Console.ReadLine();
        }
    }
}

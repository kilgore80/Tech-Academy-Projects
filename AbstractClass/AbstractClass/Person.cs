using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual void SayName()
        {
           // foreach (string fn in FirstName)
            //{
            //foreach (string ln in LastName)

                Console.WriteLine("Full Name : " + FirstName + " " + LastName);
            //}
            
        }
    }
}

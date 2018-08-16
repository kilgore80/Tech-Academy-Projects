using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    class Employee : IQuittable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual void Quit()
        {
            Console.WriteLine("Hello " + FirstName + " " + LastName);
        }

    }
}

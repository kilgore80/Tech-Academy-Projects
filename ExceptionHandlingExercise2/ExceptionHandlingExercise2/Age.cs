using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingExercise2
{
   public class Age
    {
        public int Yob(int x)
        {
            if (x <= 0)
                throw new ApplicationException();
            return x;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsExercise2
{
    public class Class1
    {
        public Class1()
        {

        }
        public int NumMethod(int Num1, int Num2 = 2)
        {
            int results = Num1 * Num2;
            return results;
        }
    }
}

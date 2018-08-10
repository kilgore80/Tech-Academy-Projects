using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsExercise
{
   public class ClassNum
    {
        public ClassNum()
        {

        }
        public int NumMethod(int Num1)
        {
            int results = Num1 * 13;
            return results;
        }
        public float NumMethod(float Num2)
        {
            float results2 = Num2 + 8.37f;
            int Convo = Convert.ToInt32(results2);
            return Convo;
        }
        public int NumMethod(string goat)
        {
            int cat = Convert.ToInt32(goat);
            int results3 = cat + 20;
            return results3;
        }
    }
}

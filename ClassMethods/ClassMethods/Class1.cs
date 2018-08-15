using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethods
{
    public class Class1
    {
        public Class1()
        {

        }

        public void NumMeth(int Num1)
        {
            int results = Num1 / 2;
            Console.WriteLine(Num1 + " divided by two = " + results);
            Console.ReadLine();
        }
        public void NumMeth2(out int i, out int x)
        {
            i = 10;
            x = 5;
            i *= i;
            x *= x;
        }
        public int NumMeth3(int Wal, int Gal )
        {
            int results2 = Wal + Gal;
            return results2;
            
        }
        public float NumMeth3(float Tree, float Day)
        {
            float results3 = Tree + Day;
            return results3;
        }
        public string NumMeth3(string rat, string kid)
        {
            string results4 = rat + kid;
            return results4;
        }
    }
}

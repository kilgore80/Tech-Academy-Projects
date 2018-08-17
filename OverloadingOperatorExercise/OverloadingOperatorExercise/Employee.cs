using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingOperatorExercise
{
    public class Employee
    {
        public string Firstname { get; set; }
        public int Id { get; set; }
        public string Lastname { get; set; }

        public static bool operator== (Employee employee1, Employee employee2)
        {
            return Equals(employee1.Id, employee2.Id);
            //bool results;
            //if(employee1.Id == employee2.Id)
            //{
            //    results = true;
            //    return results;
            //}

            //else
            //{
            //    results = false;
            //    return results;
            //}

        }

        public static bool operator!= (Employee employee1, Employee employee2)
        {
            return !Equals(employee1.Id, employee2.Id);
            //bool results2;
            //if (employee1.Id != employee2.Id)
            //{
            //    results2 = true;
            //    return results2;
            //}
            //else
            //{
            //    results2 = false;
            //    return results2;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
    }

   


    }



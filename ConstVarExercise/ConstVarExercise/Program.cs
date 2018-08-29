using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstVarExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Players player = new Players("Matt Cain", 10);
            const string stadium = "AT&T Park";
            var sportsTeam = "San Francisco Giants";
            //Console.WriteLine(player);
            Console.WriteLine("Welcome to beautiful {0}. Home of your {1}. Today on the mound {2}", stadium, sportsTeam, player.Name);
            Console.ReadLine();
        }
    }
}

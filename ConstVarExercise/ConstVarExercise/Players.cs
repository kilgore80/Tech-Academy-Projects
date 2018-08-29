using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstVarExercise
{
   public class Players
    {
        public Players(string name, int playerNum) : this(name, playerNum, "Pitcher")
        {

        }
        public Players(string name, int playerNum, string position)
        {
            Name = name;
            PlayersNumber = playerNum;
            Position = position; 
        }
        public string Name { get; set; }
        public int PlayersNumber { get; set; }
        public string Position { get; set; }

    }
}

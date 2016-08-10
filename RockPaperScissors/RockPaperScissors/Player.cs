using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Player
    {
        string name; //declare variables

        public Player (string name) //constructor
        {
            this.name = name; //assign variable
        }
       
        public string getName() //getNamemethod
        {
            return this.name;
        }

    }
}

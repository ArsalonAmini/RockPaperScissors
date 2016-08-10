using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Game
    {
        //declaring variables
        Player playerOne;
        Player playerTwo;
        int round;
        int numberOfRounds;

        public Game() //constructor
        {
            this.playerOne = new Player("Player 1");
            this.playerTwo = new Player("Player 2");
            this.numberOfRounds = 3;
            this.round = 1;
        }

        public void RunGame() //RunGame Method
        {
            Console.WriteLine("Welcome to Rock Paper Scissors");

            while (this.round <= this.numberOfRounds) //Gaming Loop
            {
                Console.WriteLine("Round {0}", this.round);
                Round turn = new Round(this.playerOne, this.playerTwo);
                turn.TakeTurn();
                
               turn.DetermineWinner();
               
                this.round++;
            }
        }
        

    }           
}

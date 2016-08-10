using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Round
    {
        Player playerOne; //declaring variables 
        Player playerTwo;
        string playerOneMove;
        string playerTwoMove;

        public Round(Player playerOne, Player playerTwo) //constructor
        {
            this.playerOne = playerOne;
            this.playerTwo = playerTwo;
        }
        public void TakeTurn() //Turn method, returns user input
        {
            playerOneMove = makeChoice();
            playerTwoMove = makeChoice();
        }
       public string makeChoice();
       { 
         Console.WriteLine("Chose (Rock, Paper or Scissors)");
         return Console.ReadLine();
        }
   
        public void DetermineWinner() //method for determining winner
        {
            if (playerOneMove == playerTwoMove)
            {
                Console.WriteLine("Tie game.");
                Console.WriteLine("Your hand was: {0}", playerOneMove);
                Console.WriteLine("Your hand was: {0}", playerTwoMove);
            }
            else if (playerOneMove == "Rock" && playerTwoMove == "Paper" || playerOneMove == "Scissors" && playerTwoMove == "Rock" || playerOneMove == "paper" && playerTwoMove == "scissors")
            {
                Console.WriteLine("{0} You win!", playerTwo.getName());
                Console.WriteLine("Your hand was: {0}", playerTwoMove);
                Console.WriteLine("Your opponent's hand was: {0}", playerOneMove);
            }
            else if (playerTwoMove == "Rock" && playerOneMove == "Paper" || playerTwoMove == "Scissors" && playerOneMove == "Rock" || playerTwoMove == "paper" && playerOneMove == "scissors")
            {
                Console.WriteLine("{0} You win!", playerOne.getName());
                Console.WriteLine("Your hand was: {0}", playerTwoMove);
                Console.WriteLine("Your opponent's hand was: {0}", playerOneMove);
            }
            else
            {
                Console.WriteLine("Invalid Entry: Must be 'Rock', 'Paper', or 'Scissors'.");
                Console.WriteLine("Please try again: ");
                playerOneMove = Console.ReadLine();
                playerTwoMove = Console.ReadLine();
            }

        }

    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS_CS
{
    internal class RunGame
    {
        //member variables
        Human playerOne;
        Human playerTwo;

        //constructor
        public RunGame()
        {
            this.playerOne = new Human();
            this.playerTwo = new Human();
            this.PlayGame();
        }


        //membermethods

        public void PlayGame()
        {
            while (this.playerOne.score < 2 && playerTwo.score < 2)
            {
                var winner = this.CompareGestures(this.playerOne.ChooseGesture(), playerTwo.ChooseGesture());
                if (winner == "Player 1")
                {
                    this.playerOne.score++;
                    Console.WriteLine("This round is won by Player One!!");
                    Console.WriteLine("****************************************************");
                }
                else if (winner == "Player 2")
                {
                    playerTwo.score++;
                    Console.WriteLine("This round is won by Player Two!!");
                    Console.WriteLine("****************************************************");
                }
                else
                {
                    Console.WriteLine("This round was a tie!!");
                    Console.WriteLine("****************************************************");
                }
            };
            DisplayWinner();
        }

        //public bool IsSinglePlayer()
        //{
        //    string input;
        //    do
        //    {
        //        Console.WriteLine();
        //        Console.WriteLine("Enter 1 for single player game, 2 for multi-player game: ");
        //        input = Console.ReadLine();
        //    }
        //    while (!input.Equals("1") && !input.Equals("2"));
        //    bool singlePlayer;
        //    if (input.Equals("1"))
        //    {
        //        singlePlayer = true;
        //    }
        //    else
        //    {
        //        singlePlayer = false;
        //    }
        //    return singlePlayer;
        //}

        public string CompareGestures(int gesture1, int gesture2)
        {
            if (gesture1 == gesture2)
            {
                return "Tie";
            }
            else if(gesture1 == 0 && (gesture2 == 2 || gesture2 == 3))
            {
                return "Player 1";
            }
            else if (gesture1 == 1 && (gesture2 == 0 || gesture2 == 4))
            {
                return "Player 1";
            }
            else if (gesture1 == 2 && (gesture2 == 1 || gesture2 == 3))
            {
                return "Player 1";
            }
            else if (gesture1 == 3 && (gesture2 == 4 || gesture2 == 1))
            {
                return "Player 1";
            }
            else if (gesture1 == 4 && (gesture2 == 2 || gesture2 == 0))
            {
                return "Player 1";
            }
            else
            {
                return "Player 2";
            }


        }

        public void DisplayWinner()
        {
            Console.WriteLine("****************************************************");
            Console.WriteLine("GAME RESULTS:");
            if (this.playerOne.score > this.playerTwo.score)
            {
                Console.WriteLine("Player One Wins the Game!!");
            }
            else
            {
                Console.WriteLine("Player Two Wins the Game!!");
            }
        }

    }   
   
}

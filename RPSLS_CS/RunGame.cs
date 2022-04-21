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

        //constructor
        public RunGame()
        {
            this.playerOne = new Human();
        }


        //membermethods
        public void PlayGame()
        {
            Console.WriteLine("Welcome to RPSLS!");
            bool play_type = this.IsSinglePlayer();
            // this isnt going to work since its strongly typed. need a new way to switch between single/multi player
            if (play_type)
            {
                Robot playerTwo = new Robot();
            }
            else
            {
                Human playerTwo = new Human();
            }
            while (this.playerOne.score < 2 && playerTwo.score < 2) ;

        }

        public bool IsSinglePlayer()
        {
            string input;
            do
            {
                Console.WriteLine();
                Console.WriteLine("Enter 1 for single player game, 2 for multi-player game: ");
                input = Console.ReadLine();
            }
            while (!input.Equals("1") && !input.Equals("2"));
            bool singlePlayer;
            if (input.Equals("1"))
            {
                singlePlayer = true;
            }
            else
            {
                singlePlayer = false;
            }
            return singlePlayer;
        }

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
    }   
   
}

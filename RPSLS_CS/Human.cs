using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace RPSLS_CS
{
    internal class Human : Player
    {
        //member variables

        //constructor


        //membermethods
        public override int ChooseGesture()
        {
   
            for (int index = 0; index < gestures.Count; index++)
            {
                Console.WriteLine($"{index} for {this.gestures[index]}");
            }
            string input;
            do
            {
                Console.WriteLine("Choose your gesture by indicating 0-4 (refer to list above)");
                input = Console.ReadLine();
            }
            while (!input.Equals("0") && !input.Equals("1") && !input.Equals("2") && !input.Equals("3") && !input.Equals("4") && !input.Equals("5"));
            int playerChoice = int.Parse(input);
            Console.WriteLine($"Your choice is: {playerChoice} - {this.gestures[playerChoice]}");
            return playerChoice;
        }
        
    }
}



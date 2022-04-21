using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS_CS
{
    internal class Robot : Player
    {
        //member variables

        //constructor


        //membermethods
        public override int ChooseGesture()
        {
            Random rnd = new Random();
            int randomNumber = rnd.Next(0, 4);
            Console.WriteLine();
            Console.WriteLine($"The robot picked: {randomNumber} - {this.gestures[randomNumber]} ");
            return randomNumber;
        }
    }
}

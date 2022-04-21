using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS_CS
{
    internal class Player
    {

        //member variables
        public List<string> gestures;
        public int score;

        //constructor
        public Player()
        {
            this.score = 0;
            this.gestures = new List<string>()
            {
                new string("rock"),
                new string("paper"),
                new string("scissors"),
                new string("lizard"),
                new string("spock"),
            };
        }

        //membermethods
        public virtual int ChooseGesture()
        {
            return 0;
        }
    }
}

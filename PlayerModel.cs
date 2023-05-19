using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Eric Hernandez
//3/18/2021
//CIS 3309

//Contains all the variables for the Player such as name and wins

namespace ParkSpencer_HernandezEric_Battleship
{
    public class PlayerModel
    {
        private string hiddenName; // name for the player
        private int hiddenWins; // number of wins. currently unused
        

        public PlayerModel(string name) // assigns the name and sets hiddenWins to 0
        {
            hiddenName = name;
            hiddenWins = 0;
        }// end New

        public String Name // gets name
        {
            get { return hiddenName;  }
        }// end Name

        public int Wins // gets wins
        {
            get { return hiddenWins;  }
        } // end Wins

        //Increment number of wins for the player. Currently unused
        public void won()
        {
            hiddenWins = hiddenWins + 1;
        }// end won
    }
}

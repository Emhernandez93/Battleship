using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Contains info and methods relating to the game board
// Eric Hernandez and Spencer Park

namespace ParkSpencer_HernandezEric_Battleship
{
    public class InternalBoard
    {

        private int ships = 5; // # of surviving ships
        private ShipClass[] fleet = new ShipClass[5]; // array of ships for the board
        private int currentShip = 0; // index for fleet for determining which ship to place.

        private const int dimensions = 10; // defines the dimensions of the board
        private SpaceClass[,] board; // array of SpaceClasses representing the game board
        private PlayerModel player; // player assigned to board

        public InternalBoard(PlayerModel pl) // refers player to pl, and runs the resetGame function
        {
            player = pl;
            resetGame();
        }

        public bool hit(int row, int col) // takes the coordinates and calls the hit function in the specified Space. Alerts whether it is a hit or miss.
        {
            if (board[row, col].hit())
            {
                MessageBox.Show("Hit!");
                if (board[row, col].getShip().getSunk())
                {
                    MessageBox.Show("You sunk " + player.Name + "'s " + board[row, col].getShip().getName() + "!");
                    ships--;
                }
                return true;
            }
            else
            {
                MessageBox.Show("Miss!");
                return false;
            }
        }

        public bool lossStatus() // returns whether the game board is in a lost state
        {
            if (ships == 0)
                return true;
            return false;
        }

        // instantiates a new SpaceClass array with prespecified dimensions and provides the fleet array with newly instantiated ShipClasses. Additionally assigns ships 5
        private void resetGame()
        {
            board = new SpaceClass[dimensions, dimensions];
            fleet[0] = new ShipClass(2, "Patrol Boat");
            fleet[1] = new ShipClass(3, "Submarine");
            fleet[2] = new ShipClass(3, "Destroyer");
            fleet[3] = new ShipClass(4, "Battleship");
            fleet[4] = new ShipClass(5, "Carrier");
            ships = 5;
        }

        
        //This controls the placement of the ships for the players.  If the checkbox is clicked a ship will be placed vertically.  Also, checks to see if the placement for the ships are valid.
        //The ship placement is done in order from smallest to largest.
        public Boolean placeShip(bool isVertical, int row, int col)
        {
            ShipClass ship = fleet[currentShip];
            try
            {
                int testRow = row;
                int testCol = col;
                for (int i = 0; i < ship.getSize(); i++)
                {
                    if (board[testRow,testCol] != null)
                    {
                        return false;
                    }
                    if (isVertical)
                    {
                        testRow++;
                    }
                    else
                    {
                        testCol++;
                    }
                }
            }
            catch
            {
                return false;
            }
                for (int i = 0; i < ship.getSize(); i++)
                {
                    board[row, col] = new SpaceClass(ship, i);
                    if (isVertical)
                    {
                        row++;
                    }
                    else
                    {
                        col++;
                    }
                }
                currentShip++;
                return true;
        }

        // goes through entire board and assigns each null space with an instantiated SpaceClass with no parameter
        public void finishBoard()
        {
            for(int i = 0; i < 10; i++)
            {
                for(int j = 0; j < 10; j++)
                {
                    if(board[i,j] == null)
                    {
                        board[i, j] = new SpaceClass();
                    }
                }
            }
        }

        //It grabs the ship in the array using currentShip as the index.
        public ShipClass currentShipClass()
        {
            try
            {
                return fleet[currentShip];
            }
            catch
            {
                return null;
            }
        }
    }
}

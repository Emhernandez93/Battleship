using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Contains info and methods related to a ship


namespace ParkSpencer_HernandezEric_Battleship
{
    public class ShipClass
    {
        private int size; // length of the ship
        private bool[] hits; // array containing whether a space on the ship is hit or not
        private string name; // name of the ship
        private bool sunk; // info whether the ship is sunk or not
        

        public ShipClass(int sz, string nm) // creates a new ship with given parameters
        {
            size = sz;
            name = nm;
            sunk = false;
            hits = new bool[size];
            for(int i = 0; i < hits.Length; i++)
            {
                hits[i] = false;
            }
        }

        public void hit(int index) // marks the ship with a hit. additionally checks whether the ship is sunk yet.
        {
            hits[index] = true;

            bool sunkCheck = true;
            for (int i = 0; i < hits.Length; i++)
            {
                if (!hits[i])
                {
                    sunkCheck = false;
                    break;
                }
            }
            sunk = sunkCheck;
        }

        public bool getSunk() // gets sunk status
        {
            return sunk;
        }

        public string getName() // gets name of ship
        {
            return name;
        }

        public int getSize() // gets size of ship
        {
            return size;
        }
    }
}

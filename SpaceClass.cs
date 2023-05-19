using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Contains info and methods relating to a space on a board.


namespace ParkSpencer_HernandezEric_Battleship
{
    public class SpaceClass
    {
        private ShipClass id; // ship that is occupying this space
        private int pieceIndex; // index of ship occupying the space
        private bool isShot; // whether the space is shot at or not
        //Constructor for SpaceClass
        public SpaceClass(ShipClass occ, int index) // for when there is an occupying ship
        {
            id = occ;
            pieceIndex = index;
            isShot = false;
        }

        public SpaceClass() // for an empty space
        {
            isShot = false;
        }

        public bool hit() // returns false if there is no ship occupying the space. Additionally, the space records that the space was shot at or not.
        {
            if(id != null)
            {
                id.hit(pieceIndex);
                isShot = true;
                return true;
            }
            isShot = true;
            return false;
        }
        
        public bool getShot() //gets isShot 
        {
            return isShot;
        }

        public ShipClass getShip() //gets namne of ship
        {
            return id;
        }
    }
}

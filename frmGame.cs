using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Form code that will track turns, game progress, and when a player wins.
// Spencer Park and Eric Hernandez

namespace ParkSpencer_HernandezEric_Battleship
{
    public partial class frmGame : Form
    {
        
        // initializes form and changes labels with correspodning player names. Runs prepareBoards and sets the current player to be player 1. Also provides instructions for the game.
        public frmGame()
        {
            InitializeComponent();
            lblPlayer1.Text = Globals.player1.Name;
            lblPlayer2.Text = Globals.player2.Name;
            prepareBoards();
            pnlPlayer2.Enabled = false;
            txtCurrentPlayer.Text = Globals.player1.Name;

            MessageBox.Show("Take turns placing shots at each other's boards. The game will notify you on misses, hits, sinks, and game wins", "Instructions");
        }

        //This controls the action of the buttons on the panel. Additionally checks for a win and switches between active players
        private void Button_Click(object sender, EventArgs e)
        {
            int rowID = convertCharToInt(((Button)sender).Name[3]);
            int colID = convertCharToInt(((Button)sender).Name[4]);
            int playerNum = convertCharToInt(((Button)sender).Name[11]);
            //Controls for player 1 board.
            //If a hit was made, it would change the color of the button to red, and then disabling the buttons on the panel.
            if (playerNum == 1) {
                if (Globals.gameBoard2.hit(rowID, colID))
                {
                    ((Button)sender).BackColor = Color.Red;
                    ((Button)sender).Enabled = false;
                    //If a Winner is detected, a message is displayed of who won and closes the application
                    if (Globals.gameBoard2.lossStatus())
                    {
                        MessageBox.Show(Globals.player1.Name + " has Won!", "Winner winner, chicken dinner!");
                        Application.Exit();
                    }
                }
               
                else
                {
                    ((Button)sender).BackColor = Color.White;
                    ((Button)sender).Enabled = false;
                }
                //Disables player 1's board and activates player 2's board.
                pnlPlayer1.Enabled = false;
                pnlPlayer2.Enabled = true;
                txtCurrentPlayer.Text = Globals.player2.Name;
            }
            else
            {
                //Controls for player 2 board.
                //If a hit was made, it would change the color of the button to red, and then disabling the buttons on the panel.
                if (Globals.gameBoard1.hit(rowID, colID))
                {
                    ((Button)sender).BackColor = Color.Red;
                    ((Button)sender).Enabled = false;
                    if (Globals.gameBoard1.lossStatus())
                    {
                        MessageBox.Show(Globals.player2.Name + " has Won!", "Winner winner, chicken dinner!");
                        Application.Exit();
                    }
                }
                else
                {
                    //If a miss was made, it would change the color of the button to white and disable all buttons on the panel
                    ((Button)sender).BackColor = Color.White;
                    ((Button)sender).Enabled = false;
                }
                //Disables player 2's board and enables player 1's board.
                pnlPlayer2.Enabled = false;
                pnlPlayer1.Enabled = true;
                txtCurrentPlayer.Text = Globals.player1.Name;
            }
        }

        private int convertCharToInt(Char c) //converts the character to int
        {
            return ((int)(c) - (int)'0');
        }

        // draws the boards on the corresponding panels
        private void prepareBoards()
        {
            pnlPlayer1.Visible = true;
            Size size = new Size(40, 40);
            Point loc = new Point(0, 0);

            for (int row = 0; row < 10; row++)
            {
                loc.Y = row * (size.Height);
                for (int col = 0; col < 10; col++)
                {
                    Button newButton1 = new Button();
                    newButton1.Location = new Point(col * (size.Width), loc.Y);
                    newButton1.Size = size;
                    newButton1.Font = new Font("Arial", 20, FontStyle.Bold);
                    newButton1.Text = "";
                    newButton1.Enabled = true;
                    newButton1.Name = "btn" + row + col + "Player1";
                    newButton1.Click += new EventHandler(Button_Click);
                    pnlPlayer1.Controls.Add(newButton1);

                    Button newButton2 = new Button();
                    newButton2.Location = new Point(col * (size.Width), loc.Y);
                    newButton2.Size = size;
                    newButton2.Font = new Font("Arial", 20, FontStyle.Bold);
                    newButton2.Text = "";
                    newButton2.Enabled = true;
                    newButton2.Name = "btn" + row + col + "Player2";
                    newButton2.Click += new EventHandler(Button_Click);
                    pnlPlayer2.Controls.Add(newButton2);
                }
            }
        }
        
        //Exits the program
        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Code for form that will record names and ship locations
// Spencer Park and Eric Hernandez

namespace ParkSpencer_HernandezEric_Battleship
{
    public partial class frmNameEntry : Form
    {

        private InternalBoard currentBoard; // refers to the current player setting up the board
        private Button[,] board; // 2-dimensional array of buttons that are referred to for setting up gameboards

        public frmNameEntry()
        {
            InitializeComponent();
        }

        //Checks to see if the name is blank and instantiates a PlayerModel Class and InternalBoard class using this name.
        private void btnPlayer1NameOK_Click(object sender, EventArgs e)
        {
            string tempPlayer1Name = txtPlayer1Name.Text;
            if(tempPlayer1Name.Length == 0)
            {
                MessageBox.Show("Invalid Name: " + "Names must not be blank.", "Entry Error!");
                txtPlayer1Name.Text = "";
                txtPlayer1Name.Focus();
            }
            else
            {
                Globals.player1 = new PlayerModel(tempPlayer1Name);
                Globals.gameBoard1 = new InternalBoard(Globals.player1);

                txtPlayer1Name.Enabled = false;
                btnPlayer1NameOK.Enabled = false;
                lblPlayer2.Visible = true;
                txtPlayer2Name.Visible = true;
                btnPlayer2NameOK.Visible = true;
                txtPlayer2Name.Focus();
            }
        }
        //Checks to see if the name is blank for player 2 and instantiates a PlayerModel Class and InternalBoard Class.  It also checks to see if both players' names are the same.
        private void btnPlayer2NameOK_Click(object sender, EventArgs e)
        {
            string tempPlayer2Name = txtPlayer2Name.Text;
            if (tempPlayer2Name.Length == 0 || tempPlayer2Name == Globals.player1.Name)
            {
                MessageBox.Show("Invalid Name: " + "Names must not be blank or the same", "Entry Error!");
                txtPlayer2Name.Text = "";
                txtPlayer2Name.Focus();
            }
            else
            {
                Globals.player2 = new PlayerModel(tempPlayer2Name);
                Globals.gameBoard2 = new InternalBoard(Globals.player2);

                txtPlayer2Name.Enabled = false;
                btnPlayer2NameOK.Enabled = false;

                prepareBoard();
                txtCurrentPlayer.Text = Globals.player1.Name;
                currentBoard = Globals.gameBoard1;
                txtCurrentShip.Text = (currentBoard.currentShipClass()).getName();
                chkVertical.Enabled = true;
            }
        }
        //draws a 10x10 grid of buttons on the panel using set size limitations. Additionally assigns a reference to each button in the board array.
        private void prepareBoard()
        {
            pnlGame.Visible = true;
            Size size = new Size(40, 40);
            Point loc = new Point(0, 0);
            board = new Button[10, 10];

            for(int row = 0; row < 10; row++)
            {
                loc.Y = row * (size.Height);
                for(int col = 0; col < 10; col++)
                {
                    Button newButton = new Button();
                    newButton.Location = new Point(col * (size.Width), loc.Y);
                    newButton.Size = size;
                    newButton.Font = new Font("Arial", 20, FontStyle.Bold);
                    newButton.Text = "";
                    newButton.Enabled = true;
                    newButton.Name = "btn" + row + col;
                    newButton.BackColor = Color.LightBlue;
                    newButton.Click += new EventHandler(Button_Click);
                    
                    pnlGame.Controls.Add(newButton);
                    board[row, col] = newButton;
                }
            }
        }

        // used to place ships on the panel by changing the background color and text of the buttons. After a ship is placed, the system checks for the next ship to be placed, if there are no more ships to be placed, the panel is disabled and btnConfirm is enabled.
        private void Button_Click(object sender, EventArgs e) 
        {
            int rowID = convertCharToInt(((Button)sender).Name[3]);
            int colID = convertCharToInt(((Button)sender).Name[4]);
            ShipClass current = currentBoard.currentShipClass();

            int cellID = rowID * 10 + colID;
            if(!currentBoard.placeShip(chkVertical.Checked, rowID, colID))
            {
                MessageBox.Show("Invalid Placement: Ship must fit within the boundaries of the board and not overlap with each other", "Placement Error!");
            }
            else
            {
                ((Button)sender).BackColor = Color.Gray;
                ((Button)sender).Text = Convert.ToString((current.getName()[0]));
                ((Button)sender).Enabled = false;
                for (int i = 0; i < (current.getSize() - 1); i++)
                {
                    if (chkVertical.Checked)
                    {
                        rowID++;
                    }
                    else
                    {
                        colID++;
                    }
                    board[rowID, colID].BackColor = Color.Gray;
                    board[rowID, colID].Text = Convert.ToString((current.getName()[0]));
                    board[rowID, colID].Enabled = false;
                }
                if(currentBoard.currentShipClass() == null)
                {
                    currentBoard.finishBoard();
                    foreach(Button temp in board)
                    {
                        temp.Enabled = false;
                    }
                    txtCurrentShip.Text = "";
                    btnConfirm.Enabled = true;
                }
                else
                {
                    txtCurrentShip.Text = currentBoard.currentShipClass().getName();
                }
            }
        }
        
        private void btnStartGame_Click(object sender, EventArgs e) // closes this form and opens frmGame
        {
            this.Visible = false;
            frmGame gameForm = new frmGame();
            gameForm.Show();
        }

        private int convertCharToInt(Char c) //converts the character to int for processing.
        {
            return ((int)(c) - (int)'0');
        }


        private void btnConfirm_Click(object sender, EventArgs e) // checks who is placing ships, and either resets the board, or displays a message stating that the game is ready to start.
        {
            if(currentBoard.currentShipClass() == null)
            {
                if(txtCurrentPlayer.Text == Globals.player1.Name)
                {
                    currentBoard = Globals.gameBoard2;
                    txtCurrentPlayer.Text = Globals.player2.Name;
                    txtCurrentShip.Text = currentBoard.currentShipClass().getName();
                    pnlGame.Controls.Clear();
                    prepareBoard();
                }
                else
                {
                    MessageBox.Show("Setup Complete: Click \"Start Game\" to start game.");
                    btnConfirm.Enabled = false;
                    btnStartGame.Enabled = true;
                    chkVertical.Enabled = false;
                }
            }
        }

        // provides brief instructions on preparing the game
        private void frmNameEntry_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to Battleship. Enter your names and place your ships. Do not look at each others' ship placements.", "Welcome");
        }
    }

}

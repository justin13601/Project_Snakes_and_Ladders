using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snakes_and_Ladders_Game
{
    public partial class Form_Game : Form
    {
        int[] Map = new int[100];
        Random rndGenerator = new Random();                 //Generates a random number for the dice
        bool bFirstPlayer = true;                           //Player 1 goes first

        int Position1, Position2, Roll, i, j;

        Color Colour1 = Color.Red;                          //Default Colours for Player Avatars
        Color Colour2 = Color.Black;


        public Form_Game()
        {
            InitializeComponent();
            InitializeMap();

        }

        private void Form_Game_Load(object sender, EventArgs e)
        {
            txtTurns.Text = "It's " + txtPlayer1Name.Text + "'s Turn.";            //Initial message, sets up game for Player 1
            pbPermanentBorder.SendToBack();
            txtTurns.TextAlign = HorizontalAlignment.Center;
            txtEvents.TextAlign = HorizontalAlignment.Center;

            Position1 = 0;
            Position2 = 0;

            MessageBox.Show("Welcome to Snakes & Ladders! For instructions on how to play the game, please view the accompanied manual. Otherwise, click 'OK' to begin your first game!");
        }

        private void pbDice_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            SolidBrush BlackDot = new SolidBrush(Color.Black);
            SolidBrush WhiteSquare = new SolidBrush(Color.White);

            if (Roll == 1)          //Graphics for dice faces, using black dots
            {
                g.FillRectangle(WhiteSquare, 0, 0, 180, 180);
                g.FillEllipse(BlackDot, 75, 75, 30, 30);
            }
            else if (Roll == 2)
            {
                g.FillRectangle(WhiteSquare, 0, 0, 180, 180);
                g.FillEllipse(BlackDot, 20, 20, 30, 30);
                g.FillEllipse(BlackDot, 130, 130, 30, 30);
            }
            else if (Roll == 3)
            {
                g.FillRectangle(WhiteSquare, 0, 0, 180, 180);
                g.FillEllipse(BlackDot, 20, 20, 30, 30);
                g.FillEllipse(BlackDot, 130, 130, 30, 30);
                g.FillEllipse(BlackDot, 75, 75, 30, 30);
            }
            else if (Roll == 4)
            {
                g.FillRectangle(WhiteSquare, 0, 0, 180, 180);
                g.FillEllipse(BlackDot, 20, 20, 30, 30);
                g.FillEllipse(BlackDot, 130, 130, 30, 30);
                g.FillEllipse(BlackDot, 130, 20, 30, 30);
                g.FillEllipse(BlackDot, 20, 130, 30, 30);
            }
            else if (Roll == 5)
            {
                g.FillRectangle(WhiteSquare, 0, 0, 180, 180);
                g.FillEllipse(BlackDot, 20, 10, 30, 30);
                g.FillEllipse(BlackDot, 130, 130, 30, 30);
                g.FillEllipse(BlackDot, 130, 10, 30, 30);
                g.FillEllipse(BlackDot, 20, 130, 30, 30);
                g.FillEllipse(BlackDot, 75, 75, 30, 30);
            }
            else if (Roll == 6)
            {
                g.FillRectangle(WhiteSquare, 0, 0, 180, 180);
                g.FillEllipse(BlackDot, 20, 10, 30, 30);
                g.FillEllipse(BlackDot, 130, 130, 30, 30);
                g.FillEllipse(BlackDot, 130, 10, 30, 30);
                g.FillEllipse(BlackDot, 20, 130, 30, 30);
                g.FillEllipse(BlackDot, 20, 70, 30, 30);
                g.FillEllipse(BlackDot, 130, 70, 30, 30);
            }
        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            Roll1();                    //Calls Method to proceed with player turns

            CheckSnakeorLadder();       //Calls method to display message for events
        }


        public void InitializeMap()     //Sets up the Snakes and Ladders pathways of the board
        {
            for (int i = 0; i < 100; i = i + 1)
            {
                Map[i] = -1;
            }

            //Ladders
            Map[1] = 37;        //Lists the starting spot and ending spot for each snake/ladder
            Map[6] = 13;
            Map[7] = 30;
            Map[14] = 25;
            Map[20] = 41;
            Map[27] = 83;
            Map[35] = 43;
            Map[50] = 66;
            Map[70] = 90;
            Map[77] = 97;
            Map[86] = 93;

            //Snakes
            Map[98] = 79;
            Map[94] = 74;
            Map[91] = 87;
            Map[88] = 67;
            Map[73] = 52;
            Map[63] = 59;
            Map[61] = 18;
            Map[48] = 10;
            Map[45] = 24;
            Map[15] = 5;


            txtPlayer1Spot.Text = Convert.ToString(1);
            txtPlayer2Spot.Text = Convert.ToString(1);
            txtScore1.Text = Convert.ToString(0);
            txtScore2.Text = Convert.ToString(0);


        }

        public void CheckSnakeorLadder()            //Method that displays a message in the event texbox if either player climbs a ladder or is bit by a snake
        {
            if (Position1 == 37 || Position1 == 13 || Position1 == 30 || Position1 == 25 || Position1 == 41 || Position1 == 83 || Position1 == 43 || Position1 == 66 || Position1 == 90 || Position1 == 97 || Position1 == 93)
            {
                txtEvents.Text = txtPlayer1Name.Text + " climbed a Ladder!";
            }
            else if (Position2 == 37 || Position2 == 13 || Position2 == 30 || Position2 == 25 || Position2 == 41 || Position2 == 83 || Position2 == 43 || Position2 == 66 || Position2 == 90 || Position2 == 97 || Position2 == 93)
            {
                txtEvents.Text = txtPlayer2Name.Text + " climbed a Ladder!";
            }

            else if (Position1 == 98 || Position1 == 94 || Position1 == 91 || Position1 == 88 || Position1 == 73 || Position1 == 63 || Position1 == 61 || Position1 == 48 || Position1 == 45 || Position1 == 15)
            {
                txtEvents.Text = "Ouch, " + txtPlayer1Name.Text + " was bit by a Snake!";
            }
            else if (Position2 == 98 || Position2 == 94 || Position2 == 91 || Position2 == 88 || Position2 == 73 || Position2 == 63 || Position2 == 61 || Position2 == 48 || Position2 == 45 || Position2 == 15)
            {
                txtEvents.Text = "Ouch, " + txtPlayer2Name.Text + " was bit by a Snake!";
            }

            else
            {
                txtEvents.Clear();
            }

        }


        public void Roll1()
        {
            Roll = rndGenerator.Next(1, 7);
            pbDice.Show();
            if (bFirstPlayer == true)           //Allows Player 1 to go first
            {
                Position1 = Position1 + Roll;

                if (Position1 > 99)             //Ensures player can only win by aquiring the exact spaces needed
                {
                    Position1 = Position1 - Roll;
                    MessageBox.Show("Oops! You cannot move that far!");
                }

                if (Map[Position1] != -1)
                {
                    Position1 = Map[Position1];
                }

                txtTurns.Text = "It's " + txtPlayer2Name.Text + "'s Turn.";        //Gives Dice to player 2
                bFirstPlayer = false;
                txtPlayer1Spot.Text = Convert.ToString(Position1 + 1);

                CheckSnakeorLadder();   


            }
            else                //Player 2 Plays
            {
                Position2 = Position2 + Roll;

                if (Position2 > 99)                 //Ensures player can only win by aquiring the exact spaces needed
                {
                    Position2 = Position2 - Roll;
                    MessageBox.Show("Oops! You cannot move that far!");
                }

                if (Map[Position2] != -1)
                {
                    Position2 = Map[Position2];
                }

                txtTurns.Text = "It's " + txtPlayer1Name.Text + "'s Turn.";        //Returns Dice to Player 1
                bFirstPlayer = true;
                txtPlayer2Spot.Text = Convert.ToString(Position2 + 1);

                CheckSnakeorLadder();

            }



            if (Position1 == 99)                    //Win conditions for Player 1
            {
                MessageBox.Show("Congratulations! " + txtPlayer1Name.Text + " Wins!");
                txtPlayer1Spot.Text = Convert.ToString(1);
                txtPlayer2Spot.Text = Convert.ToString(1);
                btnRoll.Enabled = false;

                Position1 = 0;
                Position2 = 0;
                i = i + 1;                  //Adds point to Scoreboard for Player 1
                txtScore1.Text = Convert.ToString(i);

                pbDice.Hide();
            }
            else if (Position2 == 99)               //Win conditions for Player 2
            {
                MessageBox.Show("Congratulations! " + txtPlayer2Name.Text + " Wins!");
                txtPlayer1Spot.Text = Convert.ToString(1);
                txtPlayer2Spot.Text = Convert.ToString(1);
                btnRoll.Enabled = false;

                Position1 = 0;
                Position2 = 0;
                j = j + 1;                  //Adds point to Scoreboard for Player 2
                txtScore2.Text = Convert.ToString(j);

                pbDice.Hide();
            }
            pbBoard.Invalidate();
            pbDice.Invalidate();
        }


        private void pbBoard_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            SolidBrush RedCircle1 = new SolidBrush(Colour1);            //Graphics for player avatars
            SolidBrush BlackCircle2 = new SolidBrush(Colour2);

            int iRow1, iColumn1, iRow2, iColumn2;

            iRow1 = Position1 / 10;          //Determines coordinates of Player 1 from its position on game board
            iRow1 = 9 - iRow1;
            iColumn1 = Position1 % 10;
            if (iRow1 == 1 || iRow1 == 3 || iRow1 == 5 || iRow1 == 7 || iRow1 == 9)
            {
                iColumn1 = iColumn1 + 0;
            }
            else
            {
                iColumn1 = 9 - iColumn1;
            }

            g.FillEllipse(RedCircle1, iColumn1 * 72, iRow1 * 72, 72, 72);           //Draws Player 1 on game board



            iRow2 = Position2 / 10;         //Determines coordinates of Player 2 from its position on game board
            iRow2 = 9 - iRow2;
            iColumn2 = Position2 % 10;
            if (iRow2 == 1 || iRow2 == 3 || iRow2 == 5 || iRow2 == 7 || iRow2 == 9)
            {
                iColumn2 = iColumn2 + 0;
            }
            else
            {
                iColumn2 = 9 - iColumn2;
            }

            g.FillEllipse(BlackCircle2, iColumn2 * 72, iRow2 * 72, 72, 72);         //Draws Player 2 on game board
        }



        private void btnReset_Click_1(object sender, EventArgs e)
        {
            Reset();            //Calls Method to set scoreboard to zero
        }

        public void NewGame()           //Method to reboot round and and continue the game
        {
            bFirstPlayer = true;
            txtTurns.Text = "It's " + txtPlayer1Name.Text + "'s Turn.";

            pbDice.Hide();

            Position1 = 0;
            Position2 = 0;
            btnRoll.Enabled = true;
            pbBoard.Invalidate();
            txtPlayer1Spot.Text = Convert.ToString(1);
            txtPlayer2Spot.Text = Convert.ToString(1);

            MessageBox.Show("New Game Started! Good luck!");
        }



        private void btnNewGame_Click(object sender, EventArgs e)
        {
            NewGame();                  //Calls Method for a new game
        }



        public void Reset()
        {
            txtScore1.Text = Convert.ToString(0);
            txtScore2.Text = Convert.ToString(0);               //Displays scoreboard values at New Game state

            txtPlayer1Spot.Text = Convert.ToString(1);
            txtPlayer2Spot.Text = Convert.ToString(1);          //Displays position values at New Game state

            j = 0;
            i = 0;          //Resets Scoreboard variables

            MessageBox.Show("Scoreboard successfully reset!");

        }

        public void Exit()          //Method to return to Main Menu
        {
            MessageBox.Show("Thank you for playing Snakes & Ladders! You will now be returned to the Main Menu.");

            this.Close();           //Closes game form

            Form_Menu MainMenu = new Form_Menu();
            MainMenu.Show();        //Reopens Menu

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Exit();                 //Calls Method to return to main menu
        }

        private void btnChangePlayer1Colour_Click(object sender, EventArgs e)
        {
            cDPlayer1.ShowDialog();             //Enables Player 1 to select any colour for avatar from ColourDialog Control
            Colour1 = cDPlayer1.Color;
            pbBoard.Invalidate();
        }

        private void btnChangePlayer2Colour_Click(object sender, EventArgs e)
        {
            cDPlayer2.ShowDialog();             //Enables Player 2 to select any colour for avatar ColourDialog Control
            Colour2 = cDPlayer2.Color;
            pbBoard.Invalidate();
        }

    }
}

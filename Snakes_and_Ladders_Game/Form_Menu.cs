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
    public partial class Form_Menu : Form
    {
        Form_Game StartGame;

        public Form_Menu()
        {
            InitializeComponent();
            StartGame = new Form_Game();
        }

        public void btnPlay_Click(object sender, EventArgs e)
        {
            //States default player names if custom textboxes are left blank/empty
            if (String.IsNullOrEmpty(txtPlayer1Name.Text) || String.IsNullOrWhiteSpace(txtPlayer1Name.Text))
            {
                this.txtPlayer1Name.Text = "Player 1";
            }

            if (String.IsNullOrEmpty(txtPlayer2Name.Text) || String.IsNullOrWhiteSpace(txtPlayer2Name.Text))
            {
                this.txtPlayer2Name.Text = "Player 2";
            }

            StartGame.txtPlayer1Name.Text = this.txtPlayer1Name.Text;       //Transfers Names to game
            StartGame.txtPlayer2Name.Text = this.txtPlayer2Name.Text;

            Form_Menu Menu = new Form_Menu();       //Hides main menu and opens game to begin round
            this.Hide();
            Menu.Close();
            StartGame.Show();
        }

        
    }
}

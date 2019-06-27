namespace Snakes_and_Ladders_Game
{
    partial class Form_Game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Game));
            this.txtPlayer2Name = new System.Windows.Forms.TextBox();
            this.txtPlayer1Name = new System.Windows.Forms.TextBox();
            this.pbBoard = new System.Windows.Forms.PictureBox();
            this.pbDice = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtScore2 = new System.Windows.Forms.TextBox();
            this.txtScore1 = new System.Windows.Forms.TextBox();
            this.lblScores = new System.Windows.Forms.Label();
            this.lblPlayer2 = new System.Windows.Forms.Label();
            this.lblPlayer1 = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.txtPlayer2Spot = new System.Windows.Forms.TextBox();
            this.txtPlayer1Spot = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.txtTurns = new System.Windows.Forms.TextBox();
            this.btnRoll = new System.Windows.Forms.Button();
            this.pbPermanentBorder = new System.Windows.Forms.PictureBox();
            this.lblFirstPlayer = new System.Windows.Forms.Label();
            this.lblSecondPlayer = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnChangePlayer1Colour = new System.Windows.Forms.Button();
            this.btnChangePlayer2Colour = new System.Windows.Forms.Button();
            this.cDPlayer1 = new System.Windows.Forms.ColorDialog();
            this.cDPlayer2 = new System.Windows.Forms.ColorDialog();
            this.txtEvents = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbBoard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPermanentBorder)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPlayer2Name
            // 
            this.txtPlayer2Name.Location = new System.Drawing.Point(1025, 126);
            this.txtPlayer2Name.Name = "txtPlayer2Name";
            this.txtPlayer2Name.ReadOnly = true;
            this.txtPlayer2Name.Size = new System.Drawing.Size(136, 20);
            this.txtPlayer2Name.TabIndex = 3;
            this.txtPlayer2Name.TabStop = false;
            // 
            // txtPlayer1Name
            // 
            this.txtPlayer1Name.Location = new System.Drawing.Point(1025, 71);
            this.txtPlayer1Name.Name = "txtPlayer1Name";
            this.txtPlayer1Name.ReadOnly = true;
            this.txtPlayer1Name.Size = new System.Drawing.Size(136, 20);
            this.txtPlayer1Name.TabIndex = 4;
            this.txtPlayer1Name.TabStop = false;
            // 
            // pbBoard
            // 
            this.pbBoard.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbBoard.BackgroundImage")));
            this.pbBoard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbBoard.Location = new System.Drawing.Point(13, 11);
            this.pbBoard.Name = "pbBoard";
            this.pbBoard.Size = new System.Drawing.Size(720, 720);
            this.pbBoard.TabIndex = 8;
            this.pbBoard.TabStop = false;
            this.pbBoard.Paint += new System.Windows.Forms.PaintEventHandler(this.pbBoard_Paint);
            // 
            // pbDice
            // 
            this.pbDice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbDice.Location = new System.Drawing.Point(773, 46);
            this.pbDice.Name = "pbDice";
            this.pbDice.Size = new System.Drawing.Size(185, 178);
            this.pbDice.TabIndex = 10;
            this.pbDice.TabStop = false;
            this.pbDice.Paint += new System.Windows.Forms.PaintEventHandler(this.pbDice_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(989, 511);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Player 2:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(989, 483);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Player 1:";
            // 
            // txtScore2
            // 
            this.txtScore2.Location = new System.Drawing.Point(1046, 508);
            this.txtScore2.Name = "txtScore2";
            this.txtScore2.ReadOnly = true;
            this.txtScore2.Size = new System.Drawing.Size(138, 20);
            this.txtScore2.TabIndex = 29;
            this.txtScore2.TabStop = false;
            // 
            // txtScore1
            // 
            this.txtScore1.Location = new System.Drawing.Point(1046, 480);
            this.txtScore1.Name = "txtScore1";
            this.txtScore1.ReadOnly = true;
            this.txtScore1.Size = new System.Drawing.Size(138, 20);
            this.txtScore1.TabIndex = 28;
            this.txtScore1.TabStop = false;
            // 
            // lblScores
            // 
            this.lblScores.AutoSize = true;
            this.lblScores.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScores.Location = new System.Drawing.Point(1036, 448);
            this.lblScores.Name = "lblScores";
            this.lblScores.Size = new System.Drawing.Size(96, 19);
            this.lblScores.TabIndex = 27;
            this.lblScores.Text = "Scoreboard";
            // 
            // lblPlayer2
            // 
            this.lblPlayer2.AutoSize = true;
            this.lblPlayer2.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer2.Location = new System.Drawing.Point(764, 509);
            this.lblPlayer2.Name = "lblPlayer2";
            this.lblPlayer2.Size = new System.Drawing.Size(51, 13);
            this.lblPlayer2.TabIndex = 26;
            this.lblPlayer2.Text = "Player 2:";
            // 
            // lblPlayer1
            // 
            this.lblPlayer1.AutoSize = true;
            this.lblPlayer1.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer1.Location = new System.Drawing.Point(764, 483);
            this.lblPlayer1.Name = "lblPlayer1";
            this.lblPlayer1.Size = new System.Drawing.Size(51, 13);
            this.lblPlayer1.TabIndex = 25;
            this.lblPlayer1.Text = "Player 1:";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.Location = new System.Drawing.Point(825, 448);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(70, 19);
            this.lblLocation.TabIndex = 24;
            this.lblLocation.Text = "Location";
            // 
            // txtPlayer2Spot
            // 
            this.txtPlayer2Spot.Location = new System.Drawing.Point(824, 506);
            this.txtPlayer2Spot.Name = "txtPlayer2Spot";
            this.txtPlayer2Spot.ReadOnly = true;
            this.txtPlayer2Spot.Size = new System.Drawing.Size(134, 20);
            this.txtPlayer2Spot.TabIndex = 23;
            this.txtPlayer2Spot.TabStop = false;
            // 
            // txtPlayer1Spot
            // 
            this.txtPlayer1Spot.Location = new System.Drawing.Point(824, 480);
            this.txtPlayer1Spot.Name = "txtPlayer1Spot";
            this.txtPlayer1Spot.ReadOnly = true;
            this.txtPlayer1Spot.Size = new System.Drawing.Size(134, 20);
            this.txtPlayer1Spot.TabIndex = 22;
            this.txtPlayer1Spot.TabStop = false;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(992, 570);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(194, 49);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset Scores";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click_1);
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(764, 570);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(194, 49);
            this.btnNewGame.TabIndex = 1;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // txtTurns
            // 
            this.txtTurns.Location = new System.Drawing.Point(871, 271);
            this.txtTurns.Name = "txtTurns";
            this.txtTurns.ReadOnly = true;
            this.txtTurns.Size = new System.Drawing.Size(213, 20);
            this.txtTurns.TabIndex = 35;
            this.txtTurns.TabStop = false;
            // 
            // btnRoll
            // 
            this.btnRoll.Location = new System.Drawing.Point(1000, 174);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(177, 45);
            this.btnRoll.TabIndex = 0;
            this.btnRoll.Text = "Roll Dice";
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // pbPermanentBorder
            // 
            this.pbPermanentBorder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPermanentBorder.Location = new System.Drawing.Point(773, 46);
            this.pbPermanentBorder.Name = "pbPermanentBorder";
            this.pbPermanentBorder.Size = new System.Drawing.Size(185, 178);
            this.pbPermanentBorder.TabIndex = 37;
            this.pbPermanentBorder.TabStop = false;
            // 
            // lblFirstPlayer
            // 
            this.lblFirstPlayer.AutoSize = true;
            this.lblFirstPlayer.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstPlayer.Location = new System.Drawing.Point(1058, 47);
            this.lblFirstPlayer.Name = "lblFirstPlayer";
            this.lblFirstPlayer.Size = new System.Drawing.Size(69, 19);
            this.lblFirstPlayer.TabIndex = 38;
            this.lblFirstPlayer.Text = "Player 1";
            // 
            // lblSecondPlayer
            // 
            this.lblSecondPlayer.AutoSize = true;
            this.lblSecondPlayer.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecondPlayer.Location = new System.Drawing.Point(1058, 104);
            this.lblSecondPlayer.Name = "lblSecondPlayer";
            this.lblSecondPlayer.Size = new System.Drawing.Size(69, 19);
            this.lblSecondPlayer.TabIndex = 39;
            this.lblSecondPlayer.Text = "Player 2";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(879, 645);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(193, 49);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Return to Main Menu";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnChangePlayer1Colour
            // 
            this.btnChangePlayer1Colour.Location = new System.Drawing.Point(764, 379);
            this.btnChangePlayer1Colour.Name = "btnChangePlayer1Colour";
            this.btnChangePlayer1Colour.Size = new System.Drawing.Size(194, 30);
            this.btnChangePlayer1Colour.TabIndex = 4;
            this.btnChangePlayer1Colour.Text = "Change Player 1 Colour";
            this.btnChangePlayer1Colour.UseVisualStyleBackColor = true;
            this.btnChangePlayer1Colour.Click += new System.EventHandler(this.btnChangePlayer1Colour_Click);
            // 
            // btnChangePlayer2Colour
            // 
            this.btnChangePlayer2Colour.Location = new System.Drawing.Point(990, 379);
            this.btnChangePlayer2Colour.Name = "btnChangePlayer2Colour";
            this.btnChangePlayer2Colour.Size = new System.Drawing.Size(194, 30);
            this.btnChangePlayer2Colour.TabIndex = 5;
            this.btnChangePlayer2Colour.Text = "Change Player 2 Colour";
            this.btnChangePlayer2Colour.UseVisualStyleBackColor = true;
            this.btnChangePlayer2Colour.Click += new System.EventHandler(this.btnChangePlayer2Colour_Click);
            // 
            // txtEvents
            // 
            this.txtEvents.Location = new System.Drawing.Point(795, 315);
            this.txtEvents.Name = "txtEvents";
            this.txtEvents.ReadOnly = true;
            this.txtEvents.Size = new System.Drawing.Size(366, 20);
            this.txtEvents.TabIndex = 42;
            this.txtEvents.TabStop = false;
            // 
            // Form_Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1214, 741);
            this.Controls.Add(this.txtEvents);
            this.Controls.Add(this.btnChangePlayer2Colour);
            this.Controls.Add(this.btnChangePlayer1Colour);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblSecondPlayer);
            this.Controls.Add(this.lblFirstPlayer);
            this.Controls.Add(this.pbPermanentBorder);
            this.Controls.Add(this.btnRoll);
            this.Controls.Add(this.txtTurns);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtScore2);
            this.Controls.Add(this.txtScore1);
            this.Controls.Add(this.lblScores);
            this.Controls.Add(this.lblPlayer2);
            this.Controls.Add(this.lblPlayer1);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.txtPlayer2Spot);
            this.Controls.Add(this.txtPlayer1Spot);
            this.Controls.Add(this.pbDice);
            this.Controls.Add(this.pbBoard);
            this.Controls.Add(this.txtPlayer2Name);
            this.Controls.Add(this.txtPlayer1Name);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Game";
            this.Text = "Snakes & Ladders";
            this.Load += new System.EventHandler(this.Form_Game_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbBoard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPermanentBorder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtPlayer2Name;
        public System.Windows.Forms.TextBox txtPlayer1Name;
        private System.Windows.Forms.PictureBox pbBoard;
        private System.Windows.Forms.PictureBox pbDice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtScore2;
        private System.Windows.Forms.TextBox txtScore1;
        private System.Windows.Forms.Label lblScores;
        private System.Windows.Forms.Label lblPlayer2;
        private System.Windows.Forms.Label lblPlayer1;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.TextBox txtPlayer2Spot;
        private System.Windows.Forms.TextBox txtPlayer1Spot;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.TextBox txtTurns;
        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.PictureBox pbPermanentBorder;
        private System.Windows.Forms.Label lblFirstPlayer;
        private System.Windows.Forms.Label lblSecondPlayer;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnChangePlayer1Colour;
        private System.Windows.Forms.Button btnChangePlayer2Colour;
        private System.Windows.Forms.ColorDialog cDPlayer1;
        private System.Windows.Forms.ColorDialog cDPlayer2;
        private System.Windows.Forms.TextBox txtEvents;
    }
}
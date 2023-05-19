
namespace ParkSpencer_HernandezEric_Battleship
{
    partial class frmNameEntry
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtPlayer1Name = new System.Windows.Forms.TextBox();
            this.txtPlayer2Name = new System.Windows.Forms.TextBox();
            this.btnPlayer1NameOK = new System.Windows.Forms.Button();
            this.btnPlayer2NameOK = new System.Windows.Forms.Button();
            this.pnlGame = new System.Windows.Forms.Panel();
            this.lblPlayer1 = new System.Windows.Forms.Label();
            this.lblPlayer2 = new System.Windows.Forms.Label();
            this.chkVertical = new System.Windows.Forms.CheckBox();
            this.lblCurrentPlayer = new System.Windows.Forms.Label();
            this.txtCurrentPlayer = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lblCurrentShip = new System.Windows.Forms.Label();
            this.txtCurrentShip = new System.Windows.Forms.TextBox();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(207, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(55, 13);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "BattleShip";
            // 
            // txtPlayer1Name
            // 
            this.txtPlayer1Name.Location = new System.Drawing.Point(182, 25);
            this.txtPlayer1Name.Name = "txtPlayer1Name";
            this.txtPlayer1Name.Size = new System.Drawing.Size(100, 20);
            this.txtPlayer1Name.TabIndex = 1;
            // 
            // txtPlayer2Name
            // 
            this.txtPlayer2Name.Location = new System.Drawing.Point(182, 51);
            this.txtPlayer2Name.Name = "txtPlayer2Name";
            this.txtPlayer2Name.Size = new System.Drawing.Size(100, 20);
            this.txtPlayer2Name.TabIndex = 2;
            this.txtPlayer2Name.Visible = false;
            // 
            // btnPlayer1NameOK
            // 
            this.btnPlayer1NameOK.Location = new System.Drawing.Point(304, 23);
            this.btnPlayer1NameOK.Name = "btnPlayer1NameOK";
            this.btnPlayer1NameOK.Size = new System.Drawing.Size(52, 23);
            this.btnPlayer1NameOK.TabIndex = 3;
            this.btnPlayer1NameOK.Text = "OK";
            this.btnPlayer1NameOK.UseVisualStyleBackColor = true;
            this.btnPlayer1NameOK.Click += new System.EventHandler(this.btnPlayer1NameOK_Click);
            // 
            // btnPlayer2NameOK
            // 
            this.btnPlayer2NameOK.Location = new System.Drawing.Point(304, 49);
            this.btnPlayer2NameOK.Name = "btnPlayer2NameOK";
            this.btnPlayer2NameOK.Size = new System.Drawing.Size(52, 23);
            this.btnPlayer2NameOK.TabIndex = 4;
            this.btnPlayer2NameOK.Text = "OK";
            this.btnPlayer2NameOK.UseVisualStyleBackColor = true;
            this.btnPlayer2NameOK.Visible = false;
            this.btnPlayer2NameOK.Click += new System.EventHandler(this.btnPlayer2NameOK_Click);
            // 
            // pnlGame
            // 
            this.pnlGame.Location = new System.Drawing.Point(33, 103);
            this.pnlGame.Name = "pnlGame";
            this.pnlGame.Size = new System.Drawing.Size(400, 400);
            this.pnlGame.TabIndex = 5;
            // 
            // lblPlayer1
            // 
            this.lblPlayer1.AutoSize = true;
            this.lblPlayer1.Location = new System.Drawing.Point(70, 27);
            this.lblPlayer1.Name = "lblPlayer1";
            this.lblPlayer1.Size = new System.Drawing.Size(74, 13);
            this.lblPlayer1.TabIndex = 6;
            this.lblPlayer1.Text = "Player 1 name";
            // 
            // lblPlayer2
            // 
            this.lblPlayer2.AutoSize = true;
            this.lblPlayer2.Location = new System.Drawing.Point(70, 54);
            this.lblPlayer2.Name = "lblPlayer2";
            this.lblPlayer2.Size = new System.Drawing.Size(74, 13);
            this.lblPlayer2.TabIndex = 7;
            this.lblPlayer2.Text = "Player 2 name";
            this.lblPlayer2.Visible = false;
            // 
            // chkVertical
            // 
            this.chkVertical.AutoSize = true;
            this.chkVertical.Enabled = false;
            this.chkVertical.Location = new System.Drawing.Point(33, 543);
            this.chkVertical.Name = "chkVertical";
            this.chkVertical.Size = new System.Drawing.Size(91, 17);
            this.chkVertical.TabIndex = 8;
            this.chkVertical.Text = "Make Vertical";
            this.chkVertical.UseVisualStyleBackColor = true;
            // 
            // lblCurrentPlayer
            // 
            this.lblCurrentPlayer.AutoSize = true;
            this.lblCurrentPlayer.Location = new System.Drawing.Point(132, 81);
            this.lblCurrentPlayer.Name = "lblCurrentPlayer";
            this.lblCurrentPlayer.Size = new System.Drawing.Size(87, 13);
            this.lblCurrentPlayer.TabIndex = 9;
            this.lblCurrentPlayer.Text = "Place your ships,";
            // 
            // txtCurrentPlayer
            // 
            this.txtCurrentPlayer.Enabled = false;
            this.txtCurrentPlayer.Location = new System.Drawing.Point(232, 78);
            this.txtCurrentPlayer.Name = "txtCurrentPlayer";
            this.txtCurrentPlayer.Size = new System.Drawing.Size(100, 20);
            this.txtCurrentPlayer.TabIndex = 10;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Enabled = false;
            this.btnConfirm.Location = new System.Drawing.Point(352, 539);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 11;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lblCurrentShip
            // 
            this.lblCurrentShip.AutoSize = true;
            this.lblCurrentShip.Location = new System.Drawing.Point(132, 544);
            this.lblCurrentShip.Name = "lblCurrentShip";
            this.lblCurrentShip.Size = new System.Drawing.Size(68, 13);
            this.lblCurrentShip.TabIndex = 12;
            this.lblCurrentShip.Text = "Current Ship:";
            // 
            // txtCurrentShip
            // 
            this.txtCurrentShip.Enabled = false;
            this.txtCurrentShip.Location = new System.Drawing.Point(212, 541);
            this.txtCurrentShip.Name = "txtCurrentShip";
            this.txtCurrentShip.Size = new System.Drawing.Size(100, 20);
            this.txtCurrentShip.TabIndex = 13;
            // 
            // btnStartGame
            // 
            this.btnStartGame.Enabled = false;
            this.btnStartGame.Location = new System.Drawing.Point(192, 567);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(75, 23);
            this.btnStartGame.TabIndex = 14;
            this.btnStartGame.Text = "Start game";
            this.btnStartGame.UseVisualStyleBackColor = true;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // frmNameEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 597);
            this.Controls.Add(this.btnStartGame);
            this.Controls.Add(this.txtCurrentShip);
            this.Controls.Add(this.lblCurrentShip);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.txtCurrentPlayer);
            this.Controls.Add(this.lblCurrentPlayer);
            this.Controls.Add(this.chkVertical);
            this.Controls.Add(this.lblPlayer2);
            this.Controls.Add(this.lblPlayer1);
            this.Controls.Add(this.pnlGame);
            this.Controls.Add(this.btnPlayer2NameOK);
            this.Controls.Add(this.btnPlayer1NameOK);
            this.Controls.Add(this.txtPlayer2Name);
            this.Controls.Add(this.txtPlayer1Name);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmNameEntry";
            this.Text = "Game Preparation";
            this.Load += new System.EventHandler(this.frmNameEntry_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtPlayer1Name;
        private System.Windows.Forms.TextBox txtPlayer2Name;
        private System.Windows.Forms.Button btnPlayer1NameOK;
        private System.Windows.Forms.Button btnPlayer2NameOK;
        private System.Windows.Forms.Panel pnlGame;
        private System.Windows.Forms.Label lblPlayer1;
        private System.Windows.Forms.Label lblPlayer2;
        private System.Windows.Forms.CheckBox chkVertical;
        private System.Windows.Forms.Label lblCurrentPlayer;
        private System.Windows.Forms.TextBox txtCurrentPlayer;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lblCurrentShip;
        private System.Windows.Forms.TextBox txtCurrentShip;
        private System.Windows.Forms.Button btnStartGame;
    }
}


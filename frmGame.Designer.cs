
namespace ParkSpencer_HernandezEric_Battleship
{
    partial class frmGame
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
            this.pnlPlayer1 = new System.Windows.Forms.Panel();
            this.pnlPlayer2 = new System.Windows.Forms.Panel();
            this.lblPlayer1 = new System.Windows.Forms.Label();
            this.btnQuit = new System.Windows.Forms.Button();
            this.lblCurrentPlayer = new System.Windows.Forms.Label();
            this.txtCurrentPlayer = new System.Windows.Forms.TextBox();
            this.lblPlayer2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pnlPlayer1
            // 
            this.pnlPlayer1.Location = new System.Drawing.Point(40, 55);
            this.pnlPlayer1.Name = "pnlPlayer1";
            this.pnlPlayer1.Size = new System.Drawing.Size(400, 400);
            this.pnlPlayer1.TabIndex = 6;
            // 
            // pnlPlayer2
            // 
            this.pnlPlayer2.Location = new System.Drawing.Point(472, 55);
            this.pnlPlayer2.Name = "pnlPlayer2";
            this.pnlPlayer2.Size = new System.Drawing.Size(400, 400);
            this.pnlPlayer2.TabIndex = 7;
            // 
            // lblPlayer1
            // 
            this.lblPlayer1.AutoSize = true;
            this.lblPlayer1.Location = new System.Drawing.Point(199, 39);
            this.lblPlayer1.Name = "lblPlayer1";
            this.lblPlayer1.Size = new System.Drawing.Size(45, 13);
            this.lblPlayer1.TabIndex = 8;
            this.lblPlayer1.Text = "Player 1";
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(485, 485);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 10;
            this.btnQuit.Text = "Quit Game";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // lblCurrentPlayer
            // 
            this.lblCurrentPlayer.AutoSize = true;
            this.lblCurrentPlayer.Location = new System.Drawing.Point(326, 468);
            this.lblCurrentPlayer.Name = "lblCurrentPlayer";
            this.lblCurrentPlayer.Size = new System.Drawing.Size(75, 13);
            this.lblCurrentPlayer.TabIndex = 11;
            this.lblCurrentPlayer.Text = "Current player:";
            // 
            // txtCurrentPlayer
            // 
            this.txtCurrentPlayer.Enabled = false;
            this.txtCurrentPlayer.Location = new System.Drawing.Point(329, 487);
            this.txtCurrentPlayer.Name = "txtCurrentPlayer";
            this.txtCurrentPlayer.Size = new System.Drawing.Size(100, 20);
            this.txtCurrentPlayer.TabIndex = 12;
            // 
            // lblPlayer2
            // 
            this.lblPlayer2.AutoSize = true;
            this.lblPlayer2.Location = new System.Drawing.Point(656, 39);
            this.lblPlayer2.Name = "lblPlayer2";
            this.lblPlayer2.Size = new System.Drawing.Size(45, 13);
            this.lblPlayer2.TabIndex = 13;
            this.lblPlayer2.Text = "Player 2";
            // 
            // frmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 520);
            this.Controls.Add(this.lblPlayer2);
            this.Controls.Add(this.txtCurrentPlayer);
            this.Controls.Add(this.lblCurrentPlayer);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.lblPlayer1);
            this.Controls.Add(this.pnlPlayer2);
            this.Controls.Add(this.pnlPlayer1);
            this.Name = "frmGame";
            this.Text = "Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlPlayer1;
        private System.Windows.Forms.Panel pnlPlayer2;
        private System.Windows.Forms.Label lblPlayer1;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Label lblCurrentPlayer;
        private System.Windows.Forms.TextBox txtCurrentPlayer;
        private System.Windows.Forms.Label lblPlayer2;
    }
}
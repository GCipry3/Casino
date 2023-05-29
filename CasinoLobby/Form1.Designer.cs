namespace CasinoLobby
{
    partial class Form1
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
            this.CoinFlipButton = new System.Windows.Forms.Button();
            this.SlotsButton = new System.Windows.Forms.Button();
            this.HigherLowerButton = new System.Windows.Forms.Button();
            this.DicesGameButton = new System.Windows.Forms.Button();
            this.BlackJackButton = new System.Windows.Forms.Button();
            this.PokerButton = new System.Windows.Forms.Button();
            this.HelpButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CoinFlipButton
            // 
            this.CoinFlipButton.Location = new System.Drawing.Point(145, 133);
            this.CoinFlipButton.Margin = new System.Windows.Forms.Padding(4);
            this.CoinFlipButton.Name = "CoinFlipButton";
            this.CoinFlipButton.Size = new System.Drawing.Size(100, 28);
            this.CoinFlipButton.TabIndex = 1;
            this.CoinFlipButton.Text = "CoinFlip";
            this.CoinFlipButton.UseVisualStyleBackColor = true;
            this.CoinFlipButton.Click += new System.EventHandler(this.CoinFlipButton_Click);
            // 
            // SlotsButton
            // 
            this.SlotsButton.Location = new System.Drawing.Point(145, 169);
            this.SlotsButton.Margin = new System.Windows.Forms.Padding(4);
            this.SlotsButton.Name = "SlotsButton";
            this.SlotsButton.Size = new System.Drawing.Size(100, 28);
            this.SlotsButton.TabIndex = 2;
            this.SlotsButton.Text = "Slots";
            this.SlotsButton.UseVisualStyleBackColor = true;
            this.SlotsButton.Click += new System.EventHandler(this.SlotsButton_Click);
            // 
            // HigherLowerButton
            // 
            this.HigherLowerButton.Location = new System.Drawing.Point(145, 205);
            this.HigherLowerButton.Margin = new System.Windows.Forms.Padding(4);
            this.HigherLowerButton.Name = "HigherLowerButton";
            this.HigherLowerButton.Size = new System.Drawing.Size(100, 28);
            this.HigherLowerButton.TabIndex = 3;
            this.HigherLowerButton.Text = "HigherLower";
            this.HigherLowerButton.UseVisualStyleBackColor = true;
            this.HigherLowerButton.Click += new System.EventHandler(this.HigherLowerButton_Click);
            // 
            // DicesGameButton
            // 
            this.DicesGameButton.Location = new System.Drawing.Point(147, 241);
            this.DicesGameButton.Margin = new System.Windows.Forms.Padding(4);
            this.DicesGameButton.Name = "DicesGameButton";
            this.DicesGameButton.Size = new System.Drawing.Size(100, 28);
            this.DicesGameButton.TabIndex = 4;
            this.DicesGameButton.Text = "Dices";
            this.DicesGameButton.UseVisualStyleBackColor = true;
            this.DicesGameButton.Click += new System.EventHandler(this.DicesGameButton_Click);
            // 
            // BlackJackButton
            // 
            this.BlackJackButton.Location = new System.Drawing.Point(147, 62);
            this.BlackJackButton.Name = "BlackJackButton";
            this.BlackJackButton.Size = new System.Drawing.Size(98, 28);
            this.BlackJackButton.TabIndex = 5;
            this.BlackJackButton.Text = "BlackJack";
            this.BlackJackButton.UseVisualStyleBackColor = true;
            this.BlackJackButton.Click += new System.EventHandler(this.BlackJackButton_Click);
            // 
            // PokerButton
            // 
            this.PokerButton.Location = new System.Drawing.Point(145, 97);
            this.PokerButton.Margin = new System.Windows.Forms.Padding(4);
            this.PokerButton.Name = "PokerButton";
            this.PokerButton.Size = new System.Drawing.Size(100, 28);
            this.PokerButton.TabIndex = 5;
            this.PokerButton.Text = "Poker";
            this.PokerButton.UseVisualStyleBackColor = true;
            this.PokerButton.Click += new System.EventHandler(this.PokerButton_Click);
            // 
            // HelpButton
            // 
            this.HelpButton.Location = new System.Drawing.Point(145, 377);
            this.HelpButton.Margin = new System.Windows.Forms.Padding(4);
            this.HelpButton.Name = "HelpButton";
            this.HelpButton.Size = new System.Drawing.Size(100, 28);
            this.HelpButton.TabIndex = 6;
            this.HelpButton.Text = "Help";
            this.HelpButton.UseVisualStyleBackColor = true;
            this.HelpButton.Click += new System.EventHandler(this.HelpButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.HelpButton);
            this.Controls.Add(this.BlackJackButton);
            this.Controls.Add(this.PokerButton);
            this.Controls.Add(this.DicesGameButton);
            this.Controls.Add(this.HigherLowerButton);
            this.Controls.Add(this.SlotsButton);
            this.Controls.Add(this.CoinFlipButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button CoinFlipButton;
        private System.Windows.Forms.Button SlotsButton;
        private System.Windows.Forms.Button HigherLowerButton;
        private System.Windows.Forms.Button DicesGameButton;
        private System.Windows.Forms.Button BlackJackButton;
        private System.Windows.Forms.Button PokerButton;
        private System.Windows.Forms.Button HelpButton;
    }
}


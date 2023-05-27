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
            this.higherLowerButton = new System.Windows.Forms.Button();
            this.DicesGameButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CoinFlipButton
            // 
            this.CoinFlipButton.Location = new System.Drawing.Point(145, 156);
            this.CoinFlipButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CoinFlipButton.Name = "CoinFlipButton";
            this.CoinFlipButton.Size = new System.Drawing.Size(100, 28);
            this.CoinFlipButton.TabIndex = 1;
            this.CoinFlipButton.Text = "CoinFlip";
            this.CoinFlipButton.UseVisualStyleBackColor = true;
            this.CoinFlipButton.Click += new System.EventHandler(this.CoinFlipButton_Click);
            // 
            // SlotsButton
            // 
            this.SlotsButton.Location = new System.Drawing.Point(145, 210);
            this.SlotsButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SlotsButton.Name = "SlotsButton";
            this.SlotsButton.Size = new System.Drawing.Size(100, 28);
            this.SlotsButton.TabIndex = 2;
            this.SlotsButton.Text = "Slots";
            this.SlotsButton.UseVisualStyleBackColor = true;
            this.SlotsButton.Click += new System.EventHandler(this.SlotsButton_Click);
            // 
            // higherLowerButton
            // 
            this.higherLowerButton.Location = new System.Drawing.Point(145, 266);
            this.higherLowerButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.higherLowerButton.Name = "higherLowerButton";
            this.higherLowerButton.Size = new System.Drawing.Size(100, 28);
            this.higherLowerButton.TabIndex = 3;
            this.higherLowerButton.Text = "HigherLower";
            this.higherLowerButton.UseVisualStyleBackColor = true;
            this.higherLowerButton.Click += new System.EventHandler(this.higherLowerButton_Click);
            // 
            // DicesGameButton
            // 
            this.DicesGameButton.Location = new System.Drawing.Point(145, 325);
            this.DicesGameButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DicesGameButton.Name = "DicesGameButton";
            this.DicesGameButton.Size = new System.Drawing.Size(100, 28);
            this.DicesGameButton.TabIndex = 4;
            this.DicesGameButton.Text = "Dices";
            this.DicesGameButton.UseVisualStyleBackColor = true;
            this.DicesGameButton.Click += new System.EventHandler(this.DicesGameButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(145, 97);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 28);
            this.button1.TabIndex = 5;
            this.button1.Text = "Poker";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DicesGameButton);
            this.Controls.Add(this.higherLowerButton);
            this.Controls.Add(this.SlotsButton);
            this.Controls.Add(this.CoinFlipButton);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button CoinFlipButton;
        private System.Windows.Forms.Button SlotsButton;
        private System.Windows.Forms.Button higherLowerButton;
        private System.Windows.Forms.Button DicesGameButton;
        private System.Windows.Forms.Button button1;
    }
}


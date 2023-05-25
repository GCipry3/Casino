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
            this.SuspendLayout();
            // 
            // CoinFlipButton
            // 
            this.CoinFlipButton.Location = new System.Drawing.Point(109, 127);
            this.CoinFlipButton.Name = "CoinFlipButton";
            this.CoinFlipButton.Size = new System.Drawing.Size(75, 23);
            this.CoinFlipButton.TabIndex = 1;
            this.CoinFlipButton.Text = "CoinFlip";
            this.CoinFlipButton.UseVisualStyleBackColor = true;
            this.CoinFlipButton.Click += new System.EventHandler(this.CoinFlipButton_Click);
            // 
            // SlotsButton
            // 
            this.SlotsButton.Location = new System.Drawing.Point(109, 171);
            this.SlotsButton.Name = "SlotsButton";
            this.SlotsButton.Size = new System.Drawing.Size(75, 23);
            this.SlotsButton.TabIndex = 2;
            this.SlotsButton.Text = "Slots";
            this.SlotsButton.UseVisualStyleBackColor = true;
            this.SlotsButton.Click += new System.EventHandler(this.SlotsButton_Click);
            // 
            // higherLowerButton
            // 
            this.higherLowerButton.Location = new System.Drawing.Point(109, 216);
            this.higherLowerButton.Name = "higherLowerButton";
            this.higherLowerButton.Size = new System.Drawing.Size(75, 23);
            this.higherLowerButton.TabIndex = 3;
            this.higherLowerButton.Text = "HigherLower";
            this.higherLowerButton.UseVisualStyleBackColor = true;
            this.higherLowerButton.Click += new System.EventHandler(this.higherLowerButton_Click);
            // 
            // DicesGameButton
            // 
            this.DicesGameButton.Location = new System.Drawing.Point(109, 264);
            this.DicesGameButton.Name = "DicesGameButton";
            this.DicesGameButton.Size = new System.Drawing.Size(75, 23);
            this.DicesGameButton.TabIndex = 4;
            this.DicesGameButton.Text = "Dices";
            this.DicesGameButton.UseVisualStyleBackColor = true;
            this.DicesGameButton.Click += new System.EventHandler(this.DicesGameButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DicesGameButton);
            this.Controls.Add(this.higherLowerButton);
            this.Controls.Add(this.SlotsButton);
            this.Controls.Add(this.CoinFlipButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button CoinFlipButton;
        private System.Windows.Forms.Button SlotsButton;
        private System.Windows.Forms.Button higherLowerButton;
        private System.Windows.Forms.Button DicesGameButton;
    }
}


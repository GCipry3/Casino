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
            this.PokerButton = new System.Windows.Forms.Button();
            this.CoinFlipButton = new System.Windows.Forms.Button();
            this.SlotsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PokerButton
            // 
            this.PokerButton.Location = new System.Drawing.Point(145, 103);
            this.PokerButton.Margin = new System.Windows.Forms.Padding(4);
            this.PokerButton.Name = "PokerButton";
            this.PokerButton.Size = new System.Drawing.Size(100, 28);
            this.PokerButton.TabIndex = 0;
            this.PokerButton.Text = "Poker";
            this.PokerButton.UseVisualStyleBackColor = true;
            this.PokerButton.Click += new System.EventHandler(this.PokerButton_Click);
            // 
            // CoinFlipButton
            // 
            this.CoinFlipButton.Location = new System.Drawing.Point(145, 156);
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
            this.SlotsButton.Location = new System.Drawing.Point(145, 211);
            this.SlotsButton.Margin = new System.Windows.Forms.Padding(4);
            this.SlotsButton.Name = "SlotsButton";
            this.SlotsButton.Size = new System.Drawing.Size(100, 28);
            this.SlotsButton.TabIndex = 2;
            this.SlotsButton.Text = "Slots";
            this.SlotsButton.UseVisualStyleBackColor = true;
            this.SlotsButton.Click += new System.EventHandler(this.SlotsButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.SlotsButton);
            this.Controls.Add(this.CoinFlipButton);
            this.Controls.Add(this.PokerButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PokerButton;
        private System.Windows.Forms.Button CoinFlipButton;
        private System.Windows.Forms.Button SlotsButton;
    }
}


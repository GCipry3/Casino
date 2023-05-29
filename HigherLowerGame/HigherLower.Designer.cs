namespace HigherLowerGame
{
    partial class HigherLower
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
            this.components = new System.ComponentModel.Container();
            this.HigherButton = new System.Windows.Forms.Button();
            this.LowerButton = new System.Windows.Forms.Button();
            this.BetNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.WinningsTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MoneyTextBox = new System.Windows.Forms.TextBox();
            this.CardPictureBox = new System.Windows.Forms.PictureBox();
            this.ShuffleTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.BetNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CardPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // HigherButton
            // 
            this.higherButton.Location = new System.Drawing.Point(283, 367);
            this.higherButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.higherButton.Name = "higherButton";
            this.higherButton.Size = new System.Drawing.Size(83, 42);
            this.higherButton.TabIndex = 0;
            this.higherButton.Text = "Higher";
            this.higherButton.UseVisualStyleBackColor = true;
            this.higherButton.Click += new System.EventHandler(this.higherButton_Click);
            this.HigherButton.Location = new System.Drawing.Point(283, 367);
            this.HigherButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HigherButton.Name = "HigherButton";
            this.HigherButton.Size = new System.Drawing.Size(83, 42);
            this.HigherButton.TabIndex = 0;
            this.HigherButton.Text = "Higher";
            this.HigherButton.UseVisualStyleBackColor = true;
            this.HigherButton.Click += new System.EventHandler(this.HigherButton_Click);
            // 
            // LowerButton
            // 
            this.lowerButton.Location = new System.Drawing.Point(409, 367);
            this.lowerButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lowerButton.Name = "lowerButton";
            this.lowerButton.Size = new System.Drawing.Size(83, 42);
            this.lowerButton.TabIndex = 1;
            this.lowerButton.Text = "Lower";
            this.lowerButton.UseVisualStyleBackColor = true;
            this.lowerButton.Click += new System.EventHandler(this.lowerButton_Click);
            this.LowerButton.Location = new System.Drawing.Point(409, 367);
            this.LowerButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LowerButton.Name = "LowerButton";
            this.LowerButton.Size = new System.Drawing.Size(83, 42);
            this.LowerButton.TabIndex = 1;
            this.LowerButton.Text = "Lower";
            this.LowerButton.UseVisualStyleBackColor = true;
            this.LowerButton.Click += new System.EventHandler(this.LowerButton_Click);
            // 
            // BetNumericUpDown
            // 
            this.betNumericUpDown.Location = new System.Drawing.Point(116, 97);
            this.betNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.betNumericUpDown.Name = "betNumericUpDown";
            this.betNumericUpDown.Size = new System.Drawing.Size(73, 22);
            this.betNumericUpDown.TabIndex = 3;
            this.BetNumericUpDown.Location = new System.Drawing.Point(116, 97);
            this.BetNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BetNumericUpDown.Name = "BetNumericUpDown";
            this.BetNumericUpDown.Size = new System.Drawing.Size(73, 22);
            this.BetNumericUpDown.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Choose your bet";
            // 
            // WinningsTextBox
            // 
            this.winningsTextBox.Location = new System.Drawing.Point(149, 31);
            this.winningsTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.winningsTextBox.Name = "winningsTextBox";
            this.winningsTextBox.Size = new System.Drawing.Size(87, 22);
            this.winningsTextBox.TabIndex = 5;
            this.WinningsTextBox.Location = new System.Drawing.Point(143, 31);
            this.WinningsTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WinningsTextBox.Name = "WinningsTextBox";
            this.WinningsTextBox.Size = new System.Drawing.Size(87, 22);
            this.WinningsTextBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 34);
            this.label2.Location = new System.Drawing.Point(69, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Winnings :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(541, 34);
            this.label3.Location = new System.Drawing.Point(542, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Total funds :";
            // 
            // MoneyTextBox
            // 
            this.moneyTextBox.Location = new System.Drawing.Point(627, 31);
            this.moneyTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.moneyTextBox.Name = "moneyTextBox";
            this.moneyTextBox.Size = new System.Drawing.Size(109, 22);
            this.moneyTextBox.TabIndex = 8;
            this.MoneyTextBox.Location = new System.Drawing.Point(627, 31);
            this.MoneyTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MoneyTextBox.Name = "MoneyTextBox";
            this.MoneyTextBox.Size = new System.Drawing.Size(109, 22);
            this.MoneyTextBox.TabIndex = 8;
            // 
            // CardPictureBox
            // 
            this.pictureBox1.Image = global::HigherLowerGame.Properties.Resources._7frunza;
            this.pictureBox1.Location = new System.Drawing.Point(283, 31);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(209, 318);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.CardPictureBox.Image = global::HigherLowerGame.Properties.Resources._7frunza;
            this.CardPictureBox.Location = new System.Drawing.Point(283, 31);
            this.CardPictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CardPictureBox.Name = "CardPictureBox";
            this.CardPictureBox.Size = new System.Drawing.Size(209, 318);
            this.CardPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CardPictureBox.TabIndex = 2;
            this.CardPictureBox.TabStop = false;
            // 
            // ShuffleTimer
            // 
            this.ShuffleTimer.Interval = 150;
            this.ShuffleTimer.Tick += new System.EventHandler(this.ShuffleTimer_Tick);
            // 
            // HigherLower
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.moneyTextBox);
            this.Controls.Add(this.MoneyTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.WinningsTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.betNumericUpDown);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lowerButton);
            this.Controls.Add(this.higherButton);
            this.Controls.Add(this.BetNumericUpDown);
            this.Controls.Add(this.CardPictureBox);
            this.Controls.Add(this.LowerButton);
            this.Controls.Add(this.HigherButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "HigherLower";
            this.Text = "HigherLower";
            this.Load += new System.EventHandler(this.HigherLower_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BetNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CardPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button HigherButton;
        private System.Windows.Forms.Button LowerButton;
        private System.Windows.Forms.PictureBox CardPictureBox;
        private System.Windows.Forms.NumericUpDown BetNumericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox WinningsTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox MoneyTextBox;
        private System.Windows.Forms.Timer ShuffleTimer;
    }
}
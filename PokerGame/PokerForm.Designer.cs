namespace PokerGame
{
    partial class PokerForm
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
            this.Card1PictureBox = new System.Windows.Forms.PictureBox();
            this.Card2PictureBox = new System.Windows.Forms.PictureBox();
            this.Card3PictureBox = new System.Windows.Forms.PictureBox();
            this.Card4PictureBox = new System.Windows.Forms.PictureBox();
            this.Card5PictureBox = new System.Windows.Forms.PictureBox();
            this.Card1Button = new System.Windows.Forms.Button();
            this.Card2Button = new System.Windows.Forms.Button();
            this.Card3Button = new System.Windows.Forms.Button();
            this.Card4Button = new System.Windows.Forms.Button();
            this.Card5Button = new System.Windows.Forms.Button();
            this.PlayButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.BetNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.WinningsTextBox = new System.Windows.Forms.TextBox();
            this.MoneyTextBox = new System.Windows.Forms.TextBox();
            this.InterGameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Card1PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card2PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card3PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card4PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card5PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BetNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // Card1PictureBox
            // 
            this.Card1PictureBox.Image = global::PokerGame.Properties.Resources.cardBack;
            this.Card1PictureBox.Location = new System.Drawing.Point(12, 100);
            this.Card1PictureBox.Name = "Card1PictureBox";
            this.Card1PictureBox.Size = new System.Drawing.Size(130, 197);
            this.Card1PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Card1PictureBox.TabIndex = 0;
            this.Card1PictureBox.TabStop = false;
            // 
            // Card2PictureBox
            // 
            this.Card2PictureBox.Image = global::PokerGame.Properties.Resources.cardBack;
            this.Card2PictureBox.Location = new System.Drawing.Point(173, 100);
            this.Card2PictureBox.Name = "Card2PictureBox";
            this.Card2PictureBox.Size = new System.Drawing.Size(130, 197);
            this.Card2PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Card2PictureBox.TabIndex = 1;
            this.Card2PictureBox.TabStop = false;
            // 
            // Card3PictureBox
            // 
            this.Card3PictureBox.Image = global::PokerGame.Properties.Resources.cardBack;
            this.Card3PictureBox.Location = new System.Drawing.Point(333, 100);
            this.Card3PictureBox.Name = "Card3PictureBox";
            this.Card3PictureBox.Size = new System.Drawing.Size(130, 197);
            this.Card3PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Card3PictureBox.TabIndex = 2;
            this.Card3PictureBox.TabStop = false;
            // 
            // Card4PictureBox
            // 
            this.Card4PictureBox.Image = global::PokerGame.Properties.Resources.cardBack;
            this.Card4PictureBox.Location = new System.Drawing.Point(495, 100);
            this.Card4PictureBox.Name = "Card4PictureBox";
            this.Card4PictureBox.Size = new System.Drawing.Size(130, 197);
            this.Card4PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Card4PictureBox.TabIndex = 3;
            this.Card4PictureBox.TabStop = false;
            // 
            // Card5PictureBox
            // 
            this.Card5PictureBox.Image = global::PokerGame.Properties.Resources.cardBack;
            this.Card5PictureBox.Location = new System.Drawing.Point(658, 100);
            this.Card5PictureBox.Name = "Card5PictureBox";
            this.Card5PictureBox.Size = new System.Drawing.Size(130, 197);
            this.Card5PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Card5PictureBox.TabIndex = 4;
            this.Card5PictureBox.TabStop = false;
            // 
            // Card1Button
            // 
            this.Card1Button.Location = new System.Drawing.Point(40, 303);
            this.Card1Button.Name = "Card1Button";
            this.Card1Button.Size = new System.Drawing.Size(75, 33);
            this.Card1Button.TabIndex = 5;
            this.Card1Button.Text = "Keep";
            this.Card1Button.UseVisualStyleBackColor = true;
            this.Card1Button.Click += new System.EventHandler(this.Card1Button_Click);
            // 
            // Card2Button
            // 
            this.Card2Button.Location = new System.Drawing.Point(200, 303);
            this.Card2Button.Name = "Card2Button";
            this.Card2Button.Size = new System.Drawing.Size(75, 33);
            this.Card2Button.TabIndex = 6;
            this.Card2Button.Text = "Keep";
            this.Card2Button.UseVisualStyleBackColor = true;
            this.Card2Button.Click += new System.EventHandler(this.Card2Button_Click);
            // 
            // Card3Button
            // 
            this.Card3Button.Location = new System.Drawing.Point(360, 303);
            this.Card3Button.Name = "Card3Button";
            this.Card3Button.Size = new System.Drawing.Size(75, 33);
            this.Card3Button.TabIndex = 7;
            this.Card3Button.Text = "Keep";
            this.Card3Button.UseVisualStyleBackColor = true;
            this.Card3Button.Click += new System.EventHandler(this.Card3Button_Click);
            // 
            // Card4Button
            // 
            this.Card4Button.Location = new System.Drawing.Point(522, 303);
            this.Card4Button.Name = "Card4Button";
            this.Card4Button.Size = new System.Drawing.Size(75, 33);
            this.Card4Button.TabIndex = 8;
            this.Card4Button.Text = "Keep";
            this.Card4Button.UseVisualStyleBackColor = true;
            this.Card4Button.Click += new System.EventHandler(this.Card4Button_Click);
            // 
            // Card5Button
            // 
            this.Card5Button.Location = new System.Drawing.Point(686, 303);
            this.Card5Button.Name = "Card5Button";
            this.Card5Button.Size = new System.Drawing.Size(75, 33);
            this.Card5Button.TabIndex = 9;
            this.Card5Button.Text = "Keep";
            this.Card5Button.UseVisualStyleBackColor = true;
            this.Card5Button.Click += new System.EventHandler(this.Card5Button_Click);
            // 
            // PlayButton
            // 
            this.PlayButton.Location = new System.Drawing.Point(333, 370);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(130, 45);
            this.PlayButton.TabIndex = 10;
            this.PlayButton.Text = "Play";
            this.PlayButton.UseVisualStyleBackColor = true;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(315, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Winnings :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(566, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Total funds :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Choose your bet";
            // 
            // GameTimer
            // 
            this.GameTimer.Interval = 150;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // BetNumericUpDown
            // 
            this.BetNumericUpDown.Location = new System.Drawing.Point(173, 44);
            this.BetNumericUpDown.Name = "BetNumericUpDown";
            this.BetNumericUpDown.Size = new System.Drawing.Size(102, 22);
            this.BetNumericUpDown.TabIndex = 17;
            // 
            // WinningsTextBox
            // 
            this.WinningsTextBox.Location = new System.Drawing.Point(389, 44);
            this.WinningsTextBox.Name = "WinningsTextBox";
            this.WinningsTextBox.Size = new System.Drawing.Size(100, 22);
            this.WinningsTextBox.TabIndex = 18;
            // 
            // MoneyTextBox
            // 
            this.MoneyTextBox.Location = new System.Drawing.Point(651, 43);
            this.MoneyTextBox.Name = "MoneyTextBox";
            this.MoneyTextBox.Size = new System.Drawing.Size(100, 22);
            this.MoneyTextBox.TabIndex = 19;
            // 
            // InterGameTimer
            // 
            this.InterGameTimer.Interval = 150;
            this.InterGameTimer.Tick += new System.EventHandler(this.InterGameTimer_Tick);
            // 
            // PokerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MoneyTextBox);
            this.Controls.Add(this.WinningsTextBox);
            this.Controls.Add(this.BetNumericUpDown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PlayButton);
            this.Controls.Add(this.Card5Button);
            this.Controls.Add(this.Card4Button);
            this.Controls.Add(this.Card3Button);
            this.Controls.Add(this.Card2Button);
            this.Controls.Add(this.Card1Button);
            this.Controls.Add(this.Card5PictureBox);
            this.Controls.Add(this.Card4PictureBox);
            this.Controls.Add(this.Card3PictureBox);
            this.Controls.Add(this.Card2PictureBox);
            this.Controls.Add(this.Card1PictureBox);
            this.Name = "PokerForm";
            this.Text = "PokerForm";
            this.Load += new System.EventHandler(this.PokerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Card1PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card2PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card3PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card4PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card5PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BetNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Card1PictureBox;
        private System.Windows.Forms.PictureBox Card2PictureBox;
        private System.Windows.Forms.PictureBox Card3PictureBox;
        private System.Windows.Forms.PictureBox Card4PictureBox;
        private System.Windows.Forms.PictureBox Card5PictureBox;
        private System.Windows.Forms.Button Card1Button;
        private System.Windows.Forms.Button Card2Button;
        private System.Windows.Forms.Button Card3Button;
        private System.Windows.Forms.Button Card4Button;
        private System.Windows.Forms.Button Card5Button;
        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.NumericUpDown BetNumericUpDown;
        private System.Windows.Forms.TextBox WinningsTextBox;
        private System.Windows.Forms.TextBox MoneyTextBox;
        private System.Windows.Forms.Timer InterGameTimer;
    }
}
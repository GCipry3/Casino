using System.Windows.Forms;

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
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.AddMoneyButton = new System.Windows.Forms.Button();
            this.AddMoneyGroupBox = new System.Windows.Forms.GroupBox();
            this.AddMoneyNumbericUpDown = new System.Windows.Forms.NumericUpDown();
            this.AddMoneyGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddMoneyNumbericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // CoinFlipButton
            // 
            this.CoinFlipButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CoinFlipButton.Location = new System.Drawing.Point(46, 58);
            this.CoinFlipButton.Name = "CoinFlipButton";
            this.CoinFlipButton.Size = new System.Drawing.Size(109, 33);
            this.CoinFlipButton.Location = new System.Drawing.Point(46, 94);
            this.CoinFlipButton.Name = "CoinFlipButton";
            this.CoinFlipButton.Size = new System.Drawing.Size(75, 23);
            this.CoinFlipButton.TabIndex = 1;
            this.CoinFlipButton.Text = "CoinFlip";
            this.CoinFlipButton.UseVisualStyleBackColor = true;
            this.CoinFlipButton.Visible = false;
            this.CoinFlipButton.Click += new System.EventHandler(this.CoinFlipButton_Click);
            // 
            // SlotsButton
            // 
            this.SlotsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SlotsButton.Location = new System.Drawing.Point(173, 107);
            this.SlotsButton.Name = "SlotsButton";
            this.SlotsButton.Size = new System.Drawing.Size(109, 33);
            this.SlotsButton.Location = new System.Drawing.Point(46, 118);
            this.SlotsButton.Name = "SlotsButton";
            this.SlotsButton.Size = new System.Drawing.Size(75, 23);
            this.SlotsButton.TabIndex = 2;
            this.SlotsButton.Text = "Slots";
            this.SlotsButton.UseVisualStyleBackColor = true;
            this.SlotsButton.Visible = false;
            this.SlotsButton.Click += new System.EventHandler(this.SlotsButton_Click);
            // 
            // HigherLowerButton
            // 
            this.HigherLowerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HigherLowerButton.Location = new System.Drawing.Point(46, 107);
            this.HigherLowerButton.Name = "HigherLowerButton";
            this.HigherLowerButton.Size = new System.Drawing.Size(109, 33);
            this.HigherLowerButton.Location = new System.Drawing.Point(46, 141);
            this.HigherLowerButton.Name = "HigherLowerButton";
            this.HigherLowerButton.Size = new System.Drawing.Size(75, 23);
            this.HigherLowerButton.TabIndex = 3;
            this.HigherLowerButton.Text = "HigherLower";
            this.HigherLowerButton.UseVisualStyleBackColor = true;
            this.HigherLowerButton.Visible = false;
            this.HigherLowerButton.Click += new System.EventHandler(this.HigherLowerButton_Click);
            // 
            // DicesGameButton
            // 
            this.DicesGameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DicesGameButton.Location = new System.Drawing.Point(173, 11);
            this.DicesGameButton.Name = "DicesGameButton";
            this.DicesGameButton.Size = new System.Drawing.Size(109, 33);
            this.DicesGameButton.Location = new System.Drawing.Point(46, 165);
            this.DicesGameButton.Name = "DicesGameButton";
            this.DicesGameButton.Size = new System.Drawing.Size(75, 23);
            this.DicesGameButton.TabIndex = 4;
            this.DicesGameButton.Text = "Dices";
            this.DicesGameButton.UseVisualStyleBackColor = true;
            this.DicesGameButton.Visible = false;
            this.DicesGameButton.Click += new System.EventHandler(this.DicesGameButton_Click);
            // 
            // BlackJackButton
            // 
            this.BlackJackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BlackJackButton.Location = new System.Drawing.Point(46, 11);
            this.BlackJackButton.Margin = new System.Windows.Forms.Padding(2);
            this.BlackJackButton.Name = "BlackJackButton";
            this.BlackJackButton.Size = new System.Drawing.Size(109, 33);
            this.BlackJackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BlackJackButton.Location = new System.Drawing.Point(62, 63);
            this.BlackJackButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BlackJackButton.Name = "BlackJackButton";
            this.BlackJackButton.Size = new System.Drawing.Size(75, 19);
            this.BlackJackButton.TabIndex = 5;
            this.BlackJackButton.Text = "BlackJack";
            this.BlackJackButton.UseVisualStyleBackColor = true;
            this.BlackJackButton.Visible = false;
            this.BlackJackButton.Click += new System.EventHandler(this.BlackJackButton_Click);
            // 
            // PokerButton
            // 
            this.PokerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PokerButton.Location = new System.Drawing.Point(173, 58);
            this.PokerButton.Name = "PokerButton";
            this.PokerButton.Size = new System.Drawing.Size(109, 33);
            this.PokerButton.Location = new System.Drawing.Point(62, 87);
            this.PokerButton.Name = "PokerButton";
            this.PokerButton.Size = new System.Drawing.Size(75, 23);
            this.PokerButton.TabIndex = 5;
            this.PokerButton.Text = "Poker";
            this.PokerButton.UseVisualStyleBackColor = true;
            this.PokerButton.Visible = false;
            this.PokerButton.Click += new System.EventHandler(this.PokerButton_Click);
            // 
            // HelpButton
            // 
            this.HelpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpButton.Location = new System.Drawing.Point(938, 477);
            this.HelpButton.Margin = new System.Windows.Forms.Padding(4);
            this.HelpButton.Location = new System.Drawing.Point(62, 271);
            this.HelpButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.HelpButton.Name = "HelpButton";
            this.HelpButton.Size = new System.Drawing.Size(75, 28);
            this.HelpButton.TabIndex = 6;
            this.HelpButton.Text = "Help";
            this.HelpButton.UseVisualStyleBackColor = true;
            this.HelpButton.Click += new System.EventHandler(this.HelpButton_Click);
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Location = new System.Drawing.Point(446, 196);
            this.UsernameTextBox.Location = new System.Drawing.Point(282, 177);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(183, 20);
            this.UsernameTextBox.TabIndex = 6;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(446, 252);
            this.PasswordTextBox.Location = new System.Drawing.Point(282, 233);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(183, 20);
            this.PasswordTextBox.TabIndex = 7;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.Location = new System.Drawing.Point(493, 173);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(78, 16);
            this.UsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.Location = new System.Drawing.Point(329, 154);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(83, 20);
            this.UsernameLabel.TabIndex = 8;
            this.UsernameLabel.Text = "Username";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.Location = new System.Drawing.Point(493, 229);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(75, 16);
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.Location = new System.Drawing.Point(329, 210);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(78, 20);
            this.PasswordLabel.TabIndex = 9;
            this.PasswordLabel.Text = "Password";
            // 
            // LoginButton
            // 
            this.LoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.Location = new System.Drawing.Point(446, 290);
            this.LoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.Location = new System.Drawing.Point(282, 271);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(85, 40);
            this.LoginButton.TabIndex = 10;
            this.LoginButton.Text = "Log In";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // RegisterButton
            // 
            this.RegisterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterButton.Location = new System.Drawing.Point(537, 290);
            this.RegisterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterButton.Location = new System.Drawing.Point(373, 271);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(92, 40);
            this.RegisterButton.TabIndex = 11;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // LogOutButton
            // 
            this.LogOutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOutButton.Location = new System.Drawing.Point(72, 453);
            this.LogOutButton.Margin = new System.Windows.Forms.Padding(2);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(97, 34);
            this.LogOutButton.TabIndex = 12;
            this.LogOutButton.Text = "Log Out";
            this.LogOutButton.UseVisualStyleBackColor = true;
            this.LogOutButton.Visible = false;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // AddMoneyButton
            // 
            this.AddMoneyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddMoneyButton.Location = new System.Drawing.Point(4, 15);
            this.AddMoneyButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddMoneyButton.Name = "AddMoneyButton";
            this.AddMoneyButton.Size = new System.Drawing.Size(141, 32);
            this.AddMoneyButton.TabIndex = 14;
            this.AddMoneyButton.Text = "Add Money";
            this.AddMoneyButton.UseVisualStyleBackColor = true;
            this.AddMoneyButton.Click += new System.EventHandler(this.AddMoneyButton_Click);
            // 
            // AddMoneyGroupBox
            // 
            this.AddMoneyGroupBox.Controls.Add(this.AddMoneyNumbericUpDown);
            this.AddMoneyGroupBox.Controls.Add(this.AddMoneyButton);
            this.AddMoneyGroupBox.Location = new System.Drawing.Point(441, 275);
            this.AddMoneyGroupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddMoneyGroupBox.Name = "AddMoneyGroupBox";
            this.AddMoneyGroupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddMoneyGroupBox.Size = new System.Drawing.Size(150, 81);
            this.AddMoneyGroupBox.TabIndex = 15;
            this.AddMoneyGroupBox.TabStop = false;
            this.AddMoneyGroupBox.Visible = false;
            // 
            // AddMoneyNumbericUpDown
            // 
            this.AddMoneyNumbericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddMoneyNumbericUpDown.Location = new System.Drawing.Point(4, 53);
            this.AddMoneyNumbericUpDown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddMoneyNumbericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.AddMoneyNumbericUpDown.Name = "AddMoneyNumbericUpDown";
            this.AddMoneyNumbericUpDown.Size = new System.Drawing.Size(141, 26);
            this.AddMoneyNumbericUpDown.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CasinoLobby.Properties.Resources.cartoon_dogs_playing_poker;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.LogOutButton);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddMoneyGroupBox);
            this.Controls.Add(this.HelpButton);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.UsernameTextBox);
            this.Controls.Add(this.BlackJackButton);
            this.Controls.Add(this.PokerButton);
            this.Controls.Add(this.DicesGameButton);
            this.Controls.Add(this.HigherLowerButton);
            this.Controls.Add(this.SlotsButton);
            this.Controls.Add(this.CoinFlipButton);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Casino";
            this.Name = "Form1";
            this.Text = "Form1";
            this.AddMoneyGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AddMoneyNumbericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button CoinFlipButton;
        private System.Windows.Forms.Button SlotsButton;
        private System.Windows.Forms.Button HigherLowerButton;
        private System.Windows.Forms.Button DicesGameButton;
        private System.Windows.Forms.Button BlackJackButton;
        private System.Windows.Forms.Button PokerButton;
        private System.Windows.Forms.Button HelpButton;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Button RegisterButton;
        private Button LogOutButton;
        private System.Windows.Forms.Button AddMoneyButton;
        private System.Windows.Forms.GroupBox AddMoneyGroupBox;
        private System.Windows.Forms.NumericUpDown AddMoneyNumbericUpDown;
    }
}


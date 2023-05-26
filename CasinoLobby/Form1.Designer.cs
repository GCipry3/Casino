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
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.InsertUserButton = new System.Windows.Forms.Button();
            this.DeleteUserButton = new System.Windows.Forms.Button();
            this.GetUserInfoButton = new System.Windows.Forms.Button();
            this.BalanceTextBox = new System.Windows.Forms.TextBox();
            this.RoleTextBox = new System.Windows.Forms.TextBox();
            this.UpdateUserButton = new System.Windows.Forms.Button();
            this.UserInfoLabel = new System.Windows.Forms.Label();
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
            // UsernameTextBox
            // 
            this.UsernameTextBox.Location = new System.Drawing.Point(277, 127);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(100, 20);
            this.UsernameTextBox.TabIndex = 5;
            this.UsernameTextBox.Text = "Username";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(277, 171);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(100, 20);
            this.PasswordTextBox.TabIndex = 6;
            this.PasswordTextBox.Text = "Password";
            // 
            // InsertUserButton
            // 
            this.InsertUserButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.InsertUserButton.Location = new System.Drawing.Point(277, 216);
            this.InsertUserButton.Name = "InsertUserButton";
            this.InsertUserButton.Size = new System.Drawing.Size(100, 23);
            this.InsertUserButton.TabIndex = 7;
            this.InsertUserButton.Text = "Insert";
            this.InsertUserButton.UseVisualStyleBackColor = false;
            this.InsertUserButton.Click += new System.EventHandler(this.InsertUserButton_Click);
            // 
            // DeleteUserButton
            // 
            this.DeleteUserButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.DeleteUserButton.Location = new System.Drawing.Point(277, 245);
            this.DeleteUserButton.Name = "DeleteUserButton";
            this.DeleteUserButton.Size = new System.Drawing.Size(100, 23);
            this.DeleteUserButton.TabIndex = 10;
            this.DeleteUserButton.Text = "Delete User";
            this.DeleteUserButton.UseVisualStyleBackColor = false;
            this.DeleteUserButton.Click += new System.EventHandler(this.DeleteUserButton_Click);
            // 
            // GetUserInfoButton
            // 
            this.GetUserInfoButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.GetUserInfoButton.Location = new System.Drawing.Point(277, 274);
            this.GetUserInfoButton.Name = "GetUserInfoButton";
            this.GetUserInfoButton.Size = new System.Drawing.Size(100, 23);
            this.GetUserInfoButton.TabIndex = 13;
            this.GetUserInfoButton.Text = "GetUserInfo";
            this.GetUserInfoButton.UseVisualStyleBackColor = false;
            this.GetUserInfoButton.Click += new System.EventHandler(this.GetUserInfoButton_Click);
            // 
            // BalanceTextBox
            // 
            this.BalanceTextBox.Location = new System.Drawing.Point(277, 338);
            this.BalanceTextBox.Name = "BalanceTextBox";
            this.BalanceTextBox.Size = new System.Drawing.Size(100, 20);
            this.BalanceTextBox.TabIndex = 12;
            this.BalanceTextBox.Text = "Balance";
            // 
            // RoleTextBox
            // 
            this.RoleTextBox.Location = new System.Drawing.Point(277, 312);
            this.RoleTextBox.Name = "RoleTextBox";
            this.RoleTextBox.Size = new System.Drawing.Size(100, 20);
            this.RoleTextBox.TabIndex = 11;
            this.RoleTextBox.Text = "Role (Admin/User)";
            // 
            // UpdateUserButton
            // 
            this.UpdateUserButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.UpdateUserButton.Location = new System.Drawing.Point(277, 366);
            this.UpdateUserButton.Name = "UpdateUserButton";
            this.UpdateUserButton.Size = new System.Drawing.Size(100, 23);
            this.UpdateUserButton.TabIndex = 16;
            this.UpdateUserButton.Text = "Update";
            this.UpdateUserButton.UseVisualStyleBackColor = false;
            this.UpdateUserButton.Click += new System.EventHandler(this.UpdateUserButton_Click);
            // 
            // UserInfoLabel
            // 
            this.UserInfoLabel.AutoSize = true;
            this.UserInfoLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.UserInfoLabel.Location = new System.Drawing.Point(404, 283);
            this.UserInfoLabel.Name = "UserInfoLabel";
            this.UserInfoLabel.Size = new System.Drawing.Size(195, 13);
            this.UserInfoLabel.TabIndex = 17;
            this.UserInfoLabel.Text = "Username: ;Password: ;Balance: ;Role: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UserInfoLabel);
            this.Controls.Add(this.UpdateUserButton);
            this.Controls.Add(this.GetUserInfoButton);
            this.Controls.Add(this.BalanceTextBox);
            this.Controls.Add(this.RoleTextBox);
            this.Controls.Add(this.DeleteUserButton);
            this.Controls.Add(this.InsertUserButton);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.UsernameTextBox);
            this.Controls.Add(this.DicesGameButton);
            this.Controls.Add(this.higherLowerButton);
            this.Controls.Add(this.SlotsButton);
            this.Controls.Add(this.CoinFlipButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button CoinFlipButton;
        private System.Windows.Forms.Button SlotsButton;
        private System.Windows.Forms.Button higherLowerButton;
        private System.Windows.Forms.Button DicesGameButton;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Button InsertUserButton;
        private System.Windows.Forms.Button DeleteUserButton;
        private System.Windows.Forms.Button GetUserInfoButton;
        private System.Windows.Forms.TextBox BalanceTextBox;
        private System.Windows.Forms.TextBox RoleTextBox;
        private System.Windows.Forms.Button UpdateUserButton;
        private System.Windows.Forms.Label UserInfoLabel;
    }
}


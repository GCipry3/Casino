namespace CasinoLobby
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
            this.higherButton = new System.Windows.Forms.Button();
            this.lowerButton = new System.Windows.Forms.Button();
            this.betNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.winningsTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.moneyTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.shuffleTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.betNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // higherButton
            // 
            this.higherButton.Location = new System.Drawing.Point(282, 367);
            this.higherButton.Name = "higherButton";
            this.higherButton.Size = new System.Drawing.Size(82, 42);
            this.higherButton.TabIndex = 0;
            this.higherButton.Text = "Higher";
            this.higherButton.UseVisualStyleBackColor = true;
            this.higherButton.Click += new System.EventHandler(this.higherButton_Click);
            // 
            // lowerButton
            // 
            this.lowerButton.Location = new System.Drawing.Point(409, 367);
            this.lowerButton.Name = "lowerButton";
            this.lowerButton.Size = new System.Drawing.Size(82, 42);
            this.lowerButton.TabIndex = 1;
            this.lowerButton.Text = "Lower";
            this.lowerButton.UseVisualStyleBackColor = true;
            this.lowerButton.Click += new System.EventHandler(this.lowerButton_Click);
            // 
            // betNumericUpDown
            // 
            this.betNumericUpDown.Location = new System.Drawing.Point(116, 97);
            this.betNumericUpDown.Name = "betNumericUpDown";
            this.betNumericUpDown.Size = new System.Drawing.Size(73, 22);
            this.betNumericUpDown.TabIndex = 3;
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
            // winningsTextBox
            // 
            this.winningsTextBox.Location = new System.Drawing.Point(143, 31);
            this.winningsTextBox.Name = "winningsTextBox";
            this.winningsTextBox.Size = new System.Drawing.Size(86, 22);
            this.winningsTextBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Winnings :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(541, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Total funds :";
            // 
            // moneyTextBox
            // 
            this.moneyTextBox.Location = new System.Drawing.Point(626, 31);
            this.moneyTextBox.Name = "moneyTextBox";
            this.moneyTextBox.Size = new System.Drawing.Size(109, 22);
            this.moneyTextBox.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CasinoLobby.Properties.Resources.ainima;
            this.pictureBox1.Location = new System.Drawing.Point(282, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(209, 317);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // shuffleTimer
            // 
            this.shuffleTimer.Interval = 150;
            this.shuffleTimer.Tick += new System.EventHandler(this.shuffleTimer_Tick);
            // 
            // HigherLower
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.moneyTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.winningsTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.betNumericUpDown);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lowerButton);
            this.Controls.Add(this.higherButton);
            this.Name = "HigherLower";
            this.Text = "HigherLower";
            this.Load += new System.EventHandler(this.HigherLower_Load);
            ((System.ComponentModel.ISupportInitialize)(this.betNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button higherButton;
        private System.Windows.Forms.Button lowerButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown betNumericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox winningsTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox moneyTextBox;
        private System.Windows.Forms.Timer shuffleTimer;
    }
}
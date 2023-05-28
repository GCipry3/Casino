namespace SlotsGame
{
    partial class Slots
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
            this.PlayButton = new System.Windows.Forms.Button();
            this.BetNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.betLabel = new System.Windows.Forms.Label();
            this.moneyLabel = new System.Windows.Forms.Label();
            this.MoneyTextBox = new System.Windows.Forms.TextBox();
            this.winningsLabel = new System.Windows.Forms.Label();
            this.WinningsTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Slot3PictureBox = new System.Windows.Forms.PictureBox();
            this.Slot2PictureBox = new System.Windows.Forms.PictureBox();
            this.Slot1PictureBox = new System.Windows.Forms.PictureBox();
            this.TimerSlots1 = new System.Windows.Forms.Timer(this.components);
            this.TimerPlayerStop = new System.Windows.Forms.Timer(this.components);
            this.TimerSlots2 = new System.Windows.Forms.Timer(this.components);
            this.TimerSlots3 = new System.Windows.Forms.Timer(this.components);
            this.TimerAutoStop = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.BetNumericUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Slot3PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Slot2PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Slot1PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // PlayButton
            // 
            this.PlayButton.Location = new System.Drawing.Point(371, 218);
            this.PlayButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(68, 34);
            this.PlayButton.TabIndex = 3;
            this.PlayButton.Text = "Play";
            this.PlayButton.UseVisualStyleBackColor = true;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // BetNumericUpDown
            // 
            this.BetNumericUpDown.Location = new System.Drawing.Point(79, 225);
            this.BetNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BetNumericUpDown.Name = "BetNumericUpDown";
            this.BetNumericUpDown.Size = new System.Drawing.Size(55, 22);
            this.BetNumericUpDown.TabIndex = 4;
            // 
            // betLabel
            // 
            this.betLabel.AutoSize = true;
            this.betLabel.Location = new System.Drawing.Point(57, 199);
            this.betLabel.Name = "betLabel";
            this.betLabel.Size = new System.Drawing.Size(105, 16);
            this.betLabel.TabIndex = 5;
            this.betLabel.Text = "Choose your bet";
            // 
            // moneyLabel
            // 
            this.moneyLabel.AutoSize = true;
            this.moneyLabel.Location = new System.Drawing.Point(445, 47);
            this.moneyLabel.Name = "moneyLabel";
            this.moneyLabel.Size = new System.Drawing.Size(79, 16);
            this.moneyLabel.TabIndex = 6;
            this.moneyLabel.Text = "Total funds :";
            // 
            // MoneyTextBox
            // 
            this.MoneyTextBox.Location = new System.Drawing.Point(531, 47);
            this.MoneyTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MoneyTextBox.Name = "MoneyTextBox";
            this.MoneyTextBox.Size = new System.Drawing.Size(220, 22);
            this.MoneyTextBox.TabIndex = 7;
            // 
            // winningsLabel
            // 
            this.winningsLabel.AutoSize = true;
            this.winningsLabel.Location = new System.Drawing.Point(168, 47);
            this.winningsLabel.Name = "winningsLabel";
            this.winningsLabel.Size = new System.Drawing.Size(68, 16);
            this.winningsLabel.TabIndex = 8;
            this.winningsLabel.Text = "Winnings :";
            // 
            // WinningsTextBox
            // 
            this.WinningsTextBox.Location = new System.Drawing.Point(243, 44);
            this.WinningsTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WinningsTextBox.Name = "WinningsTextBox";
            this.WinningsTextBox.Size = new System.Drawing.Size(71, 22);
            this.WinningsTextBox.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SaddleBrown;
            this.groupBox1.Controls.Add(this.betLabel);
            this.groupBox1.Controls.Add(this.BetNumericUpDown);
            this.groupBox1.Controls.Add(this.PlayButton);
            this.groupBox1.Controls.Add(this.Slot3PictureBox);
            this.groupBox1.Controls.Add(this.Slot2PictureBox);
            this.groupBox1.Controls.Add(this.Slot1PictureBox);
            this.groupBox1.Location = new System.Drawing.Point(127, 92);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(515, 290);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // Slot3PictureBox
            // 
            this.Slot3PictureBox.Image = global::SlotsGame.Properties.Resources._7;
            this.Slot3PictureBox.Location = new System.Drawing.Point(343, 42);
            this.Slot3PictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Slot3PictureBox.Name = "Slot3PictureBox";
            this.Slot3PictureBox.Size = new System.Drawing.Size(131, 130);
            this.Slot3PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Slot3PictureBox.TabIndex = 2;
            this.Slot3PictureBox.TabStop = false;
            // 
            // Slot2PictureBox
            // 
            this.Slot2PictureBox.Image = global::SlotsGame.Properties.Resources._7;
            this.Slot2PictureBox.Location = new System.Drawing.Point(195, 42);
            this.Slot2PictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Slot2PictureBox.Name = "Slot2PictureBox";
            this.Slot2PictureBox.Size = new System.Drawing.Size(131, 130);
            this.Slot2PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Slot2PictureBox.TabIndex = 1;
            this.Slot2PictureBox.TabStop = false;
            // 
            // Slot1PictureBox
            // 
            this.Slot1PictureBox.ErrorImage = global::SlotsGame.Properties.Resources._7;
            this.Slot1PictureBox.Image = global::SlotsGame.Properties.Resources._7;
            this.Slot1PictureBox.Location = new System.Drawing.Point(44, 42);
            this.Slot1PictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Slot1PictureBox.Name = "Slot1PictureBox";
            this.Slot1PictureBox.Size = new System.Drawing.Size(131, 130);
            this.Slot1PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Slot1PictureBox.TabIndex = 0;
            this.Slot1PictureBox.TabStop = false;
            // 
            // TimerSlots1
            // 
            this.TimerSlots1.Interval = 50;
            this.TimerSlots1.Tick += new System.EventHandler(this.TimerSlots1_Tick);
            // 
            // TimerPlayerStop
            // 
            this.TimerPlayerStop.Interval = 200;
            this.TimerPlayerStop.Tick += new System.EventHandler(this.TimerPlayerStop_Tick);
            // 
            // TimerSlots2
            // 
            this.TimerSlots2.Interval = 50;
            this.TimerSlots2.Tick += new System.EventHandler(this.TimerSlots2_Tick);
            // 
            // TimerSlots3
            // 
            this.TimerSlots3.Interval = 50;
            this.TimerSlots3.Tick += new System.EventHandler(this.TimerSlots3_Tick);
            // 
            // TimerAutoStop
            // 
            this.TimerAutoStop.Interval = 50;
            this.TimerAutoStop.Tick += new System.EventHandler(this.TimerAutoStop_Tick);
            // 
            // Slots
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.WinningsTextBox);
            this.Controls.Add(this.winningsLabel);
            this.Controls.Add(this.MoneyTextBox);
            this.Controls.Add(this.moneyLabel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Slots";
            this.Text = "Slots";
            ((System.ComponentModel.ISupportInitialize)(this.BetNumericUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Slot3PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Slot2PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Slot1PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Slot1PictureBox;
        private System.Windows.Forms.PictureBox Slot2PictureBox;
        private System.Windows.Forms.PictureBox Slot3PictureBox;
        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.NumericUpDown BetNumericUpDown;
        private System.Windows.Forms.Label betLabel;
        private System.Windows.Forms.Label moneyLabel;
        private System.Windows.Forms.TextBox MoneyTextBox;
        private System.Windows.Forms.Label winningsLabel;
        private System.Windows.Forms.TextBox WinningsTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Timer TimerSlots1;
        private System.Windows.Forms.Timer TimerPlayerStop;
        private System.Windows.Forms.Timer TimerSlots2;
        private System.Windows.Forms.Timer TimerSlots3;
        private System.Windows.Forms.Timer TimerAutoStop;
    }
}
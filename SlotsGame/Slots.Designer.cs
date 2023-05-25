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
            this.playButton = new System.Windows.Forms.Button();
            this.betNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.betLabel = new System.Windows.Forms.Label();
            this.moneyLabel = new System.Windows.Forms.Label();
            this.moneyTextBox = new System.Windows.Forms.TextBox();
            this.winningsLabel = new System.Windows.Forms.Label();
            this.winningsTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.timerSlots1 = new System.Windows.Forms.Timer(this.components);
            this.timerStop = new System.Windows.Forms.Timer(this.components);
            this.timerSlots2 = new System.Windows.Forms.Timer(this.components);
            this.timerSlots3 = new System.Windows.Forms.Timer(this.components);
            this.timerAuto = new System.Windows.Forms.Timer(this.components);
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.betNumericUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(278, 177);
            this.playButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(51, 28);
            this.playButton.TabIndex = 3;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // betNumericUpDown
            // 
            this.betNumericUpDown.Location = new System.Drawing.Point(59, 183);
            this.betNumericUpDown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.betNumericUpDown.Name = "betNumericUpDown";
            this.betNumericUpDown.Size = new System.Drawing.Size(41, 20);
            this.betNumericUpDown.TabIndex = 4;
            // 
            // betLabel
            // 
            this.betLabel.AutoSize = true;
            this.betLabel.Location = new System.Drawing.Point(43, 162);
            this.betLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.betLabel.Name = "betLabel";
            this.betLabel.Size = new System.Drawing.Size(84, 13);
            this.betLabel.TabIndex = 5;
            this.betLabel.Text = "Choose your bet";
            // 
            // moneyLabel
            // 
            this.moneyLabel.AutoSize = true;
            this.moneyLabel.Location = new System.Drawing.Point(334, 38);
            this.moneyLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.moneyLabel.Name = "moneyLabel";
            this.moneyLabel.Size = new System.Drawing.Size(66, 13);
            this.moneyLabel.TabIndex = 6;
            this.moneyLabel.Text = "Total funds :";
            // 
            // moneyTextBox
            // 
            this.moneyTextBox.Location = new System.Drawing.Point(398, 38);
            this.moneyTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.moneyTextBox.Name = "moneyTextBox";
            this.moneyTextBox.Size = new System.Drawing.Size(166, 20);
            this.moneyTextBox.TabIndex = 7;
            // 
            // winningsLabel
            // 
            this.winningsLabel.AutoSize = true;
            this.winningsLabel.Location = new System.Drawing.Point(126, 38);
            this.winningsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.winningsLabel.Name = "winningsLabel";
            this.winningsLabel.Size = new System.Drawing.Size(57, 13);
            this.winningsLabel.TabIndex = 8;
            this.winningsLabel.Text = "Winnings :";
            this.winningsLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // winningsTextBox
            // 
            this.winningsTextBox.Location = new System.Drawing.Point(182, 36);
            this.winningsTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.winningsTextBox.Name = "winningsTextBox";
            this.winningsTextBox.Size = new System.Drawing.Size(54, 20);
            this.winningsTextBox.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SaddleBrown;
            this.groupBox1.Controls.Add(this.betLabel);
            this.groupBox1.Controls.Add(this.betNumericUpDown);
            this.groupBox1.Controls.Add(this.playButton);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(95, 75);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(386, 236);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // timerSlots1
            // 
            this.timerSlots1.Interval = 50;
            this.timerSlots1.Tick += new System.EventHandler(this.timerSlots1_Tick);
            // 
            // timerStop
            // 
            this.timerStop.Interval = 200;
            this.timerStop.Tick += new System.EventHandler(this.timerStop_Tick);
            // 
            // timerSlots2
            // 
            this.timerSlots2.Interval = 50;
            this.timerSlots2.Tick += new System.EventHandler(this.timerSlots2_Tick);
            // 
            // timerSlots3
            // 
            this.timerSlots3.Interval = 50;
            this.timerSlots3.Tick += new System.EventHandler(this.timerSlots3_Tick);
            // 
            // timerAuto
            // 
            this.timerAuto.Interval = 50;
            this.timerAuto.Tick += new System.EventHandler(this.timerAuto_Tick);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::SlotsGame.Properties.Resources._7;
            this.pictureBox3.Location = new System.Drawing.Point(257, 34);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(98, 106);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SlotsGame.Properties.Resources._7;
            this.pictureBox2.Location = new System.Drawing.Point(146, 34);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(98, 106);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::SlotsGame.Properties.Resources._7;
            this.pictureBox1.Location = new System.Drawing.Point(33, 34);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(98, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Slots
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.winningsTextBox);
            this.Controls.Add(this.winningsLabel);
            this.Controls.Add(this.moneyTextBox);
            this.Controls.Add(this.moneyLabel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Slots";
            this.Text = "Slots";
            this.Load += new System.EventHandler(this.Slots_Load);
            ((System.ComponentModel.ISupportInitialize)(this.betNumericUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.NumericUpDown betNumericUpDown;
        private System.Windows.Forms.Label betLabel;
        private System.Windows.Forms.Label moneyLabel;
        private System.Windows.Forms.TextBox moneyTextBox;
        private System.Windows.Forms.Label winningsLabel;
        private System.Windows.Forms.TextBox winningsTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Timer timerSlots1;
        private System.Windows.Forms.Timer timerStop;
        private System.Windows.Forms.Timer timerSlots2;
        private System.Windows.Forms.Timer timerSlots3;
        private System.Windows.Forms.Timer timerAuto;
    }
}
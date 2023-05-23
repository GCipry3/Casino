namespace CasinoLobby
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Slots));
            this.playButton = new System.Windows.Forms.Button();
            this.betNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.betLabel = new System.Windows.Forms.Label();
            this.moneyLabel = new System.Windows.Forms.Label();
            this.moneyTextBox = new System.Windows.Forms.TextBox();
            this.winningsLabel = new System.Windows.Forms.Label();
            this.winningsTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timerSlots1 = new System.Windows.Forms.Timer(this.components);
            this.timerStop = new System.Windows.Forms.Timer(this.components);
            this.timerSlots2 = new System.Windows.Forms.Timer(this.components);
            this.timerSlots3 = new System.Windows.Forms.Timer(this.components);
            this.timerAuto = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.betNumericUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(371, 218);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(68, 35);
            this.playButton.TabIndex = 3;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // betNumericUpDown
            // 
            this.betNumericUpDown.Location = new System.Drawing.Point(79, 225);
            this.betNumericUpDown.Name = "betNumericUpDown";
            this.betNumericUpDown.Size = new System.Drawing.Size(55, 22);
            this.betNumericUpDown.TabIndex = 4;
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
            // moneyTextBox
            // 
            this.moneyTextBox.Location = new System.Drawing.Point(530, 47);
            this.moneyTextBox.Name = "moneyTextBox";
            this.moneyTextBox.Size = new System.Drawing.Size(220, 22);
            this.moneyTextBox.TabIndex = 7;
            // 
            // winningsLabel
            // 
            this.winningsLabel.AutoSize = true;
            this.winningsLabel.Location = new System.Drawing.Point(168, 47);
            this.winningsLabel.Name = "winningsLabel";
            this.winningsLabel.Size = new System.Drawing.Size(68, 16);
            this.winningsLabel.TabIndex = 8;
            this.winningsLabel.Text = "Winnings :";
            this.winningsLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // winningsTextBox
            // 
            this.winningsTextBox.Location = new System.Drawing.Point(242, 44);
            this.winningsTextBox.Name = "winningsTextBox";
            this.winningsTextBox.Size = new System.Drawing.Size(70, 22);
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
            this.groupBox1.Location = new System.Drawing.Point(127, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(514, 290);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(343, 42);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(130, 130);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(194, 42);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(130, 130);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(44, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
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
            // Slots
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.winningsTextBox);
            this.Controls.Add(this.winningsLabel);
            this.Controls.Add(this.moneyTextBox);
            this.Controls.Add(this.moneyLabel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
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
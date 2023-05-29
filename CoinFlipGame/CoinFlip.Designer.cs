namespace CoinFlipGame
{
    partial class CoinFlip
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CoinFlip));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.bunifuLabelResult = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuButtonFlipCoin = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.pictureBoxCoin = new System.Windows.Forms.PictureBox();
            this.comboBoxCoinFace = new System.Windows.Forms.ComboBox();
            this.HeadsCountLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.TailsCountLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.timerFlip = new System.Windows.Forms.Timer(this.components);
            this.WinningsTextBox = new System.Windows.Forms.TextBox();
            this.FundsTextBox = new System.Windows.Forms.TextBox();
            this.WinningsLabel = new System.Windows.Forms.Label();
            this.FundsLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BetNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BetNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuLabelResult
            // 
            this.bunifuLabelResult.AllowParentOverrides = false;
            this.bunifuLabelResult.AutoEllipsis = false;
            this.bunifuLabelResult.AutoSize = false;
            this.bunifuLabelResult.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabelResult.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabelResult.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabelResult.Location = new System.Drawing.Point(324, 360);
            this.bunifuLabelResult.Name = "bunifuLabelResult";
            this.bunifuLabelResult.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabelResult.Size = new System.Drawing.Size(150, 44);
            this.bunifuLabelResult.TabIndex = 0;
            this.bunifuLabelResult.Text = "Result";
            this.bunifuLabelResult.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuLabelResult.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuButtonFlipCoin
            // 
            this.bunifuButtonFlipCoin.AllowAnimations = true;
            this.bunifuButtonFlipCoin.AllowMouseEffects = true;
            this.bunifuButtonFlipCoin.AllowToggling = false;
            this.bunifuButtonFlipCoin.AnimationSpeed = 200;
            this.bunifuButtonFlipCoin.AutoGenerateColors = false;
            this.bunifuButtonFlipCoin.AutoRoundBorders = false;
            this.bunifuButtonFlipCoin.AutoSizeLeftIcon = true;
            this.bunifuButtonFlipCoin.AutoSizeRightIcon = true;
            this.bunifuButtonFlipCoin.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButtonFlipCoin.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.bunifuButtonFlipCoin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButtonFlipCoin.BackgroundImage")));
            this.bunifuButtonFlipCoin.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButtonFlipCoin.ButtonText = "Flip Coin";
            this.bunifuButtonFlipCoin.ButtonTextMarginLeft = 0;
            this.bunifuButtonFlipCoin.ColorContrastOnClick = 45;
            this.bunifuButtonFlipCoin.ColorContrastOnHover = 45;
            this.bunifuButtonFlipCoin.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.bunifuButtonFlipCoin.CustomizableEdges = borderEdges3;
            this.bunifuButtonFlipCoin.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuButtonFlipCoin.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButtonFlipCoin.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButtonFlipCoin.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButtonFlipCoin.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.bunifuButtonFlipCoin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuButtonFlipCoin.ForeColor = System.Drawing.Color.White;
            this.bunifuButtonFlipCoin.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuButtonFlipCoin.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButtonFlipCoin.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.bunifuButtonFlipCoin.IconMarginLeft = 11;
            this.bunifuButtonFlipCoin.IconPadding = 10;
            this.bunifuButtonFlipCoin.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuButtonFlipCoin.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButtonFlipCoin.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.bunifuButtonFlipCoin.IconSize = 25;
            this.bunifuButtonFlipCoin.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButtonFlipCoin.IdleBorderRadius = 1;
            this.bunifuButtonFlipCoin.IdleBorderThickness = 1;
            this.bunifuButtonFlipCoin.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButtonFlipCoin.IdleIconLeftImage = null;
            this.bunifuButtonFlipCoin.IdleIconRightImage = null;
            this.bunifuButtonFlipCoin.IndicateFocus = false;
            this.bunifuButtonFlipCoin.Location = new System.Drawing.Point(12, 120);
            this.bunifuButtonFlipCoin.Name = "bunifuButtonFlipCoin";
            this.bunifuButtonFlipCoin.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButtonFlipCoin.OnDisabledState.BorderRadius = 1;
            this.bunifuButtonFlipCoin.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButtonFlipCoin.OnDisabledState.BorderThickness = 1;
            this.bunifuButtonFlipCoin.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButtonFlipCoin.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButtonFlipCoin.OnDisabledState.IconLeftImage = null;
            this.bunifuButtonFlipCoin.OnDisabledState.IconRightImage = null;
            this.bunifuButtonFlipCoin.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuButtonFlipCoin.onHoverState.BorderRadius = 1;
            this.bunifuButtonFlipCoin.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButtonFlipCoin.onHoverState.BorderThickness = 1;
            this.bunifuButtonFlipCoin.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuButtonFlipCoin.onHoverState.ForeColor = System.Drawing.Color.White;
            this.bunifuButtonFlipCoin.onHoverState.IconLeftImage = null;
            this.bunifuButtonFlipCoin.onHoverState.IconRightImage = null;
            this.bunifuButtonFlipCoin.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButtonFlipCoin.OnIdleState.BorderRadius = 1;
            this.bunifuButtonFlipCoin.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButtonFlipCoin.OnIdleState.BorderThickness = 1;
            this.bunifuButtonFlipCoin.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButtonFlipCoin.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.bunifuButtonFlipCoin.OnIdleState.IconLeftImage = null;
            this.bunifuButtonFlipCoin.OnIdleState.IconRightImage = null;
            this.bunifuButtonFlipCoin.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButtonFlipCoin.OnPressedState.BorderRadius = 1;
            this.bunifuButtonFlipCoin.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButtonFlipCoin.OnPressedState.BorderThickness = 1;
            this.bunifuButtonFlipCoin.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButtonFlipCoin.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.bunifuButtonFlipCoin.OnPressedState.IconLeftImage = null;
            this.bunifuButtonFlipCoin.OnPressedState.IconRightImage = null;
            this.bunifuButtonFlipCoin.Size = new System.Drawing.Size(150, 40);
            this.bunifuButtonFlipCoin.TabIndex = 1;
            this.bunifuButtonFlipCoin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButtonFlipCoin.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bunifuButtonFlipCoin.TextMarginLeft = 0;
            this.bunifuButtonFlipCoin.TextPadding = new System.Windows.Forms.Padding(0);
            this.bunifuButtonFlipCoin.UseDefaultRadiusAndThickness = true;
            this.bunifuButtonFlipCoin.Click += new System.EventHandler(this.bunifuButtonFlipCoin_Click);
            // 
            // pictureBoxCoin
            // 
            this.pictureBoxCoin.Image = global::CoinFlipGame.Properties.Resources.coinTails;
            this.pictureBoxCoin.Location = new System.Drawing.Point(324, 181);
            this.pictureBoxCoin.Name = "pictureBoxCoin";
            this.pictureBoxCoin.Size = new System.Drawing.Size(150, 150);
            this.pictureBoxCoin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCoin.TabIndex = 2;
            this.pictureBoxCoin.TabStop = false;
            // 
            // comboBoxCoinFace
            // 
            this.comboBoxCoinFace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCoinFace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCoinFace.FormattingEnabled = true;
            this.comboBoxCoinFace.Items.AddRange(new object[] {
            "Heads",
            "Tails"});
            this.comboBoxCoinFace.Location = new System.Drawing.Point(12, 181);
            this.comboBoxCoinFace.Name = "comboBoxCoinFace";
            this.comboBoxCoinFace.Size = new System.Drawing.Size(150, 28);
            this.comboBoxCoinFace.TabIndex = 3;
            // 
            // HeadsCountLabel
            // 
            this.HeadsCountLabel.AllowParentOverrides = false;
            this.HeadsCountLabel.AutoEllipsis = false;
            this.HeadsCountLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.HeadsCountLabel.CursorType = System.Windows.Forms.Cursors.Default;
            this.HeadsCountLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeadsCountLabel.Location = new System.Drawing.Point(47, 128);
            this.HeadsCountLabel.Name = "HeadsCountLabel";
            this.HeadsCountLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.HeadsCountLabel.Size = new System.Drawing.Size(80, 30);
            this.HeadsCountLabel.TabIndex = 4;
            this.HeadsCountLabel.Text = "Heads: 0";
            this.HeadsCountLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.HeadsCountLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // TailsCountLabel
            // 
            this.TailsCountLabel.AllowParentOverrides = false;
            this.TailsCountLabel.AutoEllipsis = false;
            this.TailsCountLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.TailsCountLabel.CursorType = System.Windows.Forms.Cursors.Default;
            this.TailsCountLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TailsCountLabel.Location = new System.Drawing.Point(47, 61);
            this.TailsCountLabel.Name = "TailsCountLabel";
            this.TailsCountLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TailsCountLabel.Size = new System.Drawing.Size(63, 30);
            this.TailsCountLabel.TabIndex = 5;
            this.TailsCountLabel.Text = "Tails: 0";
            this.TailsCountLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.TailsCountLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // timerFlip
            // 
            this.timerFlip.Tick += new System.EventHandler(this.timerFlip_Tick);
            // 
            // WinningsTextBox
            // 
            this.WinningsTextBox.Location = new System.Drawing.Point(507, 41);
            this.WinningsTextBox.Name = "WinningsTextBox";
            this.WinningsTextBox.ReadOnly = true;
            this.WinningsTextBox.Size = new System.Drawing.Size(100, 20);
            this.WinningsTextBox.TabIndex = 6;
            // 
            // FundsTextBox
            // 
            this.FundsTextBox.Location = new System.Drawing.Point(663, 41);
            this.FundsTextBox.Name = "FundsTextBox";
            this.FundsTextBox.ReadOnly = true;
            this.FundsTextBox.Size = new System.Drawing.Size(100, 20);
            this.FundsTextBox.TabIndex = 7;
            // 
            // WinningsLabel
            // 
            this.WinningsLabel.AutoSize = true;
            this.WinningsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WinningsLabel.Location = new System.Drawing.Point(512, 18);
            this.WinningsLabel.Name = "WinningsLabel";
            this.WinningsLabel.Size = new System.Drawing.Size(82, 20);
            this.WinningsLabel.TabIndex = 8;
            this.WinningsLabel.Text = "Winnings";
            // 
            // FundsLabel
            // 
            this.FundsLabel.AutoSize = true;
            this.FundsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FundsLabel.Location = new System.Drawing.Point(659, 18);
            this.FundsLabel.Name = "FundsLabel";
            this.FundsLabel.Size = new System.Drawing.Size(104, 20);
            this.FundsLabel.TabIndex = 9;
            this.FundsLabel.Text = "Total Funds";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TailsCountLabel);
            this.groupBox1.Controls.Add(this.HeadsCountLabel);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(588, 135);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(175, 221);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Previous Results";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 278);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "Choose You Bet";
            // 
            // BetNumericUpDown
            // 
            this.BetNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BetNumericUpDown.Location = new System.Drawing.Point(12, 311);
            this.BetNumericUpDown.Name = "BetNumericUpDown";
            this.BetNumericUpDown.Size = new System.Drawing.Size(150, 26);
            this.BetNumericUpDown.TabIndex = 13;
            this.BetNumericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // CoinFlip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BetNumericUpDown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.FundsLabel);
            this.Controls.Add(this.WinningsLabel);
            this.Controls.Add(this.FundsTextBox);
            this.Controls.Add(this.WinningsTextBox);
            this.Controls.Add(this.comboBoxCoinFace);
            this.Controls.Add(this.pictureBoxCoin);
            this.Controls.Add(this.bunifuButtonFlipCoin);
            this.Controls.Add(this.bunifuLabelResult);
            this.Name = "CoinFlip";
            this.Text = "CoinFlip";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BetNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Bunifu.UI.WinForms.BunifuLabel bunifuLabelResult;
        public Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButtonFlipCoin;
        public System.Windows.Forms.PictureBox pictureBoxCoin;
        public System.Windows.Forms.ComboBox comboBoxCoinFace;
        public Bunifu.UI.WinForms.BunifuLabel HeadsCountLabel;
        public Bunifu.UI.WinForms.BunifuLabel TailsCountLabel;
        public System.Windows.Forms.Timer timerFlip;
        private System.Windows.Forms.TextBox WinningsTextBox;
        private System.Windows.Forms.TextBox FundsTextBox;
        private System.Windows.Forms.Label WinningsLabel;
        private System.Windows.Forms.Label FundsLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown BetNumericUpDown;
    }
}
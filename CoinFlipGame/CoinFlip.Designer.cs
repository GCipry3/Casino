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
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.bunifuLabelResult = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuButtonFlipCoin = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.pictureBoxCoin = new System.Windows.Forms.PictureBox();
            this.comboBoxCoinFace = new System.Windows.Forms.ComboBox();
            this.HeadsCountLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.TailsCountLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.timerFlip = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin)).BeginInit();
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
            this.bunifuLabelResult.Location = new System.Drawing.Point(324, 300);
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
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.bunifuButtonFlipCoin.CustomizableEdges = borderEdges1;
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
            this.bunifuButtonFlipCoin.Location = new System.Drawing.Point(12, 177);
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
            this.bunifuButtonFlipCoin.Size = new System.Drawing.Size(121, 40);
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
            this.pictureBoxCoin.Location = new System.Drawing.Point(324, 144);
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
            this.comboBoxCoinFace.Location = new System.Drawing.Point(12, 223);
            this.comboBoxCoinFace.Name = "comboBoxCoinFace";
            this.comboBoxCoinFace.Size = new System.Drawing.Size(121, 28);
            this.comboBoxCoinFace.TabIndex = 3;
            // 
            // HeadsCountLabel
            // 
            this.HeadsCountLabel.AllowParentOverrides = false;
            this.HeadsCountLabel.AutoEllipsis = false;
            this.HeadsCountLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.HeadsCountLabel.CursorType = System.Windows.Forms.Cursors.Default;
            this.HeadsCountLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.HeadsCountLabel.Location = new System.Drawing.Point(13, 13);
            this.HeadsCountLabel.Name = "HeadsCountLabel";
            this.HeadsCountLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.HeadsCountLabel.Size = new System.Drawing.Size(59, 21);
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
            this.TailsCountLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TailsCountLabel.Location = new System.Drawing.Point(13, 40);
            this.TailsCountLabel.Name = "TailsCountLabel";
            this.TailsCountLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TailsCountLabel.Size = new System.Drawing.Size(47, 21);
            this.TailsCountLabel.TabIndex = 5;
            this.TailsCountLabel.Text = "Tails: 0";
            this.TailsCountLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.TailsCountLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // timerFlip
            // 
            this.timerFlip.Tick += new System.EventHandler(this.timerFlip_Tick);
            // 
            // CoinFlip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TailsCountLabel);
            this.Controls.Add(this.HeadsCountLabel);
            this.Controls.Add(this.comboBoxCoinFace);
            this.Controls.Add(this.pictureBoxCoin);
            this.Controls.Add(this.bunifuButtonFlipCoin);
            this.Controls.Add(this.bunifuLabelResult);
            this.Name = "CoinFlip";
            this.Text = "CoinFlip";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin)).EndInit();
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
    }
}
using System.Windows.Forms;

namespace BlackJackGame
{
    partial class BlackJack
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BlackJack));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges25 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges26 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges27 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges28 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges29 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges30 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges31 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges32 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.DealCardsButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.PlayerLabel2 = new System.Windows.Forms.Label();
            this.playerFlowPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.playerFlowPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.dealerPanel = new System.Windows.Forms.Panel();
            this.winningsLabel = new System.Windows.Forms.Label();
            this.betLabel = new System.Windows.Forms.Label();
            this.betNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.winningsTextbox = new System.Windows.Forms.TextBox();
            this.rightSideLabel = new System.Windows.Forms.Label();
            this.playerWinsLabel = new System.Windows.Forms.Label();
            this.leftSideLabel = new System.Windows.Forms.Label();
            this.dealerWinsLabel = new System.Windows.Forms.Label();
            this.splitButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.standButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.hitButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.standRightSideButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.hitRightSideButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.standLeftSideButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.hitLeftSideButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.dealerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.betNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // DealCardsButton
            // 
            this.DealCardsButton.AllowAnimations = true;
            this.DealCardsButton.AllowMouseEffects = true;
            this.DealCardsButton.AllowToggling = false;
            this.DealCardsButton.AnimationSpeed = 200;
            this.DealCardsButton.AutoGenerateColors = false;
            this.DealCardsButton.AutoRoundBorders = false;
            this.DealCardsButton.AutoSizeLeftIcon = true;
            this.DealCardsButton.AutoSizeRightIcon = true;
            this.DealCardsButton.BackColor = System.Drawing.Color.Transparent;
            this.DealCardsButton.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.DealCardsButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DealCardsButton.BackgroundImage")));
            this.DealCardsButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.DealCardsButton.ButtonText = "Deal Cards";
            this.DealCardsButton.ButtonTextMarginLeft = 0;
            this.DealCardsButton.ColorContrastOnClick = 45;
            this.DealCardsButton.ColorContrastOnHover = 45;
            this.DealCardsButton.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges25.BottomLeft = true;
            borderEdges25.BottomRight = true;
            borderEdges25.TopLeft = true;
            borderEdges25.TopRight = true;
            this.DealCardsButton.CustomizableEdges = borderEdges25;
            this.DealCardsButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.DealCardsButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.DealCardsButton.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.DealCardsButton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.DealCardsButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.DealCardsButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DealCardsButton.ForeColor = System.Drawing.Color.White;
            this.DealCardsButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DealCardsButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.DealCardsButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.DealCardsButton.IconMarginLeft = 11;
            this.DealCardsButton.IconPadding = 10;
            this.DealCardsButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DealCardsButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.DealCardsButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.DealCardsButton.IconSize = 25;
            this.DealCardsButton.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.DealCardsButton.IdleBorderRadius = 1;
            this.DealCardsButton.IdleBorderThickness = 1;
            this.DealCardsButton.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.DealCardsButton.IdleIconLeftImage = null;
            this.DealCardsButton.IdleIconRightImage = null;
            this.DealCardsButton.IndicateFocus = false;
            this.DealCardsButton.Location = new System.Drawing.Point(21, 11);
            this.DealCardsButton.Name = "DealCardsButton";
            this.DealCardsButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.DealCardsButton.OnDisabledState.BorderRadius = 1;
            this.DealCardsButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.DealCardsButton.OnDisabledState.BorderThickness = 1;
            this.DealCardsButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.DealCardsButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.DealCardsButton.OnDisabledState.IconLeftImage = null;
            this.DealCardsButton.OnDisabledState.IconRightImage = null;
            this.DealCardsButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.DealCardsButton.onHoverState.BorderRadius = 1;
            this.DealCardsButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.DealCardsButton.onHoverState.BorderThickness = 1;
            this.DealCardsButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.DealCardsButton.onHoverState.ForeColor = System.Drawing.Color.White;
            this.DealCardsButton.onHoverState.IconLeftImage = null;
            this.DealCardsButton.onHoverState.IconRightImage = null;
            this.DealCardsButton.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.DealCardsButton.OnIdleState.BorderRadius = 1;
            this.DealCardsButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.DealCardsButton.OnIdleState.BorderThickness = 1;
            this.DealCardsButton.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.DealCardsButton.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.DealCardsButton.OnIdleState.IconLeftImage = null;
            this.DealCardsButton.OnIdleState.IconRightImage = null;
            this.DealCardsButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.DealCardsButton.OnPressedState.BorderRadius = 1;
            this.DealCardsButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.DealCardsButton.OnPressedState.BorderThickness = 1;
            this.DealCardsButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.DealCardsButton.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.DealCardsButton.OnPressedState.IconLeftImage = null;
            this.DealCardsButton.OnPressedState.IconRightImage = null;
            this.DealCardsButton.Size = new System.Drawing.Size(150, 39);
            this.DealCardsButton.TabIndex = 1;
            this.DealCardsButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DealCardsButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DealCardsButton.TextMarginLeft = 0;
            this.DealCardsButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.DealCardsButton.UseDefaultRadiusAndThickness = true;
            this.DealCardsButton.Click += new System.EventHandler(this.DealCardsButton_Click);
            // 
            // PlayerLabel2
            // 
            this.PlayerLabel2.Location = new System.Drawing.Point(0, 0);
            this.PlayerLabel2.Name = "PlayerLabel2";
            this.PlayerLabel2.Size = new System.Drawing.Size(100, 23);
            this.PlayerLabel2.TabIndex = 0;
            // 
            // playerFlowPanel2
            // 
            this.playerFlowPanel2.Location = new System.Drawing.Point(563, 355);
            this.playerFlowPanel2.Name = "playerFlowPanel2";
            this.playerFlowPanel2.Size = new System.Drawing.Size(533, 273);
            this.playerFlowPanel2.TabIndex = 2;
            this.playerFlowPanel2.WrapContents = false;
            // 
            // playerFlowPanel1
            // 
            this.playerFlowPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.playerFlowPanel1.Location = new System.Drawing.Point(0, 355);
            this.playerFlowPanel1.Name = "playerFlowPanel1";
            this.playerFlowPanel1.Size = new System.Drawing.Size(544, 273);
            this.playerFlowPanel1.TabIndex = 3;
            this.playerFlowPanel1.WrapContents = false;
            // 
            // dealerPanel
            // 
            this.dealerPanel.Controls.Add(this.winningsLabel);
            this.dealerPanel.Controls.Add(this.betLabel);
            this.dealerPanel.Controls.Add(this.betNumericUpDown);
            this.dealerPanel.Controls.Add(this.playerWinsLabel);
            this.dealerPanel.Controls.Add(this.winningsTextbox);
            this.dealerPanel.Controls.Add(this.rightSideLabel);
            this.dealerPanel.Controls.Add(this.leftSideLabel);
            this.dealerPanel.Controls.Add(this.dealerWinsLabel);
            this.dealerPanel.Controls.Add(this.splitButton);
            this.dealerPanel.Controls.Add(this.standButton);
            this.dealerPanel.Controls.Add(this.hitButton);
            this.dealerPanel.Controls.Add(this.standRightSideButton);
            this.dealerPanel.Controls.Add(this.hitRightSideButton);
            this.dealerPanel.Controls.Add(this.standLeftSideButton);
            this.dealerPanel.Controls.Add(this.hitLeftSideButton);
            this.dealerPanel.Controls.Add(this.DealCardsButton);
            this.dealerPanel.Location = new System.Drawing.Point(2, 1);
            this.dealerPanel.Name = "dealerPanel";
            this.dealerPanel.Size = new System.Drawing.Size(1094, 354);
            this.dealerPanel.TabIndex = 4;
            // 
            // winningsLabel
            // 
            this.winningsLabel.AutoSize = true;
            this.winningsLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.winningsLabel.Location = new System.Drawing.Point(31, 170);
            this.winningsLabel.Name = "winningsLabel";
            this.winningsLabel.Size = new System.Drawing.Size(76, 21);
            this.winningsLabel.TabIndex = 21;
            this.winningsLabel.Text = "Winnings";
            // 
            // betLabel
            // 
            this.betLabel.AutoSize = true;
            this.betLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.betLabel.Location = new System.Drawing.Point(31, 86);
            this.betLabel.Name = "betLabel";
            this.betLabel.Size = new System.Drawing.Size(124, 21);
            this.betLabel.TabIndex = 20;
            this.betLabel.Text = "Choose your bet";
            // 
            // betNumericUpDown
            // 
            this.betNumericUpDown.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.betNumericUpDown.Location = new System.Drawing.Point(35, 117);
            this.betNumericUpDown.Name = "betNumericUpDown";
            this.betNumericUpDown.Size = new System.Drawing.Size(70, 29);
            this.betNumericUpDown.TabIndex = 19;
            // 
            // winningsTextbox
            // 
            this.winningsTextbox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.winningsTextbox.Location = new System.Drawing.Point(35, 204);
            this.winningsTextbox.Name = "winningsTextbox";
            this.winningsTextbox.Size = new System.Drawing.Size(70, 29);
            this.winningsTextbox.TabIndex = 18;
            this.winningsTextbox.Text = "0";
            // 
            // rightSideLabel
            // 
            this.rightSideLabel.AutoSize = true;
            this.rightSideLabel.Location = new System.Drawing.Point(931, 271);
            this.rightSideLabel.Name = "rightSideLabel";
            this.rightSideLabel.Size = new System.Drawing.Size(78, 13);
            this.rightSideLabel.TabIndex = 12;
            this.rightSideLabel.Text = "Right Side Win";
            this.rightSideLabel.Visible = false;
            // 
            // playerWinsLabel
            // 
            this.playerWinsLabel.AutoSize = true;
            this.playerWinsLabel.Location = new System.Drawing.Point(500, 271);
            this.playerWinsLabel.Name = "playerWinsLabel";
            this.playerWinsLabel.Size = new System.Drawing.Size(63, 13);
            this.playerWinsLabel.TabIndex = 11;
            this.playerWinsLabel.Text = "Player Wins";
            this.playerWinsLabel.Visible = false;
            // 
            // leftSideLabel
            // 
            this.leftSideLabel.AutoSize = true;
            this.leftSideLabel.Location = new System.Drawing.Point(100, 271);
            this.leftSideLabel.Name = "leftSideLabel";
            this.leftSideLabel.Size = new System.Drawing.Size(71, 13);
            this.leftSideLabel.TabIndex = 10;
            this.leftSideLabel.Text = "Left Side Win";
            this.leftSideLabel.Visible = false;
            // 
            // dealerWinsLabel
            // 
            this.dealerWinsLabel.AutoSize = true;
            this.dealerWinsLabel.Location = new System.Drawing.Point(535, 20);
            this.dealerWinsLabel.Name = "dealerWinsLabel";
            this.dealerWinsLabel.Size = new System.Drawing.Size(65, 13);
            this.dealerWinsLabel.TabIndex = 9;
            this.dealerWinsLabel.Text = "Dealer Wins";
            this.dealerWinsLabel.Visible = false;
            // 
            // splitButton
            // 
            this.splitButton.AllowAnimations = true;
            this.splitButton.AllowMouseEffects = true;
            this.splitButton.AllowToggling = false;
            this.splitButton.AnimationSpeed = 200;
            this.splitButton.AutoGenerateColors = false;
            this.splitButton.AutoRoundBorders = false;
            this.splitButton.AutoSizeLeftIcon = true;
            this.splitButton.AutoSizeRightIcon = true;
            this.splitButton.BackColor = System.Drawing.Color.Transparent;
            this.splitButton.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.splitButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitButton.BackgroundImage")));
            this.splitButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.splitButton.ButtonText = "Split";
            this.splitButton.ButtonTextMarginLeft = 0;
            this.splitButton.ColorContrastOnClick = 45;
            this.splitButton.ColorContrastOnHover = 45;
            this.splitButton.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges26.BottomLeft = true;
            borderEdges26.BottomRight = true;
            borderEdges26.TopLeft = true;
            borderEdges26.TopRight = true;
            this.splitButton.CustomizableEdges = borderEdges26;
            this.splitButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.splitButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.splitButton.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.splitButton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.splitButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.splitButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.splitButton.ForeColor = System.Drawing.Color.White;
            this.splitButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.splitButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.splitButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.splitButton.IconMarginLeft = 11;
            this.splitButton.IconPadding = 10;
            this.splitButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.splitButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.splitButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.splitButton.IconSize = 25;
            this.splitButton.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.splitButton.IdleBorderRadius = 1;
            this.splitButton.IdleBorderThickness = 1;
            this.splitButton.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.splitButton.IdleIconLeftImage = null;
            this.splitButton.IdleIconRightImage = null;
            this.splitButton.IndicateFocus = false;
            this.splitButton.Location = new System.Drawing.Point(603, 300);
            this.splitButton.Name = "splitButton";
            this.splitButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.splitButton.OnDisabledState.BorderRadius = 1;
            this.splitButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.splitButton.OnDisabledState.BorderThickness = 1;
            this.splitButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.splitButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.splitButton.OnDisabledState.IconLeftImage = null;
            this.splitButton.OnDisabledState.IconRightImage = null;
            this.splitButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.splitButton.onHoverState.BorderRadius = 1;
            this.splitButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.splitButton.onHoverState.BorderThickness = 1;
            this.splitButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.splitButton.onHoverState.ForeColor = System.Drawing.Color.White;
            this.splitButton.onHoverState.IconLeftImage = null;
            this.splitButton.onHoverState.IconRightImage = null;
            this.splitButton.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.splitButton.OnIdleState.BorderRadius = 1;
            this.splitButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.splitButton.OnIdleState.BorderThickness = 1;
            this.splitButton.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.splitButton.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.splitButton.OnIdleState.IconLeftImage = null;
            this.splitButton.OnIdleState.IconRightImage = null;
            this.splitButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.splitButton.OnPressedState.BorderRadius = 1;
            this.splitButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.splitButton.OnPressedState.BorderThickness = 1;
            this.splitButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.splitButton.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.splitButton.OnPressedState.IconLeftImage = null;
            this.splitButton.OnPressedState.IconRightImage = null;
            this.splitButton.Size = new System.Drawing.Size(106, 39);
            this.splitButton.TabIndex = 8;
            this.splitButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.splitButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.splitButton.TextMarginLeft = 0;
            this.splitButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.splitButton.UseDefaultRadiusAndThickness = true;
            this.splitButton.Visible = false;
            this.splitButton.Click += new System.EventHandler(this.splitButton_Click);
            // 
            // standButton
            // 
            this.standButton.AllowAnimations = true;
            this.standButton.AllowMouseEffects = true;
            this.standButton.AllowToggling = false;
            this.standButton.AnimationSpeed = 200;
            this.standButton.AutoGenerateColors = false;
            this.standButton.AutoRoundBorders = false;
            this.standButton.AutoSizeLeftIcon = true;
            this.standButton.AutoSizeRightIcon = true;
            this.standButton.BackColor = System.Drawing.Color.Transparent;
            this.standButton.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.standButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("standButton.BackgroundImage")));
            this.standButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.standButton.ButtonText = "Stand";
            this.standButton.ButtonTextMarginLeft = 0;
            this.standButton.ColorContrastOnClick = 45;
            this.standButton.ColorContrastOnHover = 45;
            this.standButton.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges27.BottomLeft = true;
            borderEdges27.BottomRight = true;
            borderEdges27.TopLeft = true;
            borderEdges27.TopRight = true;
            this.standButton.CustomizableEdges = borderEdges27;
            this.standButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.standButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.standButton.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.standButton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.standButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.standButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.standButton.ForeColor = System.Drawing.Color.White;
            this.standButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.standButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.standButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.standButton.IconMarginLeft = 11;
            this.standButton.IconPadding = 10;
            this.standButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.standButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.standButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.standButton.IconSize = 25;
            this.standButton.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.standButton.IdleBorderRadius = 1;
            this.standButton.IdleBorderThickness = 1;
            this.standButton.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.standButton.IdleIconLeftImage = null;
            this.standButton.IdleIconRightImage = null;
            this.standButton.IndicateFocus = false;
            this.standButton.Location = new System.Drawing.Point(481, 300);
            this.standButton.Name = "standButton";
            this.standButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.standButton.OnDisabledState.BorderRadius = 1;
            this.standButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.standButton.OnDisabledState.BorderThickness = 1;
            this.standButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.standButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.standButton.OnDisabledState.IconLeftImage = null;
            this.standButton.OnDisabledState.IconRightImage = null;
            this.standButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.standButton.onHoverState.BorderRadius = 1;
            this.standButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.standButton.onHoverState.BorderThickness = 1;
            this.standButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.standButton.onHoverState.ForeColor = System.Drawing.Color.White;
            this.standButton.onHoverState.IconLeftImage = null;
            this.standButton.onHoverState.IconRightImage = null;
            this.standButton.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.standButton.OnIdleState.BorderRadius = 1;
            this.standButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.standButton.OnIdleState.BorderThickness = 1;
            this.standButton.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.standButton.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.standButton.OnIdleState.IconLeftImage = null;
            this.standButton.OnIdleState.IconRightImage = null;
            this.standButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.standButton.OnPressedState.BorderRadius = 1;
            this.standButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.standButton.OnPressedState.BorderThickness = 1;
            this.standButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.standButton.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.standButton.OnPressedState.IconLeftImage = null;
            this.standButton.OnPressedState.IconRightImage = null;
            this.standButton.Size = new System.Drawing.Size(106, 39);
            this.standButton.TabIndex = 7;
            this.standButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.standButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.standButton.TextMarginLeft = 0;
            this.standButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.standButton.UseDefaultRadiusAndThickness = true;
            this.standButton.Visible = false;
            this.standButton.Click += new System.EventHandler(this.standButton_Click);
            // 
            // hitButton
            // 
            this.hitButton.AllowAnimations = true;
            this.hitButton.AllowMouseEffects = true;
            this.hitButton.AllowToggling = false;
            this.hitButton.AnimationSpeed = 200;
            this.hitButton.AutoGenerateColors = false;
            this.hitButton.AutoRoundBorders = false;
            this.hitButton.AutoSizeLeftIcon = true;
            this.hitButton.AutoSizeRightIcon = true;
            this.hitButton.BackColor = System.Drawing.Color.Transparent;
            this.hitButton.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.hitButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hitButton.BackgroundImage")));
            this.hitButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.hitButton.ButtonText = "Hit";
            this.hitButton.ButtonTextMarginLeft = 0;
            this.hitButton.ColorContrastOnClick = 45;
            this.hitButton.ColorContrastOnHover = 45;
            this.hitButton.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges28.BottomLeft = true;
            borderEdges28.BottomRight = true;
            borderEdges28.TopLeft = true;
            borderEdges28.TopRight = true;
            this.hitButton.CustomizableEdges = borderEdges28;
            this.hitButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.hitButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.hitButton.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.hitButton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.hitButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.hitButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.hitButton.ForeColor = System.Drawing.Color.White;
            this.hitButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hitButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.hitButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.hitButton.IconMarginLeft = 11;
            this.hitButton.IconPadding = 10;
            this.hitButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.hitButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.hitButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.hitButton.IconSize = 25;
            this.hitButton.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.hitButton.IdleBorderRadius = 1;
            this.hitButton.IdleBorderThickness = 1;
            this.hitButton.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.hitButton.IdleIconLeftImage = null;
            this.hitButton.IdleIconRightImage = null;
            this.hitButton.IndicateFocus = false;
            this.hitButton.Location = new System.Drawing.Point(360, 300);
            this.hitButton.Name = "hitButton";
            this.hitButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.hitButton.OnDisabledState.BorderRadius = 1;
            this.hitButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.hitButton.OnDisabledState.BorderThickness = 1;
            this.hitButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.hitButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.hitButton.OnDisabledState.IconLeftImage = null;
            this.hitButton.OnDisabledState.IconRightImage = null;
            this.hitButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.hitButton.onHoverState.BorderRadius = 1;
            this.hitButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.hitButton.onHoverState.BorderThickness = 1;
            this.hitButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.hitButton.onHoverState.ForeColor = System.Drawing.Color.White;
            this.hitButton.onHoverState.IconLeftImage = null;
            this.hitButton.onHoverState.IconRightImage = null;
            this.hitButton.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.hitButton.OnIdleState.BorderRadius = 1;
            this.hitButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.hitButton.OnIdleState.BorderThickness = 1;
            this.hitButton.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.hitButton.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.hitButton.OnIdleState.IconLeftImage = null;
            this.hitButton.OnIdleState.IconRightImage = null;
            this.hitButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.hitButton.OnPressedState.BorderRadius = 1;
            this.hitButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.hitButton.OnPressedState.BorderThickness = 1;
            this.hitButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.hitButton.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.hitButton.OnPressedState.IconLeftImage = null;
            this.hitButton.OnPressedState.IconRightImage = null;
            this.hitButton.Size = new System.Drawing.Size(106, 39);
            this.hitButton.TabIndex = 6;
            this.hitButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.hitButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.hitButton.TextMarginLeft = 0;
            this.hitButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.hitButton.UseDefaultRadiusAndThickness = true;
            this.hitButton.Visible = false;
            this.hitButton.Click += new System.EventHandler(this.hitButton_Click);
            // 
            // standRightSideButton
            // 
            this.standRightSideButton.AllowAnimations = true;
            this.standRightSideButton.AllowMouseEffects = true;
            this.standRightSideButton.AllowToggling = false;
            this.standRightSideButton.AnimationSpeed = 200;
            this.standRightSideButton.AutoGenerateColors = false;
            this.standRightSideButton.AutoRoundBorders = false;
            this.standRightSideButton.AutoSizeLeftIcon = true;
            this.standRightSideButton.AutoSizeRightIcon = true;
            this.standRightSideButton.BackColor = System.Drawing.Color.Transparent;
            this.standRightSideButton.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.standRightSideButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("standRightSideButton.BackgroundImage")));
            this.standRightSideButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.standRightSideButton.ButtonText = "Stand Right Side";
            this.standRightSideButton.ButtonTextMarginLeft = 0;
            this.standRightSideButton.ColorContrastOnClick = 45;
            this.standRightSideButton.ColorContrastOnHover = 45;
            this.standRightSideButton.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges29.BottomLeft = true;
            borderEdges29.BottomRight = true;
            borderEdges29.TopLeft = true;
            borderEdges29.TopRight = true;
            this.standRightSideButton.CustomizableEdges = borderEdges29;
            this.standRightSideButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.standRightSideButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.standRightSideButton.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.standRightSideButton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.standRightSideButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.standRightSideButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.standRightSideButton.ForeColor = System.Drawing.Color.White;
            this.standRightSideButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.standRightSideButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.standRightSideButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.standRightSideButton.IconMarginLeft = 11;
            this.standRightSideButton.IconPadding = 10;
            this.standRightSideButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.standRightSideButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.standRightSideButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.standRightSideButton.IconSize = 25;
            this.standRightSideButton.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.standRightSideButton.IdleBorderRadius = 1;
            this.standRightSideButton.IdleBorderThickness = 1;
            this.standRightSideButton.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.standRightSideButton.IdleIconLeftImage = null;
            this.standRightSideButton.IdleIconRightImage = null;
            this.standRightSideButton.IndicateFocus = false;
            this.standRightSideButton.Location = new System.Drawing.Point(954, 300);
            this.standRightSideButton.Name = "standRightSideButton";
            this.standRightSideButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.standRightSideButton.OnDisabledState.BorderRadius = 1;
            this.standRightSideButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.standRightSideButton.OnDisabledState.BorderThickness = 1;
            this.standRightSideButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.standRightSideButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.standRightSideButton.OnDisabledState.IconLeftImage = null;
            this.standRightSideButton.OnDisabledState.IconRightImage = null;
            this.standRightSideButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.standRightSideButton.onHoverState.BorderRadius = 1;
            this.standRightSideButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.standRightSideButton.onHoverState.BorderThickness = 1;
            this.standRightSideButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.standRightSideButton.onHoverState.ForeColor = System.Drawing.Color.White;
            this.standRightSideButton.onHoverState.IconLeftImage = null;
            this.standRightSideButton.onHoverState.IconRightImage = null;
            this.standRightSideButton.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.standRightSideButton.OnIdleState.BorderRadius = 1;
            this.standRightSideButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.standRightSideButton.OnIdleState.BorderThickness = 1;
            this.standRightSideButton.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.standRightSideButton.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.standRightSideButton.OnIdleState.IconLeftImage = null;
            this.standRightSideButton.OnIdleState.IconRightImage = null;
            this.standRightSideButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.standRightSideButton.OnPressedState.BorderRadius = 1;
            this.standRightSideButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.standRightSideButton.OnPressedState.BorderThickness = 1;
            this.standRightSideButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.standRightSideButton.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.standRightSideButton.OnPressedState.IconLeftImage = null;
            this.standRightSideButton.OnPressedState.IconRightImage = null;
            this.standRightSideButton.Size = new System.Drawing.Size(106, 39);
            this.standRightSideButton.TabIndex = 5;
            this.standRightSideButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.standRightSideButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.standRightSideButton.TextMarginLeft = 0;
            this.standRightSideButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.standRightSideButton.UseDefaultRadiusAndThickness = true;
            this.standRightSideButton.Visible = false;
            this.standRightSideButton.Click += new System.EventHandler(this.standRightSideButton_Click);
            // 
            // hitRightSideButton
            // 
            this.hitRightSideButton.AllowAnimations = true;
            this.hitRightSideButton.AllowMouseEffects = true;
            this.hitRightSideButton.AllowToggling = false;
            this.hitRightSideButton.AnimationSpeed = 200;
            this.hitRightSideButton.AutoGenerateColors = false;
            this.hitRightSideButton.AutoRoundBorders = false;
            this.hitRightSideButton.AutoSizeLeftIcon = true;
            this.hitRightSideButton.AutoSizeRightIcon = true;
            this.hitRightSideButton.BackColor = System.Drawing.Color.Transparent;
            this.hitRightSideButton.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.hitRightSideButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hitRightSideButton.BackgroundImage")));
            this.hitRightSideButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.hitRightSideButton.ButtonText = "Hit Right Side";
            this.hitRightSideButton.ButtonTextMarginLeft = 0;
            this.hitRightSideButton.ColorContrastOnClick = 45;
            this.hitRightSideButton.ColorContrastOnHover = 45;
            this.hitRightSideButton.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges30.BottomLeft = true;
            borderEdges30.BottomRight = true;
            borderEdges30.TopLeft = true;
            borderEdges30.TopRight = true;
            this.hitRightSideButton.CustomizableEdges = borderEdges30;
            this.hitRightSideButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.hitRightSideButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.hitRightSideButton.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.hitRightSideButton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.hitRightSideButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.hitRightSideButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.hitRightSideButton.ForeColor = System.Drawing.Color.White;
            this.hitRightSideButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hitRightSideButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.hitRightSideButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.hitRightSideButton.IconMarginLeft = 11;
            this.hitRightSideButton.IconPadding = 10;
            this.hitRightSideButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.hitRightSideButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.hitRightSideButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.hitRightSideButton.IconSize = 25;
            this.hitRightSideButton.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.hitRightSideButton.IdleBorderRadius = 1;
            this.hitRightSideButton.IdleBorderThickness = 1;
            this.hitRightSideButton.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.hitRightSideButton.IdleIconLeftImage = null;
            this.hitRightSideButton.IdleIconRightImage = null;
            this.hitRightSideButton.IndicateFocus = false;
            this.hitRightSideButton.Location = new System.Drawing.Point(842, 300);
            this.hitRightSideButton.Name = "hitRightSideButton";
            this.hitRightSideButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.hitRightSideButton.OnDisabledState.BorderRadius = 1;
            this.hitRightSideButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.hitRightSideButton.OnDisabledState.BorderThickness = 1;
            this.hitRightSideButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.hitRightSideButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.hitRightSideButton.OnDisabledState.IconLeftImage = null;
            this.hitRightSideButton.OnDisabledState.IconRightImage = null;
            this.hitRightSideButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.hitRightSideButton.onHoverState.BorderRadius = 1;
            this.hitRightSideButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.hitRightSideButton.onHoverState.BorderThickness = 1;
            this.hitRightSideButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.hitRightSideButton.onHoverState.ForeColor = System.Drawing.Color.White;
            this.hitRightSideButton.onHoverState.IconLeftImage = null;
            this.hitRightSideButton.onHoverState.IconRightImage = null;
            this.hitRightSideButton.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.hitRightSideButton.OnIdleState.BorderRadius = 1;
            this.hitRightSideButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.hitRightSideButton.OnIdleState.BorderThickness = 1;
            this.hitRightSideButton.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.hitRightSideButton.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.hitRightSideButton.OnIdleState.IconLeftImage = null;
            this.hitRightSideButton.OnIdleState.IconRightImage = null;
            this.hitRightSideButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.hitRightSideButton.OnPressedState.BorderRadius = 1;
            this.hitRightSideButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.hitRightSideButton.OnPressedState.BorderThickness = 1;
            this.hitRightSideButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.hitRightSideButton.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.hitRightSideButton.OnPressedState.IconLeftImage = null;
            this.hitRightSideButton.OnPressedState.IconRightImage = null;
            this.hitRightSideButton.Size = new System.Drawing.Size(106, 39);
            this.hitRightSideButton.TabIndex = 4;
            this.hitRightSideButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.hitRightSideButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.hitRightSideButton.TextMarginLeft = 0;
            this.hitRightSideButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.hitRightSideButton.UseDefaultRadiusAndThickness = true;
            this.hitRightSideButton.Visible = false;
            this.hitRightSideButton.Click += new System.EventHandler(this.hitRightSideButton_Click);
            // 
            // standLeftSideButton
            // 
            this.standLeftSideButton.AllowAnimations = true;
            this.standLeftSideButton.AllowMouseEffects = true;
            this.standLeftSideButton.AllowToggling = false;
            this.standLeftSideButton.AnimationSpeed = 200;
            this.standLeftSideButton.AutoGenerateColors = false;
            this.standLeftSideButton.AutoRoundBorders = false;
            this.standLeftSideButton.AutoSizeLeftIcon = true;
            this.standLeftSideButton.AutoSizeRightIcon = true;
            this.standLeftSideButton.BackColor = System.Drawing.Color.Transparent;
            this.standLeftSideButton.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.standLeftSideButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("standLeftSideButton.BackgroundImage")));
            this.standLeftSideButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.standLeftSideButton.ButtonText = "Stand Left Side";
            this.standLeftSideButton.ButtonTextMarginLeft = 0;
            this.standLeftSideButton.ColorContrastOnClick = 45;
            this.standLeftSideButton.ColorContrastOnHover = 45;
            this.standLeftSideButton.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges31.BottomLeft = true;
            borderEdges31.BottomRight = true;
            borderEdges31.TopLeft = true;
            borderEdges31.TopRight = true;
            this.standLeftSideButton.CustomizableEdges = borderEdges31;
            this.standLeftSideButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.standLeftSideButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.standLeftSideButton.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.standLeftSideButton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.standLeftSideButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.standLeftSideButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.standLeftSideButton.ForeColor = System.Drawing.Color.White;
            this.standLeftSideButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.standLeftSideButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.standLeftSideButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.standLeftSideButton.IconMarginLeft = 11;
            this.standLeftSideButton.IconPadding = 10;
            this.standLeftSideButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.standLeftSideButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.standLeftSideButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.standLeftSideButton.IconSize = 25;
            this.standLeftSideButton.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.standLeftSideButton.IdleBorderRadius = 1;
            this.standLeftSideButton.IdleBorderThickness = 1;
            this.standLeftSideButton.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.standLeftSideButton.IdleIconLeftImage = null;
            this.standLeftSideButton.IdleIconRightImage = null;
            this.standLeftSideButton.IndicateFocus = false;
            this.standLeftSideButton.Location = new System.Drawing.Point(133, 300);
            this.standLeftSideButton.Name = "standLeftSideButton";
            this.standLeftSideButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.standLeftSideButton.OnDisabledState.BorderRadius = 1;
            this.standLeftSideButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.standLeftSideButton.OnDisabledState.BorderThickness = 1;
            this.standLeftSideButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.standLeftSideButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.standLeftSideButton.OnDisabledState.IconLeftImage = null;
            this.standLeftSideButton.OnDisabledState.IconRightImage = null;
            this.standLeftSideButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.standLeftSideButton.onHoverState.BorderRadius = 1;
            this.standLeftSideButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.standLeftSideButton.onHoverState.BorderThickness = 1;
            this.standLeftSideButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.standLeftSideButton.onHoverState.ForeColor = System.Drawing.Color.White;
            this.standLeftSideButton.onHoverState.IconLeftImage = null;
            this.standLeftSideButton.onHoverState.IconRightImage = null;
            this.standLeftSideButton.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.standLeftSideButton.OnIdleState.BorderRadius = 1;
            this.standLeftSideButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.standLeftSideButton.OnIdleState.BorderThickness = 1;
            this.standLeftSideButton.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.standLeftSideButton.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.standLeftSideButton.OnIdleState.IconLeftImage = null;
            this.standLeftSideButton.OnIdleState.IconRightImage = null;
            this.standLeftSideButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.standLeftSideButton.OnPressedState.BorderRadius = 1;
            this.standLeftSideButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.standLeftSideButton.OnPressedState.BorderThickness = 1;
            this.standLeftSideButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.standLeftSideButton.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.standLeftSideButton.OnPressedState.IconLeftImage = null;
            this.standLeftSideButton.OnPressedState.IconRightImage = null;
            this.standLeftSideButton.Size = new System.Drawing.Size(106, 39);
            this.standLeftSideButton.TabIndex = 3;
            this.standLeftSideButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.standLeftSideButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.standLeftSideButton.TextMarginLeft = 0;
            this.standLeftSideButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.standLeftSideButton.UseDefaultRadiusAndThickness = true;
            this.standLeftSideButton.Visible = false;
            this.standLeftSideButton.Click += new System.EventHandler(this.standLeftSideButton_Click);
            // 
            // hitLeftSideButton
            // 
            this.hitLeftSideButton.AllowAnimations = true;
            this.hitLeftSideButton.AllowMouseEffects = true;
            this.hitLeftSideButton.AllowToggling = false;
            this.hitLeftSideButton.AnimationSpeed = 200;
            this.hitLeftSideButton.AutoGenerateColors = false;
            this.hitLeftSideButton.AutoRoundBorders = false;
            this.hitLeftSideButton.AutoSizeLeftIcon = true;
            this.hitLeftSideButton.AutoSizeRightIcon = true;
            this.hitLeftSideButton.BackColor = System.Drawing.Color.Transparent;
            this.hitLeftSideButton.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.hitLeftSideButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hitLeftSideButton.BackgroundImage")));
            this.hitLeftSideButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.hitLeftSideButton.ButtonText = "Hit Left Side";
            this.hitLeftSideButton.ButtonTextMarginLeft = 0;
            this.hitLeftSideButton.ColorContrastOnClick = 45;
            this.hitLeftSideButton.ColorContrastOnHover = 45;
            this.hitLeftSideButton.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges32.BottomLeft = true;
            borderEdges32.BottomRight = true;
            borderEdges32.TopLeft = true;
            borderEdges32.TopRight = true;
            this.hitLeftSideButton.CustomizableEdges = borderEdges32;
            this.hitLeftSideButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.hitLeftSideButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.hitLeftSideButton.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.hitLeftSideButton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.hitLeftSideButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.hitLeftSideButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.hitLeftSideButton.ForeColor = System.Drawing.Color.White;
            this.hitLeftSideButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hitLeftSideButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.hitLeftSideButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.hitLeftSideButton.IconMarginLeft = 11;
            this.hitLeftSideButton.IconPadding = 10;
            this.hitLeftSideButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.hitLeftSideButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.hitLeftSideButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.hitLeftSideButton.IconSize = 25;
            this.hitLeftSideButton.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.hitLeftSideButton.IdleBorderRadius = 1;
            this.hitLeftSideButton.IdleBorderThickness = 1;
            this.hitLeftSideButton.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.hitLeftSideButton.IdleIconLeftImage = null;
            this.hitLeftSideButton.IdleIconRightImage = null;
            this.hitLeftSideButton.IndicateFocus = false;
            this.hitLeftSideButton.Location = new System.Drawing.Point(21, 300);
            this.hitLeftSideButton.Name = "hitLeftSideButton";
            this.hitLeftSideButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.hitLeftSideButton.OnDisabledState.BorderRadius = 1;
            this.hitLeftSideButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.hitLeftSideButton.OnDisabledState.BorderThickness = 1;
            this.hitLeftSideButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.hitLeftSideButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.hitLeftSideButton.OnDisabledState.IconLeftImage = null;
            this.hitLeftSideButton.OnDisabledState.IconRightImage = null;
            this.hitLeftSideButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.hitLeftSideButton.onHoverState.BorderRadius = 1;
            this.hitLeftSideButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.hitLeftSideButton.onHoverState.BorderThickness = 1;
            this.hitLeftSideButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.hitLeftSideButton.onHoverState.ForeColor = System.Drawing.Color.White;
            this.hitLeftSideButton.onHoverState.IconLeftImage = null;
            this.hitLeftSideButton.onHoverState.IconRightImage = null;
            this.hitLeftSideButton.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.hitLeftSideButton.OnIdleState.BorderRadius = 1;
            this.hitLeftSideButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.hitLeftSideButton.OnIdleState.BorderThickness = 1;
            this.hitLeftSideButton.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.hitLeftSideButton.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.hitLeftSideButton.OnIdleState.IconLeftImage = null;
            this.hitLeftSideButton.OnIdleState.IconRightImage = null;
            this.hitLeftSideButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.hitLeftSideButton.OnPressedState.BorderRadius = 1;
            this.hitLeftSideButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.hitLeftSideButton.OnPressedState.BorderThickness = 1;
            this.hitLeftSideButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.hitLeftSideButton.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.hitLeftSideButton.OnPressedState.IconLeftImage = null;
            this.hitLeftSideButton.OnPressedState.IconRightImage = null;
            this.hitLeftSideButton.Size = new System.Drawing.Size(106, 39);
            this.hitLeftSideButton.TabIndex = 2;
            this.hitLeftSideButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.hitLeftSideButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.hitLeftSideButton.TextMarginLeft = 0;
            this.hitLeftSideButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.hitLeftSideButton.UseDefaultRadiusAndThickness = true;
            this.hitLeftSideButton.Visible = false;
            this.hitLeftSideButton.Click += new System.EventHandler(this.hitLeftSideButton_Click);
            // 
            // BlackJack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 630);
            this.Controls.Add(this.dealerPanel);
            this.Controls.Add(this.playerFlowPanel1);
            this.Controls.Add(this.playerFlowPanel2);
            this.Name = "BlackJack";
            this.Text = "BlackJack";
            this.dealerPanel.ResumeLayout(false);
            this.dealerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.betNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label PlayerLabel2;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton DealCardsButton;
        private System.Windows.Forms.FlowLayoutPanel playerFlowPanel2;
        private System.Windows.Forms.FlowLayoutPanel playerFlowPanel1;
        private Panel dealerPanel;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton splitButton;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton standButton;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton hitButton;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton standRightSideButton;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton hitRightSideButton;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton standLeftSideButton;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton hitLeftSideButton;
        private Label dealerWinsLabel;
        private Label leftSideLabel;
        private Label playerWinsLabel;
        private Label rightSideLabel;
        private TextBox winningsTextbox;
        private NumericUpDown betNumericUpDown;
        private Label betLabel;
        private Label winningsLabel;
    }
}
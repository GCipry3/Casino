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
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges7 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges8 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.DealCardsButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.PlayerLabel2 = new System.Windows.Forms.Label();
            this.LeftRightPlayerFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.LeftSidePlayerFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.DealerAndButtonsPanel = new System.Windows.Forms.Panel();
            this.AboveWinningsLabel = new System.Windows.Forms.Label();
            this.AboveBetLabel = new System.Windows.Forms.Label();
            this.BetNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.CenteredLabel = new System.Windows.Forms.Label();
            this.WinningsTextbox = new System.Windows.Forms.TextBox();
            this.SplitScenarioRightSideLabel = new System.Windows.Forms.Label();
            this.SplitScenarioLeftSideLabel = new System.Windows.Forms.Label();
            this.CenteredSplitButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.CenteredStandButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.CenteredHitButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.SplitScenarioRightSideStandButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.SplitScenarioRightSideHitButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.SplitScenarioLeftSideStandButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.SplitScenarioLeftSideHitButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.BalanceTextBox = new System.Windows.Forms.TextBox();
            this.BalanceLabel = new System.Windows.Forms.Label();
            this.DealerAndButtonsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BetNumericUpDown)).BeginInit();
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
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.DealCardsButton.CustomizableEdges = borderEdges1;
            this.DealCardsButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.DealCardsButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.DealCardsButton.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.DealCardsButton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.DealCardsButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.DealCardsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // LeftRightPlayerFlowLayoutPanel
            // 
            this.LeftRightPlayerFlowLayoutPanel.Location = new System.Drawing.Point(690, 361);
            this.LeftRightPlayerFlowLayoutPanel.Name = "LeftRightPlayerFlowLayoutPanel";
            this.LeftRightPlayerFlowLayoutPanel.Size = new System.Drawing.Size(690, 250);
            this.LeftRightPlayerFlowLayoutPanel.TabIndex = 2;
            this.LeftRightPlayerFlowLayoutPanel.WrapContents = false;
            // 
            // LeftSidePlayerFlowLayoutPanel
            // 
            this.LeftSidePlayerFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.LeftSidePlayerFlowLayoutPanel.Location = new System.Drawing.Point(0, 361);
            this.LeftSidePlayerFlowLayoutPanel.Name = "LeftSidePlayerFlowLayoutPanel";
            this.LeftSidePlayerFlowLayoutPanel.Size = new System.Drawing.Size(690, 250);
            this.LeftSidePlayerFlowLayoutPanel.TabIndex = 3;
            this.LeftSidePlayerFlowLayoutPanel.WrapContents = false;
            // 
            // DealerAndButtonsPanel
            // 
            this.DealerAndButtonsPanel.Controls.Add(this.BalanceLabel);
            this.DealerAndButtonsPanel.Controls.Add(this.BalanceTextBox);
            this.DealerAndButtonsPanel.Controls.Add(this.AboveWinningsLabel);
            this.DealerAndButtonsPanel.Controls.Add(this.AboveBetLabel);
            this.DealerAndButtonsPanel.Controls.Add(this.BetNumericUpDown);
            this.DealerAndButtonsPanel.Controls.Add(this.CenteredLabel);
            this.DealerAndButtonsPanel.Controls.Add(this.WinningsTextbox);
            this.DealerAndButtonsPanel.Controls.Add(this.SplitScenarioRightSideLabel);
            this.DealerAndButtonsPanel.Controls.Add(this.SplitScenarioLeftSideLabel);
            this.DealerAndButtonsPanel.Controls.Add(this.CenteredSplitButton);
            this.DealerAndButtonsPanel.Controls.Add(this.CenteredStandButton);
            this.DealerAndButtonsPanel.Controls.Add(this.CenteredHitButton);
            this.DealerAndButtonsPanel.Controls.Add(this.SplitScenarioRightSideStandButton);
            this.DealerAndButtonsPanel.Controls.Add(this.SplitScenarioRightSideHitButton);
            this.DealerAndButtonsPanel.Controls.Add(this.SplitScenarioLeftSideStandButton);
            this.DealerAndButtonsPanel.Controls.Add(this.SplitScenarioLeftSideHitButton);
            this.DealerAndButtonsPanel.Controls.Add(this.DealCardsButton);
            this.DealerAndButtonsPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DealerAndButtonsPanel.Location = new System.Drawing.Point(0, -5);
            this.DealerAndButtonsPanel.Name = "DealerAndButtonsPanel";
            this.DealerAndButtonsPanel.Size = new System.Drawing.Size(1380, 360);
            this.DealerAndButtonsPanel.TabIndex = 4;
            // 
            // AboveWinningsLabel
            // 
            this.AboveWinningsLabel.AutoSize = true;
            this.AboveWinningsLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboveWinningsLabel.Location = new System.Drawing.Point(31, 170);
            this.AboveWinningsLabel.Name = "AboveWinningsLabel";
            this.AboveWinningsLabel.Size = new System.Drawing.Size(83, 21);
            this.AboveWinningsLabel.TabIndex = 21;
            this.AboveWinningsLabel.Text = "Winnings";
            // 
            // AboveBetLabel
            // 
            this.AboveBetLabel.AutoSize = true;
            this.AboveBetLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboveBetLabel.Location = new System.Drawing.Point(31, 86);
            this.AboveBetLabel.Name = "AboveBetLabel";
            this.AboveBetLabel.Size = new System.Drawing.Size(134, 21);
            this.AboveBetLabel.TabIndex = 20;
            this.AboveBetLabel.Text = "Choose your bet";
            // 
            // BetNumericUpDown
            // 
            this.BetNumericUpDown.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BetNumericUpDown.Location = new System.Drawing.Point(35, 117);
            this.BetNumericUpDown.Maximum = new decimal(new int[] {
            30000,
            0,
            0,
            0});
            this.BetNumericUpDown.Name = "BetNumericUpDown";
            this.BetNumericUpDown.Size = new System.Drawing.Size(70, 29);
            this.BetNumericUpDown.TabIndex = 19;
            // 
            // CenteredLabel
            // 
            this.CenteredLabel.AutoSize = true;
            this.CenteredLabel.Location = new System.Drawing.Point(662, 271);
            this.CenteredLabel.Name = "CenteredLabel";
            this.CenteredLabel.Size = new System.Drawing.Size(90, 16);
            this.CenteredLabel.TabIndex = 11;
            this.CenteredLabel.Text = "Player Wins";
            this.CenteredLabel.Visible = false;
            // 
            // WinningsTextbox
            // 
            this.WinningsTextbox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.WinningsTextbox.Location = new System.Drawing.Point(35, 204);
            this.WinningsTextbox.Name = "WinningsTextbox";
            this.WinningsTextbox.Size = new System.Drawing.Size(70, 29);
            this.WinningsTextbox.TabIndex = 18;
            this.WinningsTextbox.Text = "0";
            // 
            // SplitScenarioRightSideLabel
            // 
            this.SplitScenarioRightSideLabel.AutoSize = true;
            this.SplitScenarioRightSideLabel.Location = new System.Drawing.Point(837, 271);
            this.SplitScenarioRightSideLabel.Name = "SplitScenarioRightSideLabel";
            this.SplitScenarioRightSideLabel.Size = new System.Drawing.Size(122, 16);
            this.SplitScenarioRightSideLabel.TabIndex = 12;
            this.SplitScenarioRightSideLabel.Text = "Right Hand Wins";
            this.SplitScenarioRightSideLabel.Visible = false;
            // 
            // SplitScenarioLeftSideLabel
            // 
            this.SplitScenarioLeftSideLabel.AutoSize = true;
            this.SplitScenarioLeftSideLabel.Location = new System.Drawing.Point(481, 271);
            this.SplitScenarioLeftSideLabel.Name = "SplitScenarioLeftSideLabel";
            this.SplitScenarioLeftSideLabel.Size = new System.Drawing.Size(111, 16);
            this.SplitScenarioLeftSideLabel.TabIndex = 10;
            this.SplitScenarioLeftSideLabel.Text = "Left Hand Wins";
            this.SplitScenarioLeftSideLabel.Visible = false;
            // 
            // CenteredSplitButton
            // 
            this.CenteredSplitButton.AllowAnimations = true;
            this.CenteredSplitButton.AllowMouseEffects = true;
            this.CenteredSplitButton.AllowToggling = false;
            this.CenteredSplitButton.AnimationSpeed = 200;
            this.CenteredSplitButton.AutoGenerateColors = false;
            this.CenteredSplitButton.AutoRoundBorders = false;
            this.CenteredSplitButton.AutoSizeLeftIcon = true;
            this.CenteredSplitButton.AutoSizeRightIcon = true;
            this.CenteredSplitButton.BackColor = System.Drawing.Color.Transparent;
            this.CenteredSplitButton.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.CenteredSplitButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CenteredSplitButton.BackgroundImage")));
            this.CenteredSplitButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.CenteredSplitButton.ButtonText = "Split";
            this.CenteredSplitButton.ButtonTextMarginLeft = 0;
            this.CenteredSplitButton.ColorContrastOnClick = 45;
            this.CenteredSplitButton.ColorContrastOnHover = 45;
            this.CenteredSplitButton.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.CenteredSplitButton.CustomizableEdges = borderEdges2;
            this.CenteredSplitButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.CenteredSplitButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.CenteredSplitButton.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.CenteredSplitButton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.CenteredSplitButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.CenteredSplitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CenteredSplitButton.ForeColor = System.Drawing.Color.White;
            this.CenteredSplitButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CenteredSplitButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.CenteredSplitButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.CenteredSplitButton.IconMarginLeft = 11;
            this.CenteredSplitButton.IconPadding = 10;
            this.CenteredSplitButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CenteredSplitButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.CenteredSplitButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.CenteredSplitButton.IconSize = 25;
            this.CenteredSplitButton.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.CenteredSplitButton.IdleBorderRadius = 1;
            this.CenteredSplitButton.IdleBorderThickness = 1;
            this.CenteredSplitButton.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.CenteredSplitButton.IdleIconLeftImage = null;
            this.CenteredSplitButton.IdleIconRightImage = null;
            this.CenteredSplitButton.IndicateFocus = false;
            this.CenteredSplitButton.Location = new System.Drawing.Point(766, 300);
            this.CenteredSplitButton.Name = "CenteredSplitButton";
            this.CenteredSplitButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.CenteredSplitButton.OnDisabledState.BorderRadius = 1;
            this.CenteredSplitButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.CenteredSplitButton.OnDisabledState.BorderThickness = 1;
            this.CenteredSplitButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.CenteredSplitButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.CenteredSplitButton.OnDisabledState.IconLeftImage = null;
            this.CenteredSplitButton.OnDisabledState.IconRightImage = null;
            this.CenteredSplitButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.CenteredSplitButton.onHoverState.BorderRadius = 1;
            this.CenteredSplitButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.CenteredSplitButton.onHoverState.BorderThickness = 1;
            this.CenteredSplitButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.CenteredSplitButton.onHoverState.ForeColor = System.Drawing.Color.White;
            this.CenteredSplitButton.onHoverState.IconLeftImage = null;
            this.CenteredSplitButton.onHoverState.IconRightImage = null;
            this.CenteredSplitButton.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.CenteredSplitButton.OnIdleState.BorderRadius = 1;
            this.CenteredSplitButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.CenteredSplitButton.OnIdleState.BorderThickness = 1;
            this.CenteredSplitButton.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.CenteredSplitButton.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.CenteredSplitButton.OnIdleState.IconLeftImage = null;
            this.CenteredSplitButton.OnIdleState.IconRightImage = null;
            this.CenteredSplitButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.CenteredSplitButton.OnPressedState.BorderRadius = 1;
            this.CenteredSplitButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.CenteredSplitButton.OnPressedState.BorderThickness = 1;
            this.CenteredSplitButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.CenteredSplitButton.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.CenteredSplitButton.OnPressedState.IconLeftImage = null;
            this.CenteredSplitButton.OnPressedState.IconRightImage = null;
            this.CenteredSplitButton.Size = new System.Drawing.Size(106, 39);
            this.CenteredSplitButton.TabIndex = 8;
            this.CenteredSplitButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CenteredSplitButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.CenteredSplitButton.TextMarginLeft = 0;
            this.CenteredSplitButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.CenteredSplitButton.UseDefaultRadiusAndThickness = true;
            this.CenteredSplitButton.Visible = false;
            this.CenteredSplitButton.Click += new System.EventHandler(this.CenteredSplitButton_Click);
            // 
            // CenteredStandButton
            // 
            this.CenteredStandButton.AllowAnimations = true;
            this.CenteredStandButton.AllowMouseEffects = true;
            this.CenteredStandButton.AllowToggling = false;
            this.CenteredStandButton.AnimationSpeed = 200;
            this.CenteredStandButton.AutoGenerateColors = false;
            this.CenteredStandButton.AutoRoundBorders = false;
            this.CenteredStandButton.AutoSizeLeftIcon = true;
            this.CenteredStandButton.AutoSizeRightIcon = true;
            this.CenteredStandButton.BackColor = System.Drawing.Color.Transparent;
            this.CenteredStandButton.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.CenteredStandButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CenteredStandButton.BackgroundImage")));
            this.CenteredStandButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.CenteredStandButton.ButtonText = "Stand";
            this.CenteredStandButton.ButtonTextMarginLeft = 0;
            this.CenteredStandButton.ColorContrastOnClick = 45;
            this.CenteredStandButton.ColorContrastOnHover = 45;
            this.CenteredStandButton.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.CenteredStandButton.CustomizableEdges = borderEdges3;
            this.CenteredStandButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.CenteredStandButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.CenteredStandButton.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.CenteredStandButton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.CenteredStandButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.CenteredStandButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CenteredStandButton.ForeColor = System.Drawing.Color.White;
            this.CenteredStandButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CenteredStandButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.CenteredStandButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.CenteredStandButton.IconMarginLeft = 11;
            this.CenteredStandButton.IconPadding = 10;
            this.CenteredStandButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CenteredStandButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.CenteredStandButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.CenteredStandButton.IconSize = 25;
            this.CenteredStandButton.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.CenteredStandButton.IdleBorderRadius = 1;
            this.CenteredStandButton.IdleBorderThickness = 1;
            this.CenteredStandButton.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.CenteredStandButton.IdleIconLeftImage = null;
            this.CenteredStandButton.IdleIconRightImage = null;
            this.CenteredStandButton.IndicateFocus = false;
            this.CenteredStandButton.Location = new System.Drawing.Point(642, 300);
            this.CenteredStandButton.Name = "CenteredStandButton";
            this.CenteredStandButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.CenteredStandButton.OnDisabledState.BorderRadius = 1;
            this.CenteredStandButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.CenteredStandButton.OnDisabledState.BorderThickness = 1;
            this.CenteredStandButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.CenteredStandButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.CenteredStandButton.OnDisabledState.IconLeftImage = null;
            this.CenteredStandButton.OnDisabledState.IconRightImage = null;
            this.CenteredStandButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.CenteredStandButton.onHoverState.BorderRadius = 1;
            this.CenteredStandButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.CenteredStandButton.onHoverState.BorderThickness = 1;
            this.CenteredStandButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.CenteredStandButton.onHoverState.ForeColor = System.Drawing.Color.White;
            this.CenteredStandButton.onHoverState.IconLeftImage = null;
            this.CenteredStandButton.onHoverState.IconRightImage = null;
            this.CenteredStandButton.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.CenteredStandButton.OnIdleState.BorderRadius = 1;
            this.CenteredStandButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.CenteredStandButton.OnIdleState.BorderThickness = 1;
            this.CenteredStandButton.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.CenteredStandButton.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.CenteredStandButton.OnIdleState.IconLeftImage = null;
            this.CenteredStandButton.OnIdleState.IconRightImage = null;
            this.CenteredStandButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.CenteredStandButton.OnPressedState.BorderRadius = 1;
            this.CenteredStandButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.CenteredStandButton.OnPressedState.BorderThickness = 1;
            this.CenteredStandButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.CenteredStandButton.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.CenteredStandButton.OnPressedState.IconLeftImage = null;
            this.CenteredStandButton.OnPressedState.IconRightImage = null;
            this.CenteredStandButton.Size = new System.Drawing.Size(106, 39);
            this.CenteredStandButton.TabIndex = 7;
            this.CenteredStandButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CenteredStandButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.CenteredStandButton.TextMarginLeft = 0;
            this.CenteredStandButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.CenteredStandButton.UseDefaultRadiusAndThickness = true;
            this.CenteredStandButton.Visible = false;
            this.CenteredStandButton.Click += new System.EventHandler(this.CenteredStandButton_Click);
            // 
            // CenteredHitButton
            // 
            this.CenteredHitButton.AllowAnimations = true;
            this.CenteredHitButton.AllowMouseEffects = true;
            this.CenteredHitButton.AllowToggling = false;
            this.CenteredHitButton.AnimationSpeed = 200;
            this.CenteredHitButton.AutoGenerateColors = false;
            this.CenteredHitButton.AutoRoundBorders = false;
            this.CenteredHitButton.AutoSizeLeftIcon = true;
            this.CenteredHitButton.AutoSizeRightIcon = true;
            this.CenteredHitButton.BackColor = System.Drawing.Color.Transparent;
            this.CenteredHitButton.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.CenteredHitButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CenteredHitButton.BackgroundImage")));
            this.CenteredHitButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.CenteredHitButton.ButtonText = "Hit";
            this.CenteredHitButton.ButtonTextMarginLeft = 0;
            this.CenteredHitButton.ColorContrastOnClick = 45;
            this.CenteredHitButton.ColorContrastOnHover = 45;
            this.CenteredHitButton.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.CenteredHitButton.CustomizableEdges = borderEdges4;
            this.CenteredHitButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.CenteredHitButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.CenteredHitButton.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.CenteredHitButton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.CenteredHitButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.CenteredHitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CenteredHitButton.ForeColor = System.Drawing.Color.White;
            this.CenteredHitButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CenteredHitButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.CenteredHitButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.CenteredHitButton.IconMarginLeft = 11;
            this.CenteredHitButton.IconPadding = 10;
            this.CenteredHitButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CenteredHitButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.CenteredHitButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.CenteredHitButton.IconSize = 25;
            this.CenteredHitButton.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.CenteredHitButton.IdleBorderRadius = 1;
            this.CenteredHitButton.IdleBorderThickness = 1;
            this.CenteredHitButton.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.CenteredHitButton.IdleIconLeftImage = null;
            this.CenteredHitButton.IdleIconRightImage = null;
            this.CenteredHitButton.IndicateFocus = false;
            this.CenteredHitButton.Location = new System.Drawing.Point(518, 300);
            this.CenteredHitButton.Name = "CenteredHitButton";
            this.CenteredHitButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.CenteredHitButton.OnDisabledState.BorderRadius = 1;
            this.CenteredHitButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.CenteredHitButton.OnDisabledState.BorderThickness = 1;
            this.CenteredHitButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.CenteredHitButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.CenteredHitButton.OnDisabledState.IconLeftImage = null;
            this.CenteredHitButton.OnDisabledState.IconRightImage = null;
            this.CenteredHitButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.CenteredHitButton.onHoverState.BorderRadius = 1;
            this.CenteredHitButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.CenteredHitButton.onHoverState.BorderThickness = 1;
            this.CenteredHitButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.CenteredHitButton.onHoverState.ForeColor = System.Drawing.Color.White;
            this.CenteredHitButton.onHoverState.IconLeftImage = null;
            this.CenteredHitButton.onHoverState.IconRightImage = null;
            this.CenteredHitButton.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.CenteredHitButton.OnIdleState.BorderRadius = 1;
            this.CenteredHitButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.CenteredHitButton.OnIdleState.BorderThickness = 1;
            this.CenteredHitButton.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.CenteredHitButton.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.CenteredHitButton.OnIdleState.IconLeftImage = null;
            this.CenteredHitButton.OnIdleState.IconRightImage = null;
            this.CenteredHitButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.CenteredHitButton.OnPressedState.BorderRadius = 1;
            this.CenteredHitButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.CenteredHitButton.OnPressedState.BorderThickness = 1;
            this.CenteredHitButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.CenteredHitButton.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.CenteredHitButton.OnPressedState.IconLeftImage = null;
            this.CenteredHitButton.OnPressedState.IconRightImage = null;
            this.CenteredHitButton.Size = new System.Drawing.Size(106, 39);
            this.CenteredHitButton.TabIndex = 6;
            this.CenteredHitButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CenteredHitButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.CenteredHitButton.TextMarginLeft = 0;
            this.CenteredHitButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.CenteredHitButton.UseDefaultRadiusAndThickness = true;
            this.CenteredHitButton.Visible = false;
            this.CenteredHitButton.Click += new System.EventHandler(this.CenteredHitButton_Click);
            // 
            // SplitScenarioRightSideStandButton
            // 
            this.SplitScenarioRightSideStandButton.AllowAnimations = true;
            this.SplitScenarioRightSideStandButton.AllowMouseEffects = true;
            this.SplitScenarioRightSideStandButton.AllowToggling = false;
            this.SplitScenarioRightSideStandButton.AnimationSpeed = 200;
            this.SplitScenarioRightSideStandButton.AutoGenerateColors = false;
            this.SplitScenarioRightSideStandButton.AutoRoundBorders = false;
            this.SplitScenarioRightSideStandButton.AutoSizeLeftIcon = true;
            this.SplitScenarioRightSideStandButton.AutoSizeRightIcon = true;
            this.SplitScenarioRightSideStandButton.BackColor = System.Drawing.Color.Transparent;
            this.SplitScenarioRightSideStandButton.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.SplitScenarioRightSideStandButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SplitScenarioRightSideStandButton.BackgroundImage")));
            this.SplitScenarioRightSideStandButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.SplitScenarioRightSideStandButton.ButtonText = "Stand Right Hand";
            this.SplitScenarioRightSideStandButton.ButtonTextMarginLeft = 0;
            this.SplitScenarioRightSideStandButton.ColorContrastOnClick = 45;
            this.SplitScenarioRightSideStandButton.ColorContrastOnHover = 45;
            this.SplitScenarioRightSideStandButton.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges5.BottomLeft = true;
            borderEdges5.BottomRight = true;
            borderEdges5.TopLeft = true;
            borderEdges5.TopRight = true;
            this.SplitScenarioRightSideStandButton.CustomizableEdges = borderEdges5;
            this.SplitScenarioRightSideStandButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.SplitScenarioRightSideStandButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.SplitScenarioRightSideStandButton.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.SplitScenarioRightSideStandButton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.SplitScenarioRightSideStandButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.SplitScenarioRightSideStandButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SplitScenarioRightSideStandButton.ForeColor = System.Drawing.Color.White;
            this.SplitScenarioRightSideStandButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SplitScenarioRightSideStandButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.SplitScenarioRightSideStandButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.SplitScenarioRightSideStandButton.IconMarginLeft = 11;
            this.SplitScenarioRightSideStandButton.IconPadding = 10;
            this.SplitScenarioRightSideStandButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SplitScenarioRightSideStandButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.SplitScenarioRightSideStandButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.SplitScenarioRightSideStandButton.IconSize = 25;
            this.SplitScenarioRightSideStandButton.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.SplitScenarioRightSideStandButton.IdleBorderRadius = 1;
            this.SplitScenarioRightSideStandButton.IdleBorderThickness = 1;
            this.SplitScenarioRightSideStandButton.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.SplitScenarioRightSideStandButton.IdleIconLeftImage = null;
            this.SplitScenarioRightSideStandButton.IdleIconRightImage = null;
            this.SplitScenarioRightSideStandButton.IndicateFocus = false;
            this.SplitScenarioRightSideStandButton.Location = new System.Drawing.Point(1107, 300);
            this.SplitScenarioRightSideStandButton.Name = "SplitScenarioRightSideStandButton";
            this.SplitScenarioRightSideStandButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.SplitScenarioRightSideStandButton.OnDisabledState.BorderRadius = 1;
            this.SplitScenarioRightSideStandButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.SplitScenarioRightSideStandButton.OnDisabledState.BorderThickness = 1;
            this.SplitScenarioRightSideStandButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.SplitScenarioRightSideStandButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.SplitScenarioRightSideStandButton.OnDisabledState.IconLeftImage = null;
            this.SplitScenarioRightSideStandButton.OnDisabledState.IconRightImage = null;
            this.SplitScenarioRightSideStandButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.SplitScenarioRightSideStandButton.onHoverState.BorderRadius = 1;
            this.SplitScenarioRightSideStandButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.SplitScenarioRightSideStandButton.onHoverState.BorderThickness = 1;
            this.SplitScenarioRightSideStandButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.SplitScenarioRightSideStandButton.onHoverState.ForeColor = System.Drawing.Color.White;
            this.SplitScenarioRightSideStandButton.onHoverState.IconLeftImage = null;
            this.SplitScenarioRightSideStandButton.onHoverState.IconRightImage = null;
            this.SplitScenarioRightSideStandButton.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.SplitScenarioRightSideStandButton.OnIdleState.BorderRadius = 1;
            this.SplitScenarioRightSideStandButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.SplitScenarioRightSideStandButton.OnIdleState.BorderThickness = 1;
            this.SplitScenarioRightSideStandButton.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.SplitScenarioRightSideStandButton.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.SplitScenarioRightSideStandButton.OnIdleState.IconLeftImage = null;
            this.SplitScenarioRightSideStandButton.OnIdleState.IconRightImage = null;
            this.SplitScenarioRightSideStandButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.SplitScenarioRightSideStandButton.OnPressedState.BorderRadius = 1;
            this.SplitScenarioRightSideStandButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.SplitScenarioRightSideStandButton.OnPressedState.BorderThickness = 1;
            this.SplitScenarioRightSideStandButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.SplitScenarioRightSideStandButton.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.SplitScenarioRightSideStandButton.OnPressedState.IconLeftImage = null;
            this.SplitScenarioRightSideStandButton.OnPressedState.IconRightImage = null;
            this.SplitScenarioRightSideStandButton.Size = new System.Drawing.Size(129, 39);
            this.SplitScenarioRightSideStandButton.TabIndex = 5;
            this.SplitScenarioRightSideStandButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SplitScenarioRightSideStandButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.SplitScenarioRightSideStandButton.TextMarginLeft = 0;
            this.SplitScenarioRightSideStandButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.SplitScenarioRightSideStandButton.UseDefaultRadiusAndThickness = true;
            this.SplitScenarioRightSideStandButton.Visible = false;
            this.SplitScenarioRightSideStandButton.Click += new System.EventHandler(this.SplitScenarioRightSideStandButton_Click);
            // 
            // SplitScenarioRightSideHitButton
            // 
            this.SplitScenarioRightSideHitButton.AllowAnimations = true;
            this.SplitScenarioRightSideHitButton.AllowMouseEffects = true;
            this.SplitScenarioRightSideHitButton.AllowToggling = false;
            this.SplitScenarioRightSideHitButton.AnimationSpeed = 200;
            this.SplitScenarioRightSideHitButton.AutoGenerateColors = false;
            this.SplitScenarioRightSideHitButton.AutoRoundBorders = false;
            this.SplitScenarioRightSideHitButton.AutoSizeLeftIcon = true;
            this.SplitScenarioRightSideHitButton.AutoSizeRightIcon = true;
            this.SplitScenarioRightSideHitButton.BackColor = System.Drawing.Color.Transparent;
            this.SplitScenarioRightSideHitButton.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.SplitScenarioRightSideHitButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SplitScenarioRightSideHitButton.BackgroundImage")));
            this.SplitScenarioRightSideHitButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.SplitScenarioRightSideHitButton.ButtonText = "Hit Right Hand";
            this.SplitScenarioRightSideHitButton.ButtonTextMarginLeft = 0;
            this.SplitScenarioRightSideHitButton.ColorContrastOnClick = 45;
            this.SplitScenarioRightSideHitButton.ColorContrastOnHover = 45;
            this.SplitScenarioRightSideHitButton.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges6.BottomLeft = true;
            borderEdges6.BottomRight = true;
            borderEdges6.TopLeft = true;
            borderEdges6.TopRight = true;
            this.SplitScenarioRightSideHitButton.CustomizableEdges = borderEdges6;
            this.SplitScenarioRightSideHitButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.SplitScenarioRightSideHitButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.SplitScenarioRightSideHitButton.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.SplitScenarioRightSideHitButton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.SplitScenarioRightSideHitButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.SplitScenarioRightSideHitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SplitScenarioRightSideHitButton.ForeColor = System.Drawing.Color.White;
            this.SplitScenarioRightSideHitButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SplitScenarioRightSideHitButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.SplitScenarioRightSideHitButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.SplitScenarioRightSideHitButton.IconMarginLeft = 11;
            this.SplitScenarioRightSideHitButton.IconPadding = 10;
            this.SplitScenarioRightSideHitButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SplitScenarioRightSideHitButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.SplitScenarioRightSideHitButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.SplitScenarioRightSideHitButton.IconSize = 25;
            this.SplitScenarioRightSideHitButton.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.SplitScenarioRightSideHitButton.IdleBorderRadius = 1;
            this.SplitScenarioRightSideHitButton.IdleBorderThickness = 1;
            this.SplitScenarioRightSideHitButton.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.SplitScenarioRightSideHitButton.IdleIconLeftImage = null;
            this.SplitScenarioRightSideHitButton.IdleIconRightImage = null;
            this.SplitScenarioRightSideHitButton.IndicateFocus = false;
            this.SplitScenarioRightSideHitButton.Location = new System.Drawing.Point(980, 300);
            this.SplitScenarioRightSideHitButton.Name = "SplitScenarioRightSideHitButton";
            this.SplitScenarioRightSideHitButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.SplitScenarioRightSideHitButton.OnDisabledState.BorderRadius = 1;
            this.SplitScenarioRightSideHitButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.SplitScenarioRightSideHitButton.OnDisabledState.BorderThickness = 1;
            this.SplitScenarioRightSideHitButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.SplitScenarioRightSideHitButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.SplitScenarioRightSideHitButton.OnDisabledState.IconLeftImage = null;
            this.SplitScenarioRightSideHitButton.OnDisabledState.IconRightImage = null;
            this.SplitScenarioRightSideHitButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.SplitScenarioRightSideHitButton.onHoverState.BorderRadius = 1;
            this.SplitScenarioRightSideHitButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.SplitScenarioRightSideHitButton.onHoverState.BorderThickness = 1;
            this.SplitScenarioRightSideHitButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.SplitScenarioRightSideHitButton.onHoverState.ForeColor = System.Drawing.Color.White;
            this.SplitScenarioRightSideHitButton.onHoverState.IconLeftImage = null;
            this.SplitScenarioRightSideHitButton.onHoverState.IconRightImage = null;
            this.SplitScenarioRightSideHitButton.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.SplitScenarioRightSideHitButton.OnIdleState.BorderRadius = 1;
            this.SplitScenarioRightSideHitButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.SplitScenarioRightSideHitButton.OnIdleState.BorderThickness = 1;
            this.SplitScenarioRightSideHitButton.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.SplitScenarioRightSideHitButton.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.SplitScenarioRightSideHitButton.OnIdleState.IconLeftImage = null;
            this.SplitScenarioRightSideHitButton.OnIdleState.IconRightImage = null;
            this.SplitScenarioRightSideHitButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.SplitScenarioRightSideHitButton.OnPressedState.BorderRadius = 1;
            this.SplitScenarioRightSideHitButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.SplitScenarioRightSideHitButton.OnPressedState.BorderThickness = 1;
            this.SplitScenarioRightSideHitButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.SplitScenarioRightSideHitButton.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.SplitScenarioRightSideHitButton.OnPressedState.IconLeftImage = null;
            this.SplitScenarioRightSideHitButton.OnPressedState.IconRightImage = null;
            this.SplitScenarioRightSideHitButton.Size = new System.Drawing.Size(121, 39);
            this.SplitScenarioRightSideHitButton.TabIndex = 4;
            this.SplitScenarioRightSideHitButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SplitScenarioRightSideHitButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.SplitScenarioRightSideHitButton.TextMarginLeft = 0;
            this.SplitScenarioRightSideHitButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.SplitScenarioRightSideHitButton.UseDefaultRadiusAndThickness = true;
            this.SplitScenarioRightSideHitButton.Visible = false;
            this.SplitScenarioRightSideHitButton.Click += new System.EventHandler(this.SplitScenarioRightSideHitButton_Click);
            // 
            // SplitScenarioLeftSideStandButton
            // 
            this.SplitScenarioLeftSideStandButton.AllowAnimations = true;
            this.SplitScenarioLeftSideStandButton.AllowMouseEffects = true;
            this.SplitScenarioLeftSideStandButton.AllowToggling = false;
            this.SplitScenarioLeftSideStandButton.AnimationSpeed = 200;
            this.SplitScenarioLeftSideStandButton.AutoGenerateColors = false;
            this.SplitScenarioLeftSideStandButton.AutoRoundBorders = false;
            this.SplitScenarioLeftSideStandButton.AutoSizeLeftIcon = true;
            this.SplitScenarioLeftSideStandButton.AutoSizeRightIcon = true;
            this.SplitScenarioLeftSideStandButton.BackColor = System.Drawing.Color.Transparent;
            this.SplitScenarioLeftSideStandButton.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.SplitScenarioLeftSideStandButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SplitScenarioLeftSideStandButton.BackgroundImage")));
            this.SplitScenarioLeftSideStandButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.SplitScenarioLeftSideStandButton.ButtonText = "Stand Left Hand";
            this.SplitScenarioLeftSideStandButton.ButtonTextMarginLeft = 0;
            this.SplitScenarioLeftSideStandButton.ColorContrastOnClick = 45;
            this.SplitScenarioLeftSideStandButton.ColorContrastOnHover = 45;
            this.SplitScenarioLeftSideStandButton.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges7.BottomLeft = true;
            borderEdges7.BottomRight = true;
            borderEdges7.TopLeft = true;
            borderEdges7.TopRight = true;
            this.SplitScenarioLeftSideStandButton.CustomizableEdges = borderEdges7;
            this.SplitScenarioLeftSideStandButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.SplitScenarioLeftSideStandButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.SplitScenarioLeftSideStandButton.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.SplitScenarioLeftSideStandButton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.SplitScenarioLeftSideStandButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.SplitScenarioLeftSideStandButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SplitScenarioLeftSideStandButton.ForeColor = System.Drawing.Color.White;
            this.SplitScenarioLeftSideStandButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SplitScenarioLeftSideStandButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.SplitScenarioLeftSideStandButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.SplitScenarioLeftSideStandButton.IconMarginLeft = 11;
            this.SplitScenarioLeftSideStandButton.IconPadding = 10;
            this.SplitScenarioLeftSideStandButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SplitScenarioLeftSideStandButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.SplitScenarioLeftSideStandButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.SplitScenarioLeftSideStandButton.IconSize = 25;
            this.SplitScenarioLeftSideStandButton.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.SplitScenarioLeftSideStandButton.IdleBorderRadius = 1;
            this.SplitScenarioLeftSideStandButton.IdleBorderThickness = 1;
            this.SplitScenarioLeftSideStandButton.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.SplitScenarioLeftSideStandButton.IdleIconLeftImage = null;
            this.SplitScenarioLeftSideStandButton.IdleIconRightImage = null;
            this.SplitScenarioLeftSideStandButton.IndicateFocus = false;
            this.SplitScenarioLeftSideStandButton.Location = new System.Drawing.Point(299, 300);
            this.SplitScenarioLeftSideStandButton.Name = "SplitScenarioLeftSideStandButton";
            this.SplitScenarioLeftSideStandButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.SplitScenarioLeftSideStandButton.OnDisabledState.BorderRadius = 1;
            this.SplitScenarioLeftSideStandButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.SplitScenarioLeftSideStandButton.OnDisabledState.BorderThickness = 1;
            this.SplitScenarioLeftSideStandButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.SplitScenarioLeftSideStandButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.SplitScenarioLeftSideStandButton.OnDisabledState.IconLeftImage = null;
            this.SplitScenarioLeftSideStandButton.OnDisabledState.IconRightImage = null;
            this.SplitScenarioLeftSideStandButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.SplitScenarioLeftSideStandButton.onHoverState.BorderRadius = 1;
            this.SplitScenarioLeftSideStandButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.SplitScenarioLeftSideStandButton.onHoverState.BorderThickness = 1;
            this.SplitScenarioLeftSideStandButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.SplitScenarioLeftSideStandButton.onHoverState.ForeColor = System.Drawing.Color.White;
            this.SplitScenarioLeftSideStandButton.onHoverState.IconLeftImage = null;
            this.SplitScenarioLeftSideStandButton.onHoverState.IconRightImage = null;
            this.SplitScenarioLeftSideStandButton.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.SplitScenarioLeftSideStandButton.OnIdleState.BorderRadius = 1;
            this.SplitScenarioLeftSideStandButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.SplitScenarioLeftSideStandButton.OnIdleState.BorderThickness = 1;
            this.SplitScenarioLeftSideStandButton.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.SplitScenarioLeftSideStandButton.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.SplitScenarioLeftSideStandButton.OnIdleState.IconLeftImage = null;
            this.SplitScenarioLeftSideStandButton.OnIdleState.IconRightImage = null;
            this.SplitScenarioLeftSideStandButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.SplitScenarioLeftSideStandButton.OnPressedState.BorderRadius = 1;
            this.SplitScenarioLeftSideStandButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.SplitScenarioLeftSideStandButton.OnPressedState.BorderThickness = 1;
            this.SplitScenarioLeftSideStandButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.SplitScenarioLeftSideStandButton.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.SplitScenarioLeftSideStandButton.OnPressedState.IconLeftImage = null;
            this.SplitScenarioLeftSideStandButton.OnPressedState.IconRightImage = null;
            this.SplitScenarioLeftSideStandButton.Size = new System.Drawing.Size(123, 39);
            this.SplitScenarioLeftSideStandButton.TabIndex = 3;
            this.SplitScenarioLeftSideStandButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SplitScenarioLeftSideStandButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.SplitScenarioLeftSideStandButton.TextMarginLeft = 0;
            this.SplitScenarioLeftSideStandButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.SplitScenarioLeftSideStandButton.UseDefaultRadiusAndThickness = true;
            this.SplitScenarioLeftSideStandButton.Visible = false;
            this.SplitScenarioLeftSideStandButton.Click += new System.EventHandler(this.SplitScenarioLeftSideStandButton_Click);
            // 
            // SplitScenarioLeftSideHitButton
            // 
            this.SplitScenarioLeftSideHitButton.AllowAnimations = true;
            this.SplitScenarioLeftSideHitButton.AllowMouseEffects = true;
            this.SplitScenarioLeftSideHitButton.AllowToggling = false;
            this.SplitScenarioLeftSideHitButton.AnimationSpeed = 200;
            this.SplitScenarioLeftSideHitButton.AutoGenerateColors = false;
            this.SplitScenarioLeftSideHitButton.AutoRoundBorders = false;
            this.SplitScenarioLeftSideHitButton.AutoSizeLeftIcon = true;
            this.SplitScenarioLeftSideHitButton.AutoSizeRightIcon = true;
            this.SplitScenarioLeftSideHitButton.BackColor = System.Drawing.Color.Transparent;
            this.SplitScenarioLeftSideHitButton.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.SplitScenarioLeftSideHitButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SplitScenarioLeftSideHitButton.BackgroundImage")));
            this.SplitScenarioLeftSideHitButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.SplitScenarioLeftSideHitButton.ButtonText = "Hit Left Hand";
            this.SplitScenarioLeftSideHitButton.ButtonTextMarginLeft = 0;
            this.SplitScenarioLeftSideHitButton.ColorContrastOnClick = 45;
            this.SplitScenarioLeftSideHitButton.ColorContrastOnHover = 45;
            this.SplitScenarioLeftSideHitButton.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges8.BottomLeft = true;
            borderEdges8.BottomRight = true;
            borderEdges8.TopLeft = true;
            borderEdges8.TopRight = true;
            this.SplitScenarioLeftSideHitButton.CustomizableEdges = borderEdges8;
            this.SplitScenarioLeftSideHitButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.SplitScenarioLeftSideHitButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.SplitScenarioLeftSideHitButton.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.SplitScenarioLeftSideHitButton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.SplitScenarioLeftSideHitButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.SplitScenarioLeftSideHitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SplitScenarioLeftSideHitButton.ForeColor = System.Drawing.Color.White;
            this.SplitScenarioLeftSideHitButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SplitScenarioLeftSideHitButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.SplitScenarioLeftSideHitButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.SplitScenarioLeftSideHitButton.IconMarginLeft = 11;
            this.SplitScenarioLeftSideHitButton.IconPadding = 10;
            this.SplitScenarioLeftSideHitButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SplitScenarioLeftSideHitButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.SplitScenarioLeftSideHitButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.SplitScenarioLeftSideHitButton.IconSize = 25;
            this.SplitScenarioLeftSideHitButton.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.SplitScenarioLeftSideHitButton.IdleBorderRadius = 1;
            this.SplitScenarioLeftSideHitButton.IdleBorderThickness = 1;
            this.SplitScenarioLeftSideHitButton.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.SplitScenarioLeftSideHitButton.IdleIconLeftImage = null;
            this.SplitScenarioLeftSideHitButton.IdleIconRightImage = null;
            this.SplitScenarioLeftSideHitButton.IndicateFocus = false;
            this.SplitScenarioLeftSideHitButton.Location = new System.Drawing.Point(170, 300);
            this.SplitScenarioLeftSideHitButton.Name = "SplitScenarioLeftSideHitButton";
            this.SplitScenarioLeftSideHitButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.SplitScenarioLeftSideHitButton.OnDisabledState.BorderRadius = 1;
            this.SplitScenarioLeftSideHitButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.SplitScenarioLeftSideHitButton.OnDisabledState.BorderThickness = 1;
            this.SplitScenarioLeftSideHitButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.SplitScenarioLeftSideHitButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.SplitScenarioLeftSideHitButton.OnDisabledState.IconLeftImage = null;
            this.SplitScenarioLeftSideHitButton.OnDisabledState.IconRightImage = null;
            this.SplitScenarioLeftSideHitButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.SplitScenarioLeftSideHitButton.onHoverState.BorderRadius = 1;
            this.SplitScenarioLeftSideHitButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.SplitScenarioLeftSideHitButton.onHoverState.BorderThickness = 1;
            this.SplitScenarioLeftSideHitButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.SplitScenarioLeftSideHitButton.onHoverState.ForeColor = System.Drawing.Color.White;
            this.SplitScenarioLeftSideHitButton.onHoverState.IconLeftImage = null;
            this.SplitScenarioLeftSideHitButton.onHoverState.IconRightImage = null;
            this.SplitScenarioLeftSideHitButton.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.SplitScenarioLeftSideHitButton.OnIdleState.BorderRadius = 1;
            this.SplitScenarioLeftSideHitButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.SplitScenarioLeftSideHitButton.OnIdleState.BorderThickness = 1;
            this.SplitScenarioLeftSideHitButton.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.SplitScenarioLeftSideHitButton.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.SplitScenarioLeftSideHitButton.OnIdleState.IconLeftImage = null;
            this.SplitScenarioLeftSideHitButton.OnIdleState.IconRightImage = null;
            this.SplitScenarioLeftSideHitButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.SplitScenarioLeftSideHitButton.OnPressedState.BorderRadius = 1;
            this.SplitScenarioLeftSideHitButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.SplitScenarioLeftSideHitButton.OnPressedState.BorderThickness = 1;
            this.SplitScenarioLeftSideHitButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.SplitScenarioLeftSideHitButton.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.SplitScenarioLeftSideHitButton.OnPressedState.IconLeftImage = null;
            this.SplitScenarioLeftSideHitButton.OnPressedState.IconRightImage = null;
            this.SplitScenarioLeftSideHitButton.Size = new System.Drawing.Size(123, 39);
            this.SplitScenarioLeftSideHitButton.TabIndex = 2;
            this.SplitScenarioLeftSideHitButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SplitScenarioLeftSideHitButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.SplitScenarioLeftSideHitButton.TextMarginLeft = 0;
            this.SplitScenarioLeftSideHitButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.SplitScenarioLeftSideHitButton.UseDefaultRadiusAndThickness = true;
            this.SplitScenarioLeftSideHitButton.Visible = false;
            this.SplitScenarioLeftSideHitButton.Click += new System.EventHandler(this.SplitScenarioLeftSideHitButton_Click);
            // 
            // BalanceTextBox
            // 
            this.BalanceTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BalanceTextBox.Location = new System.Drawing.Point(35, 300);
            this.BalanceTextBox.Name = "BalanceTextBox";
            this.BalanceTextBox.ReadOnly = true;
            this.BalanceTextBox.Size = new System.Drawing.Size(70, 29);
            this.BalanceTextBox.TabIndex = 22;
            this.BalanceTextBox.Text = "0";
            // 
            // BalanceLabel
            // 
            this.BalanceLabel.AutoSize = true;
            this.BalanceLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BalanceLabel.Location = new System.Drawing.Point(31, 265);
            this.BalanceLabel.Name = "BalanceLabel";
            this.BalanceLabel.Size = new System.Drawing.Size(95, 21);
            this.BalanceLabel.TabIndex = 23;
            this.BalanceLabel.Text = "Total funds";
            // 
            // BlackJack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 630);
            this.Controls.Add(this.DealerAndButtonsPanel);
            this.Controls.Add(this.LeftSidePlayerFlowLayoutPanel);
            this.Controls.Add(this.LeftRightPlayerFlowLayoutPanel);
            this.Name = "BlackJack";
            this.Text = "BlackJack";
            this.Load += new System.EventHandler(this.BlackJack_Load);
            this.DealerAndButtonsPanel.ResumeLayout(false);
            this.DealerAndButtonsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BetNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label PlayerLabel2;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton DealCardsButton;
        private System.Windows.Forms.FlowLayoutPanel LeftRightPlayerFlowLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel LeftSidePlayerFlowLayoutPanel;
        private Panel DealerAndButtonsPanel;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton CenteredSplitButton;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton CenteredStandButton;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton CenteredHitButton;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton SplitScenarioRightSideStandButton;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton SplitScenarioRightSideHitButton;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton SplitScenarioLeftSideStandButton;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton SplitScenarioLeftSideHitButton;
        private Label SplitScenarioLeftSideLabel;
        private Label CenteredLabel;
        private Label SplitScenarioRightSideLabel;
        private TextBox WinningsTextbox;
        private NumericUpDown BetNumericUpDown;
        private Label AboveBetLabel;
        private Label AboveWinningsLabel;
        private Label BalanceLabel;
        private TextBox BalanceTextBox;
    }
}
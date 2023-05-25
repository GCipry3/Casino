namespace DicesGame
{
    partial class Dices
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dices));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.GameRuleLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.PlayerTurnLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.timer1 = new System.Windows.Forms.Timer();
            this.PlayGameButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.FaderRollButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.ChangeGameRuleButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.FaderDice2 = new System.Windows.Forms.PictureBox();
            this.FaderDice1 = new System.Windows.Forms.PictureBox();
            this.ShooterDice2 = new System.Windows.Forms.PictureBox();
            this.ShooterDice1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.FaderDice2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FaderDice1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShooterDice2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShooterDice1)).BeginInit();
            this.SuspendLayout();
            // 
            // GameRuleLabel
            // 
            this.GameRuleLabel.AllowParentOverrides = false;
            this.GameRuleLabel.AutoEllipsis = false;
            this.GameRuleLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.GameRuleLabel.CursorType = System.Windows.Forms.Cursors.Default;
            this.GameRuleLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.GameRuleLabel.Location = new System.Drawing.Point(195, 30);
            this.GameRuleLabel.Name = "GameRuleLabel";
            this.GameRuleLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.GameRuleLabel.Size = new System.Drawing.Size(575, 21);
            this.GameRuleLabel.TabIndex = 9;
            this.GameRuleLabel.Text = "Game Rule: Greater Than \"You must roll a total higher than the House\'s roll to wi" +
    "n.\"";
            this.GameRuleLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.GameRuleLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // PlayerTurnLabel
            // 
            this.PlayerTurnLabel.AllowParentOverrides = false;
            this.PlayerTurnLabel.AutoEllipsis = false;
            this.PlayerTurnLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.PlayerTurnLabel.CursorType = System.Windows.Forms.Cursors.Default;
            this.PlayerTurnLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.PlayerTurnLabel.Location = new System.Drawing.Point(40, 106);
            this.PlayerTurnLabel.Name = "PlayerTurnLabel";
            this.PlayerTurnLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PlayerTurnLabel.Size = new System.Drawing.Size(133, 21);
            this.PlayerTurnLabel.TabIndex = 11;
            this.PlayerTurnLabel.Text = "House\'s turn to roll";
            this.PlayerTurnLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.PlayerTurnLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // PlayGameButton
            // 
            this.PlayGameButton.AllowAnimations = true;
            this.PlayGameButton.AllowMouseEffects = true;
            this.PlayGameButton.AllowToggling = false;
            this.PlayGameButton.AnimationSpeed = 200;
            this.PlayGameButton.AutoGenerateColors = false;
            this.PlayGameButton.AutoRoundBorders = false;
            this.PlayGameButton.AutoSizeLeftIcon = true;
            this.PlayGameButton.AutoSizeRightIcon = true;
            this.PlayGameButton.BackColor = System.Drawing.Color.Transparent;
            this.PlayGameButton.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.PlayGameButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PlayGameButton.BackgroundImage")));
            this.PlayGameButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.PlayGameButton.ButtonText = "Play";
            this.PlayGameButton.ButtonTextMarginLeft = 0;
            this.PlayGameButton.ColorContrastOnClick = 45;
            this.PlayGameButton.ColorContrastOnHover = 45;
            this.PlayGameButton.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.PlayGameButton.CustomizableEdges = borderEdges4;
            this.PlayGameButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.PlayGameButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.PlayGameButton.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.PlayGameButton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.PlayGameButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.PlayGameButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PlayGameButton.ForeColor = System.Drawing.Color.White;
            this.PlayGameButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PlayGameButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.PlayGameButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.PlayGameButton.IconMarginLeft = 11;
            this.PlayGameButton.IconPadding = 10;
            this.PlayGameButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PlayGameButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.PlayGameButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.PlayGameButton.IconSize = 25;
            this.PlayGameButton.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.PlayGameButton.IdleBorderRadius = 1;
            this.PlayGameButton.IdleBorderThickness = 1;
            this.PlayGameButton.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.PlayGameButton.IdleIconLeftImage = null;
            this.PlayGameButton.IdleIconRightImage = null;
            this.PlayGameButton.IndicateFocus = false;
            this.PlayGameButton.Location = new System.Drawing.Point(40, 179);
            this.PlayGameButton.Name = "PlayGameButton";
            this.PlayGameButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.PlayGameButton.OnDisabledState.BorderRadius = 1;
            this.PlayGameButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.PlayGameButton.OnDisabledState.BorderThickness = 1;
            this.PlayGameButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.PlayGameButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.PlayGameButton.OnDisabledState.IconLeftImage = null;
            this.PlayGameButton.OnDisabledState.IconRightImage = null;
            this.PlayGameButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.PlayGameButton.onHoverState.BorderRadius = 1;
            this.PlayGameButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.PlayGameButton.onHoverState.BorderThickness = 1;
            this.PlayGameButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.PlayGameButton.onHoverState.ForeColor = System.Drawing.Color.White;
            this.PlayGameButton.onHoverState.IconLeftImage = null;
            this.PlayGameButton.onHoverState.IconRightImage = null;
            this.PlayGameButton.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.PlayGameButton.OnIdleState.BorderRadius = 1;
            this.PlayGameButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.PlayGameButton.OnIdleState.BorderThickness = 1;
            this.PlayGameButton.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.PlayGameButton.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.PlayGameButton.OnIdleState.IconLeftImage = null;
            this.PlayGameButton.OnIdleState.IconRightImage = null;
            this.PlayGameButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.PlayGameButton.OnPressedState.BorderRadius = 1;
            this.PlayGameButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.PlayGameButton.OnPressedState.BorderThickness = 1;
            this.PlayGameButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.PlayGameButton.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.PlayGameButton.OnPressedState.IconLeftImage = null;
            this.PlayGameButton.OnPressedState.IconRightImage = null;
            this.PlayGameButton.Size = new System.Drawing.Size(121, 40);
            this.PlayGameButton.TabIndex = 10;
            this.PlayGameButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PlayGameButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.PlayGameButton.TextMarginLeft = 0;
            this.PlayGameButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.PlayGameButton.UseDefaultRadiusAndThickness = true;
            // 
            // FaderRollButton
            // 
            this.FaderRollButton.AllowAnimations = true;
            this.FaderRollButton.AllowMouseEffects = true;
            this.FaderRollButton.AllowToggling = false;
            this.FaderRollButton.AnimationSpeed = 200;
            this.FaderRollButton.AutoGenerateColors = false;
            this.FaderRollButton.AutoRoundBorders = false;
            this.FaderRollButton.AutoSizeLeftIcon = true;
            this.FaderRollButton.AutoSizeRightIcon = true;
            this.FaderRollButton.BackColor = System.Drawing.Color.Transparent;
            this.FaderRollButton.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.FaderRollButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FaderRollButton.BackgroundImage")));
            this.FaderRollButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.FaderRollButton.ButtonText = "Fader\'s Roll";
            this.FaderRollButton.ButtonTextMarginLeft = 0;
            this.FaderRollButton.ColorContrastOnClick = 45;
            this.FaderRollButton.ColorContrastOnHover = 45;
            this.FaderRollButton.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges5.BottomLeft = true;
            borderEdges5.BottomRight = true;
            borderEdges5.TopLeft = true;
            borderEdges5.TopRight = true;
            this.FaderRollButton.CustomizableEdges = borderEdges5;
            this.FaderRollButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.FaderRollButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.FaderRollButton.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.FaderRollButton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.FaderRollButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.FaderRollButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FaderRollButton.ForeColor = System.Drawing.Color.White;
            this.FaderRollButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FaderRollButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.FaderRollButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.FaderRollButton.IconMarginLeft = 11;
            this.FaderRollButton.IconPadding = 10;
            this.FaderRollButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.FaderRollButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.FaderRollButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.FaderRollButton.IconSize = 25;
            this.FaderRollButton.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.FaderRollButton.IdleBorderRadius = 1;
            this.FaderRollButton.IdleBorderThickness = 1;
            this.FaderRollButton.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.FaderRollButton.IdleIconLeftImage = null;
            this.FaderRollButton.IdleIconRightImage = null;
            this.FaderRollButton.IndicateFocus = false;
            this.FaderRollButton.Location = new System.Drawing.Point(40, 326);
            this.FaderRollButton.Name = "FaderRollButton";
            this.FaderRollButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.FaderRollButton.OnDisabledState.BorderRadius = 1;
            this.FaderRollButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.FaderRollButton.OnDisabledState.BorderThickness = 1;
            this.FaderRollButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.FaderRollButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.FaderRollButton.OnDisabledState.IconLeftImage = null;
            this.FaderRollButton.OnDisabledState.IconRightImage = null;
            this.FaderRollButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.FaderRollButton.onHoverState.BorderRadius = 1;
            this.FaderRollButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.FaderRollButton.onHoverState.BorderThickness = 1;
            this.FaderRollButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.FaderRollButton.onHoverState.ForeColor = System.Drawing.Color.White;
            this.FaderRollButton.onHoverState.IconLeftImage = null;
            this.FaderRollButton.onHoverState.IconRightImage = null;
            this.FaderRollButton.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.FaderRollButton.OnIdleState.BorderRadius = 1;
            this.FaderRollButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.FaderRollButton.OnIdleState.BorderThickness = 1;
            this.FaderRollButton.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.FaderRollButton.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.FaderRollButton.OnIdleState.IconLeftImage = null;
            this.FaderRollButton.OnIdleState.IconRightImage = null;
            this.FaderRollButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.FaderRollButton.OnPressedState.BorderRadius = 1;
            this.FaderRollButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.FaderRollButton.OnPressedState.BorderThickness = 1;
            this.FaderRollButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.FaderRollButton.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.FaderRollButton.OnPressedState.IconLeftImage = null;
            this.FaderRollButton.OnPressedState.IconRightImage = null;
            this.FaderRollButton.Size = new System.Drawing.Size(121, 40);
            this.FaderRollButton.TabIndex = 8;
            this.FaderRollButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.FaderRollButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.FaderRollButton.TextMarginLeft = 0;
            this.FaderRollButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.FaderRollButton.UseDefaultRadiusAndThickness = true;
            // 
            // ChangeGameRuleButton
            // 
            this.ChangeGameRuleButton.AllowAnimations = true;
            this.ChangeGameRuleButton.AllowMouseEffects = true;
            this.ChangeGameRuleButton.AllowToggling = false;
            this.ChangeGameRuleButton.AnimationSpeed = 200;
            this.ChangeGameRuleButton.AutoGenerateColors = false;
            this.ChangeGameRuleButton.AutoRoundBorders = false;
            this.ChangeGameRuleButton.AutoSizeLeftIcon = true;
            this.ChangeGameRuleButton.AutoSizeRightIcon = true;
            this.ChangeGameRuleButton.BackColor = System.Drawing.Color.Transparent;
            this.ChangeGameRuleButton.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.ChangeGameRuleButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ChangeGameRuleButton.BackgroundImage")));
            this.ChangeGameRuleButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.ChangeGameRuleButton.ButtonText = "Change Game Rule";
            this.ChangeGameRuleButton.ButtonTextMarginLeft = 0;
            this.ChangeGameRuleButton.ColorContrastOnClick = 45;
            this.ChangeGameRuleButton.ColorContrastOnHover = 45;
            this.ChangeGameRuleButton.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges6.BottomLeft = true;
            borderEdges6.BottomRight = true;
            borderEdges6.TopLeft = true;
            borderEdges6.TopRight = true;
            this.ChangeGameRuleButton.CustomizableEdges = borderEdges6;
            this.ChangeGameRuleButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ChangeGameRuleButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.ChangeGameRuleButton.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ChangeGameRuleButton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.ChangeGameRuleButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.ChangeGameRuleButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ChangeGameRuleButton.ForeColor = System.Drawing.Color.White;
            this.ChangeGameRuleButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ChangeGameRuleButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.ChangeGameRuleButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.ChangeGameRuleButton.IconMarginLeft = 11;
            this.ChangeGameRuleButton.IconPadding = 10;
            this.ChangeGameRuleButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ChangeGameRuleButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.ChangeGameRuleButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.ChangeGameRuleButton.IconSize = 25;
            this.ChangeGameRuleButton.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.ChangeGameRuleButton.IdleBorderRadius = 1;
            this.ChangeGameRuleButton.IdleBorderThickness = 1;
            this.ChangeGameRuleButton.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.ChangeGameRuleButton.IdleIconLeftImage = null;
            this.ChangeGameRuleButton.IdleIconRightImage = null;
            this.ChangeGameRuleButton.IndicateFocus = false;
            this.ChangeGameRuleButton.Location = new System.Drawing.Point(40, 30);
            this.ChangeGameRuleButton.Name = "ChangeGameRuleButton";
            this.ChangeGameRuleButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.ChangeGameRuleButton.OnDisabledState.BorderRadius = 1;
            this.ChangeGameRuleButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.ChangeGameRuleButton.OnDisabledState.BorderThickness = 1;
            this.ChangeGameRuleButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ChangeGameRuleButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.ChangeGameRuleButton.OnDisabledState.IconLeftImage = null;
            this.ChangeGameRuleButton.OnDisabledState.IconRightImage = null;
            this.ChangeGameRuleButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.ChangeGameRuleButton.onHoverState.BorderRadius = 1;
            this.ChangeGameRuleButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.ChangeGameRuleButton.onHoverState.BorderThickness = 1;
            this.ChangeGameRuleButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.ChangeGameRuleButton.onHoverState.ForeColor = System.Drawing.Color.White;
            this.ChangeGameRuleButton.onHoverState.IconLeftImage = null;
            this.ChangeGameRuleButton.onHoverState.IconRightImage = null;
            this.ChangeGameRuleButton.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.ChangeGameRuleButton.OnIdleState.BorderRadius = 1;
            this.ChangeGameRuleButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.ChangeGameRuleButton.OnIdleState.BorderThickness = 1;
            this.ChangeGameRuleButton.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.ChangeGameRuleButton.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.ChangeGameRuleButton.OnIdleState.IconLeftImage = null;
            this.ChangeGameRuleButton.OnIdleState.IconRightImage = null;
            this.ChangeGameRuleButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.ChangeGameRuleButton.OnPressedState.BorderRadius = 1;
            this.ChangeGameRuleButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.ChangeGameRuleButton.OnPressedState.BorderThickness = 1;
            this.ChangeGameRuleButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.ChangeGameRuleButton.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.ChangeGameRuleButton.OnPressedState.IconLeftImage = null;
            this.ChangeGameRuleButton.OnPressedState.IconRightImage = null;
            this.ChangeGameRuleButton.Size = new System.Drawing.Size(121, 40);
            this.ChangeGameRuleButton.TabIndex = 7;
            this.ChangeGameRuleButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ChangeGameRuleButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.ChangeGameRuleButton.TextMarginLeft = 0;
            this.ChangeGameRuleButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.ChangeGameRuleButton.UseDefaultRadiusAndThickness = true;
            // 
            // FaderDice2
            // 
            this.FaderDice2.Image = global::DicesGame.Properties.Resources.Dice3;
            this.FaderDice2.Location = new System.Drawing.Point(518, 304);
            this.FaderDice2.Name = "FaderDice2";
            this.FaderDice2.Size = new System.Drawing.Size(100, 100);
            this.FaderDice2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FaderDice2.TabIndex = 6;
            this.FaderDice2.TabStop = false;
            // 
            // FaderDice1
            // 
            this.FaderDice1.Image = global::DicesGame.Properties.Resources.Dice6;
            this.FaderDice1.Location = new System.Drawing.Point(333, 304);
            this.FaderDice1.Name = "FaderDice1";
            this.FaderDice1.Size = new System.Drawing.Size(100, 100);
            this.FaderDice1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.FaderDice1.TabIndex = 5;
            this.FaderDice1.TabStop = false;
            // 
            // ShooterDice2
            // 
            this.ShooterDice2.Image = global::DicesGame.Properties.Resources.Dice5;
            this.ShooterDice2.Location = new System.Drawing.Point(518, 147);
            this.ShooterDice2.Name = "ShooterDice2";
            this.ShooterDice2.Size = new System.Drawing.Size(100, 100);
            this.ShooterDice2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ShooterDice2.TabIndex = 4;
            this.ShooterDice2.TabStop = false;
            // 
            // ShooterDice1
            // 
            this.ShooterDice1.Image = global::DicesGame.Properties.Resources.Dice1;
            this.ShooterDice1.Location = new System.Drawing.Point(333, 147);
            this.ShooterDice1.Name = "ShooterDice1";
            this.ShooterDice1.Size = new System.Drawing.Size(100, 100);
            this.ShooterDice1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ShooterDice1.TabIndex = 3;
            this.ShooterDice1.TabStop = false;
            // 
            // Dices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PlayerTurnLabel);
            this.Controls.Add(this.PlayGameButton);
            this.Controls.Add(this.GameRuleLabel);
            this.Controls.Add(this.FaderRollButton);
            this.Controls.Add(this.ChangeGameRuleButton);
            this.Controls.Add(this.FaderDice2);
            this.Controls.Add(this.FaderDice1);
            this.Controls.Add(this.ShooterDice2);
            this.Controls.Add(this.ShooterDice1);
            this.Name = "Dices";
            this.Text = "Dices";
            ((System.ComponentModel.ISupportInitialize)(this.FaderDice2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FaderDice1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShooterDice2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShooterDice1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ShooterDice1;
        private System.Windows.Forms.PictureBox ShooterDice2;
        private System.Windows.Forms.PictureBox FaderDice2;
        private System.Windows.Forms.PictureBox FaderDice1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton ChangeGameRuleButton;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton FaderRollButton;
        private Bunifu.UI.WinForms.BunifuLabel GameRuleLabel;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton PlayGameButton;
        private Bunifu.UI.WinForms.BunifuLabel PlayerTurnLabel;
        private System.Windows.Forms.Timer timer1;
    }
}
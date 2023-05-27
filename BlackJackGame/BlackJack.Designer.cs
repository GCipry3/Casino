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
            this.DealerPanel = new System.Windows.Forms.Panel();
            this.DealerLabel = new System.Windows.Forms.Label();
            this.PlayerTablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.PlayerLabel1 = new System.Windows.Forms.Label();
            this.PlayerLabel2 = new System.Windows.Forms.Label();
            this.DealerPanel.SuspendLayout();
            this.PlayerTablePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // DealerPanel
            // 
            this.DealerPanel.Controls.Add(this.DealerLabel);
            this.DealerPanel.Location = new System.Drawing.Point(3, 3);
            this.DealerPanel.Name = "DealerPanel";
            this.DealerPanel.Size = new System.Drawing.Size(916, 279);
            this.DealerPanel.TabIndex = 0;
            // 
            // DealerLabel
            // 
            this.DealerLabel.AutoSize = true;
            this.DealerLabel.Location = new System.Drawing.Point(41, 25);
            this.DealerLabel.Name = "DealerLabel";
            this.DealerLabel.Size = new System.Drawing.Size(64, 13);
            this.DealerLabel.TabIndex = 0;
            this.DealerLabel.Text = "DealerLabel";
            // 
            // PlayerTablePanel
            // 
            this.PlayerTablePanel.ColumnCount = 2;
            this.PlayerTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PlayerTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PlayerTablePanel.Controls.Add(this.PlayerLabel1, 0, 0);
            this.PlayerTablePanel.Controls.Add(this.PlayerLabel2, 1, 0);
            this.PlayerTablePanel.Location = new System.Drawing.Point(2, 288);
            this.PlayerTablePanel.Name = "PlayerTablePanel";
            this.PlayerTablePanel.RowCount = 1;
            this.PlayerTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PlayerTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 343F));
            this.PlayerTablePanel.Size = new System.Drawing.Size(916, 342);
            this.PlayerTablePanel.TabIndex = 1;
            // 
            // PlayerLabel1
            // 
            this.PlayerLabel1.AutoSize = true;
            this.PlayerLabel1.Location = new System.Drawing.Point(3, 0);
            this.PlayerLabel1.Name = "PlayerLabel1";
            this.PlayerLabel1.Size = new System.Drawing.Size(68, 13);
            this.PlayerLabel1.TabIndex = 0;
            this.PlayerLabel1.Text = "PlayerLabel1";
            // 
            // PlayerLabel2
            // 
            this.PlayerLabel2.AutoSize = true;
            this.PlayerLabel2.Location = new System.Drawing.Point(461, 0);
            this.PlayerLabel2.Name = "PlayerLabel2";
            this.PlayerLabel2.Size = new System.Drawing.Size(68, 13);
            this.PlayerLabel2.TabIndex = 1;
            this.PlayerLabel2.Text = "PlayerLabel2";
            // 
            // BlackJack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 630);
            this.Controls.Add(this.PlayerTablePanel);
            this.Controls.Add(this.DealerPanel);
            this.Name = "BlackJack";
            this.Text = "BlackJack";
            this.DealerPanel.ResumeLayout(false);
            this.DealerPanel.PerformLayout();
            this.PlayerTablePanel.ResumeLayout(false);
            this.PlayerTablePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel DealerPanel;
        private System.Windows.Forms.TableLayoutPanel PlayerTablePanel;
        private System.Windows.Forms.Label DealerLabel;
        private System.Windows.Forms.Label PlayerLabel1;
        private System.Windows.Forms.Label PlayerLabel2;
    }
}
namespace BoardGameTracker
{
    partial class ViewStats
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewStats));
            this.gameNameComboBox = new System.Windows.Forms.ComboBox();
            this.gameNameLabel = new System.Windows.Forms.Label();
            this.highScoreList = new System.Windows.Forms.ListBox();
            this.topScoresLabel = new System.Windows.Forms.Label();
            this.linkToMainMenuButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gameNameComboBox
            // 
            this.gameNameComboBox.FormattingEnabled = true;
            this.gameNameComboBox.Location = new System.Drawing.Point(125, 43);
            this.gameNameComboBox.Name = "gameNameComboBox";
            this.gameNameComboBox.Size = new System.Drawing.Size(121, 21);
            this.gameNameComboBox.TabIndex = 0;
            this.gameNameComboBox.SelectedIndexChanged += new System.EventHandler(this.gameNameComboBox_SelectedIndexChanged);
            // 
            // gameNameLabel
            // 
            this.gameNameLabel.AutoSize = true;
            this.gameNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameNameLabel.Location = new System.Drawing.Point(47, 44);
            this.gameNameLabel.Name = "gameNameLabel";
            this.gameNameLabel.Size = new System.Drawing.Size(57, 20);
            this.gameNameLabel.TabIndex = 2;
            this.gameNameLabel.Text = "Game:";
            this.gameNameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // highScoreList
            // 
            this.highScoreList.FormattingEnabled = true;
            this.highScoreList.Location = new System.Drawing.Point(266, 43);
            this.highScoreList.Name = "highScoreList";
            this.highScoreList.Size = new System.Drawing.Size(120, 95);
            this.highScoreList.TabIndex = 3;
            // 
            // topScoresLabel
            // 
            this.topScoresLabel.AutoSize = true;
            this.topScoresLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topScoresLabel.Location = new System.Drawing.Point(280, 20);
            this.topScoresLabel.Name = "topScoresLabel";
            this.topScoresLabel.Size = new System.Drawing.Size(90, 20);
            this.topScoresLabel.TabIndex = 4;
            this.topScoresLabel.Text = "Top Scores";
            this.topScoresLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // linkToMainMenuButton
            // 
            this.linkToMainMenuButton.Location = new System.Drawing.Point(465, 44);
            this.linkToMainMenuButton.Name = "linkToMainMenuButton";
            this.linkToMainMenuButton.Size = new System.Drawing.Size(98, 45);
            this.linkToMainMenuButton.TabIndex = 5;
            this.linkToMainMenuButton.Text = "Main Menu";
            this.linkToMainMenuButton.UseVisualStyleBackColor = true;
            this.linkToMainMenuButton.Click += new System.EventHandler(this.linkToMainMenuButton_Click);
            // 
            // ViewStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(691, 460);
            this.Controls.Add(this.linkToMainMenuButton);
            this.Controls.Add(this.topScoresLabel);
            this.Controls.Add(this.highScoreList);
            this.Controls.Add(this.gameNameLabel);
            this.Controls.Add(this.gameNameComboBox);
            this.Name = "ViewStats";
            this.Text = "ViewStats";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox gameNameComboBox;
        private System.Windows.Forms.Label gameNameLabel;
        private System.Windows.Forms.ListBox highScoreList;
        private System.Windows.Forms.Label topScoresLabel;
        private System.Windows.Forms.Button linkToMainMenuButton;
    }
}
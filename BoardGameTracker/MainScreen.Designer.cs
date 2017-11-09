namespace BoardGameTracker
{
    partial class MainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.linkToSubmitScoreButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.linkToStatsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // linkToSubmitScoreButton
            // 
            this.linkToSubmitScoreButton.Location = new System.Drawing.Point(53, 114);
            this.linkToSubmitScoreButton.Name = "linkToSubmitScoreButton";
            this.linkToSubmitScoreButton.Size = new System.Drawing.Size(128, 43);
            this.linkToSubmitScoreButton.TabIndex = 0;
            this.linkToSubmitScoreButton.Text = "Submit Score";
            this.linkToSubmitScoreButton.UseVisualStyleBackColor = true;
            this.linkToSubmitScoreButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(12, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome To The Board Game Tracker";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linkToStatsButton
            // 
            this.linkToStatsButton.Location = new System.Drawing.Point(242, 114);
            this.linkToStatsButton.Name = "linkToStatsButton";
            this.linkToStatsButton.Size = new System.Drawing.Size(128, 43);
            this.linkToStatsButton.TabIndex = 2;
            this.linkToStatsButton.Text = "View Stats";
            this.linkToStatsButton.UseVisualStyleBackColor = true;
            this.linkToStatsButton.Click += new System.EventHandler(this.linkToStatsButton_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(392, 261);
            this.Controls.Add(this.linkToStatsButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkToSubmitScoreButton);
            this.Name = "MainScreen";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button linkToSubmitScoreButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button linkToStatsButton;
    }
}
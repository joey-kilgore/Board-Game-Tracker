namespace BoardGameTracker
{
    partial class ScoreEntry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScoreEntry));
            this.gameNameComboBox = new System.Windows.Forms.ComboBox();
            this.gameNameLabel = new System.Windows.Forms.Label();
            this.expansionCheckBoxList = new System.Windows.Forms.CheckedListBox();
            this.numberOfPlayersNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.numberOfPlayersLabel = new System.Windows.Forms.Label();
            this.playerNameComboBox = new System.Windows.Forms.ComboBox();
            this.playerNameLabel = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.scoreTextBox = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.placedLabel = new System.Windows.Forms.Label();
            this.placedUpDown = new System.Windows.Forms.NumericUpDown();
            this.toMainMenuButton = new System.Windows.Forms.Button();
            this.newGameButton = new System.Windows.Forms.Button();
            this.gameNumberLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfPlayersNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.placedUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // gameNameComboBox
            // 
            this.gameNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.gameNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.gameNameComboBox.FormattingEnabled = true;
            this.gameNameComboBox.Location = new System.Drawing.Point(75, 21);
            this.gameNameComboBox.Name = "gameNameComboBox";
            this.gameNameComboBox.Size = new System.Drawing.Size(121, 21);
            this.gameNameComboBox.TabIndex = 0;
            this.gameNameComboBox.Text = "Choose Game";
            this.gameNameComboBox.SelectedIndexChanged += new System.EventHandler(this.gameNameComboBox_SelectedIndexChanged);
            // 
            // gameNameLabel
            // 
            this.gameNameLabel.AutoSize = true;
            this.gameNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameNameLabel.Location = new System.Drawing.Point(12, 22);
            this.gameNameLabel.Name = "gameNameLabel";
            this.gameNameLabel.Size = new System.Drawing.Size(57, 20);
            this.gameNameLabel.TabIndex = 1;
            this.gameNameLabel.Text = "Game:";
            this.gameNameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // expansionCheckBoxList
            // 
            this.expansionCheckBoxList.CheckOnClick = true;
            this.expansionCheckBoxList.FormattingEnabled = true;
            this.expansionCheckBoxList.Location = new System.Drawing.Point(251, 21);
            this.expansionCheckBoxList.Name = "expansionCheckBoxList";
            this.expansionCheckBoxList.Size = new System.Drawing.Size(201, 109);
            this.expansionCheckBoxList.TabIndex = 2;
            // 
            // numberOfPlayersNumericUpDown
            // 
            this.numberOfPlayersNumericUpDown.Location = new System.Drawing.Point(163, 55);
            this.numberOfPlayersNumericUpDown.Name = "numberOfPlayersNumericUpDown";
            this.numberOfPlayersNumericUpDown.Size = new System.Drawing.Size(33, 20);
            this.numberOfPlayersNumericUpDown.TabIndex = 3;
            // 
            // numberOfPlayersLabel
            // 
            this.numberOfPlayersLabel.AutoSize = true;
            this.numberOfPlayersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOfPlayersLabel.Location = new System.Drawing.Point(12, 55);
            this.numberOfPlayersLabel.Name = "numberOfPlayersLabel";
            this.numberOfPlayersLabel.Size = new System.Drawing.Size(145, 20);
            this.numberOfPlayersLabel.TabIndex = 4;
            this.numberOfPlayersLabel.Text = "Number Of Players:";
            this.numberOfPlayersLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // playerNameComboBox
            // 
            this.playerNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.playerNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.playerNameComboBox.FormattingEnabled = true;
            this.playerNameComboBox.Location = new System.Drawing.Point(120, 89);
            this.playerNameComboBox.Name = "playerNameComboBox";
            this.playerNameComboBox.Size = new System.Drawing.Size(121, 21);
            this.playerNameComboBox.TabIndex = 5;
            this.playerNameComboBox.Text = "Choose Name";
            // 
            // playerNameLabel
            // 
            this.playerNameLabel.AutoSize = true;
            this.playerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerNameLabel.Location = new System.Drawing.Point(12, 90);
            this.playerNameLabel.Name = "playerNameLabel";
            this.playerNameLabel.Size = new System.Drawing.Size(102, 20);
            this.playerNameLabel.TabIndex = 6;
            this.playerNameLabel.Text = "Player Name:";
            this.playerNameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.Location = new System.Drawing.Point(12, 160);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(55, 20);
            this.scoreLabel.TabIndex = 7;
            this.scoreLabel.Text = "Score:";
            this.scoreLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // scoreTextBox
            // 
            this.scoreTextBox.Location = new System.Drawing.Point(74, 160);
            this.scoreTextBox.Name = "scoreTextBox";
            this.scoreTextBox.Size = new System.Drawing.Size(54, 20);
            this.scoreTextBox.TabIndex = 8;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(73, 265);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(99, 34);
            this.submitButton.TabIndex = 9;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // placedLabel
            // 
            this.placedLabel.AutoSize = true;
            this.placedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placedLabel.Location = new System.Drawing.Point(12, 128);
            this.placedLabel.Name = "placedLabel";
            this.placedLabel.Size = new System.Drawing.Size(61, 20);
            this.placedLabel.TabIndex = 10;
            this.placedLabel.Text = "Placed:";
            this.placedLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // placedUpDown
            // 
            this.placedUpDown.Location = new System.Drawing.Point(79, 128);
            this.placedUpDown.Name = "placedUpDown";
            this.placedUpDown.Size = new System.Drawing.Size(33, 20);
            this.placedUpDown.TabIndex = 11;
            // 
            // toMainMenuButton
            // 
            this.toMainMenuButton.Location = new System.Drawing.Point(178, 265);
            this.toMainMenuButton.Name = "toMainMenuButton";
            this.toMainMenuButton.Size = new System.Drawing.Size(88, 34);
            this.toMainMenuButton.TabIndex = 12;
            this.toMainMenuButton.Text = "Main Menu";
            this.toMainMenuButton.UseVisualStyleBackColor = true;
            this.toMainMenuButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // newGameButton
            // 
            this.newGameButton.Location = new System.Drawing.Point(272, 265);
            this.newGameButton.Name = "newGameButton";
            this.newGameButton.Size = new System.Drawing.Size(99, 34);
            this.newGameButton.TabIndex = 13;
            this.newGameButton.Text = "New Game";
            this.newGameButton.UseVisualStyleBackColor = true;
            this.newGameButton.Click += new System.EventHandler(this.newGameButton_Click);
            // 
            // gameNumberLabel
            // 
            this.gameNumberLabel.AutoSize = true;
            this.gameNumberLabel.Location = new System.Drawing.Point(122, 128);
            this.gameNumberLabel.Name = "gameNumberLabel";
            this.gameNumberLabel.Size = new System.Drawing.Size(35, 13);
            this.gameNumberLabel.TabIndex = 14;
            this.gameNumberLabel.Text = "label1";
            // 
            // ScoreEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(453, 304);
            this.Controls.Add(this.gameNumberLabel);
            this.Controls.Add(this.newGameButton);
            this.Controls.Add(this.toMainMenuButton);
            this.Controls.Add(this.placedUpDown);
            this.Controls.Add(this.placedLabel);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.scoreTextBox);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.playerNameLabel);
            this.Controls.Add(this.playerNameComboBox);
            this.Controls.Add(this.numberOfPlayersLabel);
            this.Controls.Add(this.numberOfPlayersNumericUpDown);
            this.Controls.Add(this.expansionCheckBoxList);
            this.Controls.Add(this.gameNameLabel);
            this.Controls.Add(this.gameNameComboBox);
            this.Name = "ScoreEntry";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numberOfPlayersNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.placedUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox gameNameComboBox;
        private System.Windows.Forms.Label gameNameLabel;
        private System.Windows.Forms.CheckedListBox expansionCheckBoxList;
        private System.Windows.Forms.NumericUpDown numberOfPlayersNumericUpDown;
        private System.Windows.Forms.Label numberOfPlayersLabel;
        private System.Windows.Forms.ComboBox playerNameComboBox;
        private System.Windows.Forms.Label playerNameLabel;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.TextBox scoreTextBox;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label placedLabel;
        private System.Windows.Forms.NumericUpDown placedUpDown;
        private System.Windows.Forms.Button toMainMenuButton;
        private System.Windows.Forms.Button newGameButton;
        private System.Windows.Forms.Label gameNumberLabel;
    }
}


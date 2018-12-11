namespace RpgProject
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.lblGameTitle = new System.Windows.Forms.Label();
            this.btnCreateCharacter = new System.Windows.Forms.Button();
            this.btnLoadGame = new System.Windows.Forms.Button();
            this.btnHighScores = new System.Windows.Forms.Button();
            this.btnOptions = new System.Windows.Forms.Button();
            this.btnCredits = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblGameTitle
            // 
            this.lblGameTitle.AutoSize = true;
            this.lblGameTitle.Font = new System.Drawing.Font("Papyrus", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameTitle.Location = new System.Drawing.Point(13, 13);
            this.lblGameTitle.Name = "lblGameTitle";
            this.lblGameTitle.Size = new System.Drawing.Size(155, 18);
            this.lblGameTitle.TabIndex = 0;
            this.lblGameTitle.Text = "RPG Game Title Goes Here";
            this.lblGameTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnCreateCharacter
            // 
            this.btnCreateCharacter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnCreateCharacter.Font = new System.Drawing.Font("Alef", 8.25F);
            this.btnCreateCharacter.Location = new System.Drawing.Point(16, 52);
            this.btnCreateCharacter.Name = "btnCreateCharacter";
            this.btnCreateCharacter.Size = new System.Drawing.Size(105, 35);
            this.btnCreateCharacter.TabIndex = 1;
            this.btnCreateCharacter.Text = "Create Character\r\n";
            this.btnCreateCharacter.UseVisualStyleBackColor = false;
            this.btnCreateCharacter.Click += new System.EventHandler(this.btnCreateCharacter_Click);
            // 
            // btnLoadGame
            // 
            this.btnLoadGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnLoadGame.Font = new System.Drawing.Font("Alef", 8.25F);
            this.btnLoadGame.Location = new System.Drawing.Point(16, 118);
            this.btnLoadGame.Name = "btnLoadGame";
            this.btnLoadGame.Size = new System.Drawing.Size(105, 35);
            this.btnLoadGame.TabIndex = 2;
            this.btnLoadGame.Text = "Load Game\r\n";
            this.btnLoadGame.UseVisualStyleBackColor = false;
            // 
            // btnHighScores
            // 
            this.btnHighScores.Font = new System.Drawing.Font("Alef", 8.25F);
            this.btnHighScores.Location = new System.Drawing.Point(138, 214);
            this.btnHighScores.Name = "btnHighScores";
            this.btnHighScores.Size = new System.Drawing.Size(105, 35);
            this.btnHighScores.TabIndex = 3;
            this.btnHighScores.Text = "High Scores";
            this.btnHighScores.UseVisualStyleBackColor = true;
            // 
            // btnOptions
            // 
            this.btnOptions.Font = new System.Drawing.Font("Alef", 8.25F);
            this.btnOptions.Location = new System.Drawing.Point(16, 214);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(105, 35);
            this.btnOptions.TabIndex = 4;
            this.btnOptions.Text = "Options\r\n";
            this.btnOptions.UseVisualStyleBackColor = true;
            // 
            // btnCredits
            // 
            this.btnCredits.Font = new System.Drawing.Font("Alef", 8.25F);
            this.btnCredits.Location = new System.Drawing.Point(261, 214);
            this.btnCredits.Name = "btnCredits";
            this.btnCredits.Size = new System.Drawing.Size(105, 35);
            this.btnCredits.TabIndex = 5;
            this.btnCredits.Text = "Credits";
            this.btnCredits.UseVisualStyleBackColor = true;
            this.btnCredits.Click += new System.EventHandler(this.BtnCredits_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(453, 368);
            this.Controls.Add(this.btnCredits);
            this.Controls.Add(this.btnOptions);
            this.Controls.Add(this.btnHighScores);
            this.Controls.Add(this.btnLoadGame);
            this.Controls.Add(this.btnCreateCharacter);
            this.Controls.Add(this.lblGameTitle);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMenu";
            this.Text = "RPG Main Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGameTitle;
        private System.Windows.Forms.Button btnCreateCharacter;
        private System.Windows.Forms.Button btnLoadGame;
        private System.Windows.Forms.Button btnHighScores;
        private System.Windows.Forms.Button btnOptions;
        private System.Windows.Forms.Button btnCredits;
    }
}


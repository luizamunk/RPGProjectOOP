namespace RpgProject
{
    partial class FormCharacterCreator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCharacterCreator));
            this.lblCharacterName = new System.Windows.Forms.Label();
            this.txtCharacterName = new System.Windows.Forms.TextBox();
            this.comboCharacterClasses = new System.Windows.Forms.ComboBox();
            this.comboCharacterGender = new System.Windows.Forms.ComboBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.btnSaveCharacter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCharacterName
            // 
            this.lblCharacterName.AutoSize = true;
            this.lblCharacterName.Font = new System.Drawing.Font("Papyrus", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCharacterName.Location = new System.Drawing.Point(13, 13);
            this.lblCharacterName.Margin = new System.Windows.Forms.Padding(3);
            this.lblCharacterName.Name = "lblCharacterName";
            this.lblCharacterName.Size = new System.Drawing.Size(90, 18);
            this.lblCharacterName.TabIndex = 0;
            this.lblCharacterName.Text = "Character Name";
            // 
            // txtCharacterName
            // 
            this.txtCharacterName.Location = new System.Drawing.Point(131, 10);
            this.txtCharacterName.Name = "txtCharacterName";
            this.txtCharacterName.Size = new System.Drawing.Size(121, 20);
            this.txtCharacterName.TabIndex = 1;
            this.txtCharacterName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // comboCharacterClasses
            // 
            this.comboCharacterClasses.FormattingEnabled = true;
            this.comboCharacterClasses.Items.AddRange(new object[] {
            "Mage",
            "Rogue",
            "Paladin",
            "Warrior",
            "Cleric",
            "Monk",
            "Plebian",
            "Common Warrior"});
            this.comboCharacterClasses.Location = new System.Drawing.Point(131, 113);
            this.comboCharacterClasses.Name = "comboCharacterClasses";
            this.comboCharacterClasses.Size = new System.Drawing.Size(121, 21);
            this.comboCharacterClasses.TabIndex = 4;
            this.comboCharacterClasses.SelectedIndexChanged += new System.EventHandler(this.comboCharacterClasses_SelectedIndexChanged);
            // 
            // comboCharacterGender
            // 
            this.comboCharacterGender.FormattingEnabled = true;
            this.comboCharacterGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Unknown",
            "Androginous"});
            this.comboCharacterGender.Location = new System.Drawing.Point(131, 60);
            this.comboCharacterGender.Name = "comboCharacterGender";
            this.comboCharacterGender.Size = new System.Drawing.Size(121, 21);
            this.comboCharacterGender.TabIndex = 5;
            this.comboCharacterGender.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblGender
            // 
            this.lblGender.AutoEllipsis = true;
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Papyrus", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(13, 60);
            this.lblGender.Margin = new System.Windows.Forms.Padding(3);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(48, 18);
            this.lblGender.TabIndex = 6;
            this.lblGender.Text = "Gender";
            // 
            // lblClass
            // 
            this.lblClass.AutoEllipsis = true;
            this.lblClass.AutoSize = true;
            this.lblClass.Font = new System.Drawing.Font("Papyrus", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClass.Location = new System.Drawing.Point(13, 116);
            this.lblClass.Margin = new System.Windows.Forms.Padding(3);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(89, 18);
            this.lblClass.TabIndex = 7;
            this.lblClass.Text = "Character Class";
            // 
            // btnSaveCharacter
            // 
            this.btnSaveCharacter.Font = new System.Drawing.Font("Papyrus", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveCharacter.Location = new System.Drawing.Point(16, 237);
            this.btnSaveCharacter.Name = "btnSaveCharacter";
            this.btnSaveCharacter.Size = new System.Drawing.Size(117, 44);
            this.btnSaveCharacter.TabIndex = 8;
            this.btnSaveCharacter.Text = "Save Character";
            this.btnSaveCharacter.UseVisualStyleBackColor = true;
            this.btnSaveCharacter.Click += new System.EventHandler(this.btnSaveCharacter_Click);
            // 
            // FormCharacterCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(386, 312);
            this.Controls.Add(this.btnSaveCharacter);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.comboCharacterGender);
            this.Controls.Add(this.comboCharacterClasses);
            this.Controls.Add(this.txtCharacterName);
            this.Controls.Add(this.lblCharacterName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCharacterCreator";
            this.Text = "Create your Character";
            this.Load += new System.EventHandler(this.FormCharacterCreator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCharacterName;
        private System.Windows.Forms.TextBox txtCharacterName;
        private System.Windows.Forms.ComboBox comboCharacterClasses;
        private System.Windows.Forms.ComboBox comboCharacterGender;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Button btnSaveCharacter;
    }
}
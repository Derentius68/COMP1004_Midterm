namespace AbilityForm
{
    partial class AbilityForm
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
            this.rollButton = new System.Windows.Forms.Button();
            this.strengthTextBox = new System.Windows.Forms.TextBox();
            this.STRLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dexterityLabel = new System.Windows.Forms.Label();
            this.dexterityTextBox = new System.Windows.Forms.TextBox();
            this.constitutionLabel = new System.Windows.Forms.Label();
            this.constitutionTextBox = new System.Windows.Forms.TextBox();
            this.intelligenceLabel = new System.Windows.Forms.Label();
            this.intelligenceTextBox = new System.Windows.Forms.TextBox();
            this.wisdomLabel = new System.Windows.Forms.Label();
            this.wisdomTextBox = new System.Windows.Forms.TextBox();
            this.charismaLabel = new System.Windows.Forms.Label();
            this.charismaTextBox = new System.Windows.Forms.TextBox();
            this.nextButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rollButton
            // 
            this.rollButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.rollButton.Location = new System.Drawing.Point(12, 391);
            this.rollButton.Name = "rollButton";
            this.rollButton.Size = new System.Drawing.Size(103, 42);
            this.rollButton.TabIndex = 0;
            this.rollButton.Text = "Roll";
            this.rollButton.UseVisualStyleBackColor = true;
            this.rollButton.Click += new System.EventHandler(this.RollButton_Click);
            // 
            // strengthTextBox
            // 
            this.strengthTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.strengthTextBox.Location = new System.Drawing.Point(12, 36);
            this.strengthTextBox.Name = "strengthTextBox";
            this.strengthTextBox.ReadOnly = true;
            this.strengthTextBox.Size = new System.Drawing.Size(47, 35);
            this.strengthTextBox.TabIndex = 1;
            // 
            // STRLabel
            // 
            this.STRLabel.AutoSize = true;
            this.STRLabel.Location = new System.Drawing.Point(9, 74);
            this.STRLabel.Name = "STRLabel";
            this.STRLabel.Size = new System.Drawing.Size(47, 13);
            this.STRLabel.TabIndex = 2;
            this.STRLabel.Text = "Strength";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(507, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // dexterityLabel
            // 
            this.dexterityLabel.AutoSize = true;
            this.dexterityLabel.Location = new System.Drawing.Point(9, 137);
            this.dexterityLabel.Name = "dexterityLabel";
            this.dexterityLabel.Size = new System.Drawing.Size(48, 13);
            this.dexterityLabel.TabIndex = 5;
            this.dexterityLabel.Text = "Dexterity";
            // 
            // dexterityTextBox
            // 
            this.dexterityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.dexterityTextBox.Location = new System.Drawing.Point(12, 99);
            this.dexterityTextBox.Name = "dexterityTextBox";
            this.dexterityTextBox.ReadOnly = true;
            this.dexterityTextBox.Size = new System.Drawing.Size(47, 35);
            this.dexterityTextBox.TabIndex = 4;
            // 
            // constitutionLabel
            // 
            this.constitutionLabel.AutoSize = true;
            this.constitutionLabel.Location = new System.Drawing.Point(9, 196);
            this.constitutionLabel.Name = "constitutionLabel";
            this.constitutionLabel.Size = new System.Drawing.Size(62, 13);
            this.constitutionLabel.TabIndex = 7;
            this.constitutionLabel.Text = "Constitution";
            // 
            // constitutionTextBox
            // 
            this.constitutionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.constitutionTextBox.Location = new System.Drawing.Point(12, 158);
            this.constitutionTextBox.Name = "constitutionTextBox";
            this.constitutionTextBox.ReadOnly = true;
            this.constitutionTextBox.Size = new System.Drawing.Size(47, 35);
            this.constitutionTextBox.TabIndex = 6;
            // 
            // intelligenceLabel
            // 
            this.intelligenceLabel.AutoSize = true;
            this.intelligenceLabel.Location = new System.Drawing.Point(9, 253);
            this.intelligenceLabel.Name = "intelligenceLabel";
            this.intelligenceLabel.Size = new System.Drawing.Size(61, 13);
            this.intelligenceLabel.TabIndex = 9;
            this.intelligenceLabel.Text = "Intelligence";
            // 
            // intelligenceTextBox
            // 
            this.intelligenceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.intelligenceTextBox.Location = new System.Drawing.Point(12, 215);
            this.intelligenceTextBox.Name = "intelligenceTextBox";
            this.intelligenceTextBox.ReadOnly = true;
            this.intelligenceTextBox.Size = new System.Drawing.Size(47, 35);
            this.intelligenceTextBox.TabIndex = 8;
            // 
            // wisdomLabel
            // 
            this.wisdomLabel.AutoSize = true;
            this.wisdomLabel.Location = new System.Drawing.Point(9, 307);
            this.wisdomLabel.Name = "wisdomLabel";
            this.wisdomLabel.Size = new System.Drawing.Size(45, 13);
            this.wisdomLabel.TabIndex = 11;
            this.wisdomLabel.Text = "Wisdom";
            // 
            // wisdomTextBox
            // 
            this.wisdomTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.wisdomTextBox.Location = new System.Drawing.Point(12, 269);
            this.wisdomTextBox.Name = "wisdomTextBox";
            this.wisdomTextBox.ReadOnly = true;
            this.wisdomTextBox.Size = new System.Drawing.Size(47, 35);
            this.wisdomTextBox.TabIndex = 10;
            // 
            // charismaLabel
            // 
            this.charismaLabel.AutoSize = true;
            this.charismaLabel.Location = new System.Drawing.Point(9, 361);
            this.charismaLabel.Name = "charismaLabel";
            this.charismaLabel.Size = new System.Drawing.Size(50, 13);
            this.charismaLabel.TabIndex = 13;
            this.charismaLabel.Text = "Charisma";
            // 
            // charismaTextBox
            // 
            this.charismaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.charismaTextBox.Location = new System.Drawing.Point(12, 323);
            this.charismaTextBox.Name = "charismaTextBox";
            this.charismaTextBox.ReadOnly = true;
            this.charismaTextBox.Size = new System.Drawing.Size(47, 35);
            this.charismaTextBox.TabIndex = 12;
            // 
            // nextButton
            // 
            this.nextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nextButton.Location = new System.Drawing.Point(392, 391);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(103, 42);
            this.nextButton.TabIndex = 14;
            this.nextButton.Text = "Next Sheet";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // AbilityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 447);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.charismaLabel);
            this.Controls.Add(this.charismaTextBox);
            this.Controls.Add(this.wisdomLabel);
            this.Controls.Add(this.wisdomTextBox);
            this.Controls.Add(this.intelligenceLabel);
            this.Controls.Add(this.intelligenceTextBox);
            this.Controls.Add(this.constitutionLabel);
            this.Controls.Add(this.constitutionTextBox);
            this.Controls.Add(this.dexterityLabel);
            this.Controls.Add(this.dexterityTextBox);
            this.Controls.Add(this.STRLabel);
            this.Controls.Add(this.strengthTextBox);
            this.Controls.Add(this.rollButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AbilityForm";
            this.Text = "Abilities";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button rollButton;
        private System.Windows.Forms.TextBox strengthTextBox;
        private System.Windows.Forms.Label STRLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.Label dexterityLabel;
        private System.Windows.Forms.TextBox dexterityTextBox;
        private System.Windows.Forms.Label constitutionLabel;
        private System.Windows.Forms.TextBox constitutionTextBox;
        private System.Windows.Forms.Label intelligenceLabel;
        private System.Windows.Forms.TextBox intelligenceTextBox;
        private System.Windows.Forms.Label wisdomLabel;
        private System.Windows.Forms.TextBox wisdomTextBox;
        private System.Windows.Forms.Label charismaLabel;
        private System.Windows.Forms.TextBox charismaTextBox;
        private System.Windows.Forms.Button nextButton;
    }
}


namespace RaceForm
{
    partial class RaceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RaceForm));
            this.racesGroupBox = new System.Windows.Forms.GroupBox();
            this.racialBonusTextBox = new System.Windows.Forms.TextBox();
            this.aasimarRadioButton = new System.Windows.Forms.RadioButton();
            this.tieflingRadioButton = new System.Windows.Forms.RadioButton();
            this.halflingRadioButton = new System.Windows.Forms.RadioButton();
            this.elfRadioButton = new System.Windows.Forms.RadioButton();
            this.dwarfRadioButton = new System.Windows.Forms.RadioButton();
            this.humanRadioButton = new System.Windows.Forms.RadioButton();
            this.characterPictureBox = new System.Windows.Forms.PictureBox();
            this.nextButton = new System.Windows.Forms.Button();
            this.racesGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.characterPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // racesGroupBox
            // 
            this.racesGroupBox.Controls.Add(this.racialBonusTextBox);
            this.racesGroupBox.Controls.Add(this.aasimarRadioButton);
            this.racesGroupBox.Controls.Add(this.tieflingRadioButton);
            this.racesGroupBox.Controls.Add(this.halflingRadioButton);
            this.racesGroupBox.Controls.Add(this.elfRadioButton);
            this.racesGroupBox.Controls.Add(this.dwarfRadioButton);
            this.racesGroupBox.Controls.Add(this.humanRadioButton);
            this.racesGroupBox.Location = new System.Drawing.Point(12, 12);
            this.racesGroupBox.Name = "racesGroupBox";
            this.racesGroupBox.Size = new System.Drawing.Size(173, 237);
            this.racesGroupBox.TabIndex = 0;
            this.racesGroupBox.TabStop = false;
            this.racesGroupBox.Text = "Races";
            // 
            // racialBonusTextBox
            // 
            this.racialBonusTextBox.Location = new System.Drawing.Point(7, 174);
            this.racialBonusTextBox.Multiline = true;
            this.racialBonusTextBox.Name = "racialBonusTextBox";
            this.racialBonusTextBox.Size = new System.Drawing.Size(166, 57);
            this.racialBonusTextBox.TabIndex = 6;
            // 
            // aasimarRadioButton
            // 
            this.aasimarRadioButton.Enabled = false;
            this.aasimarRadioButton.Location = new System.Drawing.Point(6, 139);
            this.aasimarRadioButton.Name = "aasimarRadioButton";
            this.aasimarRadioButton.Size = new System.Drawing.Size(104, 24);
            this.aasimarRadioButton.TabIndex = 7;
            this.aasimarRadioButton.Text = "Aasimar";
            // 
            // tieflingRadioButton
            // 
            this.tieflingRadioButton.AutoSize = true;
            this.tieflingRadioButton.Location = new System.Drawing.Point(7, 116);
            this.tieflingRadioButton.Name = "tieflingRadioButton";
            this.tieflingRadioButton.Size = new System.Drawing.Size(59, 17);
            this.tieflingRadioButton.TabIndex = 4;
            this.tieflingRadioButton.Text = "Tiefling";
            this.tieflingRadioButton.UseVisualStyleBackColor = true;
            this.tieflingRadioButton.CheckedChanged += new System.EventHandler(this.tieflingRadioButton_CheckedChanged);
            // 
            // halflingRadioButton
            // 
            this.halflingRadioButton.AutoSize = true;
            this.halflingRadioButton.Location = new System.Drawing.Point(7, 92);
            this.halflingRadioButton.Name = "halflingRadioButton";
            this.halflingRadioButton.Size = new System.Drawing.Size(60, 17);
            this.halflingRadioButton.TabIndex = 3;
            this.halflingRadioButton.Text = "Halfling";
            this.halflingRadioButton.UseVisualStyleBackColor = true;
            this.halflingRadioButton.CheckedChanged += new System.EventHandler(this.halflingRadioButton_CheckedChanged);
            // 
            // elfRadioButton
            // 
            this.elfRadioButton.AutoSize = true;
            this.elfRadioButton.Location = new System.Drawing.Point(7, 68);
            this.elfRadioButton.Name = "elfRadioButton";
            this.elfRadioButton.Size = new System.Drawing.Size(37, 17);
            this.elfRadioButton.TabIndex = 2;
            this.elfRadioButton.Text = "Elf";
            this.elfRadioButton.UseVisualStyleBackColor = true;
            this.elfRadioButton.CheckedChanged += new System.EventHandler(this.elfRadioButton_CheckedChanged);
            // 
            // dwarfRadioButton
            // 
            this.dwarfRadioButton.AutoSize = true;
            this.dwarfRadioButton.Location = new System.Drawing.Point(7, 44);
            this.dwarfRadioButton.Name = "dwarfRadioButton";
            this.dwarfRadioButton.Size = new System.Drawing.Size(53, 17);
            this.dwarfRadioButton.TabIndex = 1;
            this.dwarfRadioButton.Text = "Dwarf";
            this.dwarfRadioButton.UseVisualStyleBackColor = true;
            this.dwarfRadioButton.CheckedChanged += new System.EventHandler(this.dwarfRadioButton_CheckedChanged);
            // 
            // humanRadioButton
            // 
            this.humanRadioButton.AutoSize = true;
            this.humanRadioButton.Checked = true;
            this.humanRadioButton.Location = new System.Drawing.Point(7, 20);
            this.humanRadioButton.Name = "humanRadioButton";
            this.humanRadioButton.Size = new System.Drawing.Size(59, 17);
            this.humanRadioButton.TabIndex = 0;
            this.humanRadioButton.TabStop = true;
            this.humanRadioButton.Text = "Human";
            this.humanRadioButton.UseVisualStyleBackColor = true;
            this.humanRadioButton.CheckedChanged += new System.EventHandler(this.humanRadioButton_CheckedChanged);
            // 
            // characterPictureBox
            // 
            this.characterPictureBox.ErrorImage = ((System.Drawing.Image)(resources.GetObject("characterPictureBox.ErrorImage")));
            this.characterPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("characterPictureBox.Image")));
            this.characterPictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("characterPictureBox.InitialImage")));
            this.characterPictureBox.Location = new System.Drawing.Point(191, 12);
            this.characterPictureBox.Name = "characterPictureBox";
            this.characterPictureBox.Size = new System.Drawing.Size(271, 273);
            this.characterPictureBox.TabIndex = 6;
            this.characterPictureBox.TabStop = false;
            this.characterPictureBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // nextButton
            // 
            this.nextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nextButton.Location = new System.Drawing.Point(42, 275);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(103, 42);
            this.nextButton.TabIndex = 15;
            this.nextButton.Text = "Next Sheet";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // RaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 348);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.characterPictureBox);
            this.Controls.Add(this.racesGroupBox);
            this.Name = "RaceForm";
            this.Text = "Races";
            this.racesGroupBox.ResumeLayout(false);
            this.racesGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.characterPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox racesGroupBox;
        private System.Windows.Forms.PictureBox characterPictureBox;
        private System.Windows.Forms.RadioButton aasimarRadioButton;
        private System.Windows.Forms.RadioButton tieflingRadioButton;
        private System.Windows.Forms.RadioButton halflingRadioButton;
        private System.Windows.Forms.RadioButton elfRadioButton;
        private System.Windows.Forms.RadioButton dwarfRadioButton;
        private System.Windows.Forms.RadioButton humanRadioButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.TextBox racialBonusTextBox;
    }
}


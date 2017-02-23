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
            this.humanRadioButton = new System.Windows.Forms.RadioButton();
            this.dwarfRadioButton = new System.Windows.Forms.RadioButton();
            this.elfRadioButton = new System.Windows.Forms.RadioButton();
            this.halflingRadioButton = new System.Windows.Forms.RadioButton();
            this.tieflingRadioButton = new System.Windows.Forms.RadioButton();
            this.aasimarRadioButton = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.racesGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // racesGroupBox
            // 
            this.racesGroupBox.Controls.Add(this.aasimarRadioButton);
            this.racesGroupBox.Controls.Add(this.tieflingRadioButton);
            this.racesGroupBox.Controls.Add(this.halflingRadioButton);
            this.racesGroupBox.Controls.Add(this.elfRadioButton);
            this.racesGroupBox.Controls.Add(this.dwarfRadioButton);
            this.racesGroupBox.Controls.Add(this.humanRadioButton);
            this.racesGroupBox.Location = new System.Drawing.Point(12, 12);
            this.racesGroupBox.Name = "racesGroupBox";
            this.racesGroupBox.Size = new System.Drawing.Size(250, 237);
            this.racesGroupBox.TabIndex = 0;
            this.racesGroupBox.TabStop = false;
            this.racesGroupBox.Text = "Races";
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
            // 
            // aasimarRadioButton
            // 
            this.aasimarRadioButton.AutoSize = true;
            this.aasimarRadioButton.Location = new System.Drawing.Point(7, 140);
            this.aasimarRadioButton.Name = "aasimarRadioButton";
            this.aasimarRadioButton.Size = new System.Drawing.Size(62, 17);
            this.aasimarRadioButton.TabIndex = 5;
            this.aasimarRadioButton.Text = "Aasimar";
            this.aasimarRadioButton.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(191, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(271, 273);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // RaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 348);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.racesGroupBox);
            this.Name = "RaceForm";
            this.Text = "Races";
            this.racesGroupBox.ResumeLayout(false);
            this.racesGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox racesGroupBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton aasimarRadioButton;
        private System.Windows.Forms.RadioButton tieflingRadioButton;
        private System.Windows.Forms.RadioButton halflingRadioButton;
        private System.Windows.Forms.RadioButton elfRadioButton;
        private System.Windows.Forms.RadioButton dwarfRadioButton;
        private System.Windows.Forms.RadioButton humanRadioButton;
    }
}


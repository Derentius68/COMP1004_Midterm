namespace JobForm
{
    partial class JobForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.healthTextBox = new System.Windows.Forms.TextBox();
            this.nextButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.warriorRadioButton = new System.Windows.Forms.RadioButton();
            this.thiefRadioButton = new System.Windows.Forms.RadioButton();
            this.mageRadioButton = new System.Windows.Forms.RadioButton();
            this.priestRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(273, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Health";
            // 
            // healthTextBox
            // 
            this.healthTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.healthTextBox.Location = new System.Drawing.Point(275, 39);
            this.healthTextBox.Name = "healthTextBox";
            this.healthTextBox.ReadOnly = true;
            this.healthTextBox.Size = new System.Drawing.Size(47, 35);
            this.healthTextBox.TabIndex = 2;
            // 
            // nextButton
            // 
            this.nextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nextButton.Location = new System.Drawing.Point(369, 298);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(103, 42);
            this.nextButton.TabIndex = 16;
            this.nextButton.Text = "Next Sheet";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.priestRadioButton);
            this.groupBox1.Controls.Add(this.mageRadioButton);
            this.groupBox1.Controls.Add(this.thiefRadioButton);
            this.groupBox1.Controls.Add(this.warriorRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 161);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Classes";
            // 
            // warriorRadioButton
            // 
            this.warriorRadioButton.AutoSize = true;
            this.warriorRadioButton.Location = new System.Drawing.Point(7, 20);
            this.warriorRadioButton.Name = "warriorRadioButton";
            this.warriorRadioButton.Size = new System.Drawing.Size(59, 17);
            this.warriorRadioButton.TabIndex = 0;
            this.warriorRadioButton.Text = "Warrior";
            this.warriorRadioButton.UseVisualStyleBackColor = true;
            this.warriorRadioButton.CheckedChanged += new System.EventHandler(this.warriorRadioButton_CheckedChanged);
            // 
            // thiefRadioButton
            // 
            this.thiefRadioButton.AutoSize = true;
            this.thiefRadioButton.Location = new System.Drawing.Point(7, 44);
            this.thiefRadioButton.Name = "thiefRadioButton";
            this.thiefRadioButton.Size = new System.Drawing.Size(49, 17);
            this.thiefRadioButton.TabIndex = 1;
            this.thiefRadioButton.TabStop = true;
            this.thiefRadioButton.Text = "Thief";
            this.thiefRadioButton.UseVisualStyleBackColor = true;
            this.thiefRadioButton.CheckedChanged += new System.EventHandler(this.thiefRadioButton_CheckedChanged);
            // 
            // mageRadioButton
            // 
            this.mageRadioButton.AutoSize = true;
            this.mageRadioButton.Location = new System.Drawing.Point(7, 68);
            this.mageRadioButton.Name = "mageRadioButton";
            this.mageRadioButton.Size = new System.Drawing.Size(79, 17);
            this.mageRadioButton.TabIndex = 2;
            this.mageRadioButton.TabStop = true;
            this.mageRadioButton.Text = "Magic User";
            this.mageRadioButton.UseVisualStyleBackColor = true;
            this.mageRadioButton.CheckedChanged += new System.EventHandler(this.mageRadioButton_CheckedChanged);
            // 
            // priestRadioButton
            // 
            this.priestRadioButton.AutoSize = true;
            this.priestRadioButton.Location = new System.Drawing.Point(7, 92);
            this.priestRadioButton.Name = "priestRadioButton";
            this.priestRadioButton.Size = new System.Drawing.Size(51, 17);
            this.priestRadioButton.TabIndex = 3;
            this.priestRadioButton.TabStop = true;
            this.priestRadioButton.Text = "Priest";
            this.priestRadioButton.UseVisualStyleBackColor = true;
            this.priestRadioButton.CheckedChanged += new System.EventHandler(this.priestRadioButton_CheckedChanged);
            // 
            // JobForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.healthTextBox);
            this.Controls.Add(this.label1);
            this.Name = "JobForm";
            this.Text = "Class";
            this.Load += new System.EventHandler(this.JobForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox healthTextBox;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton priestRadioButton;
        private System.Windows.Forms.RadioButton mageRadioButton;
        private System.Windows.Forms.RadioButton thiefRadioButton;
        private System.Windows.Forms.RadioButton warriorRadioButton;
    }
}


namespace Setting
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.highButton = new System.Windows.Forms.RadioButton();
            this.lowButton = new System.Windows.Forms.RadioButton();
            this.saveButton = new System.Windows.Forms.Button();
            this.blueButton = new System.Windows.Forms.RadioButton();
            this.grayButton = new System.Windows.Forms.RadioButton();
            this.redButton = new System.Windows.Forms.RadioButton();
            this.purpleButton = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(152, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customize";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.purpleButton);
            this.groupBox1.Controls.Add(this.redButton);
            this.groupBox1.Controls.Add(this.grayButton);
            this.groupBox1.Controls.Add(this.blueButton);
            this.groupBox1.Controls.Add(this.highButton);
            this.groupBox1.Controls.Add(this.lowButton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(9, 67);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(308, 151);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Colors";
            // 
            // highButton
            // 
            this.highButton.AutoSize = true;
            this.highButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highButton.Location = new System.Drawing.Point(118, 39);
            this.highButton.Margin = new System.Windows.Forms.Padding(2);
            this.highButton.Name = "highButton";
            this.highButton.Size = new System.Drawing.Size(57, 24);
            this.highButton.TabIndex = 1;
            this.highButton.Text = "Pink";
            this.highButton.UseVisualStyleBackColor = true;
            this.highButton.CheckedChanged += new System.EventHandler(this.mediumButton_CheckedChanged);
            // 
            // lowButton
            // 
            this.lowButton.AutoSize = true;
            this.lowButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lowButton.Location = new System.Drawing.Point(4, 39);
            this.lowButton.Margin = new System.Windows.Forms.Padding(2);
            this.lowButton.Name = "lowButton";
            this.lowButton.Size = new System.Drawing.Size(72, 24);
            this.lowButton.TabIndex = 0;
            this.lowButton.Text = "Green";
            this.lowButton.UseVisualStyleBackColor = true;
            this.lowButton.CheckedChanged += new System.EventHandler(this.smallButton_CheckedChanged);
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(80, 233);
            this.saveButton.Margin = new System.Windows.Forms.Padding(2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(133, 40);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // blueButton
            // 
            this.blueButton.AutoSize = true;
            this.blueButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blueButton.Location = new System.Drawing.Point(227, 39);
            this.blueButton.Name = "blueButton";
            this.blueButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.blueButton.Size = new System.Drawing.Size(59, 24);
            this.blueButton.TabIndex = 2;
            this.blueButton.TabStop = true;
            this.blueButton.Text = "Blue";
            this.blueButton.UseVisualStyleBackColor = true;
            this.blueButton.CheckedChanged += new System.EventHandler(this.blueButton_CheckedChanged);
            // 
            // grayButton
            // 
            this.grayButton.AutoSize = true;
            this.grayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grayButton.Location = new System.Drawing.Point(5, 96);
            this.grayButton.Name = "grayButton";
            this.grayButton.Size = new System.Drawing.Size(61, 24);
            this.grayButton.TabIndex = 3;
            this.grayButton.TabStop = true;
            this.grayButton.Text = "Gray";
            this.grayButton.UseVisualStyleBackColor = true;
            this.grayButton.CheckedChanged += new System.EventHandler(this.grayButton_CheckedChanged);
            // 
            // redButton
            // 
            this.redButton.AutoSize = true;
            this.redButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redButton.Location = new System.Drawing.Point(118, 96);
            this.redButton.Name = "redButton";
            this.redButton.Size = new System.Drawing.Size(57, 24);
            this.redButton.TabIndex = 4;
            this.redButton.TabStop = true;
            this.redButton.Text = "Red";
            this.redButton.UseVisualStyleBackColor = true;
            this.redButton.CheckedChanged += new System.EventHandler(this.redButton_CheckedChanged);
            // 
            // purpleButton
            // 
            this.purpleButton.AutoSize = true;
            this.purpleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purpleButton.Location = new System.Drawing.Point(227, 96);
            this.purpleButton.Name = "purpleButton";
            this.purpleButton.Size = new System.Drawing.Size(72, 24);
            this.purpleButton.TabIndex = 5;
            this.purpleButton.TabStop = true;
            this.purpleButton.Text = "Purple";
            this.purpleButton.UseVisualStyleBackColor = true;
            this.purpleButton.CheckedChanged += new System.EventHandler(this.purpleButton_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 283);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Setting";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton highButton;
        private System.Windows.Forms.RadioButton lowButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.RadioButton blueButton;
        private System.Windows.Forms.RadioButton grayButton;
        private System.Windows.Forms.RadioButton redButton;
        private System.Windows.Forms.RadioButton purpleButton;
    }
}


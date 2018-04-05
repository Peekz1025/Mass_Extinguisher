﻿namespace Setting
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
            this.smallButton = new System.Windows.Forms.RadioButton();
            this.mediumButton = new System.Windows.Forms.RadioButton();
            this.fullBox = new System.Windows.Forms.RadioButton();
            this.saveButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(154, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Setting";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fullBox);
            this.groupBox1.Controls.Add(this.mediumButton);
            this.groupBox1.Controls.Add(this.smallButton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(410, 186);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Screen Sizes";
            // 
            // smallButton
            // 
            this.smallButton.AutoSize = true;
            this.smallButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smallButton.Location = new System.Drawing.Point(105, 46);
            this.smallButton.Name = "smallButton";
            this.smallButton.Size = new System.Drawing.Size(119, 29);
            this.smallButton.TabIndex = 0;
            this.smallButton.Text = "800 x 600";
            this.smallButton.UseVisualStyleBackColor = true;
            this.smallButton.CheckedChanged += new System.EventHandler(this.smallButton_CheckedChanged);
            // 
            // mediumButton
            // 
            this.mediumButton.AutoSize = true;
            this.mediumButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mediumButton.Location = new System.Drawing.Point(105, 81);
            this.mediumButton.Name = "mediumButton";
            this.mediumButton.Size = new System.Drawing.Size(130, 29);
            this.mediumButton.TabIndex = 1;
            this.mediumButton.Text = "1240 x 768";
            this.mediumButton.UseVisualStyleBackColor = true;
            this.mediumButton.CheckedChanged += new System.EventHandler(this.mediumButton_CheckedChanged);
            // 
            // fullBox
            // 
            this.fullBox.AutoSize = true;
            this.fullBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullBox.Location = new System.Drawing.Point(105, 116);
            this.fullBox.Name = "fullBox";
            this.fullBox.Size = new System.Drawing.Size(132, 29);
            this.fullBox.TabIndex = 2;
            this.fullBox.Text = "Full Screen";
            this.fullBox.UseVisualStyleBackColor = true;
            this.fullBox.CheckedChanged += new System.EventHandler(this.fullBox_CheckedChanged);
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(107, 287);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(177, 49);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 348);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.RadioButton fullBox;
        private System.Windows.Forms.RadioButton mediumButton;
        private System.Windows.Forms.RadioButton smallButton;
        private System.Windows.Forms.Button saveButton;
    }
}



namespace dropbox14
{
    partial class Form2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.currentInstructorLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.courseTitleLabel = new System.Windows.Forms.Label();
            this.newInstructorComboBox = new System.Windows.Forms.ComboBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.findButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.courseIdTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.courseIdTextBox);
            this.groupBox1.Controls.Add(this.findButton);
            this.groupBox1.Controls.Add(this.newInstructorComboBox);
            this.groupBox1.Controls.Add(this.courseTitleLabel);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.currentInstructorLabel);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(788, 377);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Change Instructor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(184, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Course ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Course Title:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(164, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Current Intructor:";
            // 
            // currentInstructorLabel
            // 
            this.currentInstructorLabel.AutoSize = true;
            this.currentInstructorLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.currentInstructorLabel.Location = new System.Drawing.Point(281, 219);
            this.currentInstructorLabel.Name = "currentInstructorLabel";
            this.currentInstructorLabel.Size = new System.Drawing.Size(2, 15);
            this.currentInstructorLabel.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(138, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Select New Instructor:";
            // 
            // courseTitleLabel
            // 
            this.courseTitleLabel.AutoSize = true;
            this.courseTitleLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.courseTitleLabel.Location = new System.Drawing.Point(281, 137);
            this.courseTitleLabel.Name = "courseTitleLabel";
            this.courseTitleLabel.Size = new System.Drawing.Size(2, 15);
            this.courseTitleLabel.TabIndex = 5;
            // 
            // newInstructorComboBox
            // 
            this.newInstructorComboBox.Enabled = false;
            this.newInstructorComboBox.FormattingEnabled = true;
            this.newInstructorComboBox.Location = new System.Drawing.Point(284, 303);
            this.newInstructorComboBox.Name = "newInstructorComboBox";
            this.newInstructorComboBox.Size = new System.Drawing.Size(374, 21);
            this.newInstructorComboBox.TabIndex = 6;
            // 
            // updateButton
            // 
            this.updateButton.Enabled = false;
            this.updateButton.Location = new System.Drawing.Point(187, 399);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 7;
            this.updateButton.Text = "&Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // findButton
            // 
            this.findButton.Location = new System.Drawing.Point(583, 43);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(75, 23);
            this.findButton.TabIndex = 8;
            this.findButton.Text = "Find";
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(583, 399);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 9;
            this.closeButton.Text = "Cl&ose";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // courseIdTextBox
            // 
            this.courseIdTextBox.Location = new System.Drawing.Point(284, 45);
            this.courseIdTextBox.Name = "courseIdTextBox";
            this.courseIdTextBox.Size = new System.Drawing.Size(252, 20);
            this.courseIdTextBox.TabIndex = 10;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.updateButton);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox courseIdTextBox;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.ComboBox newInstructorComboBox;
        private System.Windows.Forms.Label courseTitleLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label currentInstructorLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button closeButton;
    }
}
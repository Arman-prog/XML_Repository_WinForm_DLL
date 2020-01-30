namespace XML_Form
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
            this.Student_Button = new System.Windows.Forms.Button();
            this.Teacher_Button = new System.Windows.Forms.Button();
            this.Univer_Button = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Add_Button = new System.Windows.Forms.Button();
            this.Delete_Button = new System.Windows.Forms.Button();
            this.Save_Button = new System.Windows.Forms.Button();
            this.connectionstring = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Student_Button
            // 
            this.Student_Button.Location = new System.Drawing.Point(12, 48);
            this.Student_Button.Name = "Student_Button";
            this.Student_Button.Size = new System.Drawing.Size(108, 23);
            this.Student_Button.TabIndex = 0;
            this.Student_Button.Text = "Load Students";
            this.Student_Button.UseVisualStyleBackColor = true;
            this.Student_Button.Click += new System.EventHandler(this.Student_Button_Click);
            // 
            // Teacher_Button
            // 
            this.Teacher_Button.Location = new System.Drawing.Point(12, 74);
            this.Teacher_Button.Name = "Teacher_Button";
            this.Teacher_Button.Size = new System.Drawing.Size(108, 23);
            this.Teacher_Button.TabIndex = 1;
            this.Teacher_Button.Text = "Load Teachers";
            this.Teacher_Button.UseVisualStyleBackColor = true;
            this.Teacher_Button.Click += new System.EventHandler(this.Teacher_Button_Click);
            // 
            // Univer_Button
            // 
            this.Univer_Button.Location = new System.Drawing.Point(12, 103);
            this.Univer_Button.Name = "Univer_Button";
            this.Univer_Button.Size = new System.Drawing.Size(108, 23);
            this.Univer_Button.TabIndex = 2;
            this.Univer_Button.Text = "Load Universities";
            this.Univer_Button.UseVisualStyleBackColor = true;
            this.Univer_Button.Click += new System.EventHandler(this.Univer_Button_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(142, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(646, 263);
            this.dataGridView1.TabIndex = 3;
            // 
            // Add_Button
            // 
            this.Add_Button.Location = new System.Drawing.Point(166, 341);
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.Size = new System.Drawing.Size(75, 23);
            this.Add_Button.TabIndex = 4;
            this.Add_Button.Text = "Add";
            this.Add_Button.UseVisualStyleBackColor = true;
            this.Add_Button.Click += new System.EventHandler(this.Add_Button_Click);
            // 
            // Delete_Button
            // 
            this.Delete_Button.Location = new System.Drawing.Point(275, 341);
            this.Delete_Button.Name = "Delete_Button";
            this.Delete_Button.Size = new System.Drawing.Size(75, 23);
            this.Delete_Button.TabIndex = 6;
            this.Delete_Button.Text = "Delete";
            this.Delete_Button.UseVisualStyleBackColor = true;
            this.Delete_Button.Click += new System.EventHandler(this.Delete_Button_Click);
            // 
            // Save_Button
            // 
            this.Save_Button.Location = new System.Drawing.Point(624, 341);
            this.Save_Button.Name = "Save_Button";
            this.Save_Button.Size = new System.Drawing.Size(75, 23);
            this.Save_Button.TabIndex = 7;
            this.Save_Button.Text = "Save";
            this.Save_Button.UseVisualStyleBackColor = true;
            this.Save_Button.Click += new System.EventHandler(this.Save_Button_Click);
            // 
            // connectionstring
            // 
            this.connectionstring.Location = new System.Drawing.Point(1, 12);
            this.connectionstring.Name = "connectionstring";
            this.connectionstring.Size = new System.Drawing.Size(135, 20);
            this.connectionstring.TabIndex = 11;
            this.connectionstring.Text = "Enter Connection String";
            this.connectionstring.TextChanged += new System.EventHandler(this.Connectionsting_TextChange);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.connectionstring);
            this.Controls.Add(this.Save_Button);
            this.Controls.Add(this.Delete_Button);
            this.Controls.Add(this.Add_Button);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Univer_Button);
            this.Controls.Add(this.Teacher_Button);
            this.Controls.Add(this.Student_Button);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Student_Button;
        private System.Windows.Forms.Button Teacher_Button;
        private System.Windows.Forms.Button Univer_Button;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Add_Button;
        private System.Windows.Forms.Button Delete_Button;
        private System.Windows.Forms.Button Save_Button;
        private System.Windows.Forms.TextBox connectionstring;
    }
}


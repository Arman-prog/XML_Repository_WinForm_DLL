﻿using System;
using System.Windows.Forms;
using XML_Repository.Models;

namespace XML_Form.Views
{
    public partial class AddStudentForm : Form
    {
        public Student Model { get; private set; }
        public AddStudentForm()
        {
            InitializeComponent();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            Model = new Student
            {
                FirstName = FirstNameTextBox.Text,
                Lastname = LastNameTextBox.Text,            
                BirthDate = dateTimePicker1.Value
            };
            DialogResult = DialogResult.OK;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

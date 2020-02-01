using System;
using System.Windows.Forms;
using XML_Repository.Models;

namespace XML_Form.Views
{
    public partial class AddTeacherForm : Form
    {
        public AddTeacherForm()
        {
            InitializeComponent();
        }
        public Teacher Model { get; private set; }

        private void OkButton_Click(object sender, EventArgs e)
        {
            Model = new Teacher()
            {
                FirstName = FirstNameTextBox.Text,
                Lastname = LastNameTextBox.Text,
                BirthDate = dateTimePicker1.Value
            };
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

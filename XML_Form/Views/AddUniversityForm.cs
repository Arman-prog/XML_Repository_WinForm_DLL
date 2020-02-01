using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XML_Repository.Models;

namespace XML_Form.Views
{
    public partial class AddUniversityForm : Form
    {
        public AddUniversityForm()
        {
            InitializeComponent();
        }
        public University Model { get;private set; }
        private void OkButton_Click(object sender, EventArgs e)
        {
            Model = new University()
            {
                Name = NameTextBox.Text,
                Address = AddressTextBox.Text
            };
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

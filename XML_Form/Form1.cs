using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XML_Repository;
using XML_Repository.Models;
using System.Configuration;
using System.Xml;
using XML_Form.Views;

namespace XML_Form
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private Dictionary<int, Student> StDict { get; set; }
        private Dictionary<int, Teacher> TeDdict { get; set; }
        private Dictionary<int, University> UnDict { get; set; }
        private string Model { get; set; }
        private StudentRepository StudentRepository { get; set; }
        private TeacherRepository TeacherRepository { get; set; }
        private UniversityRepository UniversityRepository { get; set; }



        private void Student_Button_Click(object sender, EventArgs e)
        {
            StudentRepository = new StudentRepository(connectionstring.Text);
            StDict = null;
            StDict = StudentRepository
                .AsEnumerable()
                .ToDictionary(st => st.Id, st => st);
            dataGridView1.DataSource = StDict.Values.ToList();

            Model = "Student";
        }

        private void Teacher_Button_Click(object sender, EventArgs e)
        {
            TeacherRepository = new TeacherRepository(connectionstring.Text);
            TeDdict = TeacherRepository
                .AsEnumerable()
                .ToDictionary(t => t.Id, t => t);
            dataGridView1.DataSource = TeDdict.Values.ToList();

            Model = "Teacher";
        }

        private void Univer_Button_Click(object sender, EventArgs e)
        {
            UniversityRepository = new UniversityRepository(connectionstring.Text);
            UnDict = UniversityRepository
                .AsEnumerable()
                .ToDictionary(u => u.Id, u => u);
            dataGridView1.DataSource = UnDict.Values.ToList();

            Model = "University";
        }

        private void Add_Button_Click(object sender, EventArgs e)//kisat e grvac
        {
            //TextBox fname = new TextBox() { Location = new Point(143, 307) };
            //TextBox lname = new TextBox() { Location = new Point(255, 307) };
            //TextBox bdate = new TextBox() { Location = new Point(367, 307) };
            //Button fnamebutton = new Button() { Location = new Point(150, 281), Text = "FirstName" };
            //Button lnamebutton = new Button() { Location = new Point(262, 281), Text = "LastName" };
            //Button bdatebutton = new Button() { Location = new Point(374, 281), Text = "BirthDate" };
            //this.Controls.Add(fname);
            //this.Controls.Add(lname);
            //this.Controls.Add(bdate);
            //this.Controls.Add(fnamebutton);
            //this.Controls.Add(lnamebutton);
            //this.Controls.Add(bdatebutton);
            //MessageBox.Show("Not ready yet this function");
            
            var addModelForm = new AddStudentForm();
            if (addModelForm.ShowDialog() == DialogResult.OK)
            {
                var model = addModelForm.Model;
            }
        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                int id = 0;
                if (int.TryParse(dataGridView1[0, index].Value.ToString(), out id))
                {
                    switch (Model)
                    {
                        case "Student":
                            StDict.Remove(id);
                            dataGridView1.DataSource = StDict.Values.ToList();
                            break;

                        case "Teacher":
                            TeDdict.Remove(id);
                            dataGridView1.DataSource = TeDdict.Values.ToList();
                            break;

                        case "University":
                            UnDict.Remove(id);
                            dataGridView1.DataSource = UnDict.Values.ToList();
                            break;
                    }
                    MessageBox.Show($"{Model} with id-{id} deleted");
                }
                else
                {
                    MessageBox.Show($"{Model} Not Found");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please select the row for delete");
                return;
            }
        }


        private void Save_Button_Click(object sender, EventArgs e)
        {
            switch (Model)
            {
                case "Student":
                {
                    StudentRepository.RemoveAll();
                    StudentRepository.AddRange(StDict.Values);
                    break;
                }

                case "Teacher":
                {
                    TeacherRepository.RemoveAll();
                    TeacherRepository.AddRange(TeDdict.Values);
                    break;
                }

                case "University":
                {
                    UniversityRepository.RemoveAll();
                    UniversityRepository.AddRange(UnDict.Values);
                    break;
                }
            }
            MessageBox.Show($"{Model}.xml saved");
        }




        private void Connectionsting_TextChange(object sender, EventArgs e)
        {

        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using XML_Repository;
using XML_Repository.Models;
using XML_Form.Views;
using XML_Repository_DLL;

namespace XML_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private DBContext Context { get; set; } = new DBContext();
        private StudentRepository StudentRepository { get; set; }
        private TeacherRepository TeacherRepository { get; set; }
        private UniversityRepository UniversityRepository { get; set; }
        private Models Model { get; set; }
        


        private void Student_Button_Click(object sender, EventArgs e)
        {

            StudentRepository = new StudentRepository(connectionstring.Text);
            Context.Students = StudentRepository
                .AsEnumerable()
                .ToDictionary(st => st.Id, st => st);
            dataGridView1.DataSource = Context.Students.Values.ToList();

            Model = Models.Student;
        }

        private void Teacher_Button_Click(object sender, EventArgs e)
        {
            TeacherRepository = new TeacherRepository(connectionstring.Text);
            Context.Teachers = TeacherRepository
                .AsEnumerable()
                .ToDictionary(t => t.Id, t => t);
            dataGridView1.DataSource = Context.Teachers.Values.ToList();

            Model = Models.Teacher;
        }

        private void Univer_Button_Click(object sender, EventArgs e)
        {
            UniversityRepository = new UniversityRepository(connectionstring.Text);
            Context.Universities = UniversityRepository
                .AsEnumerable()
                .ToDictionary(u => u.Id, u => u);
            dataGridView1.DataSource = Context.Universities.Values.ToList();

            Model = Models.University;
        }

        private void Add_Button_Click(object sender, EventArgs e)//kisat e grvac
        {         

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
                        case Models.Student:
                            Context.Students.Remove(id);
                            dataGridView1.DataSource = Context.Students.Values.ToList();
                            break;

                        case Models.Teacher:
                            Context.Teachers.Remove(id);
                            dataGridView1.DataSource = Context.Teachers.Values.ToList();
                            break;

                        case Models.University:
                            Context.Universities.Remove(id);
                            dataGridView1.DataSource = Context.Universities.Values.ToList();
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
                case Models.Student:
                    {
                       StudentRepository.RemoveAll();
                        StudentRepository.AddRange(Context.Students.Values);
                        break;
                    }

                case Models.Teacher:
                    {
                        TeacherRepository.RemoveAll();
                       TeacherRepository.AddRange(Context.Teachers.Values);
                        break;
                    }

                case Models.University:
                    {
                        UniversityRepository.RemoveAll();
                        UniversityRepository.AddRange(Context.Universities.Values);
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

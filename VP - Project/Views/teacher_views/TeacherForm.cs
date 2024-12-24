using KhApi.Utilis;
using MetroSet_UI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VP___Project.models;

namespace VP___Project.Views.teacher_views
{
    public partial class TeacherForm : MetroSetForm
    {
        SQLManager sqlmanager = new SQLManager();
        int Id;
        public TeacherForm(int id)
        {
            InitializeComponent();
            this.Id = id;
       }

        private void TeacherForm_Load(object sender, EventArgs e)
        {
            ///Get Courses that belong to teacher (Session Tab)
            DataTable courseName = sqlmanager.ExecCommand("VP_Project", "Select Course.Id,Course.Name, Staff.Name from Course JOIN Course_Student ON Course.Id = Course_Student.Course_Id  JOIN Staff ON Staff.Id = Course_Student.Teacher_Id where Teacher_Id = "+ Id +";", null);
            List<Courses> courses = sqlmanager.ConvertDataTable<Courses>(courseName);
            coursesComboBox.DataSource = courseName;
            coursesComboBox.DisplayMember = "Name";
            coursesComboBox.ValueMember = "Id";

            ///Get Courses that belong to teacher (Student Marks Tab)
            DataTable courseName2 = sqlmanager.ExecCommand("VP_Project", "Select COurse.Id,Course.Name, Staff.Name from Course JOIN Course_Staff ON Course.Id = Course_Staff.Course_Id  JOIN Staff ON Staff.Id = Course_Student.Teacher_Id where Teacher_Id = " + Id + ";", null);
            List<Courses> courses2 = sqlmanager.ConvertDataTable<Courses>(courseName2);
            coursesComboBox2.DataSource = courseName2;
            coursesComboBox2.DisplayMember = "Name";
            coursesComboBox2.ValueMember = "Id";
        }

        private void coursesComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ///Students belong to Course GridView
            ///
            DataTable dt2 = sqlmanager.ExecCommand("VP_Project", "select Student.Id, Student.FirstName + ' ' + Student.LastName FullName, Course_Student.Student_Mark from Student join Course_Student on Student.Id = Course_Student.Student_Id where Course_Student.Course_Id = " + coursesComboBox2.SelectedValue +";", null);
            studentsGridView.DataSource = dt2;
        }

        private void studentsGridView_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            try
            {
                int mark = Convert.ToInt32(studentsGridView.Rows[e.RowIndex].Cells[2].Value ?? 0);

            int arg = Convert.ToInt32(studentsGridView.Rows[e.RowIndex].Cells[0].Value);
            
                sqlmanager.ExecCommandNonQuery("VP_Project", "update Course_Student set Student_Mark = '" + mark + "' where student_Id = " + arg + ";", null);

            }
            catch (Exception ex)
            {

                //throw;
            }
        }

        private void startSessionButton_Click(object sender, EventArgs e)
        {
            sqlmanager.ExecCommandNonQuery("VP_Project", "INSERT INTO Session (Teacher_Id, Course_Id) Values (" + Id +", "+ coursesComboBox.SelectedValue +");", null);

            SessionForm sessionForm = new SessionForm(Id, Convert.ToInt32(coursesComboBox.SelectedValue));
            sessionForm.ShowDialog();
        }
    }
}

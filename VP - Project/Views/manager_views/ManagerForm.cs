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
using KhApi.Utilis;
using VP___Project.models;
using System.Data.SqlClient;
using MetroSet_UI.Controls;
using VP___Project.Views.manager_views;

namespace VP___Project
{
    public partial class ManagerForm : MetroSetForm
    {
        SQLManager sqlmanager = new SQLManager();

        public ManagerForm()
        {
            InitializeComponent();
        }

        private void ManagerForm_Load(object sender, EventArgs e)
        {
            ///Get Position Data and convert it to list
            ///
            DataTable dt = sqlmanager.ExecCommand("VP_Project", "select * from Positions", null);
            List<Position> positionList = sqlmanager.ConvertDataTable<Position>(dt);
            positionComboBox.DataSource = dt;
            positionComboBox.DisplayMember = "positionTitle";
            positionComboBox.ValueMember = "Id";

            ///Get Courses Name and convert them to list
            ///
            DataTable courseName = sqlmanager.ExecCommand("VP_Project", "Select Id,Name from Course;", null);
            List<Courses> courses = sqlmanager.ConvertDataTable<Courses>(courseName);
            courseComboBox.DataSource = courseName;
            courseComboBox.DisplayMember = "Name";
            courseComboBox.ValueMember = "Id";

            ///Get Teacher Name and convert them to list
            ///
            DataTable teacherName = sqlmanager.ExecCommand("VP_Project", "Select Id,Name from Staff where position = 3;", null);
            List<Staff> teacher = sqlmanager.ConvertDataTable<Staff>(teacherName);
            teacherComboBox.DataSource = teacherName;
            teacherComboBox.DisplayMember = "Name";
            teacherComboBox.ValueMember = "Id";

            ///All-Staff GridView Config
            ///
            DataTable dt1 = sqlmanager.ExecCommand("VP_Project", "SELECT Staff.Id, Staff.Name, Staff.UserName, Staff.Password, Positions.PositionTitle FROM Staff INNER JOIN Positions ON Staff.Position=Positions.Id;", null);
            StaffGridView.DataSource = dt1;

            ///All-Courses GridView Config
            ///
            DataTable dt2 = sqlmanager.ExecCommand("VP_Project", "SELECT Course.Id, Course.Name Course_Name, Course.Lecture_count, Staff.Name Teacher_Name, Staff.Id Teacher_Id FROM Course JOIN Course_Student ON Course.Id = Course_Student.Course_Id JOIN Staff ON Staff.Id = Course_Student.Teacher_Id;", null);
            CourseGridView.DataSource = dt2;

            ///All-Teacher GridView Config
            ///
            DataTable dt3 = sqlmanager.ExecCommand("VP_Project", "SELECT Staff.Id, Staff.Name, Staff.UserName, Staff.Password, Positions.PositionTitle FROM Staff INNER JOIN Positions ON Staff.Position=Positions.Id where Staff.Position = 3;", null);
            TeachersGridView.DataSource = dt3;

        }

        private void addCourseButton_Click(object sender, EventArgs e)
        {
            try
            {
                sqlmanager.ExecCommandNonQuery("VP_Project", "INSERT INTO Course (Name, Lecture_Count) VALUES ('" + courseNameTextBox.Text + "', "+ courseLectureCountTextBox.Text + ");", null);
            }
            catch (Exception ex)
            {

                throw;
            }
            
        }

        private void AddStaffButton_Click(object sender, EventArgs e)
        {
            try
            {
                sqlmanager.ExecCommandNonQuery("VP_Project", "INSERT INTO Staff (Name , UserName, Password, Position) VALUES ('" + staffNameTextBox.Text + "', '" + userNameTextBox.Text + "', '" + passwordTextBox.Text + "', " + positionComboBox.SelectedValue + ");", null);

                StaffGridView.Update();
                StaffGridView.Refresh();
            }
            catch (Exception ex)
            {

                throw;
            }

        }

        private void AssignButton_Click(object sender, EventArgs e)
        {
            sqlmanager.ExecCommandNonQuery("VP_Project", "INSERT INTO Course_Student (Course_Id, Teacher_Id) VALUES (" + courseComboBox.SelectedValue + ", " + teacherComboBox.SelectedValue + ");", null);
        }

        private void allStaffTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if((sender as MetroSetTabControl).TabIndex == 0)
            {
                DataTable dt = sqlmanager.ExecCommand("VP_Project", "SELECT Staff.Id, Staff.Name, Staff.UserName, Staff.Password, Positions.PositionTitle FROM Staff INNER JOIN Positions ON Staff.Position=Positions.Id;", null);
                StaffGridView.DataSource = dt;
                
            }
        }

        private void allTeachersTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((sender as MetroSetTabControl).TabIndex == 1)
            {
                DataTable dt3 = sqlmanager.ExecCommand("VP_Project", "SELECT Staff.Id, Staff.Name, Staff.UserName, Staff.Password, Positions.PositionTitle FROM Staff INNER JOIN Positions ON Staff.Position=Positions.Id where Staff.Position = 3;", null);
                TeachersGridView.DataSource = dt3;

            }
        }

        private void allCourseTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((sender as MetroSetTabControl).TabIndex == 0)
            {
                DataTable dt2 = sqlmanager.ExecCommand("VP_Project", "SELECT Course.Id, Course.Name Course_Name, Course.Lecture_count, Staff.Name Teacher_Name, Staff.Id Teacher_Id FROM Course JOIN Course_Student ON Course.Id = Course_Student.Course_Id JOIN Staff ON Staff.Id = Course_Student.Teacher_Id;", null);
                CourseGridView.DataSource = dt2;

            }
        }

        private void assignTeacherToCourseTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((sender as MetroSetTabControl).TabIndex == 2)
            {
                ///Get Courses Name and convert them to list
                ///
                DataTable courseName = sqlmanager.ExecCommand("VP_Project", "Select Id,Name from Course;", null);
                List<Courses> courses = sqlmanager.ConvertDataTable<Courses>(courseName);
                courseComboBox.DataSource = courseName;
                courseComboBox.DisplayMember = "Name";
                courseComboBox.ValueMember = "Id";

                ///Get Teacher Name and convert them to list
                ///
                DataTable teacherName = sqlmanager.ExecCommand("VP_Project", "Select Id,Name from Staff where position = 3;", null);
                List<Staff> teacher = sqlmanager.ConvertDataTable<Staff>(teacherName);
                teacherComboBox.DataSource = teacherName;
                teacherComboBox.DisplayMember = "Name";
                teacherComboBox.ValueMember = "Id";
            }
        }

        private void CourseGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int arg = Convert.ToInt32(CourseGridView.Rows[e.RowIndex].Cells[0].Value);
            int tId = Convert.ToInt32(CourseGridView.Rows[e.RowIndex].Cells[4].Value);

            CourseDetailsForm courseDetailsForm = new CourseDetailsForm(arg, tId);

            courseDetailsForm.ShowDialog();
        }
    }
}
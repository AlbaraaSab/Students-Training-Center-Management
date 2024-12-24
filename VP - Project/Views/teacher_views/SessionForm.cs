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
    public partial class SessionForm : MetroSetForm
    {
        SQLManager sqlmanager = new SQLManager();
        int teacherId;
        int courseId;
        int sessionId;
        List<Students> students;

        public SessionForm(int teacherId, int courseId)
        {
            InitializeComponent();
            this.teacherId = teacherId;
            this.courseId = courseId;
        }

        private void SessionForm_Load(object sender, EventArgs e)
        {
            ///Get Session Id
            ///
            DataTable session = sqlmanager.ExecCommand("VP_Project", "SELECT TOP 1 * FROM Session ORDER BY Id DESC", null);
            sessionId = Convert.ToInt32(session.Rows[0]["Id"]);

            ///Get Course Name as Label
            ///
            DataTable dt = sqlmanager.ExecCommand("VP_Project", "SELECT Name FROM Course where Id = "+ courseId +";", null);
            CourseNameLabel.Text = dt.Rows[0]["Name"].ToString();

            ///Get Total Lecture Count as Label
            ///
            DataTable totalCourseCount = sqlmanager.ExecCommand("VP_Project", "SELECT Lecture_count FROM Course where Id = " + courseId + ";", null);
            TotalCountLabel.Text = "Total: " + totalCourseCount.Rows[0]["Lecture_count"].ToString();

            ///Get Total Lecture Count as Label
            ///
            DataTable currentCourseCount = sqlmanager.ExecCommand("VP_Project", "select COUNT(Id) CurrentCount from Session where Course_Id = " + courseId + ";", null);
            CurrentCountLabel.Text = "Current Session: " + currentCourseCount.Rows[0]["CurrentCount"].ToString();

            ///Get Student and convert them to list
            ///
            DataTable studentName = sqlmanager.ExecCommand("VP_Project", "SELECT Student.Id, Student.FirstName + ' ' + Student.LastName+ ' '+ Convert(varchar , Student.Id) as FullName FROM Student join Course_Student on Student.Id = Course_Student.Student_Id where Course_Student.Course_Id = "+ courseId +";", null);
            students = sqlmanager.ConvertDataTable<Students>(studentName);
            foreach (var std in students)
            {
                studentsCheckedListBox.Items.Add(std.FullName);
            }

        }
        private void CloseSessionButton_Click(object sender, EventArgs e)
        {
            string comStr = "INSERT INTO Student_Session(Session_Id, Student_Id) VALUES\n";

            foreach (var item in studentsCheckedListBox.CheckedItems)
            {

                comStr += "(" + sessionId + " ," + students.FirstOrDefault(x => x.FullName == item).Id + "),\n";
            }
            comStr = comStr.Remove(comStr.Length - 2);
            sqlmanager.ExecCommandNonQuery("VP_Project", comStr, null);


            foreach (var item in studentsCheckedListBox.CheckedItems)
            {
                sqlmanager.ExecCommandNonQuery("VP_Project", "update Course_Student Set Student_Attendance = Student_Attendance + 1 where Student_Id = " + students.FirstOrDefault(x => x.FullName == item).Id + " and Teacher_Id = " + teacherId + " ;", null);
            }
        }
    }
}
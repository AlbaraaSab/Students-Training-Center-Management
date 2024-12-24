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

namespace VP___Project.Views.manager_views
{
    public partial class CourseDetailsForm : MetroSetForm
    {
        SQLManager sqlmanager = new SQLManager();

        int Id;
        int tId;

        public CourseDetailsForm(int Id, int tId)
        {
            InitializeComponent();

            this.Id = Id;
            this.tId = tId;
        }

        private void CourseDetailsForm_Load(object sender, EventArgs e)
        {
            ///All-Courses GridView Config
            ///
            DataTable dt2 = sqlmanager.ExecCommand("VP_Project", "SELECT Student.Id Student_Id, Student.FirstName, Student.LastName, Course_Student.Student_Attendance, Course_Student.Student_Mark FROM Student  JOIN Course_Student  ON Student.Id = Course_Student.Student_Id where Course_Student.Course_Id = " + Id + " and Course_Student.Teacher_Id = " + tId + ";", null);
            courseDetailsGridView.DataSource = dt2;
        }
    }
}

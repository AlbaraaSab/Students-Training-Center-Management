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

namespace VP___Project.Views.employee_views
{
    public partial class EmployeeForm : MetroSetForm
    {
        SQLManager sqlmanager = new SQLManager();
        List<Students> students;

        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            ///Get Courses Name and convert them to list
            ///
            DataTable courseName = sqlmanager.ExecCommand("VP_Project", "Select Id,Name from Course;", null);
            List<Courses> courses = sqlmanager.ConvertDataTable<Courses>(courseName);
            courseComboBox.DataSource = courseName;
            courseComboBox.DisplayMember = "Name";
            courseComboBox.ValueMember = "Id";

            ///Get Student and convert them to list
            ///
            DataTable studentName = sqlmanager.ExecCommand("VP_Project", "SELECT Id, FirstName + ' ' + LastName+ ' '+ Convert(varchar , Id) as FullName FROM Student", null);
            students = sqlmanager.ConvertDataTable<Students>(studentName);

            foreach (var std in students)
            {
                checkedListBox1.Items.Add(std.FullName);
            }
        }

        private void addNewStudentButton_Click(object sender, EventArgs e)
        {

            sqlmanager.ExecCommandNonQuery("VP_Project", "INSERT INTO Student(FirstName, LastName, Date_of_Birth, Location, Phone) VALUES('" + firstNameTextBox.Text + "', '" + lastNameTextBox.Text + "', '" + dateOfBirthTextBox.Text + "', '" + locationTextBox.Text + "', '" + phoneTextBox.Text + "');", null);

        }

        private void assignStudentButton_Click(object sender, EventArgs e)
        {
            string comStr = "INSERT INTO Course_Student(Course_Id, Student_Id) VALUES\n";

            foreach (var item in checkedListBox1.CheckedItems)
            {                
                comStr += "(" + courseComboBox.SelectedValue + " ," + students.FirstOrDefault(x => x.FullName == item).Id + "),\n";
            }
            comStr = comStr.Remove(comStr.Length - 2);
            sqlmanager.ExecCommandNonQuery("VP_Project", comStr, null);

        }
    }
}

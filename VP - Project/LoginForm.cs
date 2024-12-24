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
using VP___Project.Views.employee_views;
using VP___Project.Views.teacher_views;

namespace VP___Project
{
    public partial class LoginForm : MetroSetForm
    {
        SQLManager sqlmanager = new SQLManager();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string userName = userNameTextBox.Text;
            string password = passwordTextBox.Text;

            DataTable dt = sqlmanager.Login("VP_Project", userName, password);
            List<Staff> staff = sqlmanager.ConvertDataTable<Staff>(dt);
            if (staff.Count > 0)
            {
                if (staff.FirstOrDefault().Position == 1)
                {
                    this.Hide();
                    ManagerForm managerForm = new ManagerForm();
                    managerForm.Show();
                }
                if (staff.FirstOrDefault().Position == 2)
                {
                    this.Hide();
                    EmployeeForm employeeForm = new EmployeeForm();
                    employeeForm.Show();
                }
                if (staff.FirstOrDefault().Position == 3)
                {
                    this.Hide();
                    TeacherForm teacherForm = new TeacherForm(staff.FirstOrDefault().Id);
                    teacherForm.Show();
                }
            }
        }
    }
}

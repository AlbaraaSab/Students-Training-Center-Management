
namespace VP___Project
{
    partial class ManagerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerForm));
            this.CourseTabControl = new MetroSet_UI.Controls.MetroSetTabControl();
            this.CoursesTabPage = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.metroSetTabControl1 = new MetroSet_UI.Controls.MetroSetTabControl();
            this.allCoursesTabPage = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.CourseGridView = new System.Windows.Forms.DataGridView();
            this.addNewCourseTabPage = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.submitButton = new MetroSet_UI.Controls.MetroSetButton();
            this.courseLectureCountTextBox = new MetroSet_UI.Controls.MetroSetTextBox();
            this.metroSetLabel2 = new MetroSet_UI.Controls.MetroSetLabel();
            this.courseNameTextBox = new MetroSet_UI.Controls.MetroSetTextBox();
            this.metroSetLabel1 = new MetroSet_UI.Controls.MetroSetLabel();
            this.assignTeacherToCourseTabPage = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.AssignButton = new MetroSet_UI.Controls.MetroSetButton();
            this.metroSetLabel8 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel7 = new MetroSet_UI.Controls.MetroSetLabel();
            this.teacherComboBox = new MetroSet_UI.Controls.MetroSetComboBox();
            this.courseComboBox = new MetroSet_UI.Controls.MetroSetComboBox();
            this.StaffTabPage = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.metroSetTabControl2 = new MetroSet_UI.Controls.MetroSetTabControl();
            this.allStaffTabPage = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.StaffGridView = new System.Windows.Forms.DataGridView();
            this.allTeachersTabPage = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.TeachersGridView = new System.Windows.Forms.DataGridView();
            this.addNewStaffTabPage = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.AddStaffButton = new MetroSet_UI.Controls.MetroSetButton();
            this.positionComboBox = new MetroSet_UI.Controls.MetroSetComboBox();
            this.passwordTextBox = new MetroSet_UI.Controls.MetroSetTextBox();
            this.userNameTextBox = new MetroSet_UI.Controls.MetroSetTextBox();
            this.staffNameTextBox = new MetroSet_UI.Controls.MetroSetTextBox();
            this.metroSetLabel6 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel5 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel4 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel3 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetControlBox2 = new MetroSet_UI.Controls.MetroSetControlBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.CourseTabControl.SuspendLayout();
            this.CoursesTabPage.SuspendLayout();
            this.metroSetTabControl1.SuspendLayout();
            this.allCoursesTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CourseGridView)).BeginInit();
            this.addNewCourseTabPage.SuspendLayout();
            this.assignTeacherToCourseTabPage.SuspendLayout();
            this.StaffTabPage.SuspendLayout();
            this.metroSetTabControl2.SuspendLayout();
            this.allStaffTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StaffGridView)).BeginInit();
            this.allTeachersTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TeachersGridView)).BeginInit();
            this.addNewStaffTabPage.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // CourseTabControl
            // 
            this.CourseTabControl.AnimateEasingType = MetroSet_UI.Enums.EasingType.CubeOut;
            this.CourseTabControl.AnimateTime = 200;
            this.CourseTabControl.BackgroundColor = System.Drawing.Color.White;
            this.CourseTabControl.Controls.Add(this.CoursesTabPage);
            this.CourseTabControl.Controls.Add(this.StaffTabPage);
            this.CourseTabControl.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.CourseTabControl, "CourseTabControl");
            this.CourseTabControl.IsDerivedStyle = true;
            this.CourseTabControl.Name = "CourseTabControl";
            this.CourseTabControl.SelectedIndex = 1;
            this.CourseTabControl.SelectedTextColor = System.Drawing.Color.White;
            this.CourseTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.CourseTabControl.Speed = 100;
            this.CourseTabControl.Style = MetroSet_UI.Enums.Style.Light;
            this.CourseTabControl.StyleManager = null;
            this.CourseTabControl.ThemeAuthor = null;
            this.CourseTabControl.ThemeName = null;
            this.CourseTabControl.UnselectedTextColor = System.Drawing.Color.Gray;
            this.CourseTabControl.UseAnimation = false;
            // 
            // CoursesTabPage
            // 
            this.CoursesTabPage.BaseColor = System.Drawing.Color.White;
            this.CoursesTabPage.Controls.Add(this.metroSetTabControl1);
            resources.ApplyResources(this.CoursesTabPage, "CoursesTabPage");
            this.CoursesTabPage.IsDerivedStyle = true;
            this.CoursesTabPage.Name = "CoursesTabPage";
            this.CoursesTabPage.Style = MetroSet_UI.Enums.Style.Light;
            this.CoursesTabPage.StyleManager = null;
            this.CoursesTabPage.ThemeAuthor = "Narwin";
            this.CoursesTabPage.ThemeName = "MetroLite";
            // 
            // metroSetTabControl1
            // 
            this.metroSetTabControl1.AnimateEasingType = MetroSet_UI.Enums.EasingType.CubeOut;
            this.metroSetTabControl1.AnimateTime = 200;
            this.metroSetTabControl1.BackgroundColor = System.Drawing.Color.White;
            this.metroSetTabControl1.Controls.Add(this.allCoursesTabPage);
            this.metroSetTabControl1.Controls.Add(this.addNewCourseTabPage);
            this.metroSetTabControl1.Controls.Add(this.assignTeacherToCourseTabPage);
            this.metroSetTabControl1.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.metroSetTabControl1, "metroSetTabControl1");
            this.metroSetTabControl1.IsDerivedStyle = true;
            this.metroSetTabControl1.Name = "metroSetTabControl1";
            this.metroSetTabControl1.SelectedIndex = 2;
            this.metroSetTabControl1.SelectedTextColor = System.Drawing.Color.White;
            this.metroSetTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.metroSetTabControl1.Speed = 100;
            this.metroSetTabControl1.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetTabControl1.StyleManager = null;
            this.metroSetTabControl1.ThemeAuthor = null;
            this.metroSetTabControl1.ThemeName = null;
            this.metroSetTabControl1.UnselectedTextColor = System.Drawing.Color.Gray;
            this.metroSetTabControl1.UseAnimation = false;
            this.metroSetTabControl1.SelectedIndexChanged += new System.EventHandler(this.assignTeacherToCourseTabControl_SelectedIndexChanged);
            // 
            // allCoursesTabPage
            // 
            this.allCoursesTabPage.BaseColor = System.Drawing.Color.White;
            this.allCoursesTabPage.Controls.Add(this.CourseGridView);
            resources.ApplyResources(this.allCoursesTabPage, "allCoursesTabPage");
            this.allCoursesTabPage.IsDerivedStyle = true;
            this.allCoursesTabPage.Name = "allCoursesTabPage";
            this.allCoursesTabPage.Style = MetroSet_UI.Enums.Style.Light;
            this.allCoursesTabPage.StyleManager = null;
            this.allCoursesTabPage.ThemeAuthor = "Narwin";
            this.allCoursesTabPage.ThemeName = "MetroLite";
            // 
            // CourseGridView
            // 
            this.CourseGridView.AllowUserToAddRows = false;
            this.CourseGridView.AllowUserToDeleteRows = false;
            this.CourseGridView.AllowUserToResizeColumns = false;
            this.CourseGridView.AllowUserToResizeRows = false;
            resources.ApplyResources(this.CourseGridView, "CourseGridView");
            this.CourseGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CourseGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CourseGridView.Name = "CourseGridView";
            this.CourseGridView.ReadOnly = true;
            this.CourseGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CourseGridView_CellDoubleClick);
            // 
            // addNewCourseTabPage
            // 
            this.addNewCourseTabPage.BaseColor = System.Drawing.Color.White;
            this.addNewCourseTabPage.Controls.Add(this.tableLayoutPanel1);
            resources.ApplyResources(this.addNewCourseTabPage, "addNewCourseTabPage");
            this.addNewCourseTabPage.IsDerivedStyle = true;
            this.addNewCourseTabPage.Name = "addNewCourseTabPage";
            this.addNewCourseTabPage.Style = MetroSet_UI.Enums.Style.Light;
            this.addNewCourseTabPage.StyleManager = null;
            this.addNewCourseTabPage.ThemeAuthor = "Narwin";
            this.addNewCourseTabPage.ThemeName = "MetroLite";
            // 
            // submitButton
            // 
            this.submitButton.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.submitButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.submitButton.DisabledForeColor = System.Drawing.Color.Gray;
            resources.ApplyResources(this.submitButton, "submitButton");
            this.submitButton.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.submitButton.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.submitButton.HoverTextColor = System.Drawing.Color.White;
            this.submitButton.IsDerivedStyle = true;
            this.submitButton.Name = "submitButton";
            this.submitButton.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.submitButton.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.submitButton.NormalTextColor = System.Drawing.Color.White;
            this.submitButton.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.submitButton.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.submitButton.PressTextColor = System.Drawing.Color.White;
            this.submitButton.Style = MetroSet_UI.Enums.Style.Light;
            this.submitButton.StyleManager = null;
            this.submitButton.ThemeAuthor = null;
            this.submitButton.ThemeName = null;
            this.submitButton.Click += new System.EventHandler(this.addCourseButton_Click);
            // 
            // courseLectureCountTextBox
            // 
            resources.ApplyResources(this.courseLectureCountTextBox, "courseLectureCountTextBox");
            this.courseLectureCountTextBox.AutoCompleteCustomSource = null;
            this.courseLectureCountTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.courseLectureCountTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.courseLectureCountTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.courseLectureCountTextBox.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.courseLectureCountTextBox.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.courseLectureCountTextBox.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.courseLectureCountTextBox.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.courseLectureCountTextBox.Image = null;
            this.courseLectureCountTextBox.IsDerivedStyle = true;
            this.courseLectureCountTextBox.Lines = null;
            this.courseLectureCountTextBox.MaxLength = 32767;
            this.courseLectureCountTextBox.Multiline = false;
            this.courseLectureCountTextBox.Name = "courseLectureCountTextBox";
            this.courseLectureCountTextBox.ReadOnly = false;
            this.courseLectureCountTextBox.Style = MetroSet_UI.Enums.Style.Light;
            this.courseLectureCountTextBox.StyleManager = null;
            this.courseLectureCountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.courseLectureCountTextBox.ThemeAuthor = null;
            this.courseLectureCountTextBox.ThemeName = null;
            this.courseLectureCountTextBox.UseSystemPasswordChar = false;
            this.courseLectureCountTextBox.WatermarkText = "";
            // 
            // metroSetLabel2
            // 
            resources.ApplyResources(this.metroSetLabel2, "metroSetLabel2");
            this.metroSetLabel2.IsDerivedStyle = true;
            this.metroSetLabel2.Name = "metroSetLabel2";
            this.metroSetLabel2.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel2.StyleManager = null;
            this.metroSetLabel2.ThemeAuthor = null;
            this.metroSetLabel2.ThemeName = null;
            // 
            // courseNameTextBox
            // 
            resources.ApplyResources(this.courseNameTextBox, "courseNameTextBox");
            this.courseNameTextBox.AutoCompleteCustomSource = null;
            this.courseNameTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.courseNameTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.courseNameTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.courseNameTextBox.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.courseNameTextBox.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.courseNameTextBox.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.courseNameTextBox.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.courseNameTextBox.Image = null;
            this.courseNameTextBox.IsDerivedStyle = true;
            this.courseNameTextBox.Lines = null;
            this.courseNameTextBox.MaxLength = 32767;
            this.courseNameTextBox.Multiline = false;
            this.courseNameTextBox.Name = "courseNameTextBox";
            this.courseNameTextBox.ReadOnly = false;
            this.courseNameTextBox.Style = MetroSet_UI.Enums.Style.Light;
            this.courseNameTextBox.StyleManager = null;
            this.courseNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.courseNameTextBox.ThemeAuthor = null;
            this.courseNameTextBox.ThemeName = null;
            this.courseNameTextBox.UseSystemPasswordChar = false;
            this.courseNameTextBox.WatermarkText = "";
            // 
            // metroSetLabel1
            // 
            resources.ApplyResources(this.metroSetLabel1, "metroSetLabel1");
            this.metroSetLabel1.IsDerivedStyle = true;
            this.metroSetLabel1.Name = "metroSetLabel1";
            this.metroSetLabel1.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel1.StyleManager = null;
            this.metroSetLabel1.ThemeAuthor = null;
            this.metroSetLabel1.ThemeName = null;
            // 
            // assignTeacherToCourseTabPage
            // 
            this.assignTeacherToCourseTabPage.BaseColor = System.Drawing.Color.White;
            this.assignTeacherToCourseTabPage.Controls.Add(this.tableLayoutPanel2);
            resources.ApplyResources(this.assignTeacherToCourseTabPage, "assignTeacherToCourseTabPage");
            this.assignTeacherToCourseTabPage.IsDerivedStyle = true;
            this.assignTeacherToCourseTabPage.Name = "assignTeacherToCourseTabPage";
            this.assignTeacherToCourseTabPage.Style = MetroSet_UI.Enums.Style.Light;
            this.assignTeacherToCourseTabPage.StyleManager = null;
            this.assignTeacherToCourseTabPage.ThemeAuthor = "Narwin";
            this.assignTeacherToCourseTabPage.ThemeName = "MetroLite";
            // 
            // AssignButton
            // 
            this.AssignButton.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.AssignButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.AssignButton.DisabledForeColor = System.Drawing.Color.Gray;
            resources.ApplyResources(this.AssignButton, "AssignButton");
            this.AssignButton.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.AssignButton.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.AssignButton.HoverTextColor = System.Drawing.Color.White;
            this.AssignButton.IsDerivedStyle = true;
            this.AssignButton.Name = "AssignButton";
            this.AssignButton.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.AssignButton.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.AssignButton.NormalTextColor = System.Drawing.Color.White;
            this.AssignButton.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.AssignButton.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.AssignButton.PressTextColor = System.Drawing.Color.White;
            this.AssignButton.Style = MetroSet_UI.Enums.Style.Light;
            this.AssignButton.StyleManager = null;
            this.AssignButton.ThemeAuthor = null;
            this.AssignButton.ThemeName = null;
            this.AssignButton.Click += new System.EventHandler(this.AssignButton_Click);
            // 
            // metroSetLabel8
            // 
            resources.ApplyResources(this.metroSetLabel8, "metroSetLabel8");
            this.metroSetLabel8.IsDerivedStyle = true;
            this.metroSetLabel8.Name = "metroSetLabel8";
            this.metroSetLabel8.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel8.StyleManager = null;
            this.metroSetLabel8.ThemeAuthor = null;
            this.metroSetLabel8.ThemeName = null;
            // 
            // metroSetLabel7
            // 
            resources.ApplyResources(this.metroSetLabel7, "metroSetLabel7");
            this.metroSetLabel7.IsDerivedStyle = true;
            this.metroSetLabel7.Name = "metroSetLabel7";
            this.metroSetLabel7.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel7.StyleManager = null;
            this.metroSetLabel7.ThemeAuthor = null;
            this.metroSetLabel7.ThemeName = null;
            // 
            // teacherComboBox
            // 
            this.teacherComboBox.AllowDrop = true;
            this.teacherComboBox.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.teacherComboBox.BackColor = System.Drawing.Color.Transparent;
            this.teacherComboBox.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.teacherComboBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.teacherComboBox.CausesValidation = false;
            this.teacherComboBox.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.teacherComboBox.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.teacherComboBox.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.teacherComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.teacherComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.teacherComboBox, "teacherComboBox");
            this.teacherComboBox.FormattingEnabled = true;
            this.teacherComboBox.IsDerivedStyle = true;
            this.teacherComboBox.Name = "teacherComboBox";
            this.teacherComboBox.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.teacherComboBox.SelectedItemForeColor = System.Drawing.Color.White;
            this.teacherComboBox.Style = MetroSet_UI.Enums.Style.Light;
            this.teacherComboBox.StyleManager = null;
            this.teacherComboBox.ThemeAuthor = null;
            this.teacherComboBox.ThemeName = null;
            // 
            // courseComboBox
            // 
            this.courseComboBox.AllowDrop = true;
            this.courseComboBox.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.courseComboBox.BackColor = System.Drawing.Color.Transparent;
            this.courseComboBox.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.courseComboBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.courseComboBox.CausesValidation = false;
            this.courseComboBox.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.courseComboBox.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.courseComboBox.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.courseComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.courseComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.courseComboBox, "courseComboBox");
            this.courseComboBox.FormattingEnabled = true;
            this.courseComboBox.IsDerivedStyle = true;
            this.courseComboBox.Name = "courseComboBox";
            this.courseComboBox.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.courseComboBox.SelectedItemForeColor = System.Drawing.Color.White;
            this.courseComboBox.Style = MetroSet_UI.Enums.Style.Light;
            this.courseComboBox.StyleManager = null;
            this.courseComboBox.ThemeAuthor = null;
            this.courseComboBox.ThemeName = null;
            // 
            // StaffTabPage
            // 
            this.StaffTabPage.BaseColor = System.Drawing.Color.White;
            this.StaffTabPage.Controls.Add(this.metroSetTabControl2);
            resources.ApplyResources(this.StaffTabPage, "StaffTabPage");
            this.StaffTabPage.IsDerivedStyle = true;
            this.StaffTabPage.Name = "StaffTabPage";
            this.StaffTabPage.Style = MetroSet_UI.Enums.Style.Light;
            this.StaffTabPage.StyleManager = null;
            this.StaffTabPage.ThemeAuthor = "Narwin";
            this.StaffTabPage.ThemeName = "MetroLite";
            // 
            // metroSetTabControl2
            // 
            this.metroSetTabControl2.AnimateEasingType = MetroSet_UI.Enums.EasingType.CubeOut;
            this.metroSetTabControl2.AnimateTime = 200;
            this.metroSetTabControl2.BackgroundColor = System.Drawing.Color.White;
            this.metroSetTabControl2.Controls.Add(this.allStaffTabPage);
            this.metroSetTabControl2.Controls.Add(this.allTeachersTabPage);
            this.metroSetTabControl2.Controls.Add(this.addNewStaffTabPage);
            this.metroSetTabControl2.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.metroSetTabControl2, "metroSetTabControl2");
            this.metroSetTabControl2.IsDerivedStyle = true;
            this.metroSetTabControl2.Name = "metroSetTabControl2";
            this.metroSetTabControl2.SelectedIndex = 2;
            this.metroSetTabControl2.SelectedTextColor = System.Drawing.Color.White;
            this.metroSetTabControl2.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.metroSetTabControl2.Speed = 100;
            this.metroSetTabControl2.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetTabControl2.StyleManager = null;
            this.metroSetTabControl2.ThemeAuthor = null;
            this.metroSetTabControl2.ThemeName = null;
            this.metroSetTabControl2.UnselectedTextColor = System.Drawing.Color.Gray;
            this.metroSetTabControl2.UseAnimation = false;
            this.metroSetTabControl2.SelectedIndexChanged += new System.EventHandler(this.allTeachersTabControl_SelectedIndexChanged);
            // 
            // allStaffTabPage
            // 
            resources.ApplyResources(this.allStaffTabPage, "allStaffTabPage");
            this.allStaffTabPage.BaseColor = System.Drawing.Color.White;
            this.allStaffTabPage.Controls.Add(this.StaffGridView);
            this.allStaffTabPage.IsDerivedStyle = true;
            this.allStaffTabPage.Name = "allStaffTabPage";
            this.allStaffTabPage.Style = MetroSet_UI.Enums.Style.Light;
            this.allStaffTabPage.StyleManager = null;
            this.allStaffTabPage.ThemeAuthor = "Narwin";
            this.allStaffTabPage.ThemeName = "MetroLite";
            // 
            // StaffGridView
            // 
            this.StaffGridView.AllowUserToAddRows = false;
            this.StaffGridView.AllowUserToDeleteRows = false;
            this.StaffGridView.AllowUserToResizeColumns = false;
            this.StaffGridView.AllowUserToResizeRows = false;
            this.StaffGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.StaffGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.StaffGridView, "StaffGridView");
            this.StaffGridView.Name = "StaffGridView";
            this.StaffGridView.ReadOnly = true;
            // 
            // allTeachersTabPage
            // 
            resources.ApplyResources(this.allTeachersTabPage, "allTeachersTabPage");
            this.allTeachersTabPage.BaseColor = System.Drawing.Color.White;
            this.allTeachersTabPage.Controls.Add(this.TeachersGridView);
            this.allTeachersTabPage.IsDerivedStyle = true;
            this.allTeachersTabPage.Name = "allTeachersTabPage";
            this.allTeachersTabPage.Style = MetroSet_UI.Enums.Style.Light;
            this.allTeachersTabPage.StyleManager = null;
            this.allTeachersTabPage.ThemeAuthor = "Narwin";
            this.allTeachersTabPage.ThemeName = "MetroLite";
            // 
            // TeachersGridView
            // 
            this.TeachersGridView.AllowUserToAddRows = false;
            this.TeachersGridView.AllowUserToDeleteRows = false;
            this.TeachersGridView.AllowUserToResizeColumns = false;
            this.TeachersGridView.AllowUserToResizeRows = false;
            this.TeachersGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TeachersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.TeachersGridView, "TeachersGridView");
            this.TeachersGridView.Name = "TeachersGridView";
            this.TeachersGridView.ReadOnly = true;
            // 
            // addNewStaffTabPage
            // 
            this.addNewStaffTabPage.BaseColor = System.Drawing.Color.White;
            this.addNewStaffTabPage.Controls.Add(this.tableLayoutPanel3);
            resources.ApplyResources(this.addNewStaffTabPage, "addNewStaffTabPage");
            this.addNewStaffTabPage.IsDerivedStyle = true;
            this.addNewStaffTabPage.Name = "addNewStaffTabPage";
            this.addNewStaffTabPage.Style = MetroSet_UI.Enums.Style.Light;
            this.addNewStaffTabPage.StyleManager = null;
            this.addNewStaffTabPage.ThemeAuthor = "Narwin";
            this.addNewStaffTabPage.ThemeName = "MetroLite";
            // 
            // AddStaffButton
            // 
            resources.ApplyResources(this.AddStaffButton, "AddStaffButton");
            this.AddStaffButton.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.AddStaffButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.AddStaffButton.DisabledForeColor = System.Drawing.Color.Gray;
            this.AddStaffButton.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.AddStaffButton.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.AddStaffButton.HoverTextColor = System.Drawing.Color.White;
            this.AddStaffButton.IsDerivedStyle = true;
            this.AddStaffButton.Name = "AddStaffButton";
            this.AddStaffButton.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.AddStaffButton.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.AddStaffButton.NormalTextColor = System.Drawing.Color.White;
            this.AddStaffButton.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.AddStaffButton.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.AddStaffButton.PressTextColor = System.Drawing.Color.White;
            this.AddStaffButton.Style = MetroSet_UI.Enums.Style.Light;
            this.AddStaffButton.StyleManager = null;
            this.AddStaffButton.ThemeAuthor = null;
            this.AddStaffButton.ThemeName = null;
            this.AddStaffButton.Click += new System.EventHandler(this.AddStaffButton_Click);
            // 
            // positionComboBox
            // 
            this.positionComboBox.AllowDrop = true;
            this.positionComboBox.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.positionComboBox.BackColor = System.Drawing.Color.Transparent;
            this.positionComboBox.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.positionComboBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.positionComboBox.CausesValidation = false;
            this.positionComboBox.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.positionComboBox.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.positionComboBox.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            resources.ApplyResources(this.positionComboBox, "positionComboBox");
            this.positionComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.positionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.positionComboBox.FormattingEnabled = true;
            this.positionComboBox.IsDerivedStyle = true;
            this.positionComboBox.Name = "positionComboBox";
            this.positionComboBox.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.positionComboBox.SelectedItemForeColor = System.Drawing.Color.White;
            this.positionComboBox.Style = MetroSet_UI.Enums.Style.Light;
            this.positionComboBox.StyleManager = null;
            this.positionComboBox.ThemeAuthor = null;
            this.positionComboBox.ThemeName = null;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.AutoCompleteCustomSource = null;
            this.passwordTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.passwordTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.passwordTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.passwordTextBox.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.passwordTextBox.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.passwordTextBox.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            resources.ApplyResources(this.passwordTextBox, "passwordTextBox");
            this.passwordTextBox.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.passwordTextBox.Image = null;
            this.passwordTextBox.IsDerivedStyle = true;
            this.passwordTextBox.Lines = null;
            this.passwordTextBox.MaxLength = 32767;
            this.passwordTextBox.Multiline = false;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.ReadOnly = false;
            this.passwordTextBox.Style = MetroSet_UI.Enums.Style.Light;
            this.passwordTextBox.StyleManager = null;
            this.passwordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.passwordTextBox.ThemeAuthor = null;
            this.passwordTextBox.ThemeName = null;
            this.passwordTextBox.UseSystemPasswordChar = false;
            this.passwordTextBox.WatermarkText = "";
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.AutoCompleteCustomSource = null;
            this.userNameTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.userNameTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.userNameTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.userNameTextBox.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.userNameTextBox.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.userNameTextBox.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            resources.ApplyResources(this.userNameTextBox, "userNameTextBox");
            this.userNameTextBox.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.userNameTextBox.Image = null;
            this.userNameTextBox.IsDerivedStyle = true;
            this.userNameTextBox.Lines = null;
            this.userNameTextBox.MaxLength = 32767;
            this.userNameTextBox.Multiline = false;
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.ReadOnly = false;
            this.userNameTextBox.Style = MetroSet_UI.Enums.Style.Light;
            this.userNameTextBox.StyleManager = null;
            this.userNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.userNameTextBox.ThemeAuthor = null;
            this.userNameTextBox.ThemeName = null;
            this.userNameTextBox.UseSystemPasswordChar = false;
            this.userNameTextBox.WatermarkText = "";
            // 
            // staffNameTextBox
            // 
            this.staffNameTextBox.AutoCompleteCustomSource = null;
            this.staffNameTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.staffNameTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.staffNameTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.staffNameTextBox.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.staffNameTextBox.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.staffNameTextBox.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            resources.ApplyResources(this.staffNameTextBox, "staffNameTextBox");
            this.staffNameTextBox.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.staffNameTextBox.Image = null;
            this.staffNameTextBox.IsDerivedStyle = true;
            this.staffNameTextBox.Lines = null;
            this.staffNameTextBox.MaxLength = 32767;
            this.staffNameTextBox.Multiline = false;
            this.staffNameTextBox.Name = "staffNameTextBox";
            this.staffNameTextBox.ReadOnly = false;
            this.staffNameTextBox.Style = MetroSet_UI.Enums.Style.Light;
            this.staffNameTextBox.StyleManager = null;
            this.staffNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.staffNameTextBox.ThemeAuthor = null;
            this.staffNameTextBox.ThemeName = null;
            this.staffNameTextBox.UseSystemPasswordChar = false;
            this.staffNameTextBox.WatermarkText = "";
            // 
            // metroSetLabel6
            // 
            resources.ApplyResources(this.metroSetLabel6, "metroSetLabel6");
            this.metroSetLabel6.IsDerivedStyle = true;
            this.metroSetLabel6.Name = "metroSetLabel6";
            this.metroSetLabel6.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel6.StyleManager = null;
            this.metroSetLabel6.ThemeAuthor = null;
            this.metroSetLabel6.ThemeName = null;
            // 
            // metroSetLabel5
            // 
            resources.ApplyResources(this.metroSetLabel5, "metroSetLabel5");
            this.metroSetLabel5.IsDerivedStyle = true;
            this.metroSetLabel5.Name = "metroSetLabel5";
            this.metroSetLabel5.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel5.StyleManager = null;
            this.metroSetLabel5.ThemeAuthor = null;
            this.metroSetLabel5.ThemeName = null;
            // 
            // metroSetLabel4
            // 
            resources.ApplyResources(this.metroSetLabel4, "metroSetLabel4");
            this.metroSetLabel4.IsDerivedStyle = true;
            this.metroSetLabel4.Name = "metroSetLabel4";
            this.metroSetLabel4.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel4.StyleManager = null;
            this.metroSetLabel4.ThemeAuthor = null;
            this.metroSetLabel4.ThemeName = null;
            // 
            // metroSetLabel3
            // 
            resources.ApplyResources(this.metroSetLabel3, "metroSetLabel3");
            this.metroSetLabel3.IsDerivedStyle = true;
            this.metroSetLabel3.Name = "metroSetLabel3";
            this.metroSetLabel3.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel3.StyleManager = null;
            this.metroSetLabel3.ThemeAuthor = null;
            this.metroSetLabel3.ThemeName = null;
            // 
            // metroSetControlBox2
            // 
            resources.ApplyResources(this.metroSetControlBox2, "metroSetControlBox2");
            this.metroSetControlBox2.CloseHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.metroSetControlBox2.CloseHoverForeColor = System.Drawing.Color.White;
            this.metroSetControlBox2.CloseNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox2.DisabledForeColor = System.Drawing.Color.DimGray;
            this.metroSetControlBox2.IsDerivedStyle = true;
            this.metroSetControlBox2.MaximizeBox = true;
            this.metroSetControlBox2.MaximizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetControlBox2.MaximizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox2.MaximizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox2.MinimizeBox = true;
            this.metroSetControlBox2.MinimizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetControlBox2.MinimizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox2.MinimizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox2.Name = "metroSetControlBox2";
            this.metroSetControlBox2.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetControlBox2.StyleManager = null;
            this.metroSetControlBox2.ThemeAuthor = null;
            this.metroSetControlBox2.ThemeName = null;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.metroSetLabel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.courseLectureCountTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.courseNameTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.metroSetLabel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.submitButton, 1, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.courseComboBox, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.metroSetLabel7, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.metroSetLabel8, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.teacherComboBox, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.AssignButton, 2, 1);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.tableLayoutPanel3, "tableLayoutPanel3");
            this.tableLayoutPanel3.Controls.Add(this.metroSetLabel3, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.metroSetLabel4, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.positionComboBox, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.metroSetLabel6, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.passwordTextBox, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.metroSetLabel5, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.userNameTextBox, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.staffNameTextBox, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.AddStaffButton, 1, 4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            // 
            // ManagerForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroSetControlBox2);
            this.Controls.Add(this.CourseTabControl);
            this.Name = "ManagerForm";
            this.ShowTitle = false;
            this.ThemeAuthor = null;
            this.ThemeName = null;
            this.Load += new System.EventHandler(this.ManagerForm_Load);
            this.CourseTabControl.ResumeLayout(false);
            this.CoursesTabPage.ResumeLayout(false);
            this.metroSetTabControl1.ResumeLayout(false);
            this.allCoursesTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CourseGridView)).EndInit();
            this.addNewCourseTabPage.ResumeLayout(false);
            this.assignTeacherToCourseTabPage.ResumeLayout(false);
            this.StaffTabPage.ResumeLayout(false);
            this.metroSetTabControl2.ResumeLayout(false);
            this.allStaffTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StaffGridView)).EndInit();
            this.allTeachersTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TeachersGridView)).EndInit();
            this.addNewStaffTabPage.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroSet_UI.Controls.MetroSetTabControl CourseTabControl;
        private MetroSet_UI.Child.MetroSetSetTabPage CoursesTabPage;
        private MetroSet_UI.Controls.MetroSetTabControl metroSetTabControl1;
        private MetroSet_UI.Child.MetroSetSetTabPage allCoursesTabPage;
        private MetroSet_UI.Child.MetroSetSetTabPage addNewCourseTabPage;
        private MetroSet_UI.Child.MetroSetSetTabPage StaffTabPage;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel1;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel2;
        private MetroSet_UI.Controls.MetroSetTextBox courseNameTextBox;
        private MetroSet_UI.Controls.MetroSetTextBox courseLectureCountTextBox;
        private MetroSet_UI.Controls.MetroSetButton submitButton;
        private MetroSet_UI.Child.MetroSetSetTabPage assignTeacherToCourseTabPage;
        private MetroSet_UI.Controls.MetroSetTabControl metroSetTabControl2;
        private MetroSet_UI.Child.MetroSetSetTabPage allStaffTabPage;
        private MetroSet_UI.Child.MetroSetSetTabPage addNewStaffTabPage;
        private MetroSet_UI.Controls.MetroSetButton AddStaffButton;
        private MetroSet_UI.Controls.MetroSetComboBox positionComboBox;
        private MetroSet_UI.Controls.MetroSetTextBox passwordTextBox;
        private MetroSet_UI.Controls.MetroSetTextBox userNameTextBox;
        private MetroSet_UI.Controls.MetroSetTextBox staffNameTextBox;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel6;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel5;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel4;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel3;
        private System.Windows.Forms.DataGridView StaffGridView;
        private MetroSet_UI.Controls.MetroSetControlBox metroSetControlBox2;
        private System.Windows.Forms.DataGridView CourseGridView;
        private MetroSet_UI.Controls.MetroSetComboBox teacherComboBox;
        private MetroSet_UI.Controls.MetroSetComboBox courseComboBox;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel8;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel7;
        private MetroSet_UI.Controls.MetroSetButton AssignButton;
        private MetroSet_UI.Child.MetroSetSetTabPage allTeachersTabPage;
        private System.Windows.Forms.DataGridView TeachersGridView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    }
}



namespace VP___Project.Views.teacher_views
{
    partial class SessionForm
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
            this.metroSetControlBox1 = new MetroSet_UI.Controls.MetroSetControlBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.studentsCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.CourseNameLabel = new MetroSet_UI.Controls.MetroSetLabel();
            this.TotalCountLabel = new MetroSet_UI.Controls.MetroSetLabel();
            this.CurrentCountLabel = new MetroSet_UI.Controls.MetroSetLabel();
            this.CloseSessionButton = new MetroSet_UI.Controls.MetroSetButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroSetControlBox1
            // 
            this.metroSetControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroSetControlBox1.CloseHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.metroSetControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            this.metroSetControlBox1.CloseNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.DisabledForeColor = System.Drawing.Color.DimGray;
            this.metroSetControlBox1.IsDerivedStyle = true;
            this.metroSetControlBox1.Location = new System.Drawing.Point(669, 7);
            this.metroSetControlBox1.MaximizeBox = true;
            this.metroSetControlBox1.MaximizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetControlBox1.MaximizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MaximizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MinimizeBox = true;
            this.metroSetControlBox1.MinimizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetControlBox1.MinimizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MinimizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.Name = "metroSetControlBox1";
            this.metroSetControlBox1.Size = new System.Drawing.Size(100, 25);
            this.metroSetControlBox1.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetControlBox1.StyleManager = null;
            this.metroSetControlBox1.TabIndex = 0;
            this.metroSetControlBox1.Text = "metroSetControlBox1";
            this.metroSetControlBox1.ThemeAuthor = "Narwin";
            this.metroSetControlBox1.ThemeName = "MetroLite";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Window;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.92557F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.07443F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 313F));
            this.tableLayoutPanel1.Controls.Add(this.studentsCheckedListBox, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.CourseNameLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.TotalCountLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.CurrentCountLabel, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.CloseSessionButton, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 70);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.98738F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.01262F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(751, 404);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // studentsCheckedListBox
            // 
            this.studentsCheckedListBox.CheckOnClick = true;
            this.studentsCheckedListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.studentsCheckedListBox.FormattingEnabled = true;
            this.studentsCheckedListBox.Location = new System.Drawing.Point(440, 51);
            this.studentsCheckedListBox.Name = "studentsCheckedListBox";
            this.studentsCheckedListBox.Size = new System.Drawing.Size(308, 350);
            this.studentsCheckedListBox.TabIndex = 0;
            // 
            // CourseNameLabel
            // 
            this.CourseNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CourseNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CourseNameLabel.IsDerivedStyle = true;
            this.CourseNameLabel.Location = new System.Drawing.Point(3, 0);
            this.CourseNameLabel.Name = "CourseNameLabel";
            this.CourseNameLabel.Size = new System.Drawing.Size(199, 48);
            this.CourseNameLabel.Style = MetroSet_UI.Enums.Style.Light;
            this.CourseNameLabel.StyleManager = null;
            this.CourseNameLabel.TabIndex = 1;
            this.CourseNameLabel.Text = "metroSetLabel1";
            this.CourseNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CourseNameLabel.ThemeAuthor = "Narwin";
            this.CourseNameLabel.ThemeName = "MetroLite";
            // 
            // TotalCountLabel
            // 
            this.TotalCountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TotalCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TotalCountLabel.IsDerivedStyle = true;
            this.TotalCountLabel.Location = new System.Drawing.Point(208, 0);
            this.TotalCountLabel.Name = "TotalCountLabel";
            this.TotalCountLabel.Size = new System.Drawing.Size(226, 48);
            this.TotalCountLabel.Style = MetroSet_UI.Enums.Style.Light;
            this.TotalCountLabel.StyleManager = null;
            this.TotalCountLabel.TabIndex = 2;
            this.TotalCountLabel.Text = "metroSetLabel2";
            this.TotalCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TotalCountLabel.ThemeAuthor = "Narwin";
            this.TotalCountLabel.ThemeName = "MetroLite";
            // 
            // CurrentCountLabel
            // 
            this.CurrentCountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CurrentCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CurrentCountLabel.IsDerivedStyle = true;
            this.CurrentCountLabel.Location = new System.Drawing.Point(440, 0);
            this.CurrentCountLabel.Name = "CurrentCountLabel";
            this.CurrentCountLabel.Size = new System.Drawing.Size(308, 48);
            this.CurrentCountLabel.Style = MetroSet_UI.Enums.Style.Light;
            this.CurrentCountLabel.StyleManager = null;
            this.CurrentCountLabel.TabIndex = 3;
            this.CurrentCountLabel.Text = "metroSetLabel1";
            this.CurrentCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CurrentCountLabel.ThemeAuthor = "Narwin";
            this.CurrentCountLabel.ThemeName = "MetroLite";
            // 
            // CloseSessionButton
            // 
            this.CloseSessionButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseSessionButton.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.CloseSessionButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.CloseSessionButton.DisabledForeColor = System.Drawing.Color.Gray;
            this.CloseSessionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CloseSessionButton.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.CloseSessionButton.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.CloseSessionButton.HoverTextColor = System.Drawing.Color.White;
            this.CloseSessionButton.IsDerivedStyle = true;
            this.CloseSessionButton.Location = new System.Drawing.Point(3, 359);
            this.CloseSessionButton.Name = "CloseSessionButton";
            this.CloseSessionButton.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.CloseSessionButton.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.CloseSessionButton.NormalTextColor = System.Drawing.Color.White;
            this.CloseSessionButton.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.CloseSessionButton.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.CloseSessionButton.PressTextColor = System.Drawing.Color.White;
            this.CloseSessionButton.Size = new System.Drawing.Size(199, 42);
            this.CloseSessionButton.Style = MetroSet_UI.Enums.Style.Light;
            this.CloseSessionButton.StyleManager = null;
            this.CloseSessionButton.TabIndex = 4;
            this.CloseSessionButton.Text = "Done";
            this.CloseSessionButton.ThemeAuthor = "Narwin";
            this.CloseSessionButton.ThemeName = "MetroLite";
            this.CloseSessionButton.Click += new System.EventHandler(this.CloseSessionButton_Click);
            // 
            // SessionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(775, 486);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.metroSetControlBox1);
            this.Name = "SessionForm";
            this.Text = "SessionForm";
            this.Load += new System.EventHandler(this.SessionForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroSet_UI.Controls.MetroSetControlBox metroSetControlBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.CheckedListBox studentsCheckedListBox;
        private MetroSet_UI.Controls.MetroSetLabel CourseNameLabel;
        private MetroSet_UI.Controls.MetroSetLabel TotalCountLabel;
        private MetroSet_UI.Controls.MetroSetLabel CurrentCountLabel;
        private MetroSet_UI.Controls.MetroSetButton CloseSessionButton;
    }
}
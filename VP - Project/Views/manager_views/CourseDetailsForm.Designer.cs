
namespace VP___Project.Views.manager_views
{
    partial class CourseDetailsForm
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
            this.courseDetailsGridView = new System.Windows.Forms.DataGridView();
            this.metroSetControlBox1 = new MetroSet_UI.Controls.MetroSetControlBox();
            ((System.ComponentModel.ISupportInitialize)(this.courseDetailsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // courseDetailsGridView
            // 
            this.courseDetailsGridView.AllowUserToAddRows = false;
            this.courseDetailsGridView.AllowUserToDeleteRows = false;
            this.courseDetailsGridView.AllowUserToResizeColumns = false;
            this.courseDetailsGridView.AllowUserToResizeRows = false;
            this.courseDetailsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.courseDetailsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.courseDetailsGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.courseDetailsGridView.Location = new System.Drawing.Point(12, 90);
            this.courseDetailsGridView.Name = "courseDetailsGridView";
            this.courseDetailsGridView.ReadOnly = true;
            this.courseDetailsGridView.Size = new System.Drawing.Size(776, 348);
            this.courseDetailsGridView.TabIndex = 2;
            // 
            // metroSetControlBox1
            // 
            this.metroSetControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroSetControlBox1.CloseHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.metroSetControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            this.metroSetControlBox1.CloseNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.DisabledForeColor = System.Drawing.Color.DimGray;
            this.metroSetControlBox1.IsDerivedStyle = true;
            this.metroSetControlBox1.Location = new System.Drawing.Point(685, 9);
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
            this.metroSetControlBox1.TabIndex = 3;
            this.metroSetControlBox1.Text = "metroSetControlBox1";
            this.metroSetControlBox1.ThemeAuthor = "Narwin";
            this.metroSetControlBox1.ThemeName = "MetroLite";
            // 
            // CourseDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.metroSetControlBox1);
            this.Controls.Add(this.courseDetailsGridView);
            this.Name = "CourseDetailsForm";
            this.Padding = new System.Windows.Forms.Padding(12, 90, 12, 12);
            this.Text = "COURSE DETAILS";
            this.Load += new System.EventHandler(this.CourseDetailsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.courseDetailsGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView courseDetailsGridView;
        private MetroSet_UI.Controls.MetroSetControlBox metroSetControlBox1;
    }
}
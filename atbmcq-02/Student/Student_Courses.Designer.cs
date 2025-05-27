using OracleUserManager.Models;

namespace atbmcq_02
{
    partial class Student_Courses
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dtgvCourse = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            CName = new DataGridViewTextBoxColumn();
            Credits = new DataGridViewTextBoxColumn();
            Theory = new DataGridViewTextBoxColumn();
            Practice = new DataGridViewTextBoxColumn();
            Department = new DataGridViewTextBoxColumn();
            lblCourse = new Label();
            pnlBar = new Panel();
            lblBack = new LinkLabel();
            lblSignOut = new LinkLabel();
            lblSlog = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgvCourse).BeginInit();
            pnlBar.SuspendLayout();
            SuspendLayout();
            // 
            // dtgvCourse
            // 
            dtgvCourse.BackgroundColor = SystemColors.ButtonHighlight;
            dtgvCourse.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvCourse.Columns.AddRange(new DataGridViewColumn[] { ID, CName, Credits, Theory, Practice, Department });
            dtgvCourse.Dock = DockStyle.Bottom;
            dtgvCourse.Location = new Point(0, 320);
            dtgvCourse.Name = "dtgvCourse";
            dtgvCourse.RowHeadersWidth = 62;
            dtgvCourse.Size = new Size(1412, 439);
            dtgvCourse.TabIndex = 0;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 8;
            ID.Name = "ID";
            ID.Width = 224;
            // 
            // CName
            // 
            CName.HeaderText = "Name";
            CName.MinimumWidth = 8;
            CName.Name = "CName";
            CName.Width = 228;
            // 
            // Credits
            // 
            Credits.HeaderText = "Credits";
            Credits.MinimumWidth = 8;
            Credits.Name = "Credits";
            Credits.Width = 224;
            // 
            // Theory
            // 
            Theory.HeaderText = "Theory";
            Theory.MinimumWidth = 8;
            Theory.Name = "Theory";
            Theory.Width = 224;
            // 
            // Practice
            // 
            Practice.HeaderText = "Practice";
            Practice.MinimumWidth = 8;
            Practice.Name = "Practice";
            Practice.Width = 224;
            // 
            // Department
            // 
            Department.HeaderText = "Department";
            Department.MinimumWidth = 8;
            Department.Name = "Department";
            Department.Width = 224;
            // 
            // lblCourse
            // 
            lblCourse.AutoSize = true;
            lblCourse.Font = new Font("VNI-Couri", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCourse.Location = new Point(505, 137);
            lblCourse.Name = "lblCourse";
            lblCourse.Size = new Size(403, 92);
            lblCourse.TabIndex = 1;
            lblCourse.Text = "Courses";
            // 
            // pnlBar
            // 
            pnlBar.BackColor = SystemColors.ActiveCaption;
            pnlBar.Controls.Add(lblBack);
            pnlBar.Controls.Add(lblSignOut);
            pnlBar.Controls.Add(lblSlog);
            pnlBar.Dock = DockStyle.Top;
            pnlBar.Location = new Point(0, 0);
            pnlBar.Name = "pnlBar";
            pnlBar.Size = new Size(1412, 59);
            pnlBar.TabIndex = 2;
            // 
            // lblBack
            // 
            lblBack.AutoSize = true;
            lblBack.Font = new Font("VNI-Korin", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBack.Location = new Point(1239, 8);
            lblBack.Name = "lblBack";
            lblBack.Size = new Size(65, 30);
            lblBack.TabIndex = 2;
            lblBack.TabStop = true;
            lblBack.Text = "Back";
            lblBack.LinkClicked += lblBack_LinkClicked;
            // 
            // lblSignOut
            // 
            lblSignOut.AutoSize = true;
            lblSignOut.Font = new Font("VNI-Korin", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSignOut.Location = new Point(1310, 8);
            lblSignOut.Name = "lblSignOut";
            lblSignOut.Size = new Size(99, 30);
            lblSignOut.TabIndex = 1;
            lblSignOut.TabStop = true;
            lblSignOut.Text = "Sign out";
            lblSignOut.LinkClicked += lblSignOut_LinkClicked;
            // 
            // lblSlog
            // 
            lblSlog.AutoSize = true;
            lblSlog.Font = new Font("VNI-Diudang", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSlog.Location = new Point(3, 10);
            lblSlog.Name = "lblSlog";
            lblSlog.Size = new Size(211, 29);
            lblSlog.TabIndex = 0;
            lblSlog.Text = "Welcome to University X!";
            // 
            // Courses
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            Controls.Add(pnlBar);
            Controls.Add(lblCourse);
            Controls.Add(dtgvCourse);
            Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Courses";
            Size = new Size(1412, 759);
            ((System.ComponentModel.ISupportInitialize)dtgvCourse).EndInit();
            pnlBar.ResumeLayout(false);
            pnlBar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgvCourse;
        private Label lblCourse;
        private Panel pnlBar;
        private LinkLabel lblBack;
        private LinkLabel lblSignOut;
        private Label lblSlog;
        private OracleDbConnection _connection;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn CName;
        private DataGridViewTextBoxColumn Credits;
        private DataGridViewTextBoxColumn Theory;
        private DataGridViewTextBoxColumn Practice;
        private DataGridViewTextBoxColumn Department;
    }
}

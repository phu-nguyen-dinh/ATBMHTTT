using OracleUserManager.Models;

namespace atbmcq_02
{
    partial class Student_OpenedSubjects
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
            dtgvSubject = new DataGridView();
            Course = new DataGridViewTextBoxColumn();
            Subject = new DataGridViewTextBoxColumn();
            InCharge = new DataGridViewTextBoxColumn();
            Semester = new DataGridViewTextBoxColumn();
            Year = new DataGridViewTextBoxColumn();
            pnlBar = new Panel();
            lblBack = new LinkLabel();
            lblSignOut = new LinkLabel();
            lblSlog = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgvSubject).BeginInit();
            pnlBar.SuspendLayout();
            SuspendLayout();
            // 
            // dtgvSubject
            // 
            dtgvSubject.AllowUserToAddRows = false;
            dtgvSubject.AllowUserToDeleteRows = false;
            dtgvSubject.BackgroundColor = SystemColors.ButtonHighlight;
            dtgvSubject.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvSubject.Columns.AddRange(new DataGridViewColumn[] { Course, Subject, InCharge, Semester, Year });
            dtgvSubject.Dock = DockStyle.Bottom;
            dtgvSubject.Location = new Point(0, 177);
            dtgvSubject.Margin = new Padding(4, 3, 4, 3);
            dtgvSubject.Name = "dtgvSubject";
            dtgvSubject.RowHeadersWidth = 62;
            dtgvSubject.Size = new Size(1277, 463);
            dtgvSubject.TabIndex = 1;
            // 
            // Course
            // 
            Course.HeaderText = "Course";
            Course.MinimumWidth = 8;
            Course.Name = "Course";
            Course.SortMode = DataGridViewColumnSortMode.NotSortable;
            Course.Width = 243;
            // 
            // Subject
            // 
            Subject.HeaderText = "Subject";
            Subject.MinimumWidth = 8;
            Subject.Name = "Subject";
            Subject.SortMode = DataGridViewColumnSortMode.NotSortable;
            Subject.Width = 243;
            // 
            // InCharge
            // 
            InCharge.HeaderText = "In Charge";
            InCharge.MinimumWidth = 8;
            InCharge.Name = "InCharge";
            InCharge.SortMode = DataGridViewColumnSortMode.NotSortable;
            InCharge.Width = 243;
            // 
            // Semester
            // 
            Semester.HeaderText = "Semester";
            Semester.MinimumWidth = 8;
            Semester.Name = "Semester";
            Semester.SortMode = DataGridViewColumnSortMode.NotSortable;
            Semester.Width = 243;
            // 
            // Year
            // 
            Year.HeaderText = "Year";
            Year.MinimumWidth = 8;
            Year.Name = "Year";
            Year.SortMode = DataGridViewColumnSortMode.NotSortable;
            Year.Width = 243;
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
            pnlBar.Size = new Size(1277, 50);
            pnlBar.TabIndex = 3;
            // 
            // lblBack
            // 
            lblBack.AutoSize = true;
            lblBack.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBack.Location = new Point(1104, 8);
            lblBack.Name = "lblBack";
            lblBack.Size = new Size(51, 24);
            lblBack.TabIndex = 2;
            lblBack.TabStop = true;
            lblBack.Text = "Back";
            lblBack.LinkClicked += lblBack_LinkClicked;
            // 
            // lblSignOut
            // 
            lblSignOut.AutoSize = true;
            lblSignOut.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSignOut.Location = new Point(1175, 8);
            lblSignOut.Name = "lblSignOut";
            lblSignOut.Size = new Size(79, 24);
            lblSignOut.TabIndex = 1;
            lblSignOut.TabStop = true;
            lblSignOut.Text = "Sign out";
            lblSignOut.LinkClicked += lblSignOut_LinkClicked;
            // 
            // lblSlog
            // 
            lblSlog.AutoSize = true;
            lblSlog.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSlog.Location = new Point(3, 8);
            lblSlog.Name = "lblSlog";
            lblSlog.Size = new Size(220, 24);
            lblSlog.TabIndex = 0;
            lblSlog.Text = "Welcome to University X!";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(421, 74);
            label1.Name = "label1";
            label1.Size = new Size(502, 69);
            label1.TabIndex = 4;
            label1.Text = "Opened Subjects";
            // 
            // Student_OpenedSubjects
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            Controls.Add(label1);
            Controls.Add(pnlBar);
            Controls.Add(dtgvSubject);
            Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Student_OpenedSubjects";
            Size = new Size(1277, 640);
            ((System.ComponentModel.ISupportInitialize)dtgvSubject).EndInit();
            pnlBar.ResumeLayout(false);
            pnlBar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgvSubject;
        private Panel pnlBar;
        private LinkLabel lblBack;
        private LinkLabel lblSignOut;
        private Label lblSlog;
        private Label label1;
        private OracleDbConnection _connection;
        private DataGridViewTextBoxColumn Course;
        private DataGridViewTextBoxColumn Subject;
        private DataGridViewTextBoxColumn InCharge;
        private DataGridViewTextBoxColumn Semester;
        private DataGridViewTextBoxColumn Year;
    }
}

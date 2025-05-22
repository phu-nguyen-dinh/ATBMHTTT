using OracleUserManager.Models;

namespace atbmcq_02
{
    partial class DashBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoard));
            pnlBar = new Panel();
            lblSignOut = new LinkLabel();
            lblSlog = new Label();
            lblHeader = new Label();
            pnlDSplit = new Panel();
            picCourse = new PictureBox();
            picRegis = new PictureBox();
            picOpened = new PictureBox();
            llblCourses = new LinkLabel();
            llblRegis = new LinkLabel();
            llblOpened = new LinkLabel();
            picStudent = new PictureBox();
            linkStudent = new LinkLabel();
            pnlBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picCourse).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picRegis).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picOpened).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picStudent).BeginInit();
            SuspendLayout();
            // 
            // pnlBar
            // 
            pnlBar.BackColor = SystemColors.ActiveCaption;
            pnlBar.Controls.Add(lblSignOut);
            pnlBar.Controls.Add(lblSlog);
            pnlBar.Dock = DockStyle.Top;
            pnlBar.Location = new Point(0, 0);
            pnlBar.Margin = new Padding(2);
            pnlBar.Name = "pnlBar";
            pnlBar.Size = new Size(838, 42);
            pnlBar.TabIndex = 0;
            // 
            // lblSignOut
            // 
            lblSignOut.AutoSize = true;
            lblSignOut.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSignOut.Location = new Point(694, 7);
            lblSignOut.Margin = new Padding(2, 0, 2, 0);
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
            lblSlog.Location = new Point(10, 7);
            lblSlog.Margin = new Padding(2, 0, 2, 0);
            lblSlog.Name = "lblSlog";
            lblSlog.Size = new Size(220, 24);
            lblSlog.TabIndex = 0;
            lblSlog.Text = "Welcome to University X!";
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Microsoft Sans Serif", 27.9999962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeader.Location = new Point(244, 45);
            lblHeader.Margin = new Padding(2, 0, 2, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(262, 54);
            lblHeader.TabIndex = 1;
            lblHeader.Text = "Dashboard";
            // 
            // pnlDSplit
            // 
            pnlDSplit.BackColor = SystemColors.Desktop;
            pnlDSplit.Dock = DockStyle.Top;
            pnlDSplit.Location = new Point(0, 42);
            pnlDSplit.Margin = new Padding(2);
            pnlDSplit.Name = "pnlDSplit";
            pnlDSplit.Size = new Size(838, 1);
            pnlDSplit.TabIndex = 2;
            // 
            // picCourse
            // 
            picCourse.Image = (Image)resources.GetObject("picCourse.Image");
            picCourse.Location = new Point(80, 142);
            picCourse.Margin = new Padding(2);
            picCourse.Name = "picCourse";
            picCourse.Size = new Size(160, 160);
            picCourse.SizeMode = PictureBoxSizeMode.StretchImage;
            picCourse.TabIndex = 3;
            picCourse.TabStop = false;
            // 
            // picRegis
            // 
            picRegis.Image = (Image)resources.GetObject("picRegis.Image");
            picRegis.Location = new Point(320, 142);
            picRegis.Margin = new Padding(2);
            picRegis.Name = "picRegis";
            picRegis.Size = new Size(160, 160);
            picRegis.SizeMode = PictureBoxSizeMode.StretchImage;
            picRegis.TabIndex = 4;
            picRegis.TabStop = false;
            // 
            // picOpened
            // 
            picOpened.Image = (Image)resources.GetObject("picOpened.Image");
            picOpened.Location = new Point(560, 142);
            picOpened.Margin = new Padding(2);
            picOpened.Name = "picOpened";
            picOpened.Size = new Size(160, 160);
            picOpened.SizeMode = PictureBoxSizeMode.StretchImage;
            picOpened.TabIndex = 5;
            picOpened.TabStop = false;
            // 
            // llblCourses
            // 
            llblCourses.AutoSize = true;
            llblCourses.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            llblCourses.Location = new Point(119, 119);
            llblCourses.Margin = new Padding(2, 0, 2, 0);
            llblCourses.Name = "llblCourses";
            llblCourses.Size = new Size(65, 18);
            llblCourses.TabIndex = 6;
            llblCourses.TabStop = true;
            llblCourses.Text = "Courses";
            llblCourses.LinkClicked += llblCourse_LinkClicked;
            // 
            // llblRegis
            // 
            llblRegis.AutoSize = true;
            llblRegis.Font = new Font("Microsoft Sans Serif", 8.999999F);
            llblRegis.Location = new Point(334, 119);
            llblRegis.Margin = new Padding(2, 0, 2, 0);
            llblRegis.Name = "llblRegis";
            llblRegis.Size = new Size(87, 18);
            llblRegis.TabIndex = 7;
            llblRegis.TabStop = true;
            llblRegis.Text = "Registration";
            llblRegis.LinkClicked += llblRegis_LinkClicked;
            // 
            // llblOpened
            // 
            llblOpened.AutoSize = true;
            llblOpened.Font = new Font("Microsoft Sans Serif", 8.999999F);
            llblOpened.Location = new Point(561, 119);
            llblOpened.Margin = new Padding(2, 0, 2, 0);
            llblOpened.Name = "llblOpened";
            llblOpened.Size = new Size(121, 18);
            llblOpened.TabIndex = 8;
            llblOpened.TabStop = true;
            llblOpened.Text = "Opened Subjects";
            llblOpened.LinkClicked += llblOpened_LinkClicked;
            // 
            // picStudent
            // 
            picStudent.Image = Properties.Resources.Student;
            picStudent.Location = new Point(80, 381);
            picStudent.Name = "picStudent";
            picStudent.Size = new Size(160, 160);
            picStudent.SizeMode = PictureBoxSizeMode.StretchImage;
            picStudent.TabIndex = 9;
            picStudent.TabStop = false;
            // 
            // linkStudent
            // 
            linkStudent.AutoSize = true;
            linkStudent.Font = new Font("Microsoft Sans Serif", 8.999999F);
            linkStudent.Location = new Point(119, 358);
            linkStudent.Name = "linkStudent";
            linkStudent.Size = new Size(60, 20);
            linkStudent.TabIndex = 10;
            linkStudent.TabStop = true;
            linkStudent.Text = "Student";
            linkStudent.LinkClicked += linkStudent_LinkClicked;
            // 
            // DashBoard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(838, 608);
            Controls.Add(linkStudent);
            Controls.Add(picStudent);
            Controls.Add(llblOpened);
            Controls.Add(llblRegis);
            Controls.Add(llblCourses);
            Controls.Add(picOpened);
            Controls.Add(picRegis);
            Controls.Add(picCourse);
            Controls.Add(pnlDSplit);
            Controls.Add(lblHeader);
            Controls.Add(pnlBar);
            Margin = new Padding(2);
            Name = "DashBoard";
            Text = "Dashboard";
            FormClosed += dshBoard_Closed;
            pnlBar.ResumeLayout(false);
            pnlBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picCourse).EndInit();
            ((System.ComponentModel.ISupportInitialize)picRegis).EndInit();
            ((System.ComponentModel.ISupportInitialize)picOpened).EndInit();
            ((System.ComponentModel.ISupportInitialize)picStudent).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlBar;
        private Label lblSlog;
        private LinkLabel lblSignOut;
        private Label lblHeader;
        private Panel pnlDSplit;
        private PictureBox picCourse;
        private PictureBox picRegis;
        private PictureBox picOpened;
        private LinkLabel llblCourses;
        private LinkLabel llblRegis;
        private LinkLabel llblOpened;
        private OracleDbConnection _connection;
        private PictureBox picStudent;
        private LinkLabel linkStudent;
    }
}
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
            picNotification = new PictureBox();
            lblNotification = new LinkLabel();
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
            ((System.ComponentModel.ISupportInitialize)picNotification).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCourse).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picRegis).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picOpened).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picStudent).BeginInit();
            SuspendLayout();
            // 
            // pnlBar
            // 
            pnlBar.BackColor = SystemColors.ActiveCaption;
            pnlBar.Controls.Add(picNotification);
            pnlBar.Controls.Add(lblNotification);
            pnlBar.Controls.Add(lblSignOut);
            pnlBar.Controls.Add(lblSlog);
            pnlBar.Dock = DockStyle.Top;
            pnlBar.Location = new Point(0, 0);
            pnlBar.Margin = new Padding(2, 2, 2, 2);
            pnlBar.Name = "pnlBar";
            pnlBar.Size = new Size(1048, 52);
            pnlBar.TabIndex = 0;
            // 
            // picNotification
            // 
            picNotification.Image = Properties.Resources.notification;
            picNotification.Location = new Point(840, 10);
            picNotification.Margin = new Padding(2, 2, 2, 2);
            picNotification.Name = "picNotification";
            picNotification.Size = new Size(32, 32);
            picNotification.SizeMode = PictureBoxSizeMode.StretchImage;
            picNotification.TabIndex = 3;
            picNotification.TabStop = false;
            picNotification.Click += picNotification_Click;
            // 
            // lblNotification
            // 
            lblNotification.AutoSize = true;
            lblNotification.Font = new Font("VNI-Korin", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNotification.Location = new Point(878, 10);
            lblNotification.Margin = new Padding(2, 0, 2, 0);
            lblNotification.Name = "lblNotification";
            lblNotification.Size = new Size(152, 30);
            lblNotification.TabIndex = 2;
            lblNotification.TabStop = true;
            lblNotification.Text = "Thông báo";
            lblNotification.LinkClicked += lblNotification_LinkClicked;
            // 
            // lblSignOut
            // 
            lblSignOut.AutoSize = true;
            lblSignOut.Font = new Font("VNI-Korin", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSignOut.Location = new Point(690, 10);
            lblSignOut.Margin = new Padding(2, 0, 2, 0);
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
            lblSlog.Font = new Font("VNI-Korin", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSlog.Location = new Point(11, 10);
            lblSlog.Margin = new Padding(2, 0, 2, 0);
            lblSlog.Name = "lblSlog";
            lblSlog.Size = new Size(276, 30);
            lblSlog.TabIndex = 0;
            lblSlog.Text = "Welcome to University X!";
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("VNI-Couri", 27.9999962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeader.Location = new Point(382, 56);
            lblHeader.Margin = new Padding(2, 0, 2, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(390, 71);
            lblHeader.TabIndex = 1;
            lblHeader.Text = "Dashboard";
            // 
            // pnlDSplit
            // 
            pnlDSplit.BackColor = SystemColors.Desktop;
            pnlDSplit.Dock = DockStyle.Top;
            pnlDSplit.Location = new Point(0, 52);
            pnlDSplit.Margin = new Padding(2, 2, 2, 2);
            pnlDSplit.Name = "pnlDSplit";
            pnlDSplit.Size = new Size(1048, 1);
            pnlDSplit.TabIndex = 2;
            // 
            // picCourse
            // 
            picCourse.Image = (Image)resources.GetObject("picCourse.Image");
            picCourse.Location = new Point(118, 179);
            picCourse.Margin = new Padding(2, 2, 2, 2);
            picCourse.Name = "picCourse";
            picCourse.Size = new Size(200, 200);
            picCourse.SizeMode = PictureBoxSizeMode.StretchImage;
            picCourse.TabIndex = 3;
            picCourse.TabStop = false;
            // 
            // picRegis
            // 
            picRegis.Image = (Image)resources.GetObject("picRegis.Image");
            picRegis.Location = new Point(435, 179);
            picRegis.Margin = new Padding(2, 2, 2, 2);
            picRegis.Name = "picRegis";
            picRegis.Size = new Size(200, 200);
            picRegis.SizeMode = PictureBoxSizeMode.StretchImage;
            picRegis.TabIndex = 4;
            picRegis.TabStop = false;
            // 
            // picOpened
            // 
            picOpened.Image = (Image)resources.GetObject("picOpened.Image");
            picOpened.Location = new Point(752, 179);
            picOpened.Margin = new Padding(2, 2, 2, 2);
            picOpened.Name = "picOpened";
            picOpened.Size = new Size(200, 200);
            picOpened.SizeMode = PictureBoxSizeMode.StretchImage;
            picOpened.TabIndex = 5;
            picOpened.TabStop = false;
            // 
            // llblCourses
            // 
            llblCourses.AutoSize = true;
            llblCourses.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            llblCourses.Location = new Point(174, 149);
            llblCourses.Margin = new Padding(2, 0, 2, 0);
            llblCourses.Name = "llblCourses";
            llblCourses.Size = new Size(87, 24);
            llblCourses.TabIndex = 6;
            llblCourses.TabStop = true;
            llblCourses.Text = "Courses";
            llblCourses.LinkClicked += llblCourse_LinkClicked;
            // 
            // llblRegis
            // 
            llblRegis.AutoSize = true;
            llblRegis.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            llblRegis.Location = new Point(464, 149);
            llblRegis.Margin = new Padding(2, 0, 2, 0);
            llblRegis.Name = "llblRegis";
            llblRegis.Size = new Size(142, 24);
            llblRegis.TabIndex = 7;
            llblRegis.TabStop = true;
            llblRegis.Text = "Registration";
            llblRegis.LinkClicked += llblRegis_LinkClicked;
            // 
            // llblOpened
            // 
            llblOpened.AutoSize = true;
            llblOpened.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            llblOpened.Location = new Point(764, 149);
            llblOpened.Margin = new Padding(2, 0, 2, 0);
            llblOpened.Name = "llblOpened";
            llblOpened.Size = new Size(175, 24);
            llblOpened.TabIndex = 8;
            llblOpened.TabStop = true;
            llblOpened.Text = "Opened Subjects";
            llblOpened.LinkClicked += llblOpened_LinkClicked;
            // 
            // picStudent
            // 
            picStudent.Image = Properties.Resources.Student;
            picStudent.Location = new Point(118, 476);
            picStudent.Margin = new Padding(4, 4, 4, 4);
            picStudent.Name = "picStudent";
            picStudent.Size = new Size(200, 200);
            picStudent.SizeMode = PictureBoxSizeMode.StretchImage;
            picStudent.TabIndex = 9;
            picStudent.TabStop = false;
            // 
            // linkStudent
            // 
            linkStudent.AutoSize = true;
            linkStudent.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkStudent.Location = new Point(174, 448);
            linkStudent.Margin = new Padding(4, 0, 4, 0);
            linkStudent.Name = "linkStudent";
            linkStudent.Size = new Size(87, 24);
            linkStudent.TabIndex = 10;
            linkStudent.TabStop = true;
            linkStudent.Text = "Student";
            linkStudent.LinkClicked += linkStudent_LinkClicked;
            // 
            // DashBoard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1048, 760);
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
            Margin = new Padding(2, 2, 2, 2);
            Name = "DashBoard";
            Text = "Dashboard";
            FormClosed += dshBoard_Closed;
            pnlBar.ResumeLayout(false);
            pnlBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picNotification).EndInit();
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
        private PictureBox picNotification;
        private LinkLabel lblNotification;
    }
}
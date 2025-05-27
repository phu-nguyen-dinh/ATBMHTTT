using OracleUserManager.Models;

namespace atbmcq_02
{
    partial class Teacher_DashBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Teacher_DashBoard));
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
            picInfor = new PictureBox();
            linkInfor = new LinkLabel();
            pictureBox1 = new PictureBox();
            linkStudent = new LinkLabel();
            picNotification = new PictureBox();
            lblNotification = new LinkLabel();
            pnlBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picCourse).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picRegis).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picOpened).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picInfor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picNotification).BeginInit();
            SuspendLayout();
            // 
            // pnlBar
            // 
            pnlBar.BackColor = SystemColors.ActiveCaption;
            pnlBar.Controls.Add(picNotification);
            pnlBar.Controls.Add(lblSignOut);
            pnlBar.Controls.Add(lblNotification);
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
            lblSignOut.Location = new Point(591, 8);
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
            lblSlog.Location = new Point(9, 8);
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
            lblHeader.Location = new Point(306, 45);
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
            picCourse.Location = new Point(94, 143);
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
            picRegis.Location = new Point(348, 143);
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
            picOpened.Location = new Point(602, 143);
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
            llblCourses.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            llblCourses.Location = new Point(139, 119);
            llblCourses.Margin = new Padding(2, 0, 2, 0);
            llblCourses.Name = "llblCourses";
            llblCourses.Size = new Size(72, 20);
            llblCourses.TabIndex = 6;
            llblCourses.TabStop = true;
            llblCourses.Text = "Courses";
            llblCourses.LinkClicked += llblCourse_LinkClicked;
            // 
            // llblRegis
            // 
            llblRegis.AutoSize = true;
            llblRegis.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            llblRegis.Location = new Point(371, 119);
            llblRegis.Margin = new Padding(2, 0, 2, 0);
            llblRegis.Name = "llblRegis";
            llblRegis.Size = new Size(117, 20);
            llblRegis.TabIndex = 7;
            llblRegis.TabStop = true;
            llblRegis.Text = "Registration";
            llblRegis.LinkClicked += llblRegis_LinkClicked;
            // 
            // llblOpened
            // 
            llblOpened.AutoSize = true;
            llblOpened.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            llblOpened.Location = new Point(611, 119);
            llblOpened.Margin = new Padding(2, 0, 2, 0);
            llblOpened.Name = "llblOpened";
            llblOpened.Size = new Size(144, 20);
            llblOpened.TabIndex = 8;
            llblOpened.TabStop = true;
            llblOpened.Text = "Opened Subjects";
            llblOpened.LinkClicked += llblOpened_LinkClicked;
            // 
            // picInfor
            // 
            picInfor.Image = Properties.Resources.Student;
            picInfor.Location = new Point(94, 381);
            picInfor.Name = "picInfor";
            picInfor.Size = new Size(160, 160);
            picInfor.SizeMode = PictureBoxSizeMode.StretchImage;
            picInfor.TabIndex = 9;
            picInfor.TabStop = false;
            // 
            // linkInfor
            // 
            linkInfor.AutoSize = true;
            linkInfor.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkInfor.Location = new Point(336, 359);
            linkInfor.Name = "linkInfor";
            linkInfor.Size = new Size(189, 20);
            linkInfor.TabIndex = 10;
            linkInfor.TabStop = true;
            linkInfor.Text = "Personal Information";
            linkInfor.LinkClicked += linkInfor_LinkClicked;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(348, 381);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(160, 160);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // linkStudent
            // 
            linkStudent.AutoSize = true;
            linkStudent.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkStudent.Location = new Point(139, 358);
            linkStudent.Name = "linkStudent";
            linkStudent.Size = new Size(72, 20);
            linkStudent.TabIndex = 12;
            linkStudent.TabStop = true;
            linkStudent.Text = "Student";
            linkStudent.LinkClicked += linkStudent_LinkClicked;
            // 
            // picNotification
            // 
            picNotification.Image = Properties.Resources.notification;
            picNotification.Location = new Point(694, 7);
            picNotification.Margin = new Padding(2);
            picNotification.Name = "picNotification";
            picNotification.Size = new Size(26, 26);
            picNotification.SizeMode = PictureBoxSizeMode.StretchImage;
            picNotification.TabIndex = 16;
            picNotification.TabStop = false;
            picNotification.Click += picNotification_Click;
            // 
            // lblNotification
            // 
            lblNotification.AutoSize = true;
            lblNotification.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNotification.Location = new Point(724, 8);
            lblNotification.Margin = new Padding(2, 0, 2, 0);
            lblNotification.Name = "lblNotification";
            lblNotification.Size = new Size(103, 24);
            lblNotification.TabIndex = 15;
            lblNotification.TabStop = true;
            lblNotification.Text = "Thông báo";
            lblNotification.LinkClicked += lblNotification_LinkClicked;
            // 
            // Teacher_DashBoard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(838, 608);
            Controls.Add(linkStudent);
            Controls.Add(pictureBox1);
            Controls.Add(linkInfor);
            Controls.Add(picInfor);
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
            Name = "Teacher_DashBoard";
            Text = "Dashboard";
            FormClosed += dshBoard_Closed;
            pnlBar.ResumeLayout(false);
            pnlBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picCourse).EndInit();
            ((System.ComponentModel.ISupportInitialize)picRegis).EndInit();
            ((System.ComponentModel.ISupportInitialize)picOpened).EndInit();
            ((System.ComponentModel.ISupportInitialize)picInfor).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picNotification).EndInit();
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
        private PictureBox picInfor;
        private LinkLabel linkInfor;
        private PictureBox pictureBox1;
        private LinkLabel linkStudent;
        private PictureBox picNotification;
        private LinkLabel lblNotification;
    }
}
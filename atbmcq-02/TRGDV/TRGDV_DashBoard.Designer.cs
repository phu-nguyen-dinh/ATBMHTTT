using OracleUserManager.Models;

namespace atbmcq_02
{
    partial class TRGDV_DashBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TRGDV_DashBoard));
            pnlBar = new Panel();
            lblSignOut = new LinkLabel();
            lblSlog = new Label();
            lblHeader = new Label();
            pnlDSplit = new Panel();
            picOpened = new PictureBox();
            llblOpened = new LinkLabel();
            linkInfor = new LinkLabel();
            pictureBox1 = new PictureBox();
            picNotification = new PictureBox();
            lblNotification = new LinkLabel();
            pnlBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picOpened).BeginInit();
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
            lblSignOut.Location = new Point(582, 9);
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
            // picOpened
            // 
            picOpened.Image = (Image)resources.GetObject("picOpened.Image");
            picOpened.Location = new Point(356, 143);
            picOpened.Margin = new Padding(2);
            picOpened.Name = "picOpened";
            picOpened.Size = new Size(160, 160);
            picOpened.SizeMode = PictureBoxSizeMode.StretchImage;
            picOpened.TabIndex = 5;
            picOpened.TabStop = false;
            // 
            // llblOpened
            // 
            llblOpened.AutoSize = true;
            llblOpened.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            llblOpened.Location = new Point(356, 119);
            llblOpened.Margin = new Padding(2, 0, 2, 0);
            llblOpened.Name = "llblOpened";
            llblOpened.Size = new Size(144, 20);
            llblOpened.TabIndex = 8;
            llblOpened.TabStop = true;
            llblOpened.Text = "Opened Subjects";
            llblOpened.LinkClicked += llblOpened_LinkClicked;
            // 
            // linkInfor
            // 
            linkInfor.AutoSize = true;
            linkInfor.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkInfor.Location = new Point(79, 119);
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
            pictureBox1.Location = new Point(94, 143);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(160, 160);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // picNotification
            // 
            picNotification.Image = Properties.Resources.notification;
            picNotification.Location = new Point(694, 8);
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
            lblNotification.Location = new Point(724, 9);
            lblNotification.Margin = new Padding(2, 0, 2, 0);
            lblNotification.Name = "lblNotification";
            lblNotification.Size = new Size(103, 24);
            lblNotification.TabIndex = 15;
            lblNotification.TabStop = true;
            lblNotification.Text = "Thông báo";
            lblNotification.LinkClicked += lblNotification_LinkClicked;
            // 
            // TRGDV_DashBoard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(838, 608);
            Controls.Add(pictureBox1);
            Controls.Add(linkInfor);
            Controls.Add(llblOpened);
            Controls.Add(picOpened);
            Controls.Add(pnlDSplit);
            Controls.Add(lblHeader);
            Controls.Add(pnlBar);
            Margin = new Padding(2);
            Name = "TRGDV_DashBoard";
            Text = "Dashboard";
            FormClosed += dshBoard_Closed;
            pnlBar.ResumeLayout(false);
            pnlBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picOpened).EndInit();
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
        private PictureBox picOpened;
        private LinkLabel llblOpened;
        private OracleDbConnection _connection;
        private LinkLabel linkInfor;
        private PictureBox pictureBox1;
        private PictureBox picNotification;
        private LinkLabel lblNotification;
    }
}
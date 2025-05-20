using OracleUserManager.Models;

namespace atbmcq_02
{
    partial class OpenedSubjects
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
            IDCourse = new DataGridViewTextBoxColumn();
            IDSubject = new DataGridViewTextBoxColumn();
            InCharge = new DataGridViewTextBoxColumn();
            Semester = new DataGridViewTextBoxColumn();
            Year = new DataGridViewTextBoxColumn();
            pnlBar = new Panel();
            lblBack = new LinkLabel();
            lblSignOut = new LinkLabel();
            lblSlog = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgvCourse).BeginInit();
            pnlBar.SuspendLayout();
            SuspendLayout();
            // 
            // dtgvCourse
            // 
            dtgvCourse.BackgroundColor = SystemColors.ButtonHighlight;
            dtgvCourse.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvCourse.Columns.AddRange(new DataGridViewColumn[] { IDCourse, IDSubject, InCharge, Semester, Year });
            dtgvCourse.Dock = DockStyle.Bottom;
            dtgvCourse.Location = new Point(0, 235);
            dtgvCourse.Margin = new Padding(5, 3, 5, 3);
            dtgvCourse.Name = "dtgvCourse";
            dtgvCourse.RowHeadersWidth = 62;
            dtgvCourse.Size = new Size(1279, 323);
            dtgvCourse.TabIndex = 1;
            // 
            // IDCourse
            // 
            IDCourse.HeaderText = "ID Course";
            IDCourse.MinimumWidth = 8;
            IDCourse.Name = "IDCourse";
            IDCourse.Width = 243;
            // 
            // IDSubject
            // 
            IDSubject.HeaderText = "ID Subject";
            IDSubject.MinimumWidth = 8;
            IDSubject.Name = "IDSubject";
            IDSubject.Width = 243;
            // 
            // InCharge
            // 
            InCharge.HeaderText = "In Charge";
            InCharge.MinimumWidth = 8;
            InCharge.Name = "InCharge";
            InCharge.Width = 243;
            // 
            // Semester
            // 
            Semester.HeaderText = "Semester";
            Semester.MinimumWidth = 8;
            Semester.Name = "Semester";
            Semester.Width = 243;
            // 
            // Year
            // 
            Year.HeaderText = "Year";
            Year.MinimumWidth = 8;
            Year.Name = "Year";
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
            pnlBar.Margin = new Padding(4, 3, 4, 3);
            pnlBar.Name = "pnlBar";
            pnlBar.Size = new Size(1279, 44);
            pnlBar.TabIndex = 3;
            // 
            // lblBack
            // 
            lblBack.AutoSize = true;
            lblBack.Font = new Font("VNI-Korin", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBack.Location = new Point(1103, 7);
            lblBack.Margin = new Padding(4, 0, 4, 0);
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
            lblSignOut.Location = new Point(1176, 7);
            lblSignOut.Margin = new Padding(4, 0, 4, 0);
            lblSignOut.Name = "lblSignOut";
            lblSignOut.Size = new Size(99, 30);
            lblSignOut.TabIndex = 1;
            lblSignOut.TabStop = true;
            lblSignOut.Text = "Sign out";
            // 
            // lblSlog
            // 
            lblSlog.AutoSize = true;
            lblSlog.Font = new Font("VNI-Diudang", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSlog.Location = new Point(4, 9);
            lblSlog.Margin = new Padding(4, 0, 4, 0);
            lblSlog.Name = "lblSlog";
            lblSlog.Size = new Size(211, 29);
            lblSlog.TabIndex = 0;
            lblSlog.Text = "Welcome to University X!";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("VNI-Couri", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(243, 95);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(793, 92);
            label1.TabIndex = 4;
            label1.Text = "Opened Subjects";
            // 
            // OpenedSubjects
            // 
            AutoScaleDimensions = new SizeF(13F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(pnlBar);
            Controls.Add(dtgvCourse);
            Font = new Font("VNI-Couri", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "OpenedSubjects";
            Size = new Size(1279, 558);
            ((System.ComponentModel.ISupportInitialize)dtgvCourse).EndInit();
            pnlBar.ResumeLayout(false);
            pnlBar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgvCourse;
        private Panel pnlBar;
        private LinkLabel lblBack;
        private LinkLabel lblSignOut;
        private Label lblSlog;
        private Label label1;
        private DataGridViewTextBoxColumn IDCourse;
        private DataGridViewTextBoxColumn IDSubject;
        private DataGridViewTextBoxColumn InCharge;
        private DataGridViewTextBoxColumn Semester;
        private DataGridViewTextBoxColumn Year;
        private OracleDbConnection _connection;
    }
}

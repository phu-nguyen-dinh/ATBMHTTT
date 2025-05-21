using OracleUserManager.Models;

namespace atbmcq_02
{
    partial class Student
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
            lblStudent = new Label();
            pnlBar = new Panel();
            lblBack = new LinkLabel();
            lblSignOut = new LinkLabel();
            lblSlog = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dtgvStudent1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            CName = new DataGridViewTextBoxColumn();
            Gender = new DataGridViewTextBoxColumn();
            Birthday = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            PhoneNumber = new DataGridViewTextBoxColumn();
            Department = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            tabPage2 = new TabPage();
            dtgvStudent2 = new DataGridView();
            DK_IDStudent = new DataGridViewTextBoxColumn();
            DK_IDSubject = new DataGridViewTextBoxColumn();
            DK_ps = new DataGridViewTextBoxColumn();
            DK_processS = new DataGridViewTextBoxColumn();
            DK_Fs = new DataGridViewTextBoxColumn();
            DK_SS = new DataGridViewTextBoxColumn();
            pnlBar.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvStudent1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvStudent2).BeginInit();
            SuspendLayout();
            // 
            // lblStudent
            // 
            lblStudent.AutoSize = true;
            lblStudent.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStudent.Location = new Point(505, 137);
            lblStudent.Name = "lblStudent";
            lblStudent.Size = new Size(243, 69);
            lblStudent.TabIndex = 1;
            lblStudent.Text = "Student";
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
            pnlBar.Size = new Size(1648, 59);
            pnlBar.TabIndex = 2;
            // 
            // lblBack
            // 
            lblBack.AutoSize = true;
            lblBack.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBack.Location = new Point(1239, 8);
            lblBack.Name = "lblBack";
            lblBack.Size = new Size(51, 24);
            lblBack.TabIndex = 2;
            lblBack.TabStop = true;
            lblBack.Text = "Back";
            // 
            // lblSignOut
            // 
            lblSignOut.AutoSize = true;
            lblSignOut.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSignOut.Location = new Point(1310, 8);
            lblSignOut.Name = "lblSignOut";
            lblSignOut.Size = new Size(79, 24);
            lblSignOut.TabIndex = 1;
            lblSignOut.TabStop = true;
            lblSignOut.Text = "Sign out";
            // 
            // lblSlog
            // 
            lblSlog.AutoSize = true;
            lblSlog.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSlog.Location = new Point(3, 10);
            lblSlog.Name = "lblSlog";
            lblSlog.Size = new Size(220, 24);
            lblSlog.TabIndex = 0;
            lblSlog.Text = "Welcome to University X!";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(3, 65);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1645, 788);
            tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dtgvStudent1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1637, 755);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Thông tin sinh viên";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dtgvStudent
            // 
            dtgvStudent1.BackgroundColor = SystemColors.ButtonHighlight;
            dtgvStudent1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvStudent1.Columns.AddRange(new DataGridViewColumn[] { ID, CName, Gender, Birthday, Address, PhoneNumber, Department, Status });
            dtgvStudent1.Dock = DockStyle.Bottom;
            dtgvStudent1.Location = new Point(3, 313);
            dtgvStudent1.Name = "dtgvStudent";
            dtgvStudent1.RowHeadersWidth = 62;
            dtgvStudent1.Size = new Size(1631, 439);
            dtgvStudent1.TabIndex = 1;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 8;
            ID.Name = "ID";
            ID.Width = 150;
            // 
            // CName
            // 
            CName.HeaderText = "Name";
            CName.MinimumWidth = 8;
            CName.Name = "CName";
            CName.Width = 228;
            // 
            // Gender
            // 
            Gender.HeaderText = "Gender";
            Gender.MinimumWidth = 8;
            Gender.Name = "Gender";
            Gender.Width = 224;
            // 
            // Birthday
            // 
            Birthday.HeaderText = "Birthday";
            Birthday.MinimumWidth = 8;
            Birthday.Name = "Birthday";
            Birthday.Width = 224;
            // 
            // Address
            // 
            Address.HeaderText = "Address";
            Address.MinimumWidth = 8;
            Address.Name = "Address";
            Address.Width = 224;
            // 
            // PhoneNumber
            // 
            PhoneNumber.HeaderText = "Phone Number";
            PhoneNumber.MinimumWidth = 8;
            PhoneNumber.Name = "PhoneNumber";
            PhoneNumber.Width = 224;
            // 
            // Department
            // 
            Department.HeaderText = "Department";
            Department.MinimumWidth = 6;
            Department.Name = "Department";
            Department.Width = 200;
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            Status.Width = 200;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dtgvStudent2);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1637, 755);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Thông tin đăng ký";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dtgvStudent2
            // 
            dtgvStudent2.BackgroundColor = SystemColors.ButtonHighlight;
            dtgvStudent2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvStudent2.Columns.AddRange(new DataGridViewColumn[] { DK_IDStudent, DK_IDSubject, DK_ps, DK_processS, DK_Fs, DK_SS });
            dtgvStudent2.Dock = DockStyle.Bottom;
            dtgvStudent2.Location = new Point(3, 313);
            dtgvStudent2.Name = "dataGridView1";
            dtgvStudent2.RowHeadersWidth = 62;
            dtgvStudent2.Size = new Size(1631, 439);
            dtgvStudent2.TabIndex = 2;
            // 
            // DK_IDStudent
            // 
            DK_IDStudent.HeaderText = "ID_Student";
            DK_IDStudent.MinimumWidth = 8;
            DK_IDStudent.Name = "DK_IDStudent";
            DK_IDStudent.Width = 150;
            // 
            // DK_IDSubject
            // 
            DK_IDSubject.HeaderText = "ID_Subject";
            DK_IDSubject.MinimumWidth = 8;
            DK_IDSubject.Name = "DK_IDSubject";
            DK_IDSubject.Width = 228;
            // 
            // DK_ps
            // 
            DK_ps.HeaderText = "Practice score";
            DK_ps.MinimumWidth = 8;
            DK_ps.Name = "DK_ps";
            DK_ps.Width = 224;
            // 
            // DK_processS
            // 
            DK_processS.HeaderText = "Process score";
            DK_processS.MinimumWidth = 8;
            DK_processS.Name = "DK_processS";
            DK_processS.Width = 224;
            // 
            // DK_Fs
            // 
            DK_Fs.HeaderText = "Final score";
            DK_Fs.MinimumWidth = 8;
            DK_Fs.Name = "DK_Fs";
            DK_Fs.Width = 224;
            // 
            // DK_SS
            // 
            DK_SS.HeaderText = "Sumary Score";
            DK_SS.MinimumWidth = 6;
            DK_SS.Name = "DK_SS";
            DK_SS.Width = 200;
            // 
            // Student
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1648, 850);
            Controls.Add(tabControl1);
            Controls.Add(pnlBar);
            Controls.Add(lblStudent);
            Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Student";
            pnlBar.ResumeLayout(false);
            pnlBar.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvStudent1).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvStudent2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblStudent;
        private Panel pnlBar;
        private LinkLabel lblBack;
        private LinkLabel lblSignOut;
        private Label lblSlog;
        private OracleDbConnection _connection;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView dtgvStudent1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn CName;
        private DataGridViewTextBoxColumn Gender;
        private DataGridViewTextBoxColumn Birthday;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn PhoneNumber;
        private DataGridViewTextBoxColumn Department;
        private DataGridViewTextBoxColumn Status;
        private DataGridView dtgvStudent2;
        private DataGridViewTextBoxColumn DK_IDStudent;
        private DataGridViewTextBoxColumn DK_IDSubject;
        private DataGridViewTextBoxColumn DK_ps;
        private DataGridViewTextBoxColumn DK_processS;
        private DataGridViewTextBoxColumn DK_Fs;
        private DataGridViewTextBoxColumn DK_SS;
    }
}

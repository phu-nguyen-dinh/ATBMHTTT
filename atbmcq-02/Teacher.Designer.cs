using OracleUserManager.Models;

namespace atbmcq_02
{
    partial class Teacher
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
            lblTeacher = new Label();
            pnlBar = new Panel();
            lblBack = new LinkLabel();
            lblSignOut = new LinkLabel();
            lblSlog = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dtgvTeacher = new DataGridView();
            tabPage2 = new TabPage();
            dtgvStudent1 = new DataGridView();
            GV_ID = new DataGridViewTextBoxColumn();
            GV_Name = new DataGridViewTextBoxColumn();
            GV_Gender = new DataGridViewTextBoxColumn();
            GV_Birthday = new DataGridViewTextBoxColumn();
            GV_Address = new DataGridViewTextBoxColumn();
            GV_Bonus = new DataGridViewTextBoxColumn();
            GV_PhoneNumber = new DataGridViewTextBoxColumn();
            GV_Role = new DataGridViewTextBoxColumn();
            GV_Unit = new DataGridViewTextBoxColumn();
            ID = new DataGridViewTextBoxColumn();
            CName = new DataGridViewTextBoxColumn();
            Genre = new DataGridViewTextBoxColumn();
            Birthday = new DataGridViewTextBoxColumn();
            Adddress = new DataGridViewTextBoxColumn();
            PhoneNum = new DataGridViewTextBoxColumn();
            Department = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            pnlBar.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvTeacher).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvStudent1).BeginInit();
            SuspendLayout();
            // 
            // lblTeacher
            // 
            lblTeacher.AutoSize = true;
            lblTeacher.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTeacher.Location = new Point(602, 81);
            lblTeacher.Name = "lblTeacher";
            lblTeacher.Size = new Size(256, 69);
            lblTeacher.TabIndex = 1;
            lblTeacher.Text = "Teacher";
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
            pnlBar.Size = new Size(1394, 59);
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
            lblBack.LinkClicked += lblBack_LinkClicked;
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
            lblSignOut.LinkClicked += lblSignOut_LinkClicked;
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
            tabControl1.Location = new Point(0, 186);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1394, 531);
            tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dtgvTeacher);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1386, 498);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Thông tin sinh viên cùng khoa";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dtgvTeacher.BackgroundColor = SystemColors.ButtonHighlight;
            dtgvTeacher.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvTeacher.Columns.AddRange(new DataGridViewColumn[] { ID, CName, Genre, Birthday, Adddress, PhoneNum, Department, Status });
            dtgvTeacher.Dock = DockStyle.Bottom;
            dtgvTeacher.Location = new Point(3, 113);
            dtgvTeacher.Name = "dtgvTeacher";
            dtgvTeacher.RowHeadersWidth = 62;
            dtgvTeacher.Size = new Size(1380, 382);
            dtgvTeacher.TabIndex = 4;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dtgvStudent1);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1386, 498);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Thông tin giáo viên";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dtgvStudent1
            // 
            dtgvStudent1.BackgroundColor = SystemColors.ButtonHighlight;
            dtgvStudent1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvStudent1.Columns.AddRange(new DataGridViewColumn[] { GV_ID, GV_Name, GV_Gender, GV_Birthday, GV_Address, GV_Bonus, GV_PhoneNumber, GV_Role, GV_Unit });
            dtgvStudent1.Dock = DockStyle.Bottom;
            dtgvStudent1.Location = new Point(3, 113);
            dtgvStudent1.Name = "dtgvStudent1";
            dtgvStudent1.RowHeadersWidth = 62;
            dtgvStudent1.Size = new Size(1380, 382);
            dtgvStudent1.TabIndex = 4;
            // 
            // GV_ID
            // 
            GV_ID.HeaderText = "ID";
            GV_ID.MinimumWidth = 8;
            GV_ID.Name = "GV_ID";
            GV_ID.Width = 150;
            // 
            // GV_Name
            // 
            GV_Name.HeaderText = "Name";
            GV_Name.MinimumWidth = 8;
            GV_Name.Name = "GV_Name";
            GV_Name.Width = 228;
            // 
            // GV_Gender
            // 
            GV_Gender.HeaderText = "Gender";
            GV_Gender.MinimumWidth = 8;
            GV_Gender.Name = "GV_Gender";
            GV_Gender.Width = 224;
            // 
            // GV_Birthday
            // 
            GV_Birthday.HeaderText = "Birthday";
            GV_Birthday.MinimumWidth = 8;
            GV_Birthday.Name = "GV_Birthday";
            GV_Birthday.Width = 224;
            // 
            // GV_Address
            // 
            GV_Address.HeaderText = "Salary";
            GV_Address.MinimumWidth = 8;
            GV_Address.Name = "GV_Address";
            GV_Address.Width = 224;
            // 
            // GV_Bonus
            // 
            GV_Bonus.HeaderText = "Bonus";
            GV_Bonus.MinimumWidth = 6;
            GV_Bonus.Name = "GV_Bonus";
            GV_Bonus.Width = 125;
            // 
            // GV_PhoneNumber
            // 
            GV_PhoneNumber.HeaderText = "Phone Number";
            GV_PhoneNumber.MinimumWidth = 8;
            GV_PhoneNumber.Name = "GV_PhoneNumber";
            GV_PhoneNumber.Width = 224;
            // 
            // GV_Role
            // 
            GV_Role.HeaderText = "Role";
            GV_Role.MinimumWidth = 6;
            GV_Role.Name = "GV_Role";
            GV_Role.Width = 125;
            // 
            // GV_Unit
            // 
            GV_Unit.HeaderText = "Unit";
            GV_Unit.MinimumWidth = 6;
            GV_Unit.Name = "GV_Unit";
            GV_Unit.Width = 200;
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
            CName.HeaderText = "CName";
            CName.MinimumWidth = 8;
            CName.Name = "Name";
            CName.Width = 228;
            // 
            // Genre
            // 
            Genre.HeaderText = "Gender";
            Genre.MinimumWidth = 8;
            Genre.Name = "Genre";
            Genre.Width = 224;
            // 
            // Birthday
            // 
            Birthday.HeaderText = "Birthday";
            Birthday.MinimumWidth = 8;
            Birthday.Name = "Birthday";
            Birthday.Width = 224;
            // 
            // Adddress
            // 
            Adddress.HeaderText = "Address";
            Adddress.MinimumWidth = 8;
            Adddress.Name = "Adddress";
            Adddress.Width = 224;
            // 
            // PhoneNum
            // 
            PhoneNum.HeaderText = "Phone Number";
            PhoneNum.MinimumWidth = 8;
            PhoneNum.Name = "PhoneNum";
            PhoneNum.Width = 224;
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
            // Teacher
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            Size = new Size(1394, 712);
            Controls.Add(tabControl1);
            Controls.Add(pnlBar);
            Controls.Add(lblTeacher);
            Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Teacher";
            pnlBar.ResumeLayout(false);
            pnlBar.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvTeacher).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvStudent1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblTeacher;
        private Panel pnlBar;
        private LinkLabel lblBack;
        private LinkLabel lblSignOut;
        private Label lblSlog;
        private OracleDbConnection _connection;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private DataGridView dtgvTeacher;
        private TabPage tabPage2;
        private DataGridView dtgvStudent1;
        private DataGridViewTextBoxColumn GV_ID;
        private DataGridViewTextBoxColumn GV_Name;
        private DataGridViewTextBoxColumn GV_Gender;
        private DataGridViewTextBoxColumn GV_Birthday;
        private DataGridViewTextBoxColumn GV_Address;
        private DataGridViewTextBoxColumn GV_Bonus;
        private DataGridViewTextBoxColumn GV_PhoneNumber;
        private DataGridViewTextBoxColumn GV_Role;
        private DataGridViewTextBoxColumn GV_Unit;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn CName;
        private DataGridViewTextBoxColumn Genre;
        private DataGridViewTextBoxColumn Birthday;
        private DataGridViewTextBoxColumn Adddress;
        private DataGridViewTextBoxColumn PhoneNum;
        private DataGridViewTextBoxColumn Department;
        private DataGridViewTextBoxColumn Status;
    }
}

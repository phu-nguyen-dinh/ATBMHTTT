using OracleUserManager.Models;

namespace atbmcq_02
{
    partial class Official
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
            dtgvStudent = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            CName = new DataGridViewTextBoxColumn();
            Genre = new DataGridViewTextBoxColumn();
            Birthday = new DataGridViewTextBoxColumn();
            Adddress = new DataGridViewTextBoxColumn();
            PhoneNum = new DataGridViewTextBoxColumn();
            Department = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            lblOfficial = new Label();
            pnlBar = new Panel();
            lblBack = new LinkLabel();
            lblSignOut = new LinkLabel();
            lblSlog = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            buttonXOA = new Button();
            buttonSUA = new Button();
            buttonTHEM = new Button();
            tabPage2 = new TabPage();
            dtgvOfficial = new DataGridView();
            GV_ID = new DataGridViewTextBoxColumn();
            GV_Name = new DataGridViewTextBoxColumn();
            GV_Gender = new DataGridViewTextBoxColumn();
            GV_Birthday = new DataGridViewTextBoxColumn();
            GV_Address = new DataGridViewTextBoxColumn();
            GV_Bonus = new DataGridViewTextBoxColumn();
            GV_PhoneNumber = new DataGridViewTextBoxColumn();
            GV_Role = new DataGridViewTextBoxColumn();
            GV_Unit = new DataGridViewTextBoxColumn();
            btnEditPhone = new Button();
            lblNewPhone = new Label();
            txtNewPhone = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dtgvStudent).BeginInit();
            pnlBar.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvOfficial).BeginInit();
            SuspendLayout();
            // 
            // dtgvStudent
            // 
            dtgvStudent.BackgroundColor = SystemColors.ButtonHighlight;
            dtgvStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvStudent.Columns.AddRange(new DataGridViewColumn[] { ID, CName, Genre, Birthday, Adddress, PhoneNum, Department, Status });
            dtgvStudent.Dock = DockStyle.Bottom;
            dtgvStudent.Location = new Point(3, 113);
            dtgvStudent.Name = "dtgvStudent";
            dtgvStudent.RowHeadersWidth = 62;
            dtgvStudent.Size = new Size(1380, 382);
            dtgvStudent.TabIndex = 4;
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
            CName.Name = "CName";
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
            // lblOfficial
            // 
            lblOfficial.AutoSize = true;
            lblOfficial.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOfficial.Location = new Point(602, 81);
            lblOfficial.Name = "lblOfficial";
            lblOfficial.Size = new Size(221, 69);
            lblOfficial.TabIndex = 1;
            lblOfficial.Text = "Official";
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
            tabPage1.Controls.Add(buttonXOA);
            tabPage1.Controls.Add(buttonSUA);
            tabPage1.Controls.Add(buttonTHEM);
            tabPage1.Controls.Add(dtgvStudent);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1386, 498);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Thông tin sinh viên có thể xem";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonXOA
            // 
            buttonXOA.BackColor = Color.Red;
            buttonXOA.Location = new Point(1217, 64);
            buttonXOA.Name = "buttonXOA";
            buttonXOA.Size = new Size(94, 29);
            buttonXOA.TabIndex = 7;
            buttonXOA.Text = "DELETE";
            buttonXOA.UseVisualStyleBackColor = false;
            // 
            // buttonSUA
            // 
            buttonSUA.BackColor = Color.Yellow;
            buttonSUA.Location = new Point(1091, 64);
            buttonSUA.Name = "buttonSUA";
            buttonSUA.Size = new Size(94, 29);
            buttonSUA.TabIndex = 6;
            buttonSUA.Text = "UPDATE";
            buttonSUA.UseVisualStyleBackColor = false;
            buttonSUA.Click += buttonSUA_Click;
            // 
            // buttonTHEM
            // 
            buttonTHEM.BackColor = Color.Lime;
            buttonTHEM.Location = new Point(960, 64);
            buttonTHEM.Name = "buttonTHEM";
            buttonTHEM.Size = new Size(94, 29);
            buttonTHEM.TabIndex = 5;
            buttonTHEM.Text = "ADD";
            buttonTHEM.UseVisualStyleBackColor = false;
            buttonTHEM.Click += ButtonTHEM_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnEditPhone);
            tabPage2.Controls.Add(lblNewPhone);
            tabPage2.Controls.Add(txtNewPhone);
            tabPage2.Controls.Add(dtgvOfficial);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1386, 498);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Thông tin cá nhân";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dtgvOfficial
            // 
            dtgvOfficial.BackgroundColor = SystemColors.ButtonHighlight;
            dtgvOfficial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvOfficial.Columns.AddRange(new DataGridViewColumn[] { GV_ID, GV_Name, GV_Gender, GV_Birthday, GV_Address, GV_Bonus, GV_PhoneNumber, GV_Role, GV_Unit });
            dtgvOfficial.Dock = DockStyle.Bottom;
            dtgvOfficial.Location = new Point(3, 113);
            dtgvOfficial.Name = "dtgvOfficial";
            dtgvOfficial.RowHeadersWidth = 62;
            dtgvOfficial.Size = new Size(1380, 382);
            dtgvOfficial.TabIndex = 4;
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
            // btnEditPhone
            // 
            btnEditPhone.Location = new Point(368, 65);
            btnEditPhone.Name = "btnEditPhone";
            btnEditPhone.Size = new Size(133, 29);
            btnEditPhone.TabIndex = 13;
            btnEditPhone.Text = "Cập nhật SĐT";
            btnEditPhone.UseVisualStyleBackColor = true;
            btnEditPhone.Click += btnEditPhone_Click;
            // 
            // lblNewPhone
            // 
            lblNewPhone.AutoSize = true;
            lblNewPhone.Location = new Point(47, 69);
            lblNewPhone.Name = "lblNewPhone";
            lblNewPhone.Size = new Size(81, 20);
            lblNewPhone.TabIndex = 12;
            lblNewPhone.Text = "SĐT mới:";
            // 
            // txtNewPhone
            // 
            txtNewPhone.Location = new Point(159, 66);
            txtNewPhone.Name = "txtNewPhone";
            txtNewPhone.Size = new Size(184, 25);
            txtNewPhone.TabIndex = 11;
            // 
            // Official
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            Controls.Add(tabControl1);
            Controls.Add(pnlBar);
            Controls.Add(lblOfficial);
            Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Official";
            Size = new Size(1394, 712);
            ((System.ComponentModel.ISupportInitialize)dtgvStudent).EndInit();
            pnlBar.ResumeLayout(false);
            pnlBar.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvOfficial).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblOfficial;
        private Panel pnlBar;
        private LinkLabel lblBack;
        private LinkLabel lblSignOut;
        private Label lblSlog;
        private OracleDbConnection _connection;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private DataGridView dtgvStudent;
        private TabPage tabPage2;
        private DataGridView dtgvOfficial;
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
        private Button buttonXOA;
        private Button buttonSUA;
        private Button buttonTHEM;
        private Button btnEditPhone;
        private Label lblNewPhone;
        private TextBox txtNewPhone;
    }
}

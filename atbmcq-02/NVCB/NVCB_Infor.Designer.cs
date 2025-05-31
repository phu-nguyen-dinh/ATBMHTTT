using OracleUserManager.Models;

namespace atbmcq_02
{
    partial class NVCB_Infor
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
            lblOfficial = new Label();
            pnlBar = new Panel();
            lblBack = new LinkLabel();
            lblSignOut = new LinkLabel();
            lblSlog = new Label();
            tabPage2 = new TabPage();
            pnlPersonalInfo = new Panel();
            lblUnit = new Label();
            txtUnit = new TextBox();
            lblRole = new Label();
            txtRole = new TextBox();
            lblPhone = new Label();
            txtPhone = new TextBox();
            lblBonus = new Label();
            txtBonus = new TextBox();
            lblSalary = new Label();
            txtSalary = new TextBox();
            lblBirthday = new Label();
            txtBirthday = new TextBox();
            lblGender = new Label();
            txtGender = new TextBox();
            lblName = new Label();
            txtName = new TextBox();
            lblID = new Label();
            txtID = new TextBox();
            pnlUpdatePhone = new Panel();
            btnEditPhone = new Button();
            lblNewPhone = new Label();
            txtNewPhone = new TextBox();
            tabControl1 = new TabControl();
            pnlBar.SuspendLayout();
            tabPage2.SuspendLayout();
            pnlPersonalInfo.SuspendLayout();
            pnlUpdatePhone.SuspendLayout();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // lblOfficial
            // 
            lblOfficial.AutoSize = true;
            lblOfficial.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOfficial.Location = new Point(424, 87);
            lblOfficial.Name = "lblOfficial";
            lblOfficial.Size = new Size(600, 69);
            lblOfficial.TabIndex = 1;
            lblOfficial.Text = "Personal Information";
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
            // tabPage2
            // 
            tabPage2.Controls.Add(pnlPersonalInfo);
            tabPage2.Controls.Add(pnlUpdatePhone);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1386, 498);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Thông tin cá nhân";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // pnlPersonalInfo
            // 
            pnlPersonalInfo.BackColor = Color.WhiteSmoke;
            pnlPersonalInfo.BorderStyle = BorderStyle.FixedSingle;
            pnlPersonalInfo.Controls.Add(lblUnit);
            pnlPersonalInfo.Controls.Add(txtUnit);
            pnlPersonalInfo.Controls.Add(lblRole);
            pnlPersonalInfo.Controls.Add(txtRole);
            pnlPersonalInfo.Controls.Add(lblPhone);
            pnlPersonalInfo.Controls.Add(txtPhone);
            pnlPersonalInfo.Controls.Add(lblBonus);
            pnlPersonalInfo.Controls.Add(txtBonus);
            pnlPersonalInfo.Controls.Add(lblSalary);
            pnlPersonalInfo.Controls.Add(txtSalary);
            pnlPersonalInfo.Controls.Add(lblBirthday);
            pnlPersonalInfo.Controls.Add(txtBirthday);
            pnlPersonalInfo.Controls.Add(lblGender);
            pnlPersonalInfo.Controls.Add(txtGender);
            pnlPersonalInfo.Controls.Add(lblName);
            pnlPersonalInfo.Controls.Add(txtName);
            pnlPersonalInfo.Controls.Add(lblID);
            pnlPersonalInfo.Controls.Add(txtID);
            pnlPersonalInfo.Location = new Point(47, 120);
            pnlPersonalInfo.Name = "pnlPersonalInfo";
            pnlPersonalInfo.Size = new Size(1293, 363);
            pnlPersonalInfo.TabIndex = 14;
            // 
            // lblUnit
            // 
            lblUnit.AutoSize = true;
            lblUnit.Font = new Font("Cascadia Code", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUnit.Location = new Point(666, 290);
            lblUnit.Name = "lblUnit";
            lblUnit.Size = new Size(60, 22);
            lblUnit.TabIndex = 17;
            lblUnit.Text = "Unit:";
            // 
            // txtUnit
            // 
            txtUnit.BackColor = Color.White;
            txtUnit.Font = new Font("Cascadia Code", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUnit.Location = new Point(837, 287);
            txtUnit.Name = "txtUnit";
            txtUnit.ReadOnly = true;
            txtUnit.Size = new Size(371, 27);
            txtUnit.TabIndex = 16;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Cascadia Code", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRole.Location = new Point(666, 230);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(60, 22);
            lblRole.TabIndex = 15;
            lblRole.Text = "Role:";
            // 
            // txtRole
            // 
            txtRole.BackColor = Color.White;
            txtRole.Font = new Font("Cascadia Code", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRole.Location = new Point(837, 227);
            txtRole.Name = "txtRole";
            txtRole.ReadOnly = true;
            txtRole.Size = new Size(371, 27);
            txtRole.TabIndex = 14;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Cascadia Code", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPhone.Location = new Point(666, 170);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(140, 22);
            lblPhone.TabIndex = 13;
            lblPhone.Text = "Phone Number:";
            // 
            // txtPhone
            // 
            txtPhone.BackColor = Color.White;
            txtPhone.Font = new Font("Cascadia Code", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhone.Location = new Point(837, 167);
            txtPhone.Name = "txtPhone";
            txtPhone.ReadOnly = true;
            txtPhone.Size = new Size(371, 27);
            txtPhone.TabIndex = 12;
            // 
            // lblBonus
            // 
            lblBonus.AutoSize = true;
            lblBonus.Font = new Font("Cascadia Code", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBonus.Location = new Point(666, 110);
            lblBonus.Name = "lblBonus";
            lblBonus.Size = new Size(70, 22);
            lblBonus.TabIndex = 11;
            lblBonus.Text = "Bonus:";
            // 
            // txtBonus
            // 
            txtBonus.BackColor = Color.White;
            txtBonus.Font = new Font("Cascadia Code", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBonus.Location = new Point(837, 107);
            txtBonus.Name = "txtBonus";
            txtBonus.ReadOnly = true;
            txtBonus.Size = new Size(371, 27);
            txtBonus.TabIndex = 10;
            // 
            // lblSalary
            // 
            lblSalary.AutoSize = true;
            lblSalary.Font = new Font("Cascadia Code", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSalary.Location = new Point(666, 50);
            lblSalary.Name = "lblSalary";
            lblSalary.Size = new Size(80, 22);
            lblSalary.TabIndex = 9;
            lblSalary.Text = "Salary:";
            // 
            // txtSalary
            // 
            txtSalary.BackColor = Color.White;
            txtSalary.Font = new Font("Cascadia Code", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSalary.Location = new Point(837, 47);
            txtSalary.Name = "txtSalary";
            txtSalary.ReadOnly = true;
            txtSalary.Size = new Size(371, 27);
            txtSalary.TabIndex = 8;
            // 
            // lblBirthday
            // 
            lblBirthday.AutoSize = true;
            lblBirthday.Font = new Font("Cascadia Code", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBirthday.Location = new Point(85, 230);
            lblBirthday.Name = "lblBirthday";
            lblBirthday.Size = new Size(100, 22);
            lblBirthday.TabIndex = 7;
            lblBirthday.Text = "Birthday:";
            // 
            // txtBirthday
            // 
            txtBirthday.BackColor = Color.White;
            txtBirthday.Font = new Font("Cascadia Code", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBirthday.Location = new Point(256, 227);
            txtBirthday.Name = "txtBirthday";
            txtBirthday.ReadOnly = true;
            txtBirthday.Size = new Size(371, 27);
            txtBirthday.TabIndex = 6;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Cascadia Code", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGender.Location = new Point(85, 170);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(80, 22);
            lblGender.TabIndex = 5;
            lblGender.Text = "Gender:";
            // 
            // txtGender
            // 
            txtGender.BackColor = Color.White;
            txtGender.Font = new Font("Cascadia Code", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtGender.Location = new Point(256, 167);
            txtGender.Name = "txtGender";
            txtGender.ReadOnly = true;
            txtGender.Size = new Size(371, 27);
            txtGender.TabIndex = 4;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Cascadia Code", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName.Location = new Point(85, 110);
            lblName.Name = "lblName";
            lblName.Size = new Size(60, 22);
            lblName.TabIndex = 3;
            lblName.Text = "Name:";
            // 
            // txtName
            // 
            txtName.BackColor = Color.White;
            txtName.Font = new Font("Cascadia Code", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(256, 107);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(371, 27);
            txtName.TabIndex = 2;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Cascadia Code", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblID.Location = new Point(85, 50);
            lblID.Name = "lblID";
            lblID.Size = new Size(40, 22);
            lblID.TabIndex = 1;
            lblID.Text = "ID:";
            // 
            // txtID
            // 
            txtID.BackColor = Color.White;
            txtID.Font = new Font("Cascadia Code", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtID.Location = new Point(256, 47);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(371, 27);
            txtID.TabIndex = 0;
            // 
            // pnlUpdatePhone
            // 
            pnlUpdatePhone.BackColor = Color.LightSteelBlue;
            pnlUpdatePhone.BorderStyle = BorderStyle.FixedSingle;
            pnlUpdatePhone.Controls.Add(btnEditPhone);
            pnlUpdatePhone.Controls.Add(lblNewPhone);
            pnlUpdatePhone.Controls.Add(txtNewPhone);
            pnlUpdatePhone.Location = new Point(47, 23);
            pnlUpdatePhone.Name = "pnlUpdatePhone";
            pnlUpdatePhone.Size = new Size(542, 75);
            pnlUpdatePhone.TabIndex = 15;
            // 
            // btnEditPhone
            // 
            btnEditPhone.BackColor = Color.RoyalBlue;
            btnEditPhone.FlatStyle = FlatStyle.Flat;
            btnEditPhone.Font = new Font("Cascadia Code", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditPhone.ForeColor = Color.White;
            btnEditPhone.Location = new Point(389, 22);
            btnEditPhone.Name = "btnEditPhone";
            btnEditPhone.Size = new Size(133, 29);
            btnEditPhone.TabIndex = 13;
            btnEditPhone.Text = "Cập nhật SĐT";
            btnEditPhone.UseVisualStyleBackColor = false;
            btnEditPhone.Click += btnEditPhone_Click;
            // 
            // lblNewPhone
            // 
            lblNewPhone.AutoSize = true;
            lblNewPhone.Font = new Font("Cascadia Code", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNewPhone.Location = new Point(14, 26);
            lblNewPhone.Name = "lblNewPhone";
            lblNewPhone.Size = new Size(81, 20);
            lblNewPhone.TabIndex = 12;
            lblNewPhone.Text = "SĐT mới:";
            // 
            // txtNewPhone
            // 
            txtNewPhone.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNewPhone.Location = new Point(112, 23);
            txtNewPhone.Name = "txtNewPhone";
            txtNewPhone.Size = new Size(260, 25);
            txtNewPhone.TabIndex = 11;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(0, 186);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1394, 531);
            tabControl1.TabIndex = 4;
            // 
            // NVCB_Infor
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            Controls.Add(tabControl1);
            Controls.Add(pnlBar);
            Controls.Add(lblOfficial);
            Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "NVCB_Infor";
            Size = new Size(1394, 712);
            pnlBar.ResumeLayout(false);
            pnlBar.PerformLayout();
            tabPage2.ResumeLayout(false);
            pnlPersonalInfo.ResumeLayout(false);
            pnlPersonalInfo.PerformLayout();
            pnlUpdatePhone.ResumeLayout(false);
            pnlUpdatePhone.PerformLayout();
            tabControl1.ResumeLayout(false);
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
        private TabPage tabPage2;
        private Button btnEditPhone;
        private Label lblNewPhone;
        private TextBox txtNewPhone;
        private TabControl tabControl1;
        private Panel pnlPersonalInfo;
        private Label lblID;
        private TextBox txtID;
        private Label lblName;
        private TextBox txtName;
        private Label lblGender;
        private TextBox txtGender;
        private Label lblBirthday;
        private TextBox txtBirthday;
        private Label lblSalary;
        private TextBox txtSalary;
        private Label lblBonus;
        private TextBox txtBonus;
        private Label lblPhone;
        private TextBox txtPhone;
        private Label lblRole;
        private TextBox txtRole;
        private Label lblUnit;
        private TextBox txtUnit;
        private Panel pnlUpdatePhone;
    }
}

using OracleUserManager.Models;

namespace atbmcq_02
{
    partial class AddStaff
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
            lblTITLE = new Label();
            pnlBar = new Panel();
            lblBack = new LinkLabel();
            lblSignOut = new LinkLabel();
            lblSlog = new Label();
            textBoxID = new TextBox();
            labelD = new Label();
            labelName = new Label();
            labelGender = new Label();
            labelBirthday = new Label();
            labelSalary = new Label();
            textBoxName = new TextBox();
            textBoxSalary = new TextBox();
            dateTimePickerBirthday = new DateTimePicker();
            comboBoxGender = new ComboBox();
            buttonADD = new Button();
            buttonCANCEL = new Button();
            textBoxBonus = new TextBox();
            labelBonus = new Label();
            textBoxPhoneNumber = new TextBox();
            labelPhoneNumber = new Label();
            comboBoxRole = new ComboBox();
            labelRole = new Label();
            labelUnit = new Label();
            comboBoxUnit = new ComboBox();
            pnlBar.SuspendLayout();
            SuspendLayout();
            // 
            // lblTITLE
            // 
            lblTITLE.AutoSize = true;
            lblTITLE.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTITLE.Location = new Point(491, 81);
            lblTITLE.Name = "lblTITLE";
            lblTITLE.Size = new Size(466, 69);
            lblTITLE.TabIndex = 1;
            lblTITLE.Text = "ADD STUDENT";
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
            // textBoxID
            // 
            textBoxID.Location = new Point(149, 200);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(212, 25);
            textBoxID.TabIndex = 6;
            // 
            // labelD
            // 
            labelD.AutoSize = true;
            labelD.Location = new Point(48, 205);
            labelD.Name = "labelD";
            labelD.Size = new Size(27, 20);
            labelD.TabIndex = 7;
            labelD.Text = "ID";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(48, 262);
            labelName.Name = "labelName";
            labelName.Size = new Size(45, 20);
            labelName.TabIndex = 8;
            labelName.Text = "Name";
            // 
            // labelGender
            // 
            labelGender.AutoSize = true;
            labelGender.Location = new Point(48, 332);
            labelGender.Name = "labelGender";
            labelGender.Size = new Size(63, 20);
            labelGender.TabIndex = 9;
            labelGender.Text = "Gender";
            // 
            // labelBirthday
            // 
            labelBirthday.AutoSize = true;
            labelBirthday.Location = new Point(48, 400);
            labelBirthday.Name = "labelBirthday";
            labelBirthday.Size = new Size(81, 20);
            labelBirthday.TabIndex = 10;
            labelBirthday.Text = "Birthday";
            // 
            // labelSalary
            // 
            labelSalary.AutoSize = true;
            labelSalary.Location = new Point(511, 205);
            labelSalary.Name = "labelSalary";
            labelSalary.Size = new Size(63, 20);
            labelSalary.TabIndex = 12;
            labelSalary.Text = "Salary";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(149, 262);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(212, 25);
            textBoxName.TabIndex = 15;
            // 
            // textBoxSalary
            // 
            textBoxSalary.Location = new Point(634, 202);
            textBoxSalary.Name = "textBoxSalary";
            textBoxSalary.Size = new Size(212, 25);
            textBoxSalary.TabIndex = 17;
            // 
            // dateTimePickerBirthday
            // 
            dateTimePickerBirthday.Location = new Point(149, 395);
            dateTimePickerBirthday.Name = "dateTimePickerBirthday";
            dateTimePickerBirthday.Size = new Size(250, 25);
            dateTimePickerBirthday.TabIndex = 18;
            // 
            // comboBoxGender
            // 
            comboBoxGender.FormattingEnabled = true;
            comboBoxGender.Items.AddRange(new object[] { "Nam", "Nữ" });
            comboBoxGender.Location = new Point(149, 326);
            comboBoxGender.Name = "comboBoxGender";
            comboBoxGender.Size = new Size(151, 28);
            comboBoxGender.TabIndex = 19;
            // 
            // buttonADD
            // 
            buttonADD.BackColor = Color.FromArgb(0, 192, 0);
            buttonADD.Location = new Point(501, 528);
            buttonADD.Name = "buttonADD";
            buttonADD.Size = new Size(133, 68);
            buttonADD.TabIndex = 22;
            buttonADD.Text = "ADD";
            buttonADD.UseVisualStyleBackColor = false;
            buttonADD.Click += ButtonADD_Click;
            // 
            // buttonCANCEL
            // 
            buttonCANCEL.BackColor = Color.Red;
            buttonCANCEL.Location = new Point(744, 528);
            buttonCANCEL.Name = "buttonCANCEL";
            buttonCANCEL.Size = new Size(133, 68);
            buttonCANCEL.TabIndex = 23;
            buttonCANCEL.Text = "CANCEL";
            buttonCANCEL.UseVisualStyleBackColor = false;
            buttonCANCEL.Click += ButtonCANCEL_Click;
            // 
            // textBoxBonus
            // 
            textBoxBonus.Location = new Point(634, 262);
            textBoxBonus.Name = "textBoxBonus";
            textBoxBonus.Size = new Size(212, 25);
            textBoxBonus.TabIndex = 25;
            // 
            // labelBonus
            // 
            labelBonus.AutoSize = true;
            labelBonus.Location = new Point(511, 265);
            labelBonus.Name = "labelBonus";
            labelBonus.Size = new Size(54, 20);
            labelBonus.TabIndex = 24;
            labelBonus.Text = "Bonus";
            // 
            // textBoxPhoneNumber
            // 
            textBoxPhoneNumber.Location = new Point(634, 332);
            textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            textBoxPhoneNumber.Size = new Size(212, 25);
            textBoxPhoneNumber.TabIndex = 27;
            // 
            // labelPhoneNumber
            // 
            labelPhoneNumber.AutoSize = true;
            labelPhoneNumber.Location = new Point(511, 335);
            labelPhoneNumber.Name = "labelPhoneNumber";
            labelPhoneNumber.Size = new Size(117, 20);
            labelPhoneNumber.TabIndex = 26;
            labelPhoneNumber.Text = "Phone Number";
            // 
            // comboBoxRole
            // 
            comboBoxRole.FormattingEnabled = true;
            comboBoxRole.Items.AddRange(new object[] { "NVCB", "GV", "NV PĐT", "NV PKT", "NV TCHC", "NV CTSV", "TRGĐV" });
            comboBoxRole.Location = new Point(1102, 202);
            comboBoxRole.Name = "comboBoxRole";
            comboBoxRole.Size = new Size(151, 28);
            comboBoxRole.TabIndex = 29;
            // 
            // labelRole
            // 
            labelRole.AutoSize = true;
            labelRole.Location = new Point(988, 205);
            labelRole.Name = "labelRole";
            labelRole.Size = new Size(45, 20);
            labelRole.TabIndex = 28;
            labelRole.Text = "Role";
            // 
            // labelUnit
            // 
            labelUnit.AutoSize = true;
            labelUnit.Location = new Point(988, 265);
            labelUnit.Name = "labelUnit";
            labelUnit.Size = new Size(45, 20);
            labelUnit.TabIndex = 30;
            labelUnit.Text = "Unit";
            // 
            // comboBoxUnit
            // 
            comboBoxUnit.FormattingEnabled = true;
            comboBoxUnit.Items.AddRange(new object[] { "CNTT", "DIA", "DUOC", "HOA", "KINHTE", "LUAT", "NHA", "PCTSV", "PKT", "PTC", "PĐT", "SINH", "SU", "TOAN", "TRIET", "VAN", "VATLY", "Y", "YTE" });
            comboBoxUnit.Location = new Point(1102, 262);
            comboBoxUnit.Name = "comboBoxUnit";
            comboBoxUnit.Size = new Size(151, 28);
            comboBoxUnit.TabIndex = 32;
            // 
            // AddStaff
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            Controls.Add(comboBoxUnit);
            Controls.Add(labelUnit);
            Controls.Add(comboBoxRole);
            Controls.Add(labelRole);
            Controls.Add(textBoxPhoneNumber);
            Controls.Add(labelPhoneNumber);
            Controls.Add(textBoxBonus);
            Controls.Add(labelBonus);
            Controls.Add(buttonCANCEL);
            Controls.Add(buttonADD);
            Controls.Add(comboBoxGender);
            Controls.Add(dateTimePickerBirthday);
            Controls.Add(textBoxSalary);
            Controls.Add(textBoxName);
            Controls.Add(labelSalary);
            Controls.Add(labelBirthday);
            Controls.Add(labelGender);
            Controls.Add(labelName);
            Controls.Add(labelD);
            Controls.Add(textBoxID);
            Controls.Add(pnlBar);
            Controls.Add(lblTITLE);
            Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "AddStaff";
            Size = new Size(1394, 712);
            Load += AddStudent_Load;
            pnlBar.ResumeLayout(false);
            pnlBar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblTITLE;
        private Panel pnlBar;
        private LinkLabel lblBack;
        private LinkLabel lblSignOut;
        private Label lblSlog;
        private OracleDbConnection _connection;
        private TextBox textBoxID;
        private Label labelD;
        private Label labelName;
        private Label labelGender;
        private Label labelBirthday;
        private Label labelSalary;
        private TextBox textBoxName;
        private TextBox textBoxSalary;
        private DateTimePicker dateTimePickerBirthday;
        private ComboBox comboBoxGender;
        private Button buttonADD;
        private Button buttonCANCEL;
        private TextBox textBoxBonus;
        private Label labelBonus;
        private TextBox textBoxPhoneNumber;
        private Label labelPhoneNumber;
        private ComboBox comboBoxRole;
        private Label labelRole;
        private Label labelUnit;
        private ComboBox comboBoxUnit;
    }
}

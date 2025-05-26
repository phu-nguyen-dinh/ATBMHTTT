using OracleUserManager.Models;

namespace atbmcq_02
{
    partial class UpdateStudent
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
            labelAddress = new Label();
            labelPhonenumber = new Label();
            labelDepartment = new Label();
            labelStatus = new Label();
            textBoxName = new TextBox();
            textBoxAddress = new TextBox();
            textBoxPhoneNumber = new TextBox();
            dateTimePickerBirthday = new DateTimePicker();
            comboBoxGender = new ComboBox();
            comboBoxDepartment = new ComboBox();
            comboBoxStatus = new ComboBox();
            buttonUPDATE = new Button();
            buttonCANCEL = new Button();
            pnlBar.SuspendLayout();
            SuspendLayout();
            // 
            // lblTITLE
            // 
            lblTITLE.AutoSize = true;
            lblTITLE.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTITLE.Location = new Point(454, 79);
            lblTITLE.Name = "lblTITLE";
            lblTITLE.Size = new Size(586, 69);
            lblTITLE.TabIndex = 1;
            lblTITLE.Text = "UPDATE STUDENT";
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
            labelBirthday.Location = new Point(517, 205);
            labelBirthday.Name = "labelBirthday";
            labelBirthday.Size = new Size(81, 20);
            labelBirthday.TabIndex = 10;
            labelBirthday.Text = "Birthday";
            // 
            // labelAddress
            // 
            labelAddress.AutoSize = true;
            labelAddress.Location = new Point(517, 262);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new Size(72, 20);
            labelAddress.TabIndex = 11;
            labelAddress.Text = "Address";
            // 
            // labelPhonenumber
            // 
            labelPhonenumber.AutoSize = true;
            labelPhonenumber.Location = new Point(517, 332);
            labelPhonenumber.Name = "labelPhonenumber";
            labelPhonenumber.Size = new Size(117, 20);
            labelPhonenumber.TabIndex = 12;
            labelPhonenumber.Text = "Phone Number";
            // 
            // labelDepartment
            // 
            labelDepartment.AutoSize = true;
            labelDepartment.Location = new Point(1076, 205);
            labelDepartment.Name = "labelDepartment";
            labelDepartment.Size = new Size(99, 20);
            labelDepartment.TabIndex = 13;
            labelDepartment.Text = "Department";
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Location = new Point(1076, 267);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(63, 20);
            labelStatus.TabIndex = 14;
            labelStatus.Text = "Status";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(149, 262);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(212, 25);
            textBoxName.TabIndex = 15;
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(640, 262);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(400, 25);
            textBoxAddress.TabIndex = 16;
            // 
            // textBoxPhoneNumber
            // 
            textBoxPhoneNumber.Location = new Point(640, 329);
            textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            textBoxPhoneNumber.Size = new Size(212, 25);
            textBoxPhoneNumber.TabIndex = 17;
            // 
            // dateTimePickerBirthday
            // 
            dateTimePickerBirthday.Location = new Point(640, 200);
            dateTimePickerBirthday.Name = "dateTimePickerBirthday";
            dateTimePickerBirthday.Size = new Size(250, 25);
            dateTimePickerBirthday.TabIndex = 18;
            // 
            // comboBoxGender
            // 
            comboBoxGender.FormattingEnabled = true;
            comboBoxGender.Items.AddRange(new object[] { "Man", "Woman" });
            comboBoxGender.Location = new Point(149, 326);
            comboBoxGender.Name = "comboBoxGender";
            comboBoxGender.Size = new Size(151, 28);
            comboBoxGender.TabIndex = 19;
            // 
            // comboBoxDepartment
            // 
            comboBoxDepartment.FormattingEnabled = true;
            comboBoxDepartment.Items.AddRange(new object[] { "CNTT", "DIA", "DUOC", "HOA", "KINHTE", "LUAT", "NHA", "SINH", "SU", "TOAN", "TRIET", "VAN", "VATLY", "Y", "YTE" });
            comboBoxDepartment.Location = new Point(1204, 197);
            comboBoxDepartment.Name = "comboBoxDepartment";
            comboBoxDepartment.Size = new Size(151, 28);
            comboBoxDepartment.TabIndex = 20;
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Items.AddRange(new object[] { "đang học", "nghỉ học", "bảo lưu" });
            comboBoxStatus.Location = new Point(1204, 267);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(151, 28);
            comboBoxStatus.TabIndex = 21;
            // 
            // buttonUPDATE
            // 
            buttonUPDATE.BackColor = Color.Yellow;
            buttonUPDATE.Location = new Point(501, 528);
            buttonUPDATE.Name = "buttonUPDATE";
            buttonUPDATE.Size = new Size(133, 68);
            buttonUPDATE.TabIndex = 22;
            buttonUPDATE.Text = "UPDATE";
            buttonUPDATE.UseVisualStyleBackColor = false;
            buttonUPDATE.Click += ButtonUpdate_Click;
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
            // UpdateStudent
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            Controls.Add(buttonCANCEL);
            Controls.Add(buttonUPDATE);
            Controls.Add(comboBoxStatus);
            Controls.Add(comboBoxDepartment);
            Controls.Add(comboBoxGender);
            Controls.Add(dateTimePickerBirthday);
            Controls.Add(textBoxPhoneNumber);
            Controls.Add(textBoxAddress);
            Controls.Add(textBoxName);
            Controls.Add(labelStatus);
            Controls.Add(labelDepartment);
            Controls.Add(labelPhonenumber);
            Controls.Add(labelAddress);
            Controls.Add(labelBirthday);
            Controls.Add(labelGender);
            Controls.Add(labelName);
            Controls.Add(labelD);
            Controls.Add(textBoxID);
            Controls.Add(pnlBar);
            Controls.Add(lblTITLE);
            Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "UpdateStudent";
            Size = new Size(1394, 712);
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
        private Label labelAddress;
        private Label labelPhonenumber;
        private Label labelDepartment;
        private Label labelStatus;
        private TextBox textBoxName;
        private TextBox textBoxAddress;
        private TextBox textBoxPhoneNumber;
        private DateTimePicker dateTimePickerBirthday;
        private ComboBox comboBoxGender;
        private ComboBox comboBoxDepartment;
        private ComboBox comboBoxStatus;
        private Button buttonUPDATE;
        private Button buttonCANCEL;
    }
}

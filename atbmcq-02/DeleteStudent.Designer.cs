using OracleUserManager.Models;

namespace atbmcq_02
{
    partial class DeleteStudent
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
            labelStatus = new Label();
            dtgvStudent1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            CName = new DataGridViewTextBoxColumn();
            Gender = new DataGridViewTextBoxColumn();
            Birthday = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            PhoneNumber = new DataGridViewTextBoxColumn();
            Department = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            buttonDELETE = new Button();
            buttonCANCEL = new Button();
            buttonSEARCH = new Button();
            pnlBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvStudent1).BeginInit();
            SuspendLayout();
            // 
            // lblTITLE
            // 
            lblTITLE.AutoSize = true;
            lblTITLE.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTITLE.Location = new Point(454, 79);
            lblTITLE.Name = "lblTITLE";
            lblTITLE.Size = new Size(576, 69);
            lblTITLE.TabIndex = 1;
            lblTITLE.Text = "DELETE STUDENT";
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
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Location = new Point(1076, 267);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(0, 20);
            labelStatus.TabIndex = 14;
            // 
            // dtgvStudent1
            // 
            dtgvStudent1.BackgroundColor = SystemColors.ButtonHighlight;
            dtgvStudent1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvStudent1.Columns.AddRange(new DataGridViewColumn[] { ID, CName, Gender, Birthday, Address, PhoneNumber, Department, Status });
            dtgvStudent1.Dock = DockStyle.Bottom;
            dtgvStudent1.Location = new Point(0, 267);
            dtgvStudent1.Name = "dtgvStudent1";
            dtgvStudent1.RowHeadersWidth = 62;
            dtgvStudent1.Size = new Size(1394, 445);
            dtgvStudent1.TabIndex = 24;
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
            // buttonDELETE
            // 
            buttonDELETE.BackColor = Color.Yellow;
            buttonDELETE.Location = new Point(490, 476);
            buttonDELETE.Name = "buttonDELETE";
            buttonDELETE.Size = new Size(133, 68);
            buttonDELETE.TabIndex = 22;
            buttonDELETE.Text = "DELETE";
            buttonDELETE.UseVisualStyleBackColor = false;
            buttonDELETE.Click += ButtonDelete_Click;
            // 
            // buttonCANCEL
            // 
            buttonCANCEL.BackColor = Color.Red;
            buttonCANCEL.Location = new Point(778, 476);
            buttonCANCEL.Name = "buttonCANCEL";
            buttonCANCEL.Size = new Size(133, 68);
            buttonCANCEL.TabIndex = 23;
            buttonCANCEL.Text = "CANCEL";
            buttonCANCEL.UseVisualStyleBackColor = false;
            buttonCANCEL.Click += ButtonCANCEL_Click;
            // 
            // buttonSEARCH
            // 
            buttonSEARCH.BackColor = SystemColors.ActiveCaption;
            buttonSEARCH.Location = new Point(394, 184);
            buttonSEARCH.Name = "buttonSEARCH";
            buttonSEARCH.Size = new Size(142, 41);
            buttonSEARCH.TabIndex = 25;
            buttonSEARCH.Text = "SEARCH";
            buttonSEARCH.UseVisualStyleBackColor = false;
            buttonSEARCH.Click += ButtonSearch_Click;
            // 
            // DeleteStudent
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            Controls.Add(buttonSEARCH);
            Controls.Add(buttonCANCEL);
            Controls.Add(buttonDELETE);
            Controls.Add(labelStatus);
            Controls.Add(labelD);
            Controls.Add(textBoxID);
            Controls.Add(pnlBar);
            Controls.Add(lblTITLE);
            Controls.Add(dtgvStudent1);
            Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "DeleteStudent";
            Size = new Size(1394, 712);
            pnlBar.ResumeLayout(false);
            pnlBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvStudent1).EndInit();
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
        private Label labelStatus;
        private DataGridView dtgvStudent1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn CName;
        private DataGridViewTextBoxColumn Gender;
        private DataGridViewTextBoxColumn Birthday;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn PhoneNumber;
        private DataGridViewTextBoxColumn Department;
        private DataGridViewTextBoxColumn Status;
        private Button buttonDELETE;
        private Button buttonCANCEL;
        private Button buttonSEARCH;
    }
}

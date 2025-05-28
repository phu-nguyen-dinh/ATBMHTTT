using OracleUserManager.Models;

namespace atbmcq_02
{
    partial class DeleteStaff
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
            buttonDELETE = new Button();
            buttonCANCEL = new Button();
            buttonSEARCH = new Button();
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
            pnlBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvOfficial).BeginInit();
            SuspendLayout();
            // 
            // lblTITLE
            // 
            lblTITLE.AutoSize = true;
            lblTITLE.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTITLE.Location = new Point(454, 79);
            lblTITLE.Name = "lblTITLE";
            lblTITLE.Size = new Size(482, 69);
            lblTITLE.TabIndex = 1;
            lblTITLE.Text = "DELETE STAFF";
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
            // buttonDELETE
            // 
            buttonDELETE.BackColor = Color.Yellow;
            buttonDELETE.Location = new Point(472, 447);
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
            buttonCANCEL.Location = new Point(759, 447);
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
            // dtgvOfficial
            // 
            dtgvOfficial.BackgroundColor = SystemColors.ButtonHighlight;
            dtgvOfficial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvOfficial.Columns.AddRange(new DataGridViewColumn[] { GV_ID, GV_Name, GV_Gender, GV_Birthday, GV_Address, GV_Bonus, GV_PhoneNumber, GV_Role, GV_Unit });
            dtgvOfficial.Dock = DockStyle.Bottom;
            dtgvOfficial.Location = new Point(0, 267);
            dtgvOfficial.Name = "dtgvOfficial";
            dtgvOfficial.RowHeadersWidth = 62;
            dtgvOfficial.Size = new Size(1394, 445);
            dtgvOfficial.TabIndex = 26;
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
            // DeleteStaff
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
            Controls.Add(dtgvOfficial);
            Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "DeleteStaff";
            Size = new Size(1394, 712);
            pnlBar.ResumeLayout(false);
            pnlBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvOfficial).EndInit();
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
        private Button buttonDELETE;
        private Button buttonCANCEL;
        private Button buttonSEARCH;
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
    }
}

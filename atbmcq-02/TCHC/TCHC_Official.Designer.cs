using OracleUserManager.Models;

namespace atbmcq_02
{
    partial class TCHC_Official
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
            tabControl1 = new TabControl();
            tabPage3 = new TabPage();
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
            btnDeleteStaff = new Button();
            btnUpdateStaff = new Button();
            btnAddStaff = new Button();
            lblSearch = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            pnlBar.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvOfficial).BeginInit();
            SuspendLayout();
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
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(0, 186);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1394, 531);
            tabControl1.TabIndex = 4;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(dtgvOfficial);
            tabPage3.Controls.Add(btnDeleteStaff);
            tabPage3.Controls.Add(btnUpdateStaff);
            tabPage3.Controls.Add(btnAddStaff);
            tabPage3.Controls.Add(lblSearch);
            tabPage3.Controls.Add(txtSearch);
            tabPage3.Controls.Add(btnSearch);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1386, 498);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Staff List";
            tabPage3.UseVisualStyleBackColor = true;
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
            dtgvOfficial.TabIndex = 9;
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
            // btnDeleteStaff
            // 
            btnDeleteStaff.BackColor = Color.Red;
            btnDeleteStaff.Location = new Point(1217, 64);
            btnDeleteStaff.Name = "btnDeleteStaff";
            btnDeleteStaff.Size = new Size(94, 29);
            btnDeleteStaff.TabIndex = 8;
            btnDeleteStaff.Text = "DELETE";
            btnDeleteStaff.UseVisualStyleBackColor = false;
            btnDeleteStaff.Click += btnDeleteStaff_Click;
            // 
            // btnUpdateStaff
            // 
            btnUpdateStaff.BackColor = Color.Yellow;
            btnUpdateStaff.Location = new Point(1091, 64);
            btnUpdateStaff.Name = "btnUpdateStaff";
            btnUpdateStaff.Size = new Size(94, 29);
            btnUpdateStaff.TabIndex = 7;
            btnUpdateStaff.Text = "UPDATE";
            btnUpdateStaff.UseVisualStyleBackColor = false;
            btnUpdateStaff.Click += btnUpdateStaff_Click;
            // 
            // btnAddStaff
            // 
            btnAddStaff.BackColor = Color.Lime;
            btnAddStaff.Location = new Point(960, 64);
            btnAddStaff.Name = "btnAddStaff";
            btnAddStaff.Size = new Size(94, 29);
            btnAddStaff.TabIndex = 6;
            btnAddStaff.Text = "ADD";
            btnAddStaff.UseVisualStyleBackColor = false;
            btnAddStaff.Click += btnAddStaff_Click;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Cascadia Code", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSearch.Location = new Point(32, 68);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(190, 22);
            lblSearch.TabIndex = 10;
            lblSearch.Text = "Tên hoặc ID:";
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Cascadia Code", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(228, 65);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(345, 27);
            txtSearch.TabIndex = 11;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.RoyalBlue;
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(589, 64);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 12;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // TCHC_Official
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            Controls.Add(tabControl1);
            Controls.Add(pnlBar);
            Controls.Add(lblOfficial);
            Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "TCHC_Official";
            Size = new Size(1394, 712);
            pnlBar.ResumeLayout(false);
            pnlBar.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
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
        private TabPage tabPage3;
        private Button btnDeleteStaff;
        private Button btnUpdateStaff;
        private Button btnAddStaff;
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
        private Label lblSearch;
        private TextBox txtSearch;
        private Button btnSearch;
    }
}

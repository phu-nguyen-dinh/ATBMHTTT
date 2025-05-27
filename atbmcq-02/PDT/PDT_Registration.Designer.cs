using OracleUserManager.Models;

namespace atbmcq_02
{
    partial class PDT_Registration
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
            lblRegistration = new Label();
            pnlBar = new Panel();
            lblBack = new LinkLabel();
            lblSignOut = new LinkLabel();
            lblSlog = new Label();
            dtgvOfficial = new DataGridView();
            OID = new DataGridViewTextBoxColumn();
            OName = new DataGridViewTextBoxColumn();
            OGender = new DataGridViewTextBoxColumn();
            Odate = new DataGridViewTextBoxColumn();
            Osalary = new DataGridViewTextBoxColumn();
            OBonus = new DataGridViewTextBoxColumn();
            OPhone = new DataGridViewTextBoxColumn();
            Orole = new DataGridViewTextBoxColumn();
            Ounit = new DataGridViewTextBoxColumn();
            dtgvStudent2 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            pnlBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvOfficial).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgvStudent2).BeginInit();
            SuspendLayout();
            // 
            // lblRegistration
            // 
            lblRegistration.AutoSize = true;
            lblRegistration.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRegistration.Location = new Point(519, 73);
            lblRegistration.Name = "lblRegistration";
            lblRegistration.Size = new Size(360, 69);
            lblRegistration.TabIndex = 1;
            lblRegistration.Text = "Registration";
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
            pnlBar.Size = new Size(1414, 59);
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
            // dtgvOfficial
            // 
            dtgvOfficial.BackgroundColor = SystemColors.ButtonHighlight;
            dtgvOfficial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvOfficial.Columns.AddRange(new DataGridViewColumn[] { OID, OName, OGender, Odate, Osalary, OBonus, OPhone, Orole, Ounit });
            dtgvOfficial.Dock = DockStyle.Bottom;
            dtgvOfficial.Location = new Point(0, 430);
            dtgvOfficial.Name = "dtgvOfficial";
            dtgvOfficial.RowHeadersWidth = 62;
            dtgvOfficial.Size = new Size(1414, 420);
            dtgvOfficial.TabIndex = 3;
            // 
            // OID
            // 
            OID.HeaderText = "ID";
            OID.MinimumWidth = 8;
            OID.Name = "OID";
            OID.Width = 150;
            // 
            // OName
            // 
            OName.HeaderText = "Name";
            OName.MinimumWidth = 8;
            OName.Name = "OName";
            OName.Width = 228;
            // 
            // OGender
            // 
            OGender.HeaderText = "Gender";
            OGender.MinimumWidth = 8;
            OGender.Name = "OGender";
            OGender.Width = 224;
            // 
            // Odate
            // 
            Odate.HeaderText = "Date";
            Odate.MinimumWidth = 8;
            Odate.Name = "Odate";
            Odate.Width = 224;
            // 
            // Osalary
            // 
            Osalary.HeaderText = "Salary";
            Osalary.MinimumWidth = 8;
            Osalary.Name = "Osalary";
            Osalary.Width = 224;
            // 
            // OBonus
            // 
            OBonus.HeaderText = "Bonus";
            OBonus.MinimumWidth = 6;
            OBonus.Name = "OBonus";
            OBonus.Width = 200;
            // 
            // OPhone
            // 
            OPhone.HeaderText = "Phone";
            OPhone.MinimumWidth = 6;
            OPhone.Name = "OPhone";
            OPhone.Width = 125;
            // 
            // Orole
            // 
            Orole.HeaderText = "Role";
            Orole.MinimumWidth = 6;
            Orole.Name = "Orole";
            Orole.Width = 125;
            // 
            // Ounit
            // 
            Ounit.HeaderText = "Unit";
            Ounit.MinimumWidth = 6;
            Ounit.Name = "Ounit";
            Ounit.Width = 125;
            // 
            // dtgvStudent2
            // 
            dtgvStudent2.BackgroundColor = SystemColors.ButtonHighlight;
            dtgvStudent2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvStudent2.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6 });
            dtgvStudent2.Dock = DockStyle.Bottom;
            dtgvStudent2.Location = new Point(0, 177);
            dtgvStudent2.Name = "dtgvStudent2";
            dtgvStudent2.RowHeadersWidth = 62;
            dtgvStudent2.Size = new Size(1414, 253);
            dtgvStudent2.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "ID_Student";
            dataGridViewTextBoxColumn1.MinimumWidth = 8;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "ID_Subject";
            dataGridViewTextBoxColumn2.MinimumWidth = 8;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 228;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Practice score";
            dataGridViewTextBoxColumn3.MinimumWidth = 8;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Width = 224;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Process score";
            dataGridViewTextBoxColumn4.MinimumWidth = 8;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.Width = 224;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Final score";
            dataGridViewTextBoxColumn5.MinimumWidth = 8;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.Width = 224;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "Sumary Score";
            dataGridViewTextBoxColumn6.MinimumWidth = 6;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.Width = 200;
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            Controls.Add(dtgvStudent2);
            Controls.Add(dtgvOfficial);
            Controls.Add(pnlBar);
            Controls.Add(lblRegistration);
            Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Registration";
            Size = new Size(1414, 850);
            pnlBar.ResumeLayout(false);
            pnlBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvOfficial).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgvStudent2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblRegistration;
        private Panel pnlBar;
        private LinkLabel lblBack;
        private LinkLabel lblSignOut;
        private Label lblSlog;
        private OracleDbConnection _connection;
        private DataGridView dtgvOfficial;
        private DataGridView dtgvStudent2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn OID;
        private DataGridViewTextBoxColumn OName;
        private DataGridViewTextBoxColumn OGender;
        private DataGridViewTextBoxColumn Odate;
        private DataGridViewTextBoxColumn Osalary;
        private DataGridViewTextBoxColumn OBonus;
        private DataGridViewTextBoxColumn OPhone;
        private DataGridViewTextBoxColumn Orole;
        private DataGridViewTextBoxColumn Ounit;
    }
}

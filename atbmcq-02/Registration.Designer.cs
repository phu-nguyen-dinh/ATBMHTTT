using OracleUserManager.Models;

namespace atbmcq_02
{
    partial class Registration
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
            dtgvStudent2 = new DataGridView();
            DK_IDStudent = new DataGridViewTextBoxColumn();
            DK_IDSubject = new DataGridViewTextBoxColumn();
            DK_ps = new DataGridViewTextBoxColumn();
            DK_processS = new DataGridViewTextBoxColumn();
            DK_Fs = new DataGridViewTextBoxColumn();
            DK_SS = new DataGridViewTextBoxColumn();
            pnlBar.SuspendLayout();
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
            pnlBar.Size = new Size(1409, 59);
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
            // dtgvStudent2
            // 
            dtgvStudent2.BackgroundColor = SystemColors.ButtonHighlight;
            dtgvStudent2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvStudent2.Columns.AddRange(new DataGridViewColumn[] { DK_IDStudent, DK_IDSubject, DK_ps, DK_processS, DK_Fs, DK_SS });
            dtgvStudent2.Dock = DockStyle.Bottom;
            dtgvStudent2.Location = new Point(0, 200);
            dtgvStudent2.Name = "dtgvStudent2";
            dtgvStudent2.RowHeadersWidth = 62;
            dtgvStudent2.Size = new Size(1409, 650);
            dtgvStudent2.TabIndex = 3;
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
            // Registration
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            Controls.Add(dtgvStudent2);
            Controls.Add(pnlBar);
            Controls.Add(lblRegistration);
            Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Registration";
            Size = new Size(1409, 850);
            pnlBar.ResumeLayout(false);
            pnlBar.PerformLayout();
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
        private DataGridView dtgvStudent2;
        private DataGridViewTextBoxColumn DK_IDStudent;
        private DataGridViewTextBoxColumn DK_IDSubject;
        private DataGridViewTextBoxColumn DK_ps;
        private DataGridViewTextBoxColumn DK_processS;
        private DataGridViewTextBoxColumn DK_Fs;
        private DataGridViewTextBoxColumn DK_SS;
    }
}

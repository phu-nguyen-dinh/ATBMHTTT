using OracleUserManager.Models;

namespace atbmcq_02
{
    partial class PDT_OpenedSubjects
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
            dtgvSubject = new DataGridView();
            Course = new DataGridViewTextBoxColumn();
            Subject = new DataGridViewTextBoxColumn();
            InCharge = new DataGridViewTextBoxColumn();
            Semester = new DataGridViewTextBoxColumn();
            Year = new DataGridViewTextBoxColumn();
            pnlBar = new Panel();
            lblBack = new LinkLabel();
            lblSignOut = new LinkLabel();
            lblSlog = new Label();
            label1 = new Label();
            cbbSemes = new ComboBox();
            cbbYear = new ComboBox();
            btnInsert = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnFind = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgvSubject).BeginInit();
            pnlBar.SuspendLayout();
            SuspendLayout();
            // 
            // dtgvSubject
            // 
            dtgvSubject.AllowUserToAddRows = false;
            dtgvSubject.AllowUserToDeleteRows = false;
            dtgvSubject.BackgroundColor = SystemColors.ButtonHighlight;
            dtgvSubject.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvSubject.Columns.AddRange(new DataGridViewColumn[] { Course, Subject, InCharge, Semester, Year });
            dtgvSubject.Dock = DockStyle.Bottom;
            dtgvSubject.Location = new Point(0, 271);
            dtgvSubject.Margin = new Padding(4, 3, 4, 3);
            dtgvSubject.Name = "dtgvSubject";
            dtgvSubject.RowHeadersWidth = 62;
            dtgvSubject.Size = new Size(1277, 369);
            dtgvSubject.TabIndex = 1;
            // 
            // Course
            // 
            Course.HeaderText = "Course";
            Course.MinimumWidth = 8;
            Course.Name = "Course";
            Course.SortMode = DataGridViewColumnSortMode.NotSortable;
            Course.Width = 243;
            // 
            // Subject
            // 
            Subject.HeaderText = "Subject";
            Subject.MinimumWidth = 8;
            Subject.Name = "Subject";
            Subject.SortMode = DataGridViewColumnSortMode.NotSortable;
            Subject.Width = 243;
            // 
            // InCharge
            // 
            InCharge.HeaderText = "In Charge";
            InCharge.MinimumWidth = 8;
            InCharge.Name = "InCharge";
            InCharge.SortMode = DataGridViewColumnSortMode.NotSortable;
            InCharge.Width = 243;
            // 
            // Semester
            // 
            Semester.HeaderText = "Semester";
            Semester.MinimumWidth = 8;
            Semester.Name = "Semester";
            Semester.SortMode = DataGridViewColumnSortMode.NotSortable;
            Semester.Width = 243;
            // 
            // Year
            // 
            Year.HeaderText = "Year";
            Year.MinimumWidth = 8;
            Year.Name = "Year";
            Year.SortMode = DataGridViewColumnSortMode.NotSortable;
            Year.Width = 243;
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
            pnlBar.Size = new Size(1277, 50);
            pnlBar.TabIndex = 3;
            // 
            // lblBack
            // 
            lblBack.AutoSize = true;
            lblBack.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBack.Location = new Point(1104, 8);
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
            lblSignOut.Location = new Point(1175, 8);
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
            lblSlog.Location = new Point(3, 8);
            lblSlog.Name = "lblSlog";
            lblSlog.Size = new Size(220, 24);
            lblSlog.TabIndex = 0;
            lblSlog.Text = "Welcome to University X!";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(397, 69);
            label1.Name = "label1";
            label1.Size = new Size(502, 69);
            label1.TabIndex = 4;
            label1.Text = "Opened Subjects";
            // 
            // cbbSemes
            // 
            cbbSemes.FormattingEnabled = true;
            cbbSemes.Items.AddRange(new object[] { "All", "1", "2", "3", "4" });
            cbbSemes.Location = new Point(514, 197);
            cbbSemes.Name = "cbbSemes";
            cbbSemes.Size = new Size(282, 28);
            cbbSemes.TabIndex = 5;
            // 
            // cbbYear
            // 
            cbbYear.FormattingEnabled = true;
            cbbYear.Items.AddRange(new object[] { "All", "2022", "2023", "2024", "2025" });
            cbbYear.Location = new Point(836, 197);
            cbbYear.Name = "cbbYear";
            cbbYear.Size = new Size(282, 28);
            cbbYear.TabIndex = 6;
            // 
            // btnInsert
            // 
            btnInsert.BackColor = SystemColors.GradientInactiveCaption;
            btnInsert.Font = new Font("Cascadia Code", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnInsert.Location = new Point(64, 188);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(100, 45);
            btnInsert.TabIndex = 7;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = false;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.GradientInactiveCaption;
            btnDelete.Font = new Font("Cascadia Code", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(209, 188);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 45);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.GradientInactiveCaption;
            btnUpdate.Font = new Font("Cascadia Code", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(363, 188);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(100, 45);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnFind
            // 
            btnFind.BackColor = SystemColors.GradientInactiveCaption;
            btnFind.Font = new Font("Cascadia Code", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFind.Location = new Point(1159, 188);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(100, 45);
            btnFind.TabIndex = 10;
            btnFind.Text = "Find";
            btnFind.UseVisualStyleBackColor = false;
            btnFind.Click += btnFind_Click;
            // 
            // PDT_OpenedSubjects
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            Controls.Add(btnFind);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnInsert);
            Controls.Add(cbbYear);
            Controls.Add(cbbSemes);
            Controls.Add(label1);
            Controls.Add(pnlBar);
            Controls.Add(dtgvSubject);
            Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "PDT_OpenedSubjects";
            Size = new Size(1277, 640);
            ((System.ComponentModel.ISupportInitialize)dtgvSubject).EndInit();
            pnlBar.ResumeLayout(false);
            pnlBar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgvSubject;
        private Panel pnlBar;
        private LinkLabel lblBack;
        private LinkLabel lblSignOut;
        private Label lblSlog;
        private Label label1;
        private OracleDbConnection _connection;
        private ComboBox cbbSemes;
        private ComboBox cbbYear;
        private Button btnInsert;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnFind;
        private DataGridViewTextBoxColumn Course;
        private DataGridViewTextBoxColumn Subject;
        private DataGridViewTextBoxColumn InCharge;
        private DataGridViewTextBoxColumn Semester;
        private DataGridViewTextBoxColumn Year;
    }
}

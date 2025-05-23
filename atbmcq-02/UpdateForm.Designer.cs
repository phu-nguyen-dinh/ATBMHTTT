using OracleUserManager.Models;

namespace atbmcq_02
{
    partial class UpdateForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSave = new Button();
            dtgvSubject = new DataGridView();
            Course = new DataGridViewTextBoxColumn();
            Subject = new DataGridViewTextBoxColumn();
            InCharge = new DataGridViewTextBoxColumn();
            Semester = new DataGridViewTextBoxColumn();
            Year = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dtgvSubject).BeginInit();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(1131, 12);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 33);
            btnSave.TabIndex = 5;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // dtgvSubject
            // 
            dtgvSubject.BackgroundColor = SystemColors.ButtonHighlight;
            dtgvSubject.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvSubject.Columns.AddRange(new DataGridViewColumn[] { Course, Subject, InCharge, Semester, Year });
            dtgvSubject.Dock = DockStyle.Bottom;
            dtgvSubject.Location = new Point(0, 93);
            dtgvSubject.Margin = new Padding(4, 3, 4, 3);
            dtgvSubject.Name = "dtgvSubject";
            dtgvSubject.RowHeadersWidth = 62;
            dtgvSubject.Size = new Size(1255, 339);
            dtgvSubject.TabIndex = 4;
            // 
            // Course
            // 
            Course.HeaderText = "Course";
            Course.MinimumWidth = 8;
            Course.Name = "Course";
            Course.Width = 243;
            // 
            // Subject
            // 
            Subject.HeaderText = "Subject";
            Subject.MinimumWidth = 8;
            Subject.Name = "Subject";
            Subject.Width = 243;
            // 
            // InCharge
            // 
            InCharge.HeaderText = "In Charge";
            InCharge.MinimumWidth = 8;
            InCharge.Name = "InCharge";
            InCharge.Width = 243;
            // 
            // Semester
            // 
            Semester.HeaderText = "Semester";
            Semester.MinimumWidth = 8;
            Semester.Name = "Semester";
            Semester.Width = 243;
            // 
            // Year
            // 
            Year.HeaderText = "Year";
            Year.MinimumWidth = 8;
            Year.Name = "Year";
            Year.Width = 243;
            // 
            // UpdateForm
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1255, 432);
            Controls.Add(btnSave);
            Controls.Add(dtgvSubject);
            Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "UpdateForm";
            Text = "UpdateForm";
            ((System.ComponentModel.ISupportInitialize)dtgvSubject).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnSave;
        private DataGridView dtgvSubject;
        private OracleDbConnection _connection;
        private DataGridViewTextBoxColumn Course;
        private DataGridViewTextBoxColumn Subject;
        private DataGridViewTextBoxColumn InCharge;
        private DataGridViewTextBoxColumn Semester;
        private DataGridViewTextBoxColumn Year;
    }
}
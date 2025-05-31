using OracleUserManager.Models;

namespace atbmcq_02
{
    partial class PKT_Registration
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
            dtgvDangKy = new DataGridView();
            colStudentID = new DataGridViewTextBoxColumn();
            colCourseID = new DataGridViewTextBoxColumn();
            colPracticeScore = new DataGridViewTextBoxColumn();
            colProcessScore = new DataGridViewTextBoxColumn();
            colFinalScore = new DataGridViewTextBoxColumn();
            colTotalScore = new DataGridViewTextBoxColumn();
            btnSaveScore = new Button();
            pnlBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvDangKy).BeginInit();
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
            lblRegistration.Text = "Nhập điểm";
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
            // dtgvDangKy
            // 
            dtgvDangKy.BackgroundColor = SystemColors.ButtonHighlight;
            dtgvDangKy.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvDangKy.Columns.AddRange(new DataGridViewColumn[] { colStudentID, colCourseID, colPracticeScore, colProcessScore, colFinalScore, colTotalScore });
            dtgvDangKy.Dock = DockStyle.Bottom;
            dtgvDangKy.Location = new Point(0, 177);
            dtgvDangKy.Name = "dtgvDangKy";
            dtgvDangKy.RowHeadersWidth = 62;
            dtgvDangKy.Size = new Size(1414, 673);
            dtgvDangKy.TabIndex = 3;
            // 
            // colStudentID
            // 
            colStudentID.HeaderText = "Student ID";
            colStudentID.MinimumWidth = 8;
            colStudentID.Name = "colStudentID";
            colStudentID.ReadOnly = true;
            colStudentID.Width = 150;
            // 
            // colCourseID
            // 
            colCourseID.HeaderText = "Course ID";
            colCourseID.MinimumWidth = 8;
            colCourseID.Name = "colCourseID";
            colCourseID.ReadOnly = true;
            colCourseID.Width = 150;
            // 
            // colPracticeScore
            // 
            colPracticeScore.HeaderText = "Practice Score";
            colPracticeScore.MinimumWidth = 8;
            colPracticeScore.Name = "colPracticeScore";
            colPracticeScore.Width = 150;
            // 
            // colProcessScore
            // 
            colProcessScore.HeaderText = "Process Score";
            colProcessScore.MinimumWidth = 8;
            colProcessScore.Name = "colProcessScore";
            colProcessScore.Width = 150;
            // 
            // colFinalScore
            // 
            colFinalScore.HeaderText = "Final Score";
            colFinalScore.MinimumWidth = 8;
            colFinalScore.Name = "colFinalScore";
            colFinalScore.Width = 150;
            // 
            // colTotalScore
            // 
            colTotalScore.HeaderText = "Total Score";
            colTotalScore.MinimumWidth = 8;
            colTotalScore.Name = "colTotalScore";
            colTotalScore.Width = 150;
            // 
            // btnSaveScore
            // 
            btnSaveScore.BackColor = SystemColors.ActiveCaption;
            btnSaveScore.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnSaveScore.Location = new Point(100, 142);
            btnSaveScore.Name = "btnSaveScore";
            btnSaveScore.Size = new Size(150, 29);
            btnSaveScore.TabIndex = 4;
            btnSaveScore.Text = "Lưu điểm";
            btnSaveScore.UseVisualStyleBackColor = false;
            btnSaveScore.Click += btnSaveScore_Click;
            // 
            // PKT_Registration
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            Controls.Add(btnSaveScore);
            Controls.Add(dtgvDangKy);
            Controls.Add(pnlBar);
            Controls.Add(lblRegistration);
            Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "PKT_Registration";
            Size = new Size(1414, 850);
            pnlBar.ResumeLayout(false);
            pnlBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvDangKy).EndInit();
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
        private DataGridView dtgvDangKy;
        private Button btnSaveScore;
        private DataGridViewTextBoxColumn colStudentID;
        private DataGridViewTextBoxColumn colCourseID;
        private DataGridViewTextBoxColumn colPracticeScore;
        private DataGridViewTextBoxColumn colProcessScore;
        private DataGridViewTextBoxColumn colFinalScore;
        private DataGridViewTextBoxColumn colTotalScore;
    }
}

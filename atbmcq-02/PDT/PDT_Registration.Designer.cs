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
            colStudentID = new DataGridViewTextBoxColumn();
            colCourseID = new DataGridViewTextBoxColumn();
            colPracticeScore = new DataGridViewTextBoxColumn();
            colProcessScore = new DataGridViewTextBoxColumn();
            colFinalScore = new DataGridViewTextBoxColumn();
            colTotalScore = new DataGridViewTextBoxColumn();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            pnlBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvOfficial).BeginInit();
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
            dtgvOfficial.Columns.AddRange(new DataGridViewColumn[] { colStudentID, colCourseID, colPracticeScore, colProcessScore, colFinalScore, colTotalScore });
            dtgvOfficial.Dock = DockStyle.Bottom;
            dtgvOfficial.Location = new Point(0, 177);
            dtgvOfficial.Name = "dtgvOfficial";
            dtgvOfficial.RowHeadersWidth = 62;
            dtgvOfficial.Size = new Size(1414, 673);
            dtgvOfficial.TabIndex = 3;
            // 
            // colStudentID
            // 
            colStudentID.HeaderText = "Student ID";
            colStudentID.MinimumWidth = 8;
            colStudentID.Name = "colStudentID";
            colStudentID.Width = 150;
            // 
            // colCourseID
            // 
            colCourseID.HeaderText = "Course ID";
            colCourseID.MinimumWidth = 8;
            colCourseID.Name = "colCourseID";
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
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.ActiveCaption;
            btnAdd.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.Location = new Point(100, 142);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = SystemColors.ActiveCaption;
            btnEdit.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnEdit.Location = new Point(200, 142);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 5;
            btnEdit.Text = "Sửa";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.ActiveCaption;
            btnDelete.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.Location = new Point(300, 142);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // PDT_Registration
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(dtgvOfficial);
            Controls.Add(pnlBar);
            Controls.Add(lblRegistration);
            Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "PDT_Registration";
            Size = new Size(1414, 850);
            pnlBar.ResumeLayout(false);
            pnlBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvOfficial).EndInit();
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
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private DataGridViewTextBoxColumn colStudentID;
        private DataGridViewTextBoxColumn colCourseID;
        private DataGridViewTextBoxColumn colPracticeScore;
        private DataGridViewTextBoxColumn colProcessScore;
        private DataGridViewTextBoxColumn colFinalScore;
        private DataGridViewTextBoxColumn colTotalScore;
    }
}

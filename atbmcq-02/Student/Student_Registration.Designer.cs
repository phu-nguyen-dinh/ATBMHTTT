﻿using OracleUserManager.Models;

namespace atbmcq_02
{
    partial class Student_Registration
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
            dtgvStudent = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            pnlBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvStudent).BeginInit();
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
            // dtgvStudent
            // 
            dtgvStudent.BackgroundColor = SystemColors.ButtonHighlight;
            dtgvStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvStudent.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6 });
            dtgvStudent.Dock = DockStyle.Bottom;
            dtgvStudent.Location = new Point(0, 201);
            dtgvStudent.Name = "dtgvStudent";
            dtgvStudent.RowHeadersWidth = 62;
            dtgvStudent.Size = new Size(1414, 649);
            dtgvStudent.TabIndex = 4;
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
            dataGridViewTextBoxColumn6.HeaderText = "Sumary Score 11111";
            dataGridViewTextBoxColumn6.MinimumWidth = 6;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.Width = 200;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.ActiveCaption;
            btnDelete.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDelete.Location = new Point(236, 155);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = SystemColors.ActiveCaption;
            btnEdit.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnEdit.Location = new Point(136, 155);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 8;
            btnEdit.Text = "Update";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.ActiveCaption;
            btnAdd.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAdd.Location = new Point(36, 155);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // Student_Registration
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(pnlBar);
            Controls.Add(lblRegistration);
            Controls.Add(dtgvStudent);
            Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Student_Registration";
            Size = new Size(1414, 850);
            pnlBar.ResumeLayout(false);
            pnlBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvStudent).EndInit();
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
        private DataGridView dtgvStudent;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAdd;
    }
}

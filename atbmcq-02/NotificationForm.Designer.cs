using OracleUserManager.Models;
using System.Windows.Forms;

namespace atbmcq_02
{
    partial class NotificationForm
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
            lstNotifications = new ListBox();
            btnClose = new Button();
            lblTitle = new Label();
            txtNotificationDetail = new TextBox();
            lblDetail = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // lstNotifications
            // 
            lstNotifications.Font = new Font("Segoe UI", 10F);
            lstNotifications.FormattingEnabled = true;
            lstNotifications.ItemHeight = 17;
            lstNotifications.Location = new Point(10, 69);
            lstNotifications.Margin = new Padding(3, 2, 3, 2);
            lstNotifications.Name = "lstNotifications";
            lstNotifications.Size = new Size(263, 242);
            lstNotifications.TabIndex = 0;
            lstNotifications.SelectedIndexChanged += lstNotifications_SelectedIndexChanged;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 10F);
            btnClose.Location = new Point(306, 326);
            btnClose.Margin = new Padding(3, 2, 3, 2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(88, 26);
            btnClose.TabIndex = 1;
            btnClose.Text = "Đóng";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.Location = new Point(264, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(145, 30);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "THÔNG BÁO";
            // 
            // txtNotificationDetail
            // 
            txtNotificationDetail.Font = new Font("Segoe UI", 10F);
            txtNotificationDetail.Location = new Point(289, 69);
            txtNotificationDetail.Margin = new Padding(3, 2, 3, 2);
            txtNotificationDetail.Multiline = true;
            txtNotificationDetail.Name = "txtNotificationDetail";
            txtNotificationDetail.ReadOnly = true;
            txtNotificationDetail.Size = new Size(386, 242);
            txtNotificationDetail.TabIndex = 3;
            // 
            // lblDetail
            // 
            lblDetail.AutoSize = true;
            lblDetail.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDetail.Location = new Point(289, 45);
            lblDetail.Name = "lblDetail";
            lblDetail.Size = new Size(133, 19);
            lblDetail.TabIndex = 4;
            lblDetail.Text = "Chi tiết thông báo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.Location = new Point(12, 45);
            label1.Name = "label1";
            label1.Size = new Size(133, 19);
            label1.TabIndex = 5;
            label1.Text = "Các thông báo";
            label1.Click += label1_Click;
            // 
            // NotificationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 368);
            Controls.Add(label1);
            Controls.Add(lblDetail);
            Controls.Add(txtNotificationDetail);
            Controls.Add(lblTitle);
            Controls.Add(btnClose);
            Controls.Add(lstNotifications);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "NotificationForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Thông báo";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstNotifications;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtNotificationDetail;
        private System.Windows.Forms.Label lblDetail;
        private Label label1;
    }
} 
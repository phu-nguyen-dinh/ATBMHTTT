using OracleUserManager.Models;
using System.Text.Json;
using System.Windows.Forms;

namespace atbmcq_02
{
    partial class Loggin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loggin));
            lblHeader = new Label();
            panel1 = new Panel();
            lblUsername = new Label();
            txtUsername = new TextBox();
            lblRole = new Label();
            cboRole = new ComboBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            bottomPanel = new Panel();
            btnTest = new Button();
            btnConnect = new Button();
            btnCancel = new Button();
            picLogo = new PictureBox();
            panel2 = new Panel();
            panel1.SuspendLayout();
            bottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Arial Rounded MT Bold", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHeader.Location = new Point(620, 9);
            lblHeader.Margin = new Padding(4, 0, 4, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(274, 83);
            lblHeader.TabIndex = 21;
            lblHeader.Text = "Loggin";
            lblHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblUsername);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(lblRole);
            panel1.Controls.Add(cboRole);
            panel1.Controls.Add(lblPassword);
            panel1.Controls.Add(txtPassword);
            panel1.Location = new Point(402, 114);
            panel1.Name = "panel1";
            panel1.Size = new Size(694, 242);
            panel1.TabIndex = 20;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(28, 40);
            lblUsername.Margin = new Padding(4, 0, 4, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(124, 29);
            lblUsername.TabIndex = 9;
            lblUsername.Text = "Username:";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(280, 37);
            txtUsername.Margin = new Padding(4, 3, 4, 3);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(390, 37);
            txtUsername.TabIndex = 10;
            txtUsername.Text = "C##ADMIN";
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Location = new Point(28, 172);
            lblRole.Margin = new Padding(4, 0, 4, 0);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(67, 29);
            lblRole.TabIndex = 11;
            lblRole.Text = "Role:";
            // 
            // cboRole
            // 
            cboRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cboRole.FormattingEnabled = true;
            cboRole.Items.AddRange(new object[] { "default" });
            cboRole.Location = new Point(280, 169);
            cboRole.Margin = new Padding(4, 3, 4, 3);
            cboRole.Name = "cboRole";
            cboRole.Size = new Size(390, 37);
            cboRole.TabIndex = 12;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(28, 108);
            lblPassword.Margin = new Padding(4, 0, 4, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(120, 29);
            lblPassword.TabIndex = 13;
            lblPassword.Text = "Password:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(280, 105);
            txtPassword.Margin = new Padding(4, 3, 4, 3);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(390, 37);
            txtPassword.TabIndex = 14;
            txtPassword.Text = "123456";
            // 
            // bottomPanel
            // 
            bottomPanel.Controls.Add(btnTest);
            bottomPanel.Controls.Add(btnConnect);
            bottomPanel.Controls.Add(btnCancel);
            bottomPanel.Location = new Point(402, 362);
            bottomPanel.Margin = new Padding(4, 3, 4, 3);
            bottomPanel.Name = "bottomPanel";
            bottomPanel.Size = new Size(694, 103);
            bottomPanel.TabIndex = 19;
            // 
            // btnTest
            // 
            btnTest.Location = new Point(28, 31);
            btnTest.Margin = new Padding(4, 3, 4, 3);
            btnTest.Name = "btnTest";
            btnTest.Size = new Size(140, 41);
            btnTest.TabIndex = 1;
            btnTest.Text = "Test";
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(280, 31);
            btnConnect.Margin = new Padding(4, 3, 4, 3);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(140, 41);
            btnConnect.TabIndex = 2;
            btnConnect.Text = "Connect";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(530, 31);
            btnCancel.Margin = new Padding(4, 3, 4, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(140, 41);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Cancel";
            // 
            // picLogo
            // 
            picLogo.Dock = DockStyle.Left;
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new Point(0, 0);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(392, 465);
            picLogo.SizeMode = PictureBoxSizeMode.CenterImage;
            picLogo.TabIndex = 22;
            picLogo.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Desktop;
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(392, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1, 465);
            panel2.TabIndex = 23;
            // 
            // Loggin
            // 
            AutoScaleDimensions = new SizeF(14F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1104, 465);
            Controls.Add(panel2);
            Controls.Add(picLogo);
            Controls.Add(lblHeader);
            Controls.Add(panel1);
            Controls.Add(bottomPanel);
            Font = new Font("Times New Roman", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Loggin";
            Text = "Connection";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            bottomPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeader;
        private Panel panel1;
        private Label lblUsername;
        private TextBox txtUsername;
        private Label lblRole;
        private ComboBox cboRole;
        private Label lblPassword;
        private TextBox txtPassword;
        private Panel bottomPanel;
        private Button btnTest;
        private Button btnConnect;
        private Button btnCancel;
        private PictureBox picLogo;
        private Panel panel2;
    }
}
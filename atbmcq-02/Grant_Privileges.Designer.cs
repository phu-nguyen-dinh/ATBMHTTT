// Add these using statements if they are missing
using OracleUserManager.Models;
using System.Data.Common;
using System.Diagnostics;
using System.Windows.Forms;
using System.Xml.Linq;

namespace atbmcq_02
{
    partial class Grant_Privileges
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
            grpPrivileges = new GroupBox();
            pnlSYS = new Panel();
            txtSystemPrivilege = new TextBox();
            lblSystemPrivilege = new Label();
            lblGrantType = new Label();
            cmbGrantType = new ComboBox();
            pnlObjectDetails = new Panel();
            lblObjectOwner = new Label();
            txtObjectOwner = new TextBox();
            lblObjectName = new Label();
            txtObjectName = new TextBox();
            lblObjectPrivilege = new Label();
            cmbObjectPrivilege = new ComboBox();
            pnlColumns = new Panel();
            txtColumns = new TextBox();
            lblColumns = new Label();
            chkGrantOption = new CheckBox();
            chkAdminOption = new CheckBox();
            lblGrantee = new Label();
            txtGrantee = new TextBox();
            btnGrant = new Button();
            btnRevoke = new Button();
            lstPrivileges = new ListView();
            UserOrRole = new ColumnHeader();
            Privilege = new ColumnHeader();
            Target = new ColumnHeader();
            Grantable = new ColumnHeader();
            grpPrivileges.SuspendLayout();
            pnlSYS.SuspendLayout();
            pnlObjectDetails.SuspendLayout();
            pnlColumns.SuspendLayout();
            SuspendLayout();
            // 
            // grpPrivileges
            // 
            grpPrivileges.Controls.Add(pnlSYS);
            grpPrivileges.Controls.Add(lblGrantType);
            grpPrivileges.Controls.Add(cmbGrantType);
            grpPrivileges.Controls.Add(pnlObjectDetails);
            grpPrivileges.Controls.Add(chkAdminOption);
            grpPrivileges.Controls.Add(lblGrantee);
            grpPrivileges.Controls.Add(txtGrantee);
            grpPrivileges.Controls.Add(btnGrant);
            grpPrivileges.Controls.Add(btnRevoke);
            grpPrivileges.Controls.Add(lstPrivileges);
            grpPrivileges.Dock = DockStyle.Fill;
            grpPrivileges.Location = new Point(0, 0);
            grpPrivileges.Margin = new Padding(5, 3, 5, 3);
            grpPrivileges.Name = "grpPrivileges";
            grpPrivileges.Padding = new Padding(5, 3, 5, 3);
            grpPrivileges.Size = new Size(1592, 535);
            grpPrivileges.TabIndex = 0;
            grpPrivileges.TabStop = false;
            grpPrivileges.Text = "Privilege Management";
            // 
            // pnlSYS
            // 
            pnlSYS.Controls.Add(txtSystemPrivilege);
            pnlSYS.Controls.Add(lblSystemPrivilege);
            pnlSYS.Location = new Point(30, 191);
            pnlSYS.Name = "pnlSYS";
            pnlSYS.Size = new Size(476, 65);
            pnlSYS.TabIndex = 12;
            // 
            // txtSystemPrivilege
            // 
            txtSystemPrivilege.Location = new Point(161, 14);
            txtSystemPrivilege.Name = "txtSystemPrivilege";
            txtSystemPrivilege.Size = new Size(290, 37);
            txtSystemPrivilege.TabIndex = 1;
            // 
            // lblSystemPrivilege
            // 
            lblSystemPrivilege.AutoSize = true;
            lblSystemPrivilege.Location = new Point(0, 22);
            lblSystemPrivilege.Name = "lblSystemPrivilege";
            lblSystemPrivilege.Size = new Size(155, 29);
            lblSystemPrivilege.TabIndex = 0;
            lblSystemPrivilege.Text = "SYSPrivilege:";
            // 
            // lblGrantType
            // 
            lblGrantType.AutoSize = true;
            lblGrantType.Location = new Point(30, 69);
            lblGrantType.Margin = new Padding(4, 0, 4, 0);
            lblGrantType.Name = "lblGrantType";
            lblGrantType.Size = new Size(136, 29);
            lblGrantType.TabIndex = 1;
            lblGrantType.Text = "Grant Type:";
            // 
            // cmbGrantType
            // 
            cmbGrantType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGrantType.FormattingEnabled = true;
            cmbGrantType.Items.AddRange(new object[] { "Object", "System" });
            cmbGrantType.Location = new Point(191, 66);
            cmbGrantType.Margin = new Padding(4, 3, 4, 3);
            cmbGrantType.Name = "cmbGrantType";
            cmbGrantType.Size = new Size(290, 37);
            cmbGrantType.TabIndex = 2;
            cmbGrantType.SelectedIndexChanged += cmbGrantType_SelectedIndexChanged;
            // 
            // pnlObjectDetails
            // 
            pnlObjectDetails.Controls.Add(lblObjectOwner);
            pnlObjectDetails.Controls.Add(txtObjectOwner);
            pnlObjectDetails.Controls.Add(lblObjectName);
            pnlObjectDetails.Controls.Add(txtObjectName);
            pnlObjectDetails.Controls.Add(lblObjectPrivilege);
            pnlObjectDetails.Controls.Add(cmbObjectPrivilege);
            pnlObjectDetails.Controls.Add(pnlColumns);
            pnlObjectDetails.Controls.Add(chkGrantOption);
            pnlObjectDetails.Location = new Point(600, 85);
            pnlObjectDetails.Name = "pnlObjectDetails";
            pnlObjectDetails.Size = new Size(966, 185);
            pnlObjectDetails.TabIndex = 5;
            pnlObjectDetails.Visible = false;
            // 
            // lblObjectOwner
            // 
            lblObjectOwner.AutoSize = true;
            lblObjectOwner.Location = new Point(4, 12);
            lblObjectOwner.Name = "lblObjectOwner";
            lblObjectOwner.Size = new Size(167, 29);
            lblObjectOwner.TabIndex = 0;
            lblObjectOwner.Text = "Object Owner:";
            // 
            // txtObjectOwner
            // 
            txtObjectOwner.Location = new Point(177, 9);
            txtObjectOwner.Name = "txtObjectOwner";
            txtObjectOwner.Size = new Size(276, 37);
            txtObjectOwner.TabIndex = 1;
            // 
            // lblObjectName
            // 
            lblObjectName.AutoSize = true;
            lblObjectName.Location = new Point(4, 77);
            lblObjectName.Name = "lblObjectName";
            lblObjectName.Size = new Size(158, 29);
            lblObjectName.TabIndex = 2;
            lblObjectName.Text = "Object Name:";
            // 
            // txtObjectName
            // 
            txtObjectName.Location = new Point(177, 74);
            txtObjectName.Name = "txtObjectName";
            txtObjectName.Size = new Size(276, 37);
            txtObjectName.TabIndex = 3;
            // 
            // lblObjectPrivilege
            // 
            lblObjectPrivilege.AutoSize = true;
            lblObjectPrivilege.Location = new Point(4, 142);
            lblObjectPrivilege.Name = "lblObjectPrivilege";
            lblObjectPrivilege.Size = new Size(108, 29);
            lblObjectPrivilege.TabIndex = 4;
            lblObjectPrivilege.Text = "Privilege:";
            // 
            // cmbObjectPrivilege
            // 
            cmbObjectPrivilege.FormattingEnabled = true;
            cmbObjectPrivilege.Items.AddRange(new object[] { "SELECT", "INSERT", "UPDATE", "DELETE", "EXECUTE", "REFERENCES" });
            cmbObjectPrivilege.Location = new Point(177, 134);
            cmbObjectPrivilege.Name = "cmbObjectPrivilege";
            cmbObjectPrivilege.Size = new Size(276, 37);
            cmbObjectPrivilege.TabIndex = 5;
            cmbObjectPrivilege.SelectedIndexChanged += cmbObjectPrivilege_SelectedIndexChanged;
            cmbObjectPrivilege.TextChanged += cmbObjectPrivilege_TextChanged;
            // 
            // pnlColumns
            // 
            pnlColumns.Controls.Add(txtColumns);
            pnlColumns.Controls.Add(lblColumns);
            pnlColumns.Location = new Point(569, 3);
            pnlColumns.Margin = new Padding(4, 3, 4, 3);
            pnlColumns.Name = "pnlColumns";
            pnlColumns.Size = new Size(334, 54);
            pnlColumns.TabIndex = 6;
            pnlColumns.Visible = false;
            // 
            // txtColumns
            // 
            txtColumns.Location = new Point(102, 5);
            txtColumns.Margin = new Padding(4, 3, 4, 3);
            txtColumns.Name = "txtColumns";
            txtColumns.Size = new Size(215, 37);
            txtColumns.TabIndex = 1;
            // 
            // lblColumns
            // 
            lblColumns.AutoSize = true;
            lblColumns.Location = new Point(4, 9);
            lblColumns.Margin = new Padding(4, 0, 4, 0);
            lblColumns.Name = "lblColumns";
            lblColumns.Size = new Size(111, 29);
            lblColumns.TabIndex = 0;
            lblColumns.Text = "Columns:";
            // 
            // chkGrantOption
            // 
            chkGrantOption.AutoSize = true;
            chkGrantOption.Location = new Point(569, 85);
            chkGrantOption.Name = "chkGrantOption";
            chkGrantOption.Size = new Size(231, 33);
            chkGrantOption.TabIndex = 7;
            chkGrantOption.Text = "With Grant Option";
            chkGrantOption.UseVisualStyleBackColor = true;
            // 
            // chkAdminOption
            // 
            chkAdminOption.AutoSize = true;
            chkAdminOption.Location = new Point(600, 36);
            chkAdminOption.Name = "chkAdminOption";
            chkAdminOption.Size = new Size(242, 33);
            chkAdminOption.TabIndex = 8;
            chkAdminOption.Text = "With Admin Option";
            chkAdminOption.UseVisualStyleBackColor = true;
            chkAdminOption.Visible = false;
            // 
            // lblGrantee
            // 
            lblGrantee.AutoSize = true;
            lblGrantee.Location = new Point(30, 141);
            lblGrantee.Margin = new Padding(4, 0, 4, 0);
            lblGrantee.Name = "lblGrantee";
            lblGrantee.Size = new Size(122, 29);
            lblGrantee.TabIndex = 3;
            lblGrantee.Text = "User/Role:";
            // 
            // txtGrantee
            // 
            txtGrantee.Location = new Point(191, 138);
            txtGrantee.Margin = new Padding(4, 3, 4, 3);
            txtGrantee.Name = "txtGrantee";
            txtGrantee.Size = new Size(290, 37);
            txtGrantee.TabIndex = 4;
            // 
            // btnGrant
            // 
            btnGrant.Location = new Point(1169, 30);
            btnGrant.Margin = new Padding(4, 3, 4, 3);
            btnGrant.Name = "btnGrant";
            btnGrant.Size = new Size(174, 43);
            btnGrant.TabIndex = 9;
            btnGrant.Text = "Grant";
            btnGrant.Click += btnGrant_Click;
            // 
            // btnRevoke
            // 
            btnRevoke.AutoSize = true;
            btnRevoke.Location = new Point(1392, 30);
            btnRevoke.Margin = new Padding(4, 3, 4, 3);
            btnRevoke.Name = "btnRevoke";
            btnRevoke.Size = new Size(174, 43);
            btnRevoke.TabIndex = 10;
            btnRevoke.Text = "Revoke";
            btnRevoke.Click += RevokePrivilege;
            // 
            // lstPrivileges
            // 
            lstPrivileges.Columns.AddRange(new ColumnHeader[] { UserOrRole, Privilege, Target, Grantable });
            lstPrivileges.Location = new Point(30, 290);
            lstPrivileges.Margin = new Padding(4, 3, 4, 3);
            lstPrivileges.Name = "lstPrivileges";
            lstPrivileges.Size = new Size(1536, 239);
            lstPrivileges.TabIndex = 11;
            lstPrivileges.UseCompatibleStateImageBehavior = false;
            lstPrivileges.View = View.Details;
            // 
            // UserOrRole
            // 
            UserOrRole.Text = "User/Role";
            UserOrRole.Width = 384;
            // 
            // Privilege
            // 
            Privilege.Text = "Privilege";
            Privilege.Width = 384;
            // 
            // Target
            // 
            Target.Text = "Object/Details";
            Target.Width = 384;
            // 
            // Grantable
            // 
            Grantable.Text = "Grantable";
            Grantable.Width = 384;
            // 
            // Grant_Privileges
            // 
            AutoScaleDimensions = new SizeF(14F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(grpPrivileges);
            Font = new Font("Times New Roman", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Grant_Privileges";
            Size = new Size(1592, 535);
            Load += Grant_Privileges_Load;
            grpPrivileges.ResumeLayout(false);
            grpPrivileges.PerformLayout();
            pnlSYS.ResumeLayout(false);
            pnlSYS.PerformLayout();
            pnlObjectDetails.ResumeLayout(false);
            pnlObjectDetails.PerformLayout();
            pnlColumns.ResumeLayout(false);
            pnlColumns.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private OracleDbConnection _connection;
        private GroupBox grpPrivileges;
        private Label lblGrantee;
        private TextBox txtGrantee;
        private Button btnGrant;
        private Button btnRevoke;
        private ListView lstPrivileges;
        private ColumnHeader UserOrRole;
        private ColumnHeader Privilege;
        private ColumnHeader Target;
        private ColumnHeader Grantable;
        private Label lblGrantType;
        private ComboBox cmbGrantType;
        private Panel pnlObjectDetails;
        private Label lblObjectOwner;
        private TextBox txtObjectOwner;
        private Label lblObjectName;
        private TextBox txtObjectName;
        private Label lblObjectPrivilege;
        private ComboBox cmbObjectPrivilege;
        private Panel pnlColumns;
        private TextBox txtColumns;
        private Label lblColumns;
        private CheckBox chkGrantOption;
        private Label lblSystemPrivilege;
        private TextBox txtSystemPrivilege;
        private CheckBox chkAdminOption;
        private Panel pnlSYS;
    }
}
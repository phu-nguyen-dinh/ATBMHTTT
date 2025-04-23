using OracleUserManager.Models;
using System.Text.Json;
using System.Windows.Forms;

namespace atbmcq_02
{
    partial class Connection
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
            tabControl = new TabControl();
            tabDetails = new TabPage();
            tabAdvanced = new TabPage();
            lblAuthType = new Label();
            cboAuthType = new ComboBox();
            lblUsername = new Label();
            txtUsername = new TextBox();
            lblRole = new Label();
            cboRole = new ComboBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            chkSavePassword = new CheckBox();
            lblConnType = new Label();
            cboConnType = new ComboBox();
            lblHostname = new Label();
            cboHostname = new ComboBox();
            lblPort = new Label();
            txtPort = new TextBox();
            radSID = new RadioButton();
            radServiceName = new RadioButton();
            txtSID = new TextBox();
            txtServiceName = new TextBox();
            btnConnect = new Button();
            btnTest = new Button();
            btnClear = new Button();
            btnCancel = new Button();
            btnSave = new Button();
            label1 = new Label();
            lstSavedAccounts = new ListView();
            colUsername = new ColumnHeader();
            colHostname = new ColumnHeader();
            colRole = new ColumnHeader();
            splitContainer = new SplitContainer();
            accountContextMenu = new ContextMenuStrip();
            btnEdit = new Button();
            btnDelete = new Button();

            tabControl.SuspendLayout();
            tabDetails.SuspendLayout();
            splitContainer.SuspendLayout();
            SuspendLayout();

            // splitContainer
            splitContainer.Dock = DockStyle.None;
            splitContainer.Location = new Point(27, 20);
            splitContainer.Name = "splitContainer";
            splitContainer.Panel1.Controls.Add(lstSavedAccounts);
            splitContainer.Panel2.Controls.Add(tabControl);
            splitContainer.Size = new Size(1137, 450);
            splitContainer.SplitterDistance = 300;
            splitContainer.TabIndex = 0;

            // Create a panel for buttons at the bottom
            Panel bottomPanel = new Panel();
            bottomPanel.Dock = DockStyle.Bottom;
            bottomPanel.Height = 60;
            bottomPanel.Location = new Point(27, 480);
            bottomPanel.Size = new Size(1137, 60);

            // Add buttons to the bottom panel
            bottomPanel.Controls.Add(btnSave);
            bottomPanel.Controls.Add(btnClear);
            bottomPanel.Controls.Add(btnTest);
            bottomPanel.Controls.Add(btnConnect);
            bottomPanel.Controls.Add(btnCancel);

            // btnSave
            btnSave.Location = new Point(510, 10);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 35);
            btnSave.Text = "Save";

            // btnClear
            btnClear.Location = new Point(620, 10);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(100, 35);
            btnClear.Text = "Clear";

            // btnTest
            btnTest.Location = new Point(730, 10);
            btnTest.Name = "btnTest";
            btnTest.Size = new Size(100, 35);
            btnTest.Text = "Test";

            // btnConnect
            btnConnect.Location = new Point(840, 10);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(100, 35);
            btnConnect.Text = "Connect";

            // btnCancel
            btnCancel.Location = new Point(950, 10);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(100, 35);
            btnCancel.Text = "Cancel";

            // Add panels to form
            Controls.Add(splitContainer);
            Controls.Add(bottomPanel);

            // lstSavedAccounts
            lstSavedAccounts.Columns.AddRange(new ColumnHeader[] { colUsername, colHostname, colRole });
            lstSavedAccounts.Dock = DockStyle.Fill;
            lstSavedAccounts.FullRowSelect = true;
            lstSavedAccounts.GridLines = true;
            lstSavedAccounts.Location = new Point(0, 0);
            lstSavedAccounts.Name = "lstSavedAccounts";
            lstSavedAccounts.Size = new Size(300, 450);
            lstSavedAccounts.TabIndex = 0;
            lstSavedAccounts.UseCompatibleStateImageBehavior = false;
            lstSavedAccounts.View = View.Details;
            lstSavedAccounts.ContextMenuStrip = accountContextMenu;
            lstSavedAccounts.SelectedIndexChanged += lstSavedAccounts_SelectedIndexChanged;

            // Create context menu for ListView
            accountContextMenu = new ContextMenuStrip();
            var editMenuItem = new ToolStripMenuItem("Edit");
            var deleteMenuItem = new ToolStripMenuItem("Delete");
            accountContextMenu.Items.AddRange(new ToolStripItem[] { editMenuItem, deleteMenuItem });
            editMenuItem.Click += EditAccount_Click;
            deleteMenuItem.Click += DeleteAccount_Click;

            // Panel for list buttons
            Panel listButtonPanel = new Panel();
            listButtonPanel.Dock = DockStyle.Bottom;
            listButtonPanel.Height = 40;
            listButtonPanel.Parent = splitContainer.Panel1;

            // Edit button
            btnEdit = new Button();
            btnEdit.Text = "Edit";
            btnEdit.Size = new Size(100, 35);
            btnEdit.Location = new Point(20, 2);
            btnEdit.Name = "btnEdit";
            btnEdit.Click += EditAccount_Click;
            btnEdit.Enabled = false;
            listButtonPanel.Controls.Add(btnEdit);

            // Delete button
            btnDelete = new Button();
            btnDelete.Text = "Delete";
            btnDelete.Size = new Size(100, 35);
            btnDelete.Location = new Point(130, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Click += DeleteAccount_Click;
            btnDelete.Enabled = false;
            listButtonPanel.Controls.Add(btnDelete);

            // Adjust ListView to make room for buttons
            lstSavedAccounts.Dock = DockStyle.Fill;
            splitContainer.Panel1.Controls.Add(listButtonPanel);

            // colUsername
            colUsername.Text = "Username";
            colUsername.Width = 100;

            // colHostname
            colHostname.Text = "Hostname";
            colHostname.Width = 100;

            // colRole
            colRole.Text = "Role";
            colRole.Width = 100;

            // tabControl
            tabControl.Controls.Add(tabDetails);
            tabControl.Controls.Add(tabAdvanced);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Location = new Point(0, 0);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(833, 450);
            tabControl.TabIndex = 0;

            // tabDetails
            tabDetails.Controls.Add(lblAuthType);
            tabDetails.Controls.Add(cboAuthType);
            tabDetails.Controls.Add(lblUsername);
            tabDetails.Controls.Add(txtUsername);
            tabDetails.Controls.Add(lblRole);
            tabDetails.Controls.Add(cboRole);
            tabDetails.Controls.Add(lblPassword);
            tabDetails.Controls.Add(txtPassword);
            tabDetails.Controls.Add(chkSavePassword);
            tabDetails.Controls.Add(lblConnType);
            tabDetails.Controls.Add(cboConnType);
            tabDetails.Controls.Add(lblHostname);
            tabDetails.Controls.Add(cboHostname);
            tabDetails.Controls.Add(lblPort);
            tabDetails.Controls.Add(txtPort);
            tabDetails.Controls.Add(radSID);
            tabDetails.Controls.Add(radServiceName);
            tabDetails.Controls.Add(txtSID);
            tabDetails.Controls.Add(txtServiceName);
            tabDetails.Location = new Point(4, 34);
            tabDetails.Name = "tabDetails";
            tabDetails.Size = new Size(1129, 412);
            tabDetails.TabIndex = 0;
            tabDetails.Text = "Details";

            // tabAdvanced
            tabAdvanced.Location = new Point(4, 34);
            tabAdvanced.Name = "tabAdvanced";
            tabAdvanced.Size = new Size(1129, 412);
            tabAdvanced.TabIndex = 1;
            tabAdvanced.Text = "Advanced";

            // lblAuthType
            lblAuthType.AutoSize = true;
            lblAuthType.Location = new Point(20, 20);
            lblAuthType.Name = "lblAuthType";
            lblAuthType.Size = new Size(150, 25);
            lblAuthType.Text = "Authentication Type";

            // cboAuthType
            cboAuthType.DropDownStyle = ComboBoxStyle.DropDownList;
            cboAuthType.FormattingEnabled = true;
            cboAuthType.Items.AddRange(new object[] { "Default" });
            cboAuthType.Location = new Point(200, 20);
            cboAuthType.Name = "cboAuthType";
            cboAuthType.Size = new Size(220, 33);
            cboAuthType.SelectedIndex = 0;

            // lblUsername
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(20, 70);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(91, 25);
            lblUsername.Text = "Username:";

            // txtUsername
            txtUsername.Location = new Point(180, 70);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(300, 31);

            // lblRole
            lblRole.AutoSize = true;
            lblRole.Location = new Point(500, 70);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(50, 25);
            lblRole.Text = "Role:";

            // cboRole
            cboRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cboRole.FormattingEnabled = true;
            cboRole.Items.AddRange(new object[] { 
                "default", 
                "SYSDBA",
                "SYSOPER",
                "SYSBACKUP",
                "SYSDG",
                "SYSKM",
                "SYSRAC"
            });
            cboRole.Location = new Point(560, 70);
            cboRole.Name = "cboRole";
            cboRole.Size = new Size(200, 33);
            cboRole.SelectedIndex = 0;

            // lblPassword
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(20, 120);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(87, 25);
            lblPassword.Text = "Password:";

            // txtPassword
            txtPassword.Location = new Point(180, 120);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(300, 31);

            // chkSavePassword
            chkSavePassword.AutoSize = true;
            chkSavePassword.Location = new Point(500, 120);
            chkSavePassword.Name = "chkSavePassword";
            chkSavePassword.Size = new Size(150, 29);
            chkSavePassword.Text = "Save Password";

            // lblConnType
            lblConnType.AutoSize = true;
            lblConnType.Location = new Point(20, 170);
            lblConnType.Name = "lblConnType";
            lblConnType.Size = new Size(140, 25);
            lblConnType.Text = "Connection Type:";

            // cboConnType
            cboConnType.DropDownStyle = ComboBoxStyle.DropDownList;
            cboConnType.FormattingEnabled = true;
            cboConnType.Items.AddRange(new object[] { "Basic" });
            cboConnType.Location = new Point(180, 170);
            cboConnType.Name = "cboConnType";
            cboConnType.Size = new Size(200, 33);
            cboConnType.SelectedIndex = 0;

            // lblHostname
            lblHostname.AutoSize = true;
            lblHostname.Location = new Point(20, 220);
            lblHostname.Name = "lblHostname";
            lblHostname.Size = new Size(89, 25);
            lblHostname.Text = "Hostname:";

            // cboHostname
            cboHostname.DropDownStyle = ComboBoxStyle.DropDown;
            cboHostname.FormattingEnabled = true;
            cboHostname.Location = new Point(180, 220);
            cboHostname.Name = "cboHostname";
            cboHostname.Size = new Size(580, 33);
            cboHostname.Text = "localhost";
            cboHostname.Items.AddRange(new object[] { "localhost", "127.0.0.1" });

            // lblPort
            lblPort.AutoSize = true;
            lblPort.Location = new Point(20, 270);
            lblPort.Name = "lblPort";
            lblPort.Size = new Size(47, 25);
            lblPort.Text = "Port:";

            // txtPort
            txtPort.Location = new Point(180, 270);
            txtPort.Name = "txtPort";
            txtPort.Size = new Size(580, 31);
            txtPort.Text = "1521";

            // radSID
            radSID.AutoSize = true;
            radSID.Checked = true;
            radSID.Location = new Point(20, 320);
            radSID.Name = "radSID";
            radSID.Size = new Size(65, 29);
            radSID.TabStop = true;
            radSID.Text = "SID";
            radSID.CheckedChanged += OnConnectionTypeChanged;

            // radServiceName
            radServiceName.AutoSize = true;
            radServiceName.Location = new Point(20, 360);
            radServiceName.Name = "radServiceName";
            radServiceName.Size = new Size(140, 29);
            radServiceName.Text = "Service name";
            radServiceName.CheckedChanged += OnConnectionTypeChanged;

            // txtSID
            txtSID.Location = new Point(180, 320);
            txtSID.Name = "txtSID";
            txtSID.Size = new Size(580, 31);
            txtSID.Text = "xe";

            // txtServiceName
            txtServiceName.Location = new Point(180, 360);
            txtServiceName.Name = "txtServiceName";
            txtServiceName.Size = new Size(580, 31);
            txtServiceName.Enabled = false;

            // Connection Form
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1187, 540);
            Name = "Connection";
            Text = "Connection";
            tabControl.ResumeLayout(false);
            tabDetails.ResumeLayout(false);
            tabDetails.PerformLayout();
            splitContainer.ResumeLayout(false);
            ResumeLayout(false);
        }

        private void OnConnectionTypeChanged(object sender, EventArgs e)
        {
            txtSID.Enabled = radSID.Checked;
            txtServiceName.Enabled = radServiceName.Checked;
        }

        #endregion

        private TabControl tabControl;
        private TabPage tabDetails;
        private TabPage tabAdvanced;
        private Label lblAuthType;
        private ComboBox cboAuthType;
        private Label lblUsername;
        private TextBox txtUsername;
        private Label lblRole;
        private ComboBox cboRole;
        private Label lblPassword;
        private TextBox txtPassword;
        private CheckBox chkSavePassword;
        private Label lblConnType;
        private ComboBox cboConnType;
        private Label lblHostname;
        private ComboBox cboHostname;
        private Label lblPort;
        private TextBox txtPort;
        private RadioButton radSID;
        private RadioButton radServiceName;
        private TextBox txtSID;
        private TextBox txtServiceName;
        private Button btnConnect;
        private Button btnTest;
        private Button btnClear;
        private Button btnCancel;
        private Button btnSave;
        private Label label1;
        private SplitContainer splitContainer;
        private ListView lstSavedAccounts;
        private ColumnHeader colUsername;
        private ColumnHeader colHostname;
        private ColumnHeader colRole;
        private Button btnEdit;
        private Button btnDelete;
        private ContextMenuStrip accountContextMenu;
    }
}
using OracleUserManager.Models;

namespace atbmcq_02
{
    partial class MainForm
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
            grpConnection = new GroupBox();
            lblHostname = new Label();
            txtHostname = new TextBox();
            lblPort = new Label();
            txtPort = new TextBox();
            lblSID = new Label();
            txtSID = new TextBox();
            lblUsername = new Label();
            txtUsername = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            btnConnect = new Button();
            tabControl = new TabControl();
            tabManage = new TabPage();
            grpUserRole = new GroupBox();
            radUser = new RadioButton();
            radRole = new RadioButton();
            lblName = new Label();
            txtName = new TextBox();
            lblUserPass = new Label();
            txtUserPass = new TextBox();
            chkExisting = new CheckBox();
            btnCreate = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            tabList = new TabPage();
            cboFilter = new ComboBox();
            lstUsers = new ListView();
            Ten = new ColumnHeader();
            DSLoai = new ColumnHeader();
            TrangThai = new ColumnHeader();
            NgayTao = new ColumnHeader();
            btnRefresh = new Button();
            tabPrivileges = new TabPage();
            grpPrivileges = new GroupBox();
            lblGrantee = new Label();
            txtGrantee = new TextBox();
            lblPrivilege = new Label();
            cboPrivilege = new ComboBox();
            lblObject = new Label();
            txtObject = new TextBox();
            btnGrant = new Button();
            btnRevoke = new Button();
            lstPrivileges = new ListView();
            UserOrRole = new ColumnHeader();
            Quyen = new ColumnHeader();
            DoiTuong = new ColumnHeader();
            QLoai = new ColumnHeader();
            tabTablespaces = new TabPage();
            grpTablespaces = new GroupBox();
            lblTablespace = new Label();
            txtTablespace = new TextBox();
            lblSize = new Label();
            txtSize = new TextBox();
            btnCreateTS = new Button();
            btnDropTS = new Button();
            btnResizeTS = new Button();
            lstTablespaces = new ListView();
            TBSTen = new ColumnHeader();
            KichThuoc = new ColumnHeader();
            TBSTrangThai = new ColumnHeader();
            TBSTDMR = new ColumnHeader();
            tabAudit = new TabPage();
            grpAudit = new GroupBox();
            lstAudit = new ListView();
            btnRefreshAudit = new Button();
            ThoiGian = new ColumnHeader();
            User = new ColumnHeader();
            HanhDong = new ColumnHeader();
            TDDoiTuong = new ColumnHeader();
            TDTrangThai = new ColumnHeader();
            grpConnection.SuspendLayout();
            tabControl.SuspendLayout();
            tabManage.SuspendLayout();
            grpUserRole.SuspendLayout();
            tabList.SuspendLayout();
            tabPrivileges.SuspendLayout();
            grpPrivileges.SuspendLayout();
            tabTablespaces.SuspendLayout();
            grpTablespaces.SuspendLayout();
            tabAudit.SuspendLayout();
            grpAudit.SuspendLayout();
            SuspendLayout();
            // 
            // grpConnection
            // 
            grpConnection.AutoSize = true;
            grpConnection.Controls.Add(lblHostname);
            grpConnection.Controls.Add(txtHostname);
            grpConnection.Controls.Add(lblPort);
            grpConnection.Controls.Add(txtPort);
            grpConnection.Controls.Add(lblSID);
            grpConnection.Controls.Add(txtSID);
            grpConnection.Controls.Add(lblUsername);
            grpConnection.Controls.Add(txtUsername);
            grpConnection.Controls.Add(lblPassword);
            grpConnection.Controls.Add(txtPassword);
            grpConnection.Controls.Add(btnConnect);
            grpConnection.Location = new Point(14, 12);
            grpConnection.Margin = new Padding(4, 3, 4, 3);
            grpConnection.Name = "grpConnection";
            grpConnection.Padding = new Padding(4, 3, 4, 3);
            grpConnection.Size = new Size(1137, 279);
            grpConnection.TabIndex = 0;
            grpConnection.TabStop = false;
            grpConnection.Text = "Thông tin kết nối Oracle DB";
            // 
            // lblHostname
            // 
            lblHostname.AutoSize = true;
            lblHostname.Location = new Point(28, 60);
            lblHostname.Margin = new Padding(4, 0, 4, 0);
            lblHostname.Name = "lblHostname";
            lblHostname.Size = new Size(125, 29);
            lblHostname.TabIndex = 0;
            lblHostname.Text = "Hostname:";
            // 
            // txtHostname
            // 
            txtHostname.Location = new Point(210, 57);
            txtHostname.Margin = new Padding(4, 3, 4, 3);
            txtHostname.Name = "txtHostname";
            txtHostname.Size = new Size(278, 37);
            txtHostname.TabIndex = 1;
            txtHostname.Text = "localhost";
            // 
            // lblPort
            // 
            lblPort.AutoSize = true;
            lblPort.Location = new Point(545, 60);
            lblPort.Margin = new Padding(4, 0, 4, 0);
            lblPort.Name = "lblPort";
            lblPort.Size = new Size(63, 29);
            lblPort.TabIndex = 4;
            lblPort.Text = "Port:";
            // 
            // txtPort
            // 
            txtPort.Location = new Point(630, 57);
            txtPort.Margin = new Padding(4, 3, 4, 3);
            txtPort.Name = "txtPort";
            txtPort.Size = new Size(96, 37);
            txtPort.TabIndex = 5;
            txtPort.Text = "1521";
            // 
            // lblSID
            // 
            lblSID.AutoSize = true;
            lblSID.Location = new Point(28, 109);
            lblSID.Margin = new Padding(4, 0, 4, 0);
            lblSID.Name = "lblSID";
            lblSID.Size = new Size(60, 29);
            lblSID.TabIndex = 2;
            lblSID.Text = "SID:";
            // 
            // txtSID
            // 
            txtSID.Location = new Point(210, 106);
            txtSID.Margin = new Padding(4, 3, 4, 3);
            txtSID.Name = "txtSID";
            txtSID.Size = new Size(278, 37);
            txtSID.TabIndex = 3;
            txtSID.Text = "xe";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(28, 157);
            lblUsername.Margin = new Padding(4, 0, 4, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(124, 29);
            lblUsername.TabIndex = 6;
            lblUsername.Text = "Username:";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(210, 154);
            txtUsername.Margin = new Padding(4, 3, 4, 3);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(516, 37);
            txtUsername.TabIndex = 7;
            txtUsername.Text = "sys";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(28, 209);
            lblPassword.Margin = new Padding(4, 0, 4, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(120, 29);
            lblPassword.TabIndex = 8;
            lblPassword.Text = "Password:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(210, 206);
            txtPassword.Margin = new Padding(4, 3, 4, 3);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(516, 37);
            txtPassword.TabIndex = 9;
            // 
            // btnConnect
            // 
            btnConnect.AutoSize = true;
            btnConnect.Location = new Point(869, 152);
            btnConnect.Margin = new Padding(4, 3, 4, 3);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(140, 39);
            btnConnect.TabIndex = 6;
            btnConnect.Text = "Kết nối";
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabManage);
            tabControl.Controls.Add(tabList);
            tabControl.Controls.Add(tabPrivileges);
            tabControl.Controls.Add(tabTablespaces);
            tabControl.Controls.Add(tabAudit);
            tabControl.Location = new Point(14, 319);
            tabControl.Margin = new Padding(4, 3, 4, 3);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1137, 461);
            tabControl.TabIndex = 1;
            // 
            // tabManage
            // 
            tabManage.Controls.Add(grpUserRole);
            tabManage.Location = new Point(4, 38);
            tabManage.Margin = new Padding(4, 3, 4, 3);
            tabManage.Name = "tabManage";
            tabManage.Padding = new Padding(4, 3, 4, 3);
            tabManage.Size = new Size(1129, 419);
            tabManage.TabIndex = 0;
            tabManage.Text = "Quản lý User / Role";
            // 
            // grpUserRole
            // 
            grpUserRole.Controls.Add(radUser);
            grpUserRole.Controls.Add(radRole);
            grpUserRole.Controls.Add(lblName);
            grpUserRole.Controls.Add(txtName);
            grpUserRole.Controls.Add(lblUserPass);
            grpUserRole.Controls.Add(txtUserPass);
            grpUserRole.Controls.Add(chkExisting);
            grpUserRole.Controls.Add(btnCreate);
            grpUserRole.Controls.Add(btnDelete);
            grpUserRole.Controls.Add(btnUpdate);
            grpUserRole.Location = new Point(14, 12);
            grpUserRole.Margin = new Padding(4, 3, 4, 3);
            grpUserRole.Name = "grpUserRole";
            grpUserRole.Padding = new Padding(4, 3, 4, 3);
            grpUserRole.Size = new Size(1106, 390);
            grpUserRole.TabIndex = 0;
            grpUserRole.TabStop = false;
            grpUserRole.Text = "Thông tin người dùng / role";
            // 
            // radUser
            // 
            radUser.AutoSize = true;
            radUser.Checked = true;
            radUser.Location = new Point(28, 81);
            radUser.Margin = new Padding(4, 3, 4, 3);
            radUser.Name = "radUser";
            radUser.Size = new Size(86, 33);
            radUser.TabIndex = 0;
            radUser.TabStop = true;
            radUser.Text = "User";
            // 
            // radRole
            // 
            radRole.AutoSize = true;
            radRole.Location = new Point(220, 81);
            radRole.Margin = new Padding(4, 3, 4, 3);
            radRole.Name = "radRole";
            radRole.Size = new Size(86, 33);
            radRole.TabIndex = 1;
            radRole.Text = "Role";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(28, 134);
            lblName.Margin = new Padding(4, 0, 4, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(184, 29);
            lblName.TabIndex = 2;
            lblName.Text = "Tên User / Role:";
            // 
            // txtName
            // 
            txtName.Location = new Point(220, 131);
            txtName.Margin = new Padding(4, 3, 4, 3);
            txtName.Name = "txtName";
            txtName.Size = new Size(516, 37);
            txtName.TabIndex = 3;
            // 
            // lblUserPass
            // 
            lblUserPass.AutoSize = true;
            lblUserPass.Location = new Point(28, 194);
            lblUserPass.Margin = new Padding(4, 0, 4, 0);
            lblUserPass.Name = "lblUserPass";
            lblUserPass.Size = new Size(119, 29);
            lblUserPass.TabIndex = 4;
            lblUserPass.Text = "Mật khẩu:";
            // 
            // txtUserPass
            // 
            txtUserPass.Location = new Point(220, 191);
            txtUserPass.Margin = new Padding(4, 3, 4, 3);
            txtUserPass.Name = "txtUserPass";
            txtUserPass.PasswordChar = '*';
            txtUserPass.Size = new Size(516, 37);
            txtUserPass.TabIndex = 5;
            // 
            // chkExisting
            // 
            chkExisting.AutoSize = true;
            chkExisting.Location = new Point(28, 248);
            chkExisting.Margin = new Padding(4, 3, 4, 3);
            chkExisting.Name = "chkExisting";
            chkExisting.Size = new Size(202, 33);
            chkExisting.TabIndex = 6;
            chkExisting.Text = "User đã tồn tại?";
            // 
            // btnCreate
            // 
            btnCreate.AutoSize = true;
            btnCreate.Location = new Point(851, 124);
            btnCreate.Margin = new Padding(4, 3, 4, 3);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(140, 39);
            btnCreate.TabIndex = 7;
            btnCreate.Text = "Tạo mới";
            // 
            // btnDelete
            // 
            btnDelete.AutoSize = true;
            btnDelete.Location = new Point(851, 184);
            btnDelete.Margin = new Padding(4, 3, 4, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(140, 39);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Xóa";
            // 
            // btnUpdate
            // 
            btnUpdate.AutoSize = true;
            btnUpdate.Location = new Point(851, 242);
            btnUpdate.Margin = new Padding(4, 3, 4, 3);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(140, 39);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "Cập nhật";
            // 
            // tabList
            // 
            tabList.Controls.Add(cboFilter);
            tabList.Controls.Add(lstUsers);
            tabList.Controls.Add(btnRefresh);
            tabList.Location = new Point(4, 34);
            tabList.Margin = new Padding(4, 3, 4, 3);
            tabList.Name = "tabList";
            tabList.Padding = new Padding(4, 3, 4, 3);
            tabList.Size = new Size(1129, 423);
            tabList.TabIndex = 1;
            tabList.Text = "Danh sách User / Role";
            // 
            // cboFilter
            // 
            cboFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFilter.FormattingEnabled = true;
            cboFilter.Items.AddRange(new object[] { "Users", "Roles", "All" });
            cboFilter.Location = new Point(14, 12);
            cboFilter.Margin = new Padding(4, 3, 4, 3);
            cboFilter.Name = "cboFilter";
            cboFilter.Size = new Size(278, 37);
            cboFilter.TabIndex = 0;
            // 
            // lstUsers
            // 
            lstUsers.Columns.AddRange(new ColumnHeader[] { Ten, DSLoai, TrangThai, NgayTao });
            lstUsers.FullRowSelect = true;
            lstUsers.GridLines = true;
            lstUsers.Location = new Point(14, 69);
            lstUsers.Margin = new Padding(4, 3, 4, 3);
            lstUsers.Name = "lstUsers";
            lstUsers.Size = new Size(866, 324);
            lstUsers.TabIndex = 1;
            lstUsers.UseCompatibleStateImageBehavior = false;
            lstUsers.View = View.Details;
            // 
            // Ten
            // 
            Ten.Text = "Tên";
            Ten.Width = 216;
            // 
            // DSLoai
            // 
            DSLoai.Text = "Loại";
            DSLoai.Width = 216;
            // 
            // TrangThai
            // 
            TrangThai.Text = "Trạng thái";
            TrangThai.Width = 216;
            // 
            // NgayTao
            // 
            NgayTao.Text = "Ngày tạo";
            NgayTao.Width = 218;
            // 
            // btnRefresh
            // 
            btnRefresh.AutoSize = true;
            btnRefresh.Location = new Point(892, 69);
            btnRefresh.Margin = new Padding(4, 3, 4, 3);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(229, 48);
            btnRefresh.TabIndex = 2;
            btnRefresh.Text = "Tải lại danh sách";
            // 
            // tabPrivileges
            // 
            tabPrivileges.Controls.Add(grpPrivileges);
            tabPrivileges.Location = new Point(4, 34);
            tabPrivileges.Margin = new Padding(4, 3, 4, 3);
            tabPrivileges.Name = "tabPrivileges";
            tabPrivileges.Size = new Size(1129, 423);
            tabPrivileges.TabIndex = 2;
            tabPrivileges.Text = "Quản lý Quyền";
            // 
            // grpPrivileges
            // 
            grpPrivileges.Controls.Add(lblGrantee);
            grpPrivileges.Controls.Add(txtGrantee);
            grpPrivileges.Controls.Add(lblPrivilege);
            grpPrivileges.Controls.Add(cboPrivilege);
            grpPrivileges.Controls.Add(lblObject);
            grpPrivileges.Controls.Add(txtObject);
            grpPrivileges.Controls.Add(btnGrant);
            grpPrivileges.Controls.Add(btnRevoke);
            grpPrivileges.Controls.Add(lstPrivileges);
            grpPrivileges.Location = new Point(14, 12);
            grpPrivileges.Margin = new Padding(4, 3, 4, 3);
            grpPrivileges.Name = "grpPrivileges";
            grpPrivileges.Padding = new Padding(4, 3, 4, 3);
            grpPrivileges.Size = new Size(1105, 393);
            grpPrivileges.TabIndex = 0;
            grpPrivileges.TabStop = false;
            grpPrivileges.Text = "Quản lý quyền";
            // 
            // lblGrantee
            // 
            lblGrantee.AutoSize = true;
            lblGrantee.Location = new Point(28, 43);
            lblGrantee.Margin = new Padding(4, 0, 4, 0);
            lblGrantee.Name = "lblGrantee";
            lblGrantee.Size = new Size(122, 29);
            lblGrantee.TabIndex = 0;
            lblGrantee.Text = "User/Role:";
            // 
            // txtGrantee
            // 
            txtGrantee.Location = new Point(210, 40);
            txtGrantee.Margin = new Padding(4, 3, 4, 3);
            txtGrantee.Name = "txtGrantee";
            txtGrantee.Size = new Size(278, 37);
            txtGrantee.TabIndex = 1;
            // 
            // lblPrivilege
            // 
            lblPrivilege.AutoSize = true;
            lblPrivilege.Location = new Point(28, 86);
            lblPrivilege.Margin = new Padding(4, 0, 4, 0);
            lblPrivilege.Name = "lblPrivilege";
            lblPrivilege.Size = new Size(89, 29);
            lblPrivilege.TabIndex = 2;
            lblPrivilege.Text = "Quyền:";
            // 
            // cboPrivilege
            // 
            cboPrivilege.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPrivilege.FormattingEnabled = true;
            cboPrivilege.Items.AddRange(new object[] { "SELECT", "INSERT", "UPDATE", "DELETE", "CREATE", "ALTER", "DROP" });
            cboPrivilege.Location = new Point(210, 83);
            cboPrivilege.Margin = new Padding(4, 3, 4, 3);
            cboPrivilege.Name = "cboPrivilege";
            cboPrivilege.Size = new Size(278, 37);
            cboPrivilege.TabIndex = 3;
            // 
            // lblObject
            // 
            lblObject.AutoSize = true;
            lblObject.Location = new Point(28, 129);
            lblObject.Margin = new Padding(4, 0, 4, 0);
            lblObject.Name = "lblObject";
            lblObject.Size = new Size(124, 29);
            lblObject.TabIndex = 4;
            lblObject.Text = "Đối tượng:";
            // 
            // txtObject
            // 
            txtObject.Location = new Point(210, 126);
            txtObject.Margin = new Padding(4, 3, 4, 3);
            txtObject.Name = "txtObject";
            txtObject.Size = new Size(278, 37);
            txtObject.TabIndex = 5;
            // 
            // btnGrant
            // 
            btnGrant.Location = new Point(612, 80);
            btnGrant.Margin = new Padding(4, 3, 4, 3);
            btnGrant.Name = "btnGrant";
            btnGrant.Size = new Size(175, 40);
            btnGrant.TabIndex = 6;
            btnGrant.Text = "Cấp quyền";
            // 
            // btnRevoke
            // 
            btnRevoke.AutoSize = true;
            btnRevoke.Location = new Point(851, 80);
            btnRevoke.Margin = new Padding(4, 3, 4, 3);
            btnRevoke.Name = "btnRevoke";
            btnRevoke.Size = new Size(175, 40);
            btnRevoke.TabIndex = 7;
            btnRevoke.Text = "Thu hồi quyền";
            // 
            // lstPrivileges
            // 
            lstPrivileges.Columns.AddRange(new ColumnHeader[] { UserOrRole, Quyen, DoiTuong, QLoai });
            lstPrivileges.Location = new Point(28, 179);
            lstPrivileges.Margin = new Padding(4, 3, 4, 3);
            lstPrivileges.Name = "lstPrivileges";
            lstPrivileges.Size = new Size(1050, 208);
            lstPrivileges.TabIndex = 8;
            lstPrivileges.UseCompatibleStateImageBehavior = false;
            lstPrivileges.View = View.Details;
            // 
            // UserOrRole
            // 
            UserOrRole.Text = "User/Role";
            UserOrRole.Width = 262;
            // 
            // Quyen
            // 
            Quyen.Text = "Quyền";
            Quyen.Width = 262;
            // 
            // DoiTuong
            // 
            DoiTuong.Text = "Đối tượng";
            DoiTuong.Width = 262;
            // 
            // QLoai
            // 
            QLoai.Text = "Loại";
            QLoai.Width = 264;
            // 
            // tabTablespaces
            // 
            tabTablespaces.Controls.Add(grpTablespaces);
            tabTablespaces.Location = new Point(4, 34);
            tabTablespaces.Margin = new Padding(4, 3, 4, 3);
            tabTablespaces.Name = "tabTablespaces";
            tabTablespaces.Size = new Size(1129, 423);
            tabTablespaces.TabIndex = 3;
            tabTablespaces.Text = "Quản lý Tablespace";
            // 
            // grpTablespaces
            // 
            grpTablespaces.Controls.Add(lblTablespace);
            grpTablespaces.Controls.Add(txtTablespace);
            grpTablespaces.Controls.Add(lblSize);
            grpTablespaces.Controls.Add(txtSize);
            grpTablespaces.Controls.Add(btnCreateTS);
            grpTablespaces.Controls.Add(btnDropTS);
            grpTablespaces.Controls.Add(btnResizeTS);
            grpTablespaces.Controls.Add(lstTablespaces);
            grpTablespaces.Location = new Point(14, 12);
            grpTablespaces.Margin = new Padding(4, 3, 4, 3);
            grpTablespaces.Name = "grpTablespaces";
            grpTablespaces.Padding = new Padding(4, 3, 4, 3);
            grpTablespaces.Size = new Size(1105, 391);
            grpTablespaces.TabIndex = 0;
            grpTablespaces.TabStop = false;
            grpTablespaces.Text = "Quản lý Tablespace";
            // 
            // lblTablespace
            // 
            lblTablespace.AutoSize = true;
            lblTablespace.Location = new Point(28, 41);
            lblTablespace.Margin = new Padding(4, 0, 4, 0);
            lblTablespace.Name = "lblTablespace";
            lblTablespace.Size = new Size(183, 29);
            lblTablespace.TabIndex = 0;
            lblTablespace.Text = "Tên Tablespace:";
            // 
            // txtTablespace
            // 
            txtTablespace.Location = new Point(246, 38);
            txtTablespace.Margin = new Padding(4, 3, 4, 3);
            txtTablespace.Name = "txtTablespace";
            txtTablespace.Size = new Size(278, 37);
            txtTablespace.TabIndex = 1;
            // 
            // lblSize
            // 
            lblSize.AutoSize = true;
            lblSize.Location = new Point(28, 87);
            lblSize.Margin = new Padding(4, 0, 4, 0);
            lblSize.Name = "lblSize";
            lblSize.Size = new Size(202, 29);
            lblSize.TabIndex = 2;
            lblSize.Text = "Kích thước (MB):";
            // 
            // txtSize
            // 
            txtSize.Location = new Point(246, 84);
            txtSize.Margin = new Padding(4, 3, 4, 3);
            txtSize.Name = "txtSize";
            txtSize.Size = new Size(138, 37);
            txtSize.TabIndex = 3;
            // 
            // btnCreateTS
            // 
            btnCreateTS.AutoSize = true;
            btnCreateTS.Location = new Point(560, 38);
            btnCreateTS.Margin = new Padding(4, 3, 4, 3);
            btnCreateTS.Name = "btnCreateTS";
            btnCreateTS.Size = new Size(140, 39);
            btnCreateTS.TabIndex = 4;
            btnCreateTS.Text = "Tạo mới";
            // 
            // btnDropTS
            // 
            btnDropTS.AutoSize = true;
            btnDropTS.Location = new Point(560, 84);
            btnDropTS.Margin = new Padding(4, 3, 4, 3);
            btnDropTS.Name = "btnDropTS";
            btnDropTS.Size = new Size(140, 39);
            btnDropTS.TabIndex = 5;
            btnDropTS.Text = "Xóa";
            // 
            // btnResizeTS
            // 
            btnResizeTS.AutoSize = true;
            btnResizeTS.Location = new Point(740, 41);
            btnResizeTS.Margin = new Padding(4, 3, 4, 3);
            btnResizeTS.Name = "btnResizeTS";
            btnResizeTS.Size = new Size(235, 39);
            btnResizeTS.TabIndex = 6;
            btnResizeTS.Text = "Thay đổi kích thước";
            // 
            // lstTablespaces
            // 
            lstTablespaces.Columns.AddRange(new ColumnHeader[] { TBSTen, KichThuoc, TBSTrangThai, TBSTDMR });
            lstTablespaces.Location = new Point(28, 139);
            lstTablespaces.Margin = new Padding(4, 3, 4, 3);
            lstTablespaces.Name = "lstTablespaces";
            lstTablespaces.Size = new Size(1052, 237);
            lstTablespaces.TabIndex = 7;
            lstTablespaces.UseCompatibleStateImageBehavior = false;
            lstTablespaces.View = View.Details;
            // 
            // TBSTen
            // 
            TBSTen.Text = "Tên";
            TBSTen.Width = 263;
            // 
            // KichThuoc
            // 
            KichThuoc.Text = "Kích thước (MB)";
            KichThuoc.Width = 263;
            // 
            // TBSTrangThai
            // 
            TBSTrangThai.Text = "Trạng thái";
            TBSTrangThai.Width = 263;
            // 
            // TBSTDMR
            // 
            TBSTDMR.Text = "Tự động mở rộng";
            TBSTDMR.Width = 263;
            // 
            // tabAudit
            // 
            tabAudit.Controls.Add(grpAudit);
            tabAudit.Location = new Point(4, 38);
            tabAudit.Margin = new Padding(4, 3, 4, 3);
            tabAudit.Name = "tabAudit";
            tabAudit.Size = new Size(1129, 419);
            tabAudit.TabIndex = 4;
            tabAudit.Text = "Theo dõi hoạt động";
            // 
            // grpAudit
            // 
            grpAudit.Controls.Add(lstAudit);
            grpAudit.Controls.Add(btnRefreshAudit);
            grpAudit.Location = new Point(14, 12);
            grpAudit.Margin = new Padding(4, 3, 4, 3);
            grpAudit.Name = "grpAudit";
            grpAudit.Padding = new Padding(4, 3, 4, 3);
            grpAudit.Size = new Size(1103, 392);
            grpAudit.TabIndex = 0;
            grpAudit.TabStop = false;
            grpAudit.Text = "Theo dõi hoạt động";
            // 
            // lstAudit
            // 
            lstAudit.Columns.AddRange(new ColumnHeader[] { ThoiGian, User, HanhDong, TDDoiTuong, TDTrangThai });
            lstAudit.Location = new Point(28, 35);
            lstAudit.Margin = new Padding(4, 3, 4, 3);
            lstAudit.Name = "lstAudit";
            lstAudit.Size = new Size(1051, 338);
            lstAudit.TabIndex = 0;
            lstAudit.UseCompatibleStateImageBehavior = false;
            lstAudit.View = View.Details;
            // 
            // btnRefreshAudit
            // 
            btnRefreshAudit.Location = new Point(896, 35);
            btnRefreshAudit.Margin = new Padding(4, 3, 4, 3);
            btnRefreshAudit.Name = "btnRefreshAudit";
            btnRefreshAudit.Size = new Size(98, 35);
            btnRefreshAudit.TabIndex = 1;
            btnRefreshAudit.Text = "Tải lại";
            // 
            // ThoiGian
            // 
            ThoiGian.Text = "Thời gian";
            ThoiGian.Width = 210;
            // 
            // User
            // 
            User.Text = "User";
            User.Width = 210;
            // 
            // HanhDong
            // 
            HanhDong.Text = "Hành động";
            HanhDong.Width = 210;
            // 
            // TDDoiTuong
            // 
            TDDoiTuong.Text = "Đối tượng";
            TDDoiTuong.Width = 210;
            // 
            // TDTrangThai
            // 
            TDTrangThai.Text = "Trạng thái";
            TDTrangThai.Width = 211;
            //
            // Event
            //
            btnCreate.Click += (s, e) => CreateUserOrRole();
            btnDelete.Click += (s, e) => DeleteUserOrRole();
            btnUpdate.Click += (s, e) => UpdateUserOrRole();
            btnRefresh.Click += (s, e) => LoadUserList();
            cboFilter.SelectedIndexChanged += (s, e) => LoadUserList();
            chkExisting.CheckedChanged += (s, e) => txtUserPass.Enabled = !chkExisting.Checked;
            btnGrant.Click += (s, e) => GrantPrivilege();
            btnRevoke.Click += (s, e) => RevokePrivilege();
            btnCreateTS.Click += (s, e) => CreateTablespace();
            btnDropTS.Click += (s, e) => DropTablespace();
            btnResizeTS.Click += (s, e) => ResizeTablespace();
            btnRefreshAudit.Click += (s, e) => LoadAuditLog();
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(14F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1165, 792);
            Controls.Add(grpConnection);
            Controls.Add(tabControl);
            Font = new Font("Times New Roman", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "MainForm";
            Text = "Oracle User Manager";
            grpConnection.ResumeLayout(false);
            grpConnection.PerformLayout();
            tabControl.ResumeLayout(false);
            tabManage.ResumeLayout(false);
            grpUserRole.ResumeLayout(false);
            grpUserRole.PerformLayout();
            tabList.ResumeLayout(false);
            tabList.PerformLayout();
            tabPrivileges.ResumeLayout(false);
            grpPrivileges.ResumeLayout(false);
            grpPrivileges.PerformLayout();
            tabTablespaces.ResumeLayout(false);
            grpTablespaces.ResumeLayout(false);
            grpTablespaces.PerformLayout();
            tabAudit.ResumeLayout(false);
            grpAudit.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OracleDbConnection _connection;
        private GroupBox grpConnection;
        private Label lblHostname;
        private TextBox txtHostname;
        private Label lblPort;
        private TextBox txtPort;
        private Label lblSID;
        private TextBox txtSID;
        private Label lblUsername;
        private TextBox txtUsername;
        private Label lblPassword;
        private TextBox txtPassword;
        private Button btnConnect;
        private TabControl tabControl;
        private TabPage tabManage;
        private TabPage tabList;
        private TabPage tabPrivileges;
        private TabPage tabTablespaces;
        private TabPage tabAudit;
        private GroupBox grpUserRole;
        private RadioButton radUser;
        private RadioButton radRole;
        private Label lblName;
        private TextBox txtName;
        private Label lblUserPass;
        private TextBox txtUserPass;
        private CheckBox chkExisting;
        private Button btnCreate;
        private Button btnDelete;
        private Button btnUpdate;
        private ComboBox cboFilter;
        private ListView lstUsers;
        private Button btnRefresh;
        private GroupBox grpPrivileges;
        private Label lblGrantee;
        private TextBox txtGrantee;
        private Label lblPrivilege;
        private ComboBox cboPrivilege;
        private Label lblObject;
        private TextBox txtObject;
        private Button btnGrant;
        private Button btnRevoke;
        private ListView lstPrivileges;
        private GroupBox grpTablespaces;
        private Label lblTablespace;
        private TextBox txtTablespace;
        private Label lblSize;
        private TextBox txtSize;
        private Button btnCreateTS;
        private Button btnDropTS;
        private Button btnResizeTS;
        private ListView lstTablespaces;
        private GroupBox grpAudit;
        private ListView lstAudit;
        private Button btnRefreshAudit;
        private ColumnHeader Ten;
        private ColumnHeader DSLoai;
        private ColumnHeader TrangThai;
        private ColumnHeader NgayTao;
        private ColumnHeader UserOrRole;
        private ColumnHeader Quyen;
        private ColumnHeader DoiTuong;
        private ColumnHeader QLoai;
        private ColumnHeader TBSTen;
        private ColumnHeader KichThuoc;
        private ColumnHeader TBSTrangThai;
        private ColumnHeader TBSTDMR;
        private ColumnHeader ThoiGian;
        private ColumnHeader User;
        private ColumnHeader HanhDong;
        private ColumnHeader TDDoiTuong;
        private ColumnHeader TDTrangThai;
    }
}
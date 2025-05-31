using OracleUserManager.Models;

namespace atbmcq_02
{
    partial class UserManagement
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
            txtSearch = new TextBox();
            lblSearch = new Label();
            tabThongBao = new TabPage();
            grpThongBao = new GroupBox();
            lblNoiDungTB = new Label();
            txtNoiDungTB = new TextBox();
            lblLevelTB = new Label();
            cboLevelTB = new ComboBox();
            lblCompartmentTB = new Label();
            chkListCompartment = new CheckedListBox();
            lblGroupTB = new Label();
            chkListGroup = new CheckedListBox();
            btnThemTB = new Button();
            btnXoaTB = new Button();
            btnCapNhatTB = new Button();
            lstThongBao = new ListView();
            colID = new ColumnHeader();
            colNoiDung = new ColumnHeader();
            colNhan = new ColumnHeader();
            txtTimKiemTB = new TextBox();
            lblTimKiemTB = new Label();
            tabControl.SuspendLayout();
            tabManage.SuspendLayout();
            grpUserRole.SuspendLayout();
            tabList.SuspendLayout();
            tabThongBao.SuspendLayout();
            grpThongBao.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabManage);
            tabControl.Controls.Add(tabList);
            tabControl.Controls.Add(tabThongBao);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Location = new Point(0, 0);
            tabControl.Margin = new Padding(6, 3, 6, 3);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1592, 535);
            tabControl.TabIndex = 2;
            // 
            // tabManage
            // 
            tabManage.Controls.Add(grpUserRole);
            tabManage.Location = new Point(4, 28);
            tabManage.Margin = new Padding(6, 3, 6, 3);
            tabManage.Name = "tabManage";
            tabManage.Padding = new Padding(6, 3, 6, 3);
            tabManage.Size = new Size(1584, 503);
            tabManage.TabIndex = 0;
            tabManage.Text = "User/Role Management";
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
            grpUserRole.Location = new Point(20, 14);
            grpUserRole.Margin = new Padding(6, 3, 6, 3);
            grpUserRole.Name = "grpUserRole";
            grpUserRole.Padding = new Padding(6, 3, 6, 3);
            grpUserRole.Size = new Size(1548, 452);
            grpUserRole.TabIndex = 0;
            grpUserRole.TabStop = false;
            grpUserRole.Text = "User/Role Information";
            // 
            // radUser
            // 
            radUser.AutoSize = true;
            radUser.Checked = true;
            radUser.Location = new Point(41, 66);
            radUser.Margin = new Padding(6, 3, 6, 3);
            radUser.Name = "radUser";
            radUser.Size = new Size(61, 24);
            radUser.TabIndex = 0;
            radUser.TabStop = true;
            radUser.Text = "User";
            radUser.CheckedChanged += radUser_CheckedChanged;
            // 
            // radRole
            // 
            radRole.AutoSize = true;
            radRole.Location = new Point(228, 66);
            radRole.Margin = new Padding(6, 3, 6, 3);
            radRole.Name = "radRole";
            radRole.Size = new Size(60, 24);
            radRole.TabIndex = 1;
            radRole.Text = "Role";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(39, 135);
            lblName.Margin = new Padding(6, 0, 6, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(133, 20);
            lblName.TabIndex = 2;
            lblName.Text = "User/Role Name:";
            // 
            // txtName
            // 
            txtName.Location = new Point(228, 132);
            txtName.Margin = new Padding(6, 3, 6, 3);
            txtName.Name = "txtName";
            txtName.Size = new Size(418, 27);
            txtName.TabIndex = 3;
            // 
            // lblUserPass
            // 
            lblUserPass.AutoSize = true;
            lblUserPass.Location = new Point(41, 199);
            lblUserPass.Margin = new Padding(6, 0, 6, 0);
            lblUserPass.Name = "lblUserPass";
            lblUserPass.Size = new Size(83, 20);
            lblUserPass.TabIndex = 4;
            lblUserPass.Text = "Password:";
            lblUserPass.Click += lblUserPass_Click;
            // 
            // txtUserPass
            // 
            txtUserPass.Location = new Point(228, 196);
            txtUserPass.Margin = new Padding(6, 3, 6, 3);
            txtUserPass.Name = "txtUserPass";
            txtUserPass.PasswordChar = '*';
            txtUserPass.Size = new Size(418, 27);
            txtUserPass.TabIndex = 5;
            // 
            // chkExisting
            // 
            chkExisting.AutoSize = true;
            chkExisting.Location = new Point(41, 288);
            chkExisting.Margin = new Padding(6, 3, 6, 3);
            chkExisting.Name = "chkExisting";
            chkExisting.Size = new Size(131, 24);
            chkExisting.TabIndex = 6;
            chkExisting.Text = "Existing User?";
            chkExisting.Visible = false;
            // 
            // btnCreate
            // 
            btnCreate.AutoSize = true;
            btnCreate.Location = new Point(729, 81);
            btnCreate.Margin = new Padding(6, 3, 6, 3);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(151, 38);
            btnCreate.TabIndex = 7;
            btnCreate.Text = "Create";
            btnCreate.Click += btnCreate_Click;
            // 
            // btnDelete
            // 
            btnDelete.AutoSize = true;
            btnDelete.Location = new Point(729, 148);
            btnDelete.Margin = new Padding(6, 3, 6, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(151, 37);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.AutoSize = true;
            btnUpdate.Location = new Point(729, 209);
            btnUpdate.Margin = new Padding(6, 3, 6, 3);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(151, 36);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "Update";
            btnUpdate.Click += btnUpdate_Click;
            // 
            // tabList
            // 
            tabList.Controls.Add(cboFilter);
            tabList.Controls.Add(lstUsers);
            tabList.Controls.Add(btnRefresh);
            tabList.Controls.Add(txtSearch);
            tabList.Controls.Add(lblSearch);
            tabList.Location = new Point(4, 24);
            tabList.Margin = new Padding(6, 3, 6, 3);
            tabList.Name = "tabList";
            tabList.Padding = new Padding(6, 3, 6, 3);
            tabList.Size = new Size(1584, 507);
            tabList.TabIndex = 1;
            tabList.Text = "User/Role List";
            // 
            // cboFilter
            // 
            cboFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFilter.FormattingEnabled = true;
            cboFilter.Items.AddRange(new object[] { "Users", "Roles", "All" });
            cboFilter.Location = new Point(20, 14);
            cboFilter.Margin = new Padding(6, 3, 6, 3);
            cboFilter.Name = "cboFilter";
            cboFilter.Size = new Size(200, 27);
            cboFilter.TabIndex = 0;
            // 
            // lstUsers
            // 
            lstUsers.Columns.AddRange(new ColumnHeader[] { Ten, DSLoai, TrangThai, NgayTao });
            lstUsers.FullRowSelect = true;
            lstUsers.GridLines = true;
            lstUsers.Location = new Point(20, 80);
            lstUsers.Margin = new Padding(6, 3, 6, 3);
            lstUsers.Name = "lstUsers";
            lstUsers.Size = new Size(818, 293);
            lstUsers.TabIndex = 1;
            lstUsers.UseCompatibleStateImageBehavior = false;
            lstUsers.View = View.Details;
            lstUsers.SelectedIndexChanged += lstUsers_SelectedIndexChanged;
            // 
            // Ten
            // 
            Ten.Text = "Name";
            Ten.Width = 302;
            // 
            // DSLoai
            // 
            DSLoai.Text = "Type";
            DSLoai.Width = 302;
            // 
            // TrangThai
            // 
            TrangThai.Text = "Status";
            TrangThai.Width = 302;
            // 
            // NgayTao
            // 
            NgayTao.Text = "Created Date";
            NgayTao.Width = 304;
            // 
            // btnRefresh
            // 
            btnRefresh.AutoSize = true;
            btnRefresh.Location = new Point(908, 80);
            btnRefresh.Margin = new Padding(6, 3, 6, 3);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(132, 39);
            btnRefresh.TabIndex = 2;
            btnRefresh.Text = "Refresh List";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += LoadUserList;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(360, 14);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(400, 27);
            txtSearch.TabIndex = 4;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(240, 18);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(80, 20);
            lblSearch.TabIndex = 3;
            lblSearch.Text = "Tìm kiếm";
            // 
            // tabThongBao
            // 
            tabThongBao.Controls.Add(grpThongBao);
            tabThongBao.Controls.Add(lstThongBao);
            tabThongBao.Controls.Add(txtTimKiemTB);
            tabThongBao.Controls.Add(lblTimKiemTB);
            tabThongBao.Location = new Point(4, 28);
            tabThongBao.Margin = new Padding(6, 3, 6, 3);
            tabThongBao.Name = "tabThongBao";
            tabThongBao.Padding = new Padding(6, 3, 6, 3);
            tabThongBao.Size = new Size(1584, 503);
            tabThongBao.TabIndex = 2;
            tabThongBao.Text = "Quản lý Thông báo";
            // 
            // grpThongBao
            // 
            grpThongBao.Controls.Add(lblNoiDungTB);
            grpThongBao.Controls.Add(txtNoiDungTB);
            grpThongBao.Controls.Add(lblLevelTB);
            grpThongBao.Controls.Add(cboLevelTB);
            grpThongBao.Controls.Add(lblCompartmentTB);
            grpThongBao.Controls.Add(chkListCompartment);
            grpThongBao.Controls.Add(lblGroupTB);
            grpThongBao.Controls.Add(chkListGroup);
            grpThongBao.Controls.Add(btnThemTB);
            grpThongBao.Controls.Add(btnXoaTB);
            grpThongBao.Controls.Add(btnCapNhatTB);
            grpThongBao.Location = new Point(22, 4);
            grpThongBao.Margin = new Padding(6, 3, 6, 3);
            grpThongBao.Name = "grpThongBao";
            grpThongBao.Padding = new Padding(6, 3, 6, 3);
            grpThongBao.Size = new Size(1548, 240);
            grpThongBao.TabIndex = 0;
            grpThongBao.TabStop = false;
            grpThongBao.Text = "Thông tin Thông báo";
            // 
            // lblNoiDungTB
            // 
            lblNoiDungTB.AutoSize = true;
            lblNoiDungTB.Location = new Point(20, 40);
            lblNoiDungTB.Margin = new Padding(6, 0, 6, 0);
            lblNoiDungTB.Name = "lblNoiDungTB";
            lblNoiDungTB.Size = new Size(79, 20);
            lblNoiDungTB.TabIndex = 0;
            lblNoiDungTB.Text = "Nội dung:";
            // 
            // txtNoiDungTB
            // 
            txtNoiDungTB.Location = new Point(140, 26);
            txtNoiDungTB.Margin = new Padding(6, 3, 6, 3);
            txtNoiDungTB.Multiline = true;
            txtNoiDungTB.Name = "txtNoiDungTB";
            txtNoiDungTB.Size = new Size(600, 80);
            txtNoiDungTB.TabIndex = 1;
            // 
            // lblLevelTB
            // 
            lblLevelTB.AutoSize = true;
            lblLevelTB.Location = new Point(25, 121);
            lblLevelTB.Margin = new Padding(6, 0, 6, 0);
            lblLevelTB.Name = "lblLevelTB";
            lblLevelTB.Size = new Size(53, 20);
            lblLevelTB.TabIndex = 2;
            lblLevelTB.Text = "Level:";
            lblLevelTB.Click += lblLevelTB_Click;
            // 
            // cboLevelTB
            // 
            cboLevelTB.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLevelTB.FormattingEnabled = true;
            cboLevelTB.Items.AddRange(new object[] { "SINHVIEN", "NHANVIEN", "TRGDV" });
            cboLevelTB.Location = new Point(140, 118);
            cboLevelTB.Name = "cboLevelTB";
            cboLevelTB.Size = new Size(200, 27);
            cboLevelTB.TabIndex = 3;
            cboLevelTB.SelectedIndexChanged += ThongBaoFilter_Changed;
            // 
            // lblCompartmentTB
            // 
            lblCompartmentTB.AutoSize = true;
            lblCompartmentTB.Location = new Point(20, 190);
            lblCompartmentTB.Margin = new Padding(6, 0, 6, 0);
            lblCompartmentTB.Name = "lblCompartmentTB";
            lblCompartmentTB.Size = new Size(85, 20);
            lblCompartmentTB.TabIndex = 4;
            lblCompartmentTB.Text = "Khoa/BM:";
            lblCompartmentTB.Click += lblCompartmentTB_Click;
            // 
            // chkListCompartment
            // 
            chkListCompartment.CheckOnClick = true;
            chkListCompartment.FormattingEnabled = true;
            chkListCompartment.Items.AddRange(new object[] { "TOAN", "LY", "HOA", "HC" });
            chkListCompartment.Location = new Point(140, 160);
            chkListCompartment.Name = "chkListCompartment";
            chkListCompartment.Size = new Size(250, 70);
            chkListCompartment.TabIndex = 5;
            // 
            // lblGroupTB
            // 
            lblGroupTB.AutoSize = true;
            lblGroupTB.Location = new Point(410, 190);
            lblGroupTB.Margin = new Padding(6, 0, 6, 0);
            lblGroupTB.Name = "lblGroupTB";
            lblGroupTB.Size = new Size(57, 20);
            lblGroupTB.TabIndex = 6;
            lblGroupTB.Text = "Cơ sở:";
            // 
            // chkListGroup
            // 
            chkListGroup.CheckOnClick = true;
            chkListGroup.FormattingEnabled = true;
            chkListGroup.Items.AddRange(new object[] { "CS1", "CS2" });
            chkListGroup.Location = new Point(490, 160);
            chkListGroup.Name = "chkListGroup";
            chkListGroup.Size = new Size(250, 70);
            chkListGroup.TabIndex = 7;
            // 
            // btnThemTB
            // 
            btnThemTB.AutoSize = true;
            btnThemTB.Location = new Point(802, 37);
            btnThemTB.Margin = new Padding(6, 3, 6, 3);
            btnThemTB.Name = "btnThemTB";
            btnThemTB.Size = new Size(196, 45);
            btnThemTB.TabIndex = 8;
            btnThemTB.Text = "Thêm mới";
            btnThemTB.UseVisualStyleBackColor = true;
            btnThemTB.Click += ThemThongBao;
            // 
            // btnXoaTB
            // 
            btnXoaTB.AutoSize = true;
            btnXoaTB.Location = new Point(802, 100);
            btnXoaTB.Margin = new Padding(6, 3, 6, 3);
            btnXoaTB.Name = "btnXoaTB";
            btnXoaTB.Size = new Size(196, 45);
            btnXoaTB.TabIndex = 9;
            btnXoaTB.Text = "Xóa";
            btnXoaTB.UseVisualStyleBackColor = true;
            btnXoaTB.Click += XoaThongBao;
            // 
            // btnCapNhatTB
            // 
            btnCapNhatTB.AutoSize = true;
            btnCapNhatTB.Location = new Point(802, 165);
            btnCapNhatTB.Margin = new Padding(6, 3, 6, 3);
            btnCapNhatTB.Name = "btnCapNhatTB";
            btnCapNhatTB.Size = new Size(196, 45);
            btnCapNhatTB.TabIndex = 10;
            btnCapNhatTB.Text = "Cập nhật";
            btnCapNhatTB.UseVisualStyleBackColor = true;
            btnCapNhatTB.Click += CapNhatThongBao;
            // 
            // lstThongBao
            // 
            lstThongBao.Columns.AddRange(new ColumnHeader[] { colID, colNoiDung, colNhan });
            lstThongBao.FullRowSelect = true;
            lstThongBao.GridLines = true;
            lstThongBao.Location = new Point(20, 280);
            lstThongBao.Margin = new Padding(6, 3, 6, 3);
            lstThongBao.Name = "lstThongBao";
            lstThongBao.Size = new Size(1000, 200);
            lstThongBao.TabIndex = 11;
            lstThongBao.UseCompatibleStateImageBehavior = false;
            lstThongBao.View = View.Details;
            lstThongBao.SelectedIndexChanged += ThongBao_Selected;
            // 
            // colID
            // 
            colID.Text = "ID";
            colID.Width = 100;
            // 
            // colNoiDung
            // 
            colNoiDung.Text = "Nội dung";
            colNoiDung.Width = 800;
            // 
            // colNhan
            // 
            colNhan.Text = "Nhãn";
            colNhan.Width = 650;
            // 
            // txtTimKiemTB
            // 
            txtTimKiemTB.Location = new Point(162, 247);
            txtTimKiemTB.Name = "txtTimKiemTB";
            txtTimKiemTB.Size = new Size(600, 27);
            txtTimKiemTB.TabIndex = 13;
            txtTimKiemTB.TextChanged += TimKiemThongBao_Changed;
            // 
            // lblTimKiemTB
            // 
            lblTimKiemTB.AutoSize = true;
            lblTimKiemTB.Location = new Point(20, 254);
            lblTimKiemTB.Name = "lblTimKiemTB";
            lblTimKiemTB.Size = new Size(80, 20);
            lblTimKiemTB.TabIndex = 12;
            lblTimKiemTB.Text = "Tìm kiếm";
            // 
            // UserManagement
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabControl);
            Font = new Font("Times New Roman", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "UserManagement";
            Size = new Size(1592, 535);
            tabControl.ResumeLayout(false);
            tabManage.ResumeLayout(false);
            grpUserRole.ResumeLayout(false);
            grpUserRole.PerformLayout();
            tabList.ResumeLayout(false);
            tabList.PerformLayout();
            tabThongBao.ResumeLayout(false);
            tabThongBao.PerformLayout();
            grpThongBao.ResumeLayout(false);
            grpThongBao.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl;
        private TabPage tabManage;
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
        private TabPage tabList;
        private ComboBox cboFilter;
        private ListView lstUsers;
        private ColumnHeader Ten;
        private ColumnHeader DSLoai;
        private ColumnHeader TrangThai;
        private ColumnHeader NgayTao;
        private Button btnRefresh;
        private TextBox txtSearch;
        private Label lblSearch;
        private TabPage tabThongBao;
        private GroupBox grpThongBao;
        private Label lblNoiDungTB;
        private TextBox txtNoiDungTB;
        private Label lblLevelTB;
        private ComboBox cboLevelTB;
        private Label lblCompartmentTB;
        private CheckedListBox chkListCompartment;
        private Label lblGroupTB;
        private CheckedListBox chkListGroup;
        private Button btnThemTB;
        private Button btnXoaTB;
        private Button btnCapNhatTB;
        private ListView lstThongBao;
        private ColumnHeader colID;
        private ColumnHeader colNoiDung;
        private ColumnHeader colNhan;
        private TextBox txtTimKiemTB;
        private Label lblTimKiemTB;
    }
}

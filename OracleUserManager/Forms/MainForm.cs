using OracleUserManager.Models;
using System.Data;
using Oracle.ManagedDataAccess.Client;

namespace OracleUserManager.Forms
{
    public partial class MainForm : Form
    {
        private OracleDbConnection _connection;
        
        // Controls
        private TextBox txtHostname = new();
        private TextBox txtPort = new();
        private TextBox txtSID = new();
        private TextBox txtUsername = new();
        private TextBox txtPassword = new();
        private TextBox txtName = new();
        private TextBox txtUserPass = new();
        private RadioButton radUser = new();
        private RadioButton radRole = new();
        private CheckBox chkExisting = new();
        private ListView lstUsers = new();
        private ComboBox cboFilter = new();
        private ListView lstPrivileges = new();
        private ListView lstTablespaces = new();
        private TextBox txtGrantee = new();
        private ComboBox cboPrivilege = new();
        private TextBox txtObject = new();
        private TextBox txtColumns = new();
        private CheckBox chkWithGrant = new();
        private TextBox txtTablespace = new();
        private TextBox txtSize = new();
        private ListView lstAudit = new();
        private Label lblName = new();
        private Label lblUserPass = new();
        
        public MainForm()
        {
            InitializeComponent();
            _connection = new OracleDbConnection();
        }

        private void InitializeComponent()
        {
            this.Text = "Oracle User Manager";
            this.Size = new Size(800, 600);

            // Connection Group
            var grpConnection = new GroupBox
            {
                Text = "Thông tin kết nối Oracle DB",
                Location = new Point(10, 10),
                Size = new Size(760, 150)
            };

            // Hostname and Port on same line
            var lblHostname = new Label { Text = "Hostname:", Location = new Point(20, 30) };
            txtHostname = new TextBox { Text = "localhost", Location = new Point(150, 27), Width = 200 };

            var lblPort = new Label { Text = "Port:", Location = new Point(360, 30), AutoSize = true };
            txtPort = new TextBox { Text = "1521", Location = new Point(450, 27), Width = 70 };

            var lblSID = new Label { Text = "SID:", Location = new Point(20, 60) };
            txtSID = new TextBox { Text = "xe", Location = new Point(150, 57), Width = 370 };

            var btnConnect = new Button
            {
                Text = "Kết nối",
                Location = new Point(640, 27),
                Size = new Size(100, 30)
            };

            // Other fields
            var lblUsername = new Label { Text = "Username:", Location = new Point(20, 90) };
            txtUsername = new TextBox { Text = "sys", Location = new Point(150, 87), Width = 370 };

            var lblPassword = new Label { Text = "Password:", Location = new Point(20, 120) };
            txtPassword = new TextBox { Location = new Point(150, 117), Width = 370, PasswordChar = '*' };

            // User/Role Management Group
            var tabControl = new TabControl
            {
                Location = new Point(10, 170),
                Size = new Size(760, 380)
            };

            var tabManage = new TabPage("Quản lý User / Role");
            var tabList = new TabPage("Danh sách User / Role");
            var tabPrivileges = new TabPage("Quản lý Quyền");
            var tabTablespaces = new TabPage("Quản lý Tablespace");
            var tabAudit = new TabPage("Theo dõi hoạt động");

            // Management Tab
            var grpUserRole = new GroupBox
            {
                Text = "Thông tin người dùng / role",
                Location = new Point(10, 10),
                Size = new Size(730, 150)
            };

            radUser = new RadioButton { Text = "User", Location = new Point(20, 30), Checked = true };
            radRole = new RadioButton { Text = "Role", Location = new Point(150, 30) };

            lblName = new Label { Text = "Tên User / Role:", Location = new Point(20, 60) };
            txtName = new TextBox { Location = new Point(150, 57), Width = 370 };

            lblUserPass = new Label { Text = "Mật khẩu:", Location = new Point(20, 90) };
            txtUserPass = new TextBox { Location = new Point(150, 87), Width = 370, PasswordChar = '*' };

            chkExisting = new CheckBox { Text = "User đã tồn tại?", Location = new Point(20, 120) };

            var btnCreate = new Button { Text = "Tạo mới", Location = new Point(540, 30), Size = new Size(100, 30) };
            var btnDelete = new Button { Text = "Xóa", Location = new Point(540, 70), Size = new Size(100, 30) };
            var btnUpdate = new Button { Text = "Cập nhật", Location = new Point(540, 110), Size = new Size(100, 30) };

            // List Tab
            cboFilter = new ComboBox
            {
                Location = new Point(10, 10),
                Size = new Size(200, 25),
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            cboFilter.Items.AddRange(new object[] { "Users", "Roles", "All" });
            cboFilter.SelectedIndex = 0;

            lstUsers = new ListView
            {
                Location = new Point(10, 40),
                Size = new Size(620, 280),
                View = View.Details,
                FullRowSelect = true,
                GridLines = true
            };
            lstUsers.Columns.Add("Tên", 200);
            lstUsers.Columns.Add("Loại", 100);
            lstUsers.Columns.Add("Trạng thái", 150);
            lstUsers.Columns.Add("Ngày tạo", 150);

            var btnRefresh = new Button
            {
                Text = "Tải lại danh sách",
                Location = new Point(640, 40),
                Size = new Size(120, 30)
            };

            // Privileges Tab
            var grpPrivileges = new GroupBox
            {
                Text = "Quản lý quyền",
                Location = new Point(10, 10),
                Size = new Size(730, 320)
            };

            var lblGrantee = new Label { Text = "User/Role:", Location = new Point(20, 30) };
            var txtGrantee = new TextBox { Location = new Point(150, 27), Width = 200 };

            var lblPrivilege = new Label { Text = "Quyền:", Location = new Point(20, 60) };
            var cboPrivilege = new ComboBox
            {
                Location = new Point(150, 57),
                Width = 200,
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            cboPrivilege.Items.AddRange(new object[] { "SELECT", "INSERT", "UPDATE", "DELETE", "CREATE", "ALTER", "DROP" });

            var lblObject = new Label { Text = "Đối tượng:", Location = new Point(20, 90) };
            var txtObject = new TextBox { Location = new Point(150, 87), Width = 200 };

            var btnGrant = new Button { Text = "Cấp quyền", Location = new Point(400, 30), Size = new Size(100, 30) };
            var btnRevoke = new Button { Text = "Thu hồi quyền", Location = new Point(400, 70), Size = new Size(100, 30) };

            lstPrivileges = new ListView
            {
                Location = new Point(20, 120),
                Size = new Size(690, 180),
                View = View.Details
            };
            lstPrivileges.Columns.Add("User/Role", 150);
            lstPrivileges.Columns.Add("Quyền", 100);
            lstPrivileges.Columns.Add("Đối tượng", 200);
            lstPrivileges.Columns.Add("Loại", 100);

            // Tablespaces Tab
            var grpTablespaces = new GroupBox
            {
                Text = "Quản lý Tablespace",
                Location = new Point(10, 10),
                Size = new Size(730, 320)
            };

            var lblTablespace = new Label { Text = "Tên Tablespace:", Location = new Point(20, 30) };
            var txtTablespace = new TextBox { Location = new Point(150, 27), Width = 200 };

            var lblSize = new Label { Text = "Kích thước (MB):", Location = new Point(20, 60) };
            var txtSize = new TextBox { Location = new Point(150, 57), Width = 100 };

            var btnCreateTS = new Button { Text = "Tạo mới", Location = new Point(400, 30), Size = new Size(100, 30) };
            var btnDropTS = new Button { Text = "Xóa", Location = new Point(400, 70), Size = new Size(100, 30) };
            var btnResizeTS = new Button { Text = "Thay đổi kích thước", Location = new Point(400, 110), Size = new Size(100, 30) };

            lstTablespaces = new ListView
            {
                Location = new Point(20, 120),
                Size = new Size(690, 180),
                View = View.Details
            };
            lstTablespaces.Columns.Add("Tên", 150);
            lstTablespaces.Columns.Add("Kích thước (MB)", 100);
            lstTablespaces.Columns.Add("Trạng thái", 100);
            lstTablespaces.Columns.Add("Tự động mở rộng", 100);

            // Audit Tab
            var grpAudit = new GroupBox
            {
                Text = "Theo dõi hoạt động",
                Location = new Point(10, 10),
                Size = new Size(730, 320)
            };

            var lstAudit = new ListView
            {
                Location = new Point(20, 30),
                Size = new Size(690, 270),
                View = View.Details
            };
            lstAudit.Columns.Add("Thời gian", 150);
            lstAudit.Columns.Add("User", 100);
            lstAudit.Columns.Add("Hành động", 150);
            lstAudit.Columns.Add("Đối tượng", 200);
            lstAudit.Columns.Add("Trạng thái", 100);

            var btnRefreshAudit = new Button
            {
                Text = "Tải lại",
                Location = new Point(640, 30),
                Size = new Size(70, 30)
            };

            // Add controls
            grpConnection.Controls.AddRange(new Control[] { 
                lblHostname, txtHostname, 
                lblPort, txtPort,
                lblSID, txtSID, 
                lblUsername, txtUsername, 
                lblPassword, txtPassword, 
                btnConnect 
            });

            grpUserRole.Controls.AddRange(new Control[] { radUser, radRole, lblName, txtName,
                lblUserPass, txtUserPass, chkExisting, btnCreate, btnDelete, btnUpdate });

            tabManage.Controls.Add(grpUserRole);
            tabList.Controls.AddRange(new Control[] { cboFilter, lstUsers, btnRefresh });

            // Add controls to privilege group
            grpPrivileges.Controls.AddRange(new Control[] {
                lblGrantee, txtGrantee, lblPrivilege, cboPrivilege,
                lblObject, txtObject, btnGrant, btnRevoke, lstPrivileges
            });

            // Add controls to tablespace group
            grpTablespaces.Controls.AddRange(new Control[] {
                lblTablespace, txtTablespace, lblSize, txtSize,
                btnCreateTS, btnDropTS, btnResizeTS, lstTablespaces
            });

            // Add controls to audit group
            grpAudit.Controls.AddRange(new Control[] { lstAudit, btnRefreshAudit });

            // Add groups to tabs
            tabPrivileges.Controls.Add(grpPrivileges);
            tabTablespaces.Controls.Add(grpTablespaces);
            tabAudit.Controls.Add(grpAudit);

            // Add tabs to tab control
            tabControl.Controls.AddRange(new Control[] {
                tabManage, tabList, tabPrivileges, tabTablespaces, tabAudit
            });

            this.Controls.AddRange(new Control[] { grpConnection, tabControl });

            // Wire up events
            btnConnect.Click += (s, e) =>
            {
                _connection.Hostname = txtHostname.Text;
                _connection.Port = int.Parse(txtPort.Text);
                _connection.SID = txtSID.Text;
                _connection.Username = txtUsername.Text;
                _connection.Password = txtPassword.Text;

                if (_connection.TestConnection())
                {
                    MessageBox.Show("Kết nối thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadUserList();
                }
                else
                {
                    MessageBox.Show("Kết nối thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };

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
        }

        private void CreateUserOrRole()
        {
            if (!ValidateInput()) return;

            try
            {
                using var conn = new OracleConnection(_connection.GetConnectionString());
                conn.Open();

                string name = txtName.Text.Trim().ToUpper();
                string password = txtUserPass.Text;
                bool isUser = radUser.Checked;

                using var cmd = new OracleCommand(isUser ? "create_user_proc" : "create_role_proc", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                if (isUser)
                {
                    cmd.Parameters.Add("p_username", OracleDbType.Varchar2).Value = name;
                    cmd.Parameters.Add("p_password", OracleDbType.Varchar2).Value = password;
                }
                else
                {
                    cmd.Parameters.Add("p_rolename", OracleDbType.Varchar2).Value = name;
                }

                cmd.ExecuteNonQuery();
                MessageBox.Show($"{(isUser ? "User" : "Role")} {name} đã được tạo thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadUserList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteUserOrRole()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Vui lòng nhập tên user/role!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using var conn = new OracleConnection(_connection.GetConnectionString());
                conn.Open();

                string name = txtName.Text.Trim().ToUpper();
                bool isUser = radUser.Checked;

                using var cmd = new OracleCommand(isUser ? "drop_user_proc" : "drop_role_proc", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(isUser ? "p_username" : "p_rolename", OracleDbType.Varchar2).Value = name;

                cmd.ExecuteNonQuery();
                MessageBox.Show($"{name} đã được xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadUserList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateUserOrRole()
        {
            if (!ValidateInput()) return;

            try
            {
                using var conn = new OracleConnection(_connection.GetConnectionString());
                conn.Open();

                string name = txtName.Text.Trim();
                string password = txtUserPass.Text;
                bool isUser = radUser.Checked;

                if (isUser)
                {
                    using var cmd = new OracleCommand("alter_user_password_proc", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("p_username", OracleDbType.Varchar2).Value = name;
                    cmd.Parameters.Add("p_new_password", OracleDbType.Varchar2).Value = password;
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show($"{name} đã được cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadUserList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadUserList()
        {
            try
            {
                using var conn = new OracleConnection(_connection.GetConnectionString());
                conn.Open();

                string filter = cboFilter.SelectedItem?.ToString() ?? "All";
                
                using var cmd = new OracleCommand("get_users_roles_list", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("p_filter", OracleDbType.Varchar2).Value = filter;
                cmd.Parameters.Add("p_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                lstUsers.Items.Clear();
                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var item = new ListViewItem(reader["name"].ToString());
                    item.SubItems.Add(reader["type"].ToString());
                    item.SubItems.Add(reader["status"]?.ToString() ?? "N/A");
                    item.SubItems.Add(reader["created"]?.ToString() ?? "N/A");
                    lstUsers.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Vui lòng nhập tên user/role!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Kiểm tra mật khẩu chỉ khi tạo user mới
            if (radUser.Checked && !chkExisting.Checked && string.IsNullOrWhiteSpace(txtUserPass.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu cho user mới!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Kiểm tra tên hợp lệ
            string name = txtName.Text.Trim();
            if (!System.Text.RegularExpressions.Regex.IsMatch(name, "^[a-zA-Z][a-zA-Z0-9_#$]+$"))
            {
                MessageBox.Show("Tên user/role không hợp lệ! Chỉ được phép dùng chữ cái, số và các ký tự _#$", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void GrantPrivilege()
        {
            if (string.IsNullOrWhiteSpace(txtGrantee.Text) || cboPrivilege.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using var conn = new OracleConnection(_connection.GetConnectionString());
                conn.Open();

                string grantee = txtGrantee.Text.Trim();
                string privilege = cboPrivilege.SelectedItem.ToString();
                string objectName = txtObject.Text.Trim();

                using var cmd = new OracleCommand("grant_privilege_proc", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("p_privilege", OracleDbType.Varchar2).Value = privilege;
                cmd.Parameters.Add("p_grantee", OracleDbType.Varchar2).Value = grantee;
                cmd.Parameters.Add("p_object_name", OracleDbType.Varchar2).Value = string.IsNullOrEmpty(objectName) ? null : objectName;

                cmd.ExecuteNonQuery();
                MessageBox.Show("Cấp quyền thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadPrivileges();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RevokePrivilege()
        {
            if (string.IsNullOrWhiteSpace(txtGrantee.Text) || cboPrivilege.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using var conn = new OracleConnection(_connection.GetConnectionString());
                conn.Open();

                string grantee = txtGrantee.Text.Trim();
                string privilege = cboPrivilege.SelectedItem.ToString();
                string objectName = txtObject.Text.Trim();

                using var cmd = new OracleCommand("revoke_privilege_proc", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("p_privilege", OracleDbType.Varchar2).Value = privilege;
                cmd.Parameters.Add("p_grantee", OracleDbType.Varchar2).Value = grantee;
                cmd.Parameters.Add("p_object_name", OracleDbType.Varchar2).Value = string.IsNullOrEmpty(objectName) ? null : objectName;

                cmd.ExecuteNonQuery();
                MessageBox.Show("Thu hồi quyền thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadPrivileges();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadPrivileges()
        {
            try
            {
                using var conn = new OracleConnection(_connection.GetConnectionString());
                conn.Open();

                using var cmd = new OracleCommand("get_privileges_list", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("p_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                lstPrivileges.Items.Clear();
                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var item = new ListViewItem(reader["grantee"].ToString());
                    item.SubItems.Add(reader["privilege"].ToString());
                    item.SubItems.Add(reader["table_name"].ToString());
                    item.SubItems.Add(reader["grantable"].ToString());
                    lstPrivileges.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CreateTablespace()
        {
            if (string.IsNullOrWhiteSpace(txtTablespace.Text) || string.IsNullOrWhiteSpace(txtSize.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using var conn = new OracleConnection(_connection.GetConnectionString());
                conn.Open();

                string tablespace = txtTablespace.Text.Trim();
                int size = int.Parse(txtSize.Text);

                using var cmd = new OracleCommand("create_tablespace_proc", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("p_tablespace_name", OracleDbType.Varchar2).Value = tablespace;
                cmd.Parameters.Add("p_size", OracleDbType.Int32).Value = size;

                cmd.ExecuteNonQuery();
                MessageBox.Show("Tạo tablespace thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadTablespaces();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DropTablespace()
        {
            if (string.IsNullOrWhiteSpace(txtTablespace.Text))
            {
                MessageBox.Show("Vui lòng nhập tên tablespace!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using var conn = new OracleConnection(_connection.GetConnectionString());
                conn.Open();

                string tablespace = txtTablespace.Text.Trim();

                using var cmd = new OracleCommand("drop_tablespace_proc", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("p_tablespace_name", OracleDbType.Varchar2).Value = tablespace;

                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa tablespace thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadTablespaces();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ResizeTablespace()
        {
            if (string.IsNullOrWhiteSpace(txtTablespace.Text) || string.IsNullOrWhiteSpace(txtSize.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using var conn = new OracleConnection(_connection.GetConnectionString());
                conn.Open();

                string tablespace = txtTablespace.Text.Trim();
                int size = int.Parse(txtSize.Text);

                using var cmd = new OracleCommand("resize_tablespace_proc", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("p_tablespace_name", OracleDbType.Varchar2).Value = tablespace;
                cmd.Parameters.Add("p_size", OracleDbType.Int32).Value = size;

                cmd.ExecuteNonQuery();
                MessageBox.Show("Thay đổi kích thước tablespace thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadTablespaces();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadTablespaces()
        {
            try
            {
                using var conn = new OracleConnection(_connection.GetConnectionString());
                conn.Open();

                using var cmd = new OracleCommand("get_tablespaces_list", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("p_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                lstTablespaces.Items.Clear();
                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var item = new ListViewItem(reader["tablespace_name"].ToString());
                    item.SubItems.Add(reader["size_mb"].ToString());
                    item.SubItems.Add(reader["status"].ToString());
                    item.SubItems.Add(reader["autoextensible"].ToString());
                    lstTablespaces.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadAuditLog()
        {
            try
            {
                using var conn = new OracleConnection(_connection.GetConnectionString());
                conn.Open();

                using var cmd = new OracleCommand("get_audit_log_list", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("p_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                lstAudit.Items.Clear();
                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var item = new ListViewItem(reader["timestamp"].ToString());
                    item.SubItems.Add(reader["username"].ToString());
                    item.SubItems.Add(reader["action_name"].ToString());
                    item.SubItems.Add(reader["obj_name"].ToString());
                    item.SubItems.Add(reader["status"].ToString());
                    lstAudit.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
} 
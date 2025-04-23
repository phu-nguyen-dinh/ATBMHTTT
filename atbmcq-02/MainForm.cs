using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OracleUserManager.Models;
using Oracle.ManagedDataAccess.Client;

namespace atbmcq_02
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            _connection = new OracleDbConnection();
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

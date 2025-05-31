using Oracle.ManagedDataAccess.Client;
using OracleUserManager.Models;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace atbmcq_02
{
    public partial class UserManagement : UserControl
    {
        private OracleDbConnection _connection;

        public UserManagement(OracleDbConnection _connect)
        {
            InitializeComponent();
            _connection = _connect;

            // Thêm event handler cho RadioButton
            radUser.CheckedChanged += RadioButton_CheckedChanged;
            radRole.CheckedChanged += RadioButton_CheckedChanged;

            // Thêm event handler cho TextBox tìm kiếm
            txtSearch.TextChanged += TxtSearch_TextChanged;

            // Gọi ngay lập tức để thiết lập UI ban đầu
            RadioButton_CheckedChanged(null, null);

            // Thiết lập mặc định
            cboLevelTB.SelectedIndex = 0;

            // Thêm sự kiện cho btnRefresh nếu chưa có
            btnRefresh.Click += LoadUserList;

            // Load danh sách thông báo
            LoadThongBao();
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            // Gọi hàm tải danh sách để lọc theo từ khóa tìm kiếm
            LoadUserList(sender, e);
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Hiển thị/ẩn trường mật khẩu và nút Update dựa trên selection
            bool isUser = radUser.Checked;

            lblUserPass.Visible = isUser;
            txtUserPass.Visible = isUser;
            btnUpdate.Visible = isUser;
            chkExisting.Visible = false; // Luôn ẩn checkbox Existing User
        }

        private void CreateUserOrRole(object sender, EventArgs e)
        {
            if (!ValidateInput(sender, e)) return;

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
                LoadUserList(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteUserOrRole(object sender, EventArgs e)
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
                LoadUserList(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateUserOrRole(object sender, EventArgs e)
        {
            if (!ValidateInput(sender, e)) return;

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
                LoadUserList(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadUserList(object sender, EventArgs e)
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

                // Lấy từ khóa tìm kiếm (nếu có)
                string searchKeyword = txtSearch.Text.Trim().ToLower();

                while (reader.Read())
                {
                    string name = reader["name"].ToString();

                    // Nếu có từ khóa tìm kiếm và tên không chứa từ khóa thì bỏ qua
                    if (!string.IsNullOrEmpty(searchKeyword) &&
                        !name.ToLower().Contains(searchKeyword))
                    {
                        continue;
                    }

                    var item = new ListViewItem(name);
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

        private bool ValidateInput(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Vui lòng nhập tên user/role!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Kiểm tra mật khẩu chỉ khi tạo user mới
            if (radUser.Checked && string.IsNullOrWhiteSpace(txtUserPass.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu cho user!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        #region Xử lý Thông báo

        private void ThongBaoFilter_Changed(object sender, EventArgs e)
        {
            LoadThongBao();
        }

        private void TimKiemThongBao_Changed(object sender, EventArgs e)
        {
            LoadThongBao();
        }

        private void ThongBao_Selected(object sender, EventArgs e)
        {
            if (lstThongBao.SelectedItems.Count == 0) return;

            ListViewItem item = lstThongBao.SelectedItems[0];
            string id = item.SubItems[0].Text;
            string noiDung = item.SubItems[1].Text;
            string nhan = item.SubItems[2].Text;

            txtNoiDungTB.Text = noiDung;

            // Phân tích nhãn để thiết lập UI
            // Format của nhãn: LEVEL:COMPARTMENT1,COMPARTMENT2:GROUP1,GROUP2
            string[] parts = nhan.Split(':');
            if (parts.Length >= 3)
            {
                // Thiết lập Level
                cboLevelTB.SelectedItem = parts[0];

                // Thiết lập Compartment
                string[] comps = parts[1].Split(',');
                for (int i = 0; i < chkListCompartment.Items.Count; i++)
                {
                    chkListCompartment.SetItemChecked(i, comps.Contains(chkListCompartment.Items[i].ToString()));
                }

                // Thiết lập Group
                string[] groups = parts[2].Split(',');
                for (int i = 0; i < chkListGroup.Items.Count; i++)
                {
                    chkListGroup.SetItemChecked(i, groups.Contains(chkListGroup.Items[i].ToString()));
                }
            }

            // Lưu ID hiện tại
            currentThongBaoId = int.Parse(id);
        }

        private int currentThongBaoId = -1;

        private void ThemThongBao(object sender, EventArgs e)
        {
            if (!ValidateThongBao()) return;

            try
            {
                using var conn = new OracleConnection(_connection.GetConnectionString());
                conn.Open();

                // Tạo nhãn từ các thành phần đã chọn
                string level = cboLevelTB.SelectedItem.ToString();

                // Lấy danh sách compartment đã chọn
                List<string> compartments = new List<string>();
                for (int i = 0; i < chkListCompartment.CheckedItems.Count; i++)
                {
                    compartments.Add(chkListCompartment.CheckedItems[i].ToString());
                }

                // Lấy danh sách group đã chọn
                List<string> groups = new List<string>();
                for (int i = 0; i < chkListGroup.CheckedItems.Count; i++)
                {
                    groups.Add(chkListGroup.CheckedItems[i].ToString());
                }

                string compartmentStr = string.Join(",", compartments);
                string groupStr = string.Join(",", groups);

                // Tạo chuỗi nhãn hoàn chỉnh
                string labelStr = $"{level}:{compartmentStr}:{groupStr}";

                // Lấy ID mới
                int newId = GetNextThongBaoId(conn);

                // Thêm thông báo mới với nhãn
                using var cmd = new OracleCommand("INSERT INTO C##ADMIN.THONGBAO (ID, NOIDUNG, LBL_THONGBAO) VALUES (:id, :noidung, CHAR_TO_LABEL('POL_THONGBAO', :nhan))", conn);
                cmd.Parameters.Add(":id", OracleDbType.Int32).Value = newId;
                cmd.Parameters.Add(":noidung", OracleDbType.NVarchar2).Value = txtNoiDungTB.Text;
                cmd.Parameters.Add(":nhan", OracleDbType.Varchar2).Value = labelStr;

                cmd.ExecuteNonQuery();

                MessageBox.Show("Thêm thông báo thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadThongBao();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int GetNextThongBaoId(OracleConnection conn)
        {
            using var cmd = new OracleCommand("SELECT NVL(MAX(ID), 0) + 1 FROM C##ADMIN.THONGBAO", conn);
            return Convert.ToInt32(cmd.ExecuteScalar());
        }

        private void XoaThongBao(object sender, EventArgs e)
        {
            if (currentThongBaoId < 0)
            {
                MessageBox.Show("Vui lòng chọn thông báo cần xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using var conn = new OracleConnection(_connection.GetConnectionString());
                conn.Open();

                using var cmd = new OracleCommand("DELETE FROM C##ADMIN.THONGBAO WHERE ID = :id", conn);
                cmd.Parameters.Add(":id", OracleDbType.Int32).Value = currentThongBaoId;

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Xóa thông báo thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadThongBao();
                    ResetThongBaoForm();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy thông báo cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CapNhatThongBao(object sender, EventArgs e)
        {
            if (currentThongBaoId < 0)
            {
                MessageBox.Show("Vui lòng chọn thông báo cần cập nhật!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!ValidateThongBao()) return;

            try
            {
                using var conn = new OracleConnection(_connection.GetConnectionString());
                conn.Open();

                // Tạo nhãn từ các thành phần đã chọn
                string level = cboLevelTB.SelectedItem.ToString();

                // Lấy danh sách compartment đã chọn
                List<string> compartments = new List<string>();
                for (int i = 0; i < chkListCompartment.CheckedItems.Count; i++)
                {
                    compartments.Add(chkListCompartment.CheckedItems[i].ToString());
                }

                // Lấy danh sách group đã chọn
                List<string> groups = new List<string>();
                for (int i = 0; i < chkListGroup.CheckedItems.Count; i++)
                {
                    groups.Add(chkListGroup.CheckedItems[i].ToString());
                }

                string compartmentStr = string.Join(",", compartments);
                string groupStr = string.Join(",", groups);

                // Tạo chuỗi nhãn hoàn chỉnh
                string labelStr = $"{level}:{compartmentStr}:{groupStr}";

                // Cập nhật thông báo với nhãn mới
                using var cmd = new OracleCommand("UPDATE THONGBAO SET NOIDUNG = :noidung, LBL_THONGBAO = CHAR_TO_LABEL('POL_THONGBAO', :nhan) WHERE ID = :id", conn);
                cmd.Parameters.Add(":noidung", OracleDbType.NVarchar2).Value = txtNoiDungTB.Text;
                cmd.Parameters.Add(":nhan", OracleDbType.Varchar2).Value = labelStr;
                cmd.Parameters.Add(":id", OracleDbType.Int32).Value = currentThongBaoId;

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Cập nhật thông báo thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadThongBao();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy thông báo cần cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadThongBao()
        {
            try
            {
                using var conn = new OracleConnection(_connection.GetConnectionString());
                conn.Open();

                // Sử dụng stored procedure get_filtered_thongbao
                using var cmd = new OracleCommand("get_filtered_thongbao", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("p_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                using var reader = cmd.ExecuteReader();
                lstThongBao.Items.Clear();

                string keyword = txtTimKiemTB.Text.ToLower();

                while (reader.Read())
                {
                    string id = reader["ID"].ToString();
                    string noiDung = reader["NOIDUNG"].ToString();
                    string nhan = reader["NHAN"].ToString();

                    // Lọc theo từ khóa tìm kiếm nếu có
                    if (!string.IsNullOrWhiteSpace(keyword) &&
                        !noiDung.ToLower().Contains(keyword) &&
                        !nhan.ToLower().Contains(keyword))
                    {
                        continue;
                    }

                    var item = new ListViewItem(id);
                    item.SubItems.Add(noiDung);
                    item.SubItems.Add(nhan);
                    lstThongBao.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách thông báo: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateThongBao()
        {
            if (string.IsNullOrWhiteSpace(txtNoiDungTB.Text))
            {
                MessageBox.Show("Vui lòng nhập nội dung thông báo!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (cboLevelTB.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn Level cho thông báo!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (chkListCompartment.CheckedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một Khoa/Bộ môn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (chkListGroup.CheckedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một Cơ sở!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void ResetThongBaoForm()
        {
            currentThongBaoId = -1;
            txtNoiDungTB.Text = string.Empty;
            cboLevelTB.SelectedIndex = 0;

            // Bỏ chọn tất cả các checkbox
            for (int i = 0; i < chkListCompartment.Items.Count; i++)
            {
                chkListCompartment.SetItemChecked(i, false);
            }

            for (int i = 0; i < chkListGroup.Items.Count; i++)
            {
                chkListGroup.SetItemChecked(i, false);
            }
        }

        #endregion

        private void lblCompartmentTB_Click(object sender, EventArgs e)
        {

        }

        private void lblLevelTB_Click(object sender, EventArgs e)
        {

        }

        private void radUser_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lblUserPass_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void lstUsers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

        }
    }
}

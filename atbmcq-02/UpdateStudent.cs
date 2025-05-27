using Oracle.ManagedDataAccess.Client;
using OracleUserManager.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace atbmcq_02
{
    public partial class UpdateStudent : UserControl
    {
        public event EventHandler<OracleDbConnection> backClicked;

        public UpdateStudent(OracleDbConnection _connect)
        {
            InitializeComponent();
            _connection = _connect;
        }

        private void lblBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            backClicked?.Invoke(this, _connection);
        }
        private void lblSignOut_LinkClicked(Object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Restart();
        }
        private void UpdateStudent_Load(object sender, EventArgs e)
        {
            LoadOfficial();
        }

        private void LoadOfficial()
        {
            try
            {
                string username = _connection.Username.ToUpper();
                using var conn = new OracleConnection(_connection.GetConnectionString());
                conn.Open();

                string query = "SELECT * FROM C##ADMIN.NHANVIEN WHERE MANLD= '" + username + "'";
                using var cmd = new OracleCommand(query, conn);
                using var reader = cmd.ExecuteReader();

                // Ẩn/hiện nút theo vai trò
                if (reader.Read())
                {
                    string vaitro = reader["VAITRO"].ToString();
                    if (vaitro == "NV PĐT")
                    {
                        comboBoxStatus.Visible = true;
                    }
                    else
                    {
                        comboBoxStatus.Visible = false;
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                using var conn = new OracleConnection(_connection.GetConnectionString());
                conn.Open();

                string Username = _connection.Username;
                string query = $"SELECT VAITRO FROM C##ADMIN.NHANVIEN WHERE USERNAME = '{Username}'";
                string role = "";

                using (var roleCmd = new OracleCommand(query, conn))
                using (var reader = roleCmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        role = reader.GetString(0);
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy tài khoản người dùng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                string ID = textBoxID.Text;
                string Name = textBoxName.Text;
                string Gender = comboBoxGender.Text;
                string Birthday = dateTimePickerBirthday.Text;
                string address = textBoxAddress.Text;
                string PhoneNumber = textBoxPhoneNumber.Text;
                string Department = comboBoxDepartment.Text;
                string Status = comboBoxStatus.Text;

                string updateQuery;

                if (role == "NV PĐT")
                {
                    updateQuery = $@"
                UPDATE C##ADMIN.SINHVIEN
                SET
                    HOTEN = N'{Name}',
                    PHAI = N'{Gender}',
                    NGSINH = TO_DATE('{dateTimePickerBirthday.Value:yyyy-MM-dd}', 'YYYY-MM-DD'),
                    DCHI = N'{address}',
                    DT = '{PhoneNumber}',
                    KHOA = '{Department}',
                    TINHTRANG = N'{Status}'
                WHERE MASV = '{ID}'";
                }
                else
                {
                    updateQuery = $@"
                UPDATE C##ADMIN.SINHVIEN
                SET
                    HOTEN = N'{Name}',
                    PHAI = N'{Gender}',
                    NGSINH = TO_DATE('{dateTimePickerBirthday.Value:yyyy-MM-dd}', 'YYYY-MM-DD'),
                    DCHI = N'{address}',
                    DT = '{PhoneNumber}',
                    KHOA = '{Department}'
                WHERE MASV = '{ID}'";
                }

                using var cmd = new OracleCommand(updateQuery, conn);
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Cập nhật không thành công!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void ButtonCANCEL_Click(object sender, EventArgs e)
        {
            backClicked?.Invoke(this, _connection);
        }
    }
}

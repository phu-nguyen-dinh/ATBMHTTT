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
using System.Text.Json;
using System.IO;

namespace atbmcq_02
{
    public partial class Login : Form
    {
        private OracleDbConnection _connection;

        public Login()
        {
            InitializeComponent();
            this._connection = new OracleDbConnection();

            // Add event handlers for buttons
            btnTest.Click += BtnTest_Click;
            btnConnect.Click += orclConnect;
            btnCancel.Click += BtnCancel_Click;
        }

        private void BtnTest_Click(object? sender, EventArgs e)
        {
            try
            {
                _connection.Hostname = "localhost";
                _connection.Port = 1521;
                _connection.Username = txtUsername.Text;
                _connection.Password = txtPassword.Text;
                _connection.Role = cboRole.SelectedItem?.ToString() ?? "default";
                _connection.ServiceName = "xepdb1";

                if (_connection.Connect())
                {
                    MessageBox.Show("Connection test successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Connection test failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                _connection.conn.Close();
                _connection.conn.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error testing connection: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCancel_Click(object? sender, EventArgs e)
        {
            this.Close();
        }

        private void orclConnect(object? sender, EventArgs e)
        {
            try
            {
                this._connection.Hostname = "localhost";
                this._connection.Port = 1521;
                _connection.ServiceName = "xepdb1";
                this._connection.Username = txtUsername.Text;
                this._connection.Password = txtPassword.Text;
                this._connection.Role = cboRole.SelectedItem?.ToString() ?? "default";

                if (_connection.Connect())
                {
                    MessageBox.Show("Connection successful!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadMainForm();
                }
                else
                {
                    MessageBox.Show("Connection failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error connecting: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private String getRole()
        {
            try
            {
                using var conn = new OracleConnection(_connection.GetConnectionString());
                conn.Open();

                string query = "SELECT VAITRO FROM C##ADMIN.NHANVIEN WHERE MANLD= '" + _connection.Username+"'";
                using var cmd = new OracleCommand(query, conn);
                using var reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return reader.GetString(0);
                }
                return "";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }
        }

        private void loadMainForm()
        {
            string username = _connection.Username.ToUpper();
            this.Hide();

            if (username == "C##ADMIN" || username == "ADMIN")
            {
                Home homeForm = new Home(_connection);
                homeForm.ShowDialog();
            }
            else if (username.StartsWith("SV"))
            {
                DashBoard dshBrd = new DashBoard(_connection);
                dshBrd.ShowDialog();
            }
            else if (username.StartsWith("NV"))
            {
                // Lấy vai trò từ bảng NHANVIEN
                try
                {
                    using var conn = new OracleConnection(_connection.GetConnectionString());
                    conn.Open();
                    string roleQuery = $"SELECT VAITRO FROM C##ADMIN.NHANVIEN WHERE MANLD = '{username}'";

                    using var cmd = new OracleCommand(roleQuery, conn);
                    string vaitro = cmd.ExecuteScalar()?.ToString();

                    if (vaitro == "GV")
                    {
                        Teacher_DashBoard teacherForm = new Teacher_DashBoard(_connection);
                        teacherForm.ShowDialog();
                    }
                    else if(vaitro == "NV PĐT")
                    {
                        PDT_DashBoard PDTForm = new PDT_DashBoard(_connection);
                        PDTForm.ShowDialog();
                    }
                    else if(vaitro== "NV CTSV")
                    {
                        CTSV_DashBoard CTSVForm = new CTSV_DashBoard(_connection);
                        CTSVForm.ShowDialog();
                    }
                    else if(vaitro== "NVCB")
                    {
                        NVCB_DashBoard NVCBForm = new NVCB_DashBoard(_connection);
                        NVCBForm.ShowDialog();
                    }
                    else if(vaitro=="NV PKT")
                    {
                        PKT_DashBoard PKTForm = new PKT_DashBoard(_connection);
                        PKTForm.ShowDialog();
                    }
                    else if(vaitro== "NV TCHC")
                    {
                        TCHC_DashBoard TCHCForm = new TCHC_DashBoard(_connection);
                        TCHCForm.ShowDialog();
                    }
                    else if(vaitro== "TRGĐV")
                    {
                        TRGDV_DashBoard TRGDVForm = new TRGDV_DashBoard(_connection);
                        TRGDVForm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show($"Do not have any user like that", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Application.Restart();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi phân quyền: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DashBoard dshBrd = new DashBoard(_connection);
                    dshBrd.ShowDialog();
                }
            }
            else
            {
                DashBoard dshBrd = new DashBoard(_connection);
                dshBrd.ShowDialog();
            }

            this.Close();
        }
    }
}

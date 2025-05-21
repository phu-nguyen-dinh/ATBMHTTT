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
            _connection = new OracleDbConnection();

            // Add event handlers for buttons
            btnTest.Click += BtnTest_Click;
            btnConnect.Click += orclConnect;
            btnCancel.Click += BtnCancel_Click;
        }

        private void BtnTest_Click(object? sender, EventArgs e)
        {
            try
            {
                // Get connection details
                _connection.Hostname = "localhost";
                _connection.Port = 1521;
                _connection.Username = txtUsername.Text;
                _connection.Password = txtPassword.Text;
                _connection.Role = cboRole.SelectedItem?.ToString() ?? "default";
                _connection.ServiceName = "xepdb1";

                // Test the connection
                if (_connection.TestConnection())
                {
                    MessageBox.Show("Connection test successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Connection test failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error testing connection: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCancel_Click(object? sender, EventArgs e)
        {
            // Close the form
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

                if (_connection.TestConnection())
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

        private void loadMainForm()
        {
            string username = _connection.Username.ToUpper();

            this.Hide();

            if (username.StartsWith("SV"))
            {
                // Nếu là sinh viên → mở form Student
                Student studentForm = new Student(_connection);
                studentForm.ShowDialog();
            }
            else
            {
                // Các vai trò khác → mở Dashboard
                DashBoard dshBrd = new DashBoard(_connection);
                dshBrd.ShowDialog();
            }

            this.Close();
        }

    }
}

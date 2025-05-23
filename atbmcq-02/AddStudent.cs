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
    public partial class AddStudent : UserControl
    {
        public event EventHandler<OracleDbConnection> backClicked;

        public AddStudent(OracleDbConnection _connect)
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
        private void ButtonADD_Click(object sender, EventArgs e)
        {
            try
            {
                using var conn = new OracleConnection(_connection.GetConnectionString());
                conn.Open();

                String query = "";
                String ID = textBoxID.Text;
                String Name = textBoxName.Text;
                String Gender = comboBoxGender.Text;
                String Birthday = dateTimePickerBirthday.Text;
                String address = textBoxAddress.Text;
                String PhoneNumber = textBoxPhoneNumber.Text;
                String Department = comboBoxDepartment.Text;
                String Status = comboBoxStatus.Text;
                query = $@"
                INSERT INTO C##ADMIN.SINHVIEN 
                (MASV, HOTEN, PHAI, NGSINH, DCHI, DT, KHOA, TINHTRANG)
                VALUES (
                    '{ID}', 
                    N'{Name}', 
                    N'{Gender}', 
                    TO_DATE('{dateTimePickerBirthday.Value:yyyy-MM-dd}', 'YYYY-MM-DD'),
                    N'{address}', 
                    '{PhoneNumber}', 
                    '{Department}', 
                    N'{Status}'
                )";

                using var cmd = new OracleCommand(query, conn);
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("SUCCESS", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("NOT SUCCESS", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ERROR: {ex.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonCANCEL_Click(object sender, EventArgs e)
        {
            backClicked?.Invoke(this, _connection);         
        }
    }
}

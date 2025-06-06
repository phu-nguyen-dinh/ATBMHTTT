﻿using Oracle.ManagedDataAccess.Client;
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
    public partial class UpdateStaff : UserControl
    {
        public event EventHandler<OracleDbConnection> backClicked;

        public UpdateStaff(OracleDbConnection _connect)
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
                String Salary = textBoxSalary.Text;
                String Bonus = textBoxBonus.Text;
                String PhoneNumber = textBoxSalary.Text;
                String Role = comboBoxRole.Text;
                String Unit = comboBoxUnit.Text;
                query = $@"
                UPDATE C##ADMIN.NHANVIEN
                SET
                    HOTEN = N'{Name}',
                    PHAI = N'{Gender}',
                    NGSINH = TO_DATE('{dateTimePickerBirthday.Value:yyyy-MM-dd}', 'YYYY-MM-DD'),
                    LUONG = {Salary},
                    PHUCAP = {Bonus},
                    DT = '{PhoneNumber}',
                    VAITRO = N'{Role}',
                    MADV = '{Unit}'
                WHERE MANLD = '{ID}'";


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

        private void AddStudent_Load(object sender, EventArgs e)
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

                string query = "SELECT * FROM C##ADMIN.NHANVIEN";
                using var cmd = new OracleCommand(query, conn);
                using var reader = cmd.ExecuteReader();
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

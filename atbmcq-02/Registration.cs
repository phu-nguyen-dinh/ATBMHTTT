﻿using Oracle.ManagedDataAccess.Client;
using OracleUserManager.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atbmcq_02
{
    public partial class Registration : UserControl
    {
        public event EventHandler<OracleDbConnection> backClicked;
        public Registration(OracleDbConnection _connect)
        {
            String username = _connect.Username;
            InitializeComponent();
            _connection = _connect;
            if (username.StartsWith("SV"))
            {
                dtgvStudent2.Visible = true;
                dtgvOfficial.Visible = false;
                dtgvStudent2.Location = new Point(0, 0);
                dtgvStudent2.BringToFront();
                LoadRegisteredCoursesForStudent();
            }
            else
            {
                dtgvStudent2.Visible = false;
                dtgvOfficial.Visible = true;
                dtgvOfficial.Location = new Point(0, 0);
                dtgvOfficial.BringToFront();
                LoadRegisteredCoursesForOfficial();
            }
        }

        private void lblBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            backClicked?.Invoke(this, _connection);
        }

        private void LoadRegisteredCoursesForStudent()
        {
            try
            {
                string username = _connection.Username.ToUpper();
                using var conn = new OracleConnection(_connection.GetConnectionString());
                conn.Open();
                string query = "SELECT * FROM C##ADMIN.DANGKY WHERE MASV= '" + username + "'";
                using var cmd = new OracleCommand(query, conn);
                using var reader = cmd.ExecuteReader();

                dtgvStudent2.Rows.Clear();

                while (reader.Read())
                {
                    object[] row = new object[reader.FieldCount];
                    reader.GetValues(row);
                    dtgvStudent2.Rows.Add(row);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadRegisteredCoursesForOfficial()
        {
            try
            {
                string username = _connection.Username.ToUpper();
                using var conn = new OracleConnection(_connection.GetConnectionString());
                conn.Open();
                String query = "SELECT NV.MANLD, NV.HOTEN, NV.PHAI, NV.NGSINH, NV.LUONG, NV.PHUCAP, NV.DT, NV.VAITRO, NV.MADV\r\nFROM C##ADMIN.DANGKY DK\r\nJOIN C##ADMIN.MOMON MM ON MM.MAMM = DK.MAMM\r\nJOIN C##ADMIN.NHANVIEN NV ON NV.MANLD = MM.MAGV\r\nWHERE MM.MAGV ='" + username + "'";
                using var cmd = new OracleCommand(query, conn);
                using var reader = cmd.ExecuteReader();

                dtgvOfficial.Rows.Clear();

                while (reader.Read())
                {
                    object[] row = new object[reader.FieldCount];
                    reader.GetValues(row);
                    dtgvOfficial.Rows.Add(row);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void lblSignOut_LinkClicked(Object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Restart();
        }
    }
}

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
    public partial class DeleteStudent : UserControl
    {
        public event EventHandler<OracleDbConnection> backClicked;

        public DeleteStudent(OracleDbConnection _connect)
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
        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                using var conn = new OracleConnection(_connection.GetConnectionString());
                conn.Open();

                String ID = textBoxID.Text;

                string query = $@"
                DELETE FROM C##ADMIN.SINHVIEN
                WHERE MASV = '"+ID+"'";

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

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                using var conn = new OracleConnection(_connection.GetConnectionString());
                conn.Open();

                string ID = textBoxID.Text.Trim();
                string query = "SELECT * FROM C##ADMIN.SINHVIEN WHERE MASV = :id";

                using var cmd = new OracleCommand(query, conn);
                cmd.Parameters.Add(new OracleParameter("id", ID));

                using var reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    dtgvStudent1.Rows.Clear(); // Nếu có DataGridView để hiển thị
                    while (reader.Read())
                    {
                        object[] row = new object[reader.FieldCount];
                        reader.GetValues(row);
                        dtgvStudent1.Rows.Add(row);
                    }
                }
                else
                {
                    MessageBox.Show($"Do not have any student with ID = {ID}", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ERROR: {ex.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadStudents()
        {
            try
            {
                using var conn = new OracleConnection(_connection.GetConnectionString());
                conn.Open();

                String ID = textBoxID.Text;

                string query = "SELECT * FROM C##ADMIN.SINHVIEN WHERE MASV='"+ID+"'";
                using var cmd = new OracleCommand(query, conn);
                using var reader = cmd.ExecuteReader();

                dtgvStudent1.Rows.Clear();

                while (reader.Read())
                {
                    object[] row = new object[reader.FieldCount];
                    reader.GetValues(row);
                    dtgvStudent1.Rows.Add(row);
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

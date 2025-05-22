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
    public partial class Teacher : UserControl
    {
        public event EventHandler<OracleDbConnection> backClicked;

        public Teacher(OracleDbConnection _connect)
        {
            InitializeComponent();
            _connection = _connect;
            LoadTeacher();
            LoadStudents();
        }

        private void lblBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            backClicked?.Invoke(this, _connection);
        }

        private void LoadStudents()    {        try        {            using var conn = new OracleConnection(_connection.GetConnectionString());            conn.Open();            string query = "SELECT * FROM C##ADMIN.SINHVIEN";            using var cmd = new OracleCommand(query, conn);            using var reader = cmd.ExecuteReader();            dtgvStudentInfo.Rows.Clear();            while (reader.Read())            {                object[] row = new object[reader.FieldCount];                reader.GetValues(row);                dtgvStudentInfo.Rows.Add(row);            }        }        catch (Exception ex)        {            MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);        }    }

        private void LoadTeacher()    {        try        {            using var conn = new OracleConnection(_connection.GetConnectionString());            conn.Open();            string query = "SELECT * FROM C##ADMIN.VW_NHANVIEN_SELF";            using var cmd = new OracleCommand(query, conn);            using var reader = cmd.ExecuteReader();            dtgvTeacherInfo.Rows.Clear();            while (reader.Read())            {                object[] row = new object[reader.FieldCount];                reader.GetValues(row);                dtgvTeacherInfo.Rows.Add(row);            }        }        catch(Exception ex)        {            MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);        }    }

        private void lblSignOut_LinkClicked(Object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Restart();
        }

        private void btnEditPhone_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNewPhone.Text))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using var conn = new OracleConnection(_connection.GetConnectionString());
                conn.Open();

                string query = "UPDATE C##ADMIN.VW_NHANVIEN_SELF SET DT = :phone";
                using var cmd = new OracleCommand(query, conn);
                cmd.Parameters.Add(new OracleParameter("phone", txtNewPhone.Text));
                
                int result = cmd.ExecuteNonQuery();
                
                if (result > 0)
                {
                    MessageBox.Show("Cập nhật số điện thoại thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadTeacher(); // Tải lại thông tin sau khi cập nhật
                    txtNewPhone.Clear();
                }
                else
                {
                    MessageBox.Show("Không thể cập nhật số điện thoại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

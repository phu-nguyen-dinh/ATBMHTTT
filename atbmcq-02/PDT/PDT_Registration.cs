using Oracle.ManagedDataAccess.Client;
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
    public partial class PDT_Registration : UserControl
    {
        public event EventHandler<OracleDbConnection> backClicked;
        public PDT_Registration(OracleDbConnection _connect)
        {
            InitializeComponent();
            _connection = _connect;
            
            // Hiển thị tất cả dữ liệu đăng ký học phần
            LoadAllRegistrations();
        }

        private void lblBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            backClicked?.Invoke(this, _connection);
        }

        private void LoadAllRegistrations()
        {
            try
            {
                using var conn = new OracleConnection(_connection.GetConnectionString());
                conn.Open();
                string query = "SELECT * FROM C##ADMIN.DANGKY";
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

        private bool IsRegistrationPeriodOpen(string mamm)
        {
            try
            {
                using var conn = new OracleConnection(_connection.GetConnectionString());
                conn.Open();
                string query = "SELECT IS_REGISTRATION_PERIOD_OPEN_FUNC(:mamm) FROM DUAL";
                using var cmd = new OracleCommand(query, conn);
                cmd.Parameters.Add(new OracleParameter("mamm", OracleDbType.Varchar2)).Value = mamm;
                
                var result = cmd.ExecuteScalar();
                return result != null && result.ToString() == "1";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi kiểm tra thời gian đăng ký: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Hiển thị form thêm đăng ký mới
            using var addForm = new Form();
            addForm.Text = "Thêm đăng ký học phần";
            addForm.Size = new Size(400, 250);
            addForm.StartPosition = FormStartPosition.CenterParent;
            
            var lblMaSV = new Label { Text = "Student ID:", Location = new Point(20, 20) };
            var txtMaSV = new TextBox { Location = new Point(150, 20), Width = 200 };
            
            var lblMaMM = new Label { Text = "Course ID:", Location = new Point(20, 60) };
            var txtMaMM = new TextBox { Location = new Point(150, 60), Width = 200 };
            
            var btnSave = new Button { Text = "Save", Location = new Point(150, 150), DialogResult = DialogResult.OK };
            var btnCancel = new Button { Text = "Cancel", Location = new Point(250, 150), DialogResult = DialogResult.Cancel };
            
            addForm.Controls.AddRange(new Control[] { lblMaSV, txtMaSV, lblMaMM, txtMaMM, btnSave, btnCancel });
            addForm.AcceptButton = btnSave;
            addForm.CancelButton = btnCancel;
            
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                string masv = txtMaSV.Text.Trim().ToUpper();
                string mamm = txtMaMM.Text.Trim().ToUpper();
                
                if (string.IsNullOrEmpty(masv) || string.IsNullOrEmpty(mamm))
                {
                    MessageBox.Show("Please enter all required information!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
                // Kiểm tra thời gian đăng ký
                if (!IsRegistrationPeriodOpen(mamm))
                {
                    MessageBox.Show("Registration period is closed for this course!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
                try
                {
                    using var conn = new OracleConnection(_connection.GetConnectionString());
                    conn.Open();
                    string query = "INSERT INTO C##ADMIN.DANGKY (MASV, MAMM) VALUES (:masv, :mamm)";
                    using var cmd = new OracleCommand(query, conn);
                    cmd.Parameters.Add(new OracleParameter("masv", OracleDbType.Varchar2)).Value = masv;
                    cmd.Parameters.Add(new OracleParameter("mamm", OracleDbType.Varchar2)).Value = mamm;
                    
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Registration added successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadAllRegistrations();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có dòng nào được chọn không
            if (dtgvOfficial.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a registration to edit!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
            var selectedRow = dtgvOfficial.SelectedRows[0];
            string masv = selectedRow.Cells[0].Value?.ToString();
            string mamm = selectedRow.Cells[1].Value?.ToString();
            
            // Kiểm tra thời gian đăng ký
            if (!IsRegistrationPeriodOpen(mamm))
            {
                MessageBox.Show("Registration period is closed for this course!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            // Hiển thị form sửa đăng ký
            using var editForm = new Form();
            editForm.Text = "Edit Registration";
            editForm.Size = new Size(400, 250);
            editForm.StartPosition = FormStartPosition.CenterParent;
            
            var lblMaSV = new Label { Text = "Student ID:", Location = new Point(20, 20) };
            var txtMaSV = new TextBox { Location = new Point(150, 20), Width = 200, Text = masv, ReadOnly = true };
            
            var lblMaMM = new Label { Text = "Course ID:", Location = new Point(20, 60) };
            var txtMaMM = new TextBox { Location = new Point(150, 60), Width = 200, Text = mamm, ReadOnly = true };
            
            var lblNewMaMM = new Label { Text = "New Course ID:", Location = new Point(20, 100) };
            var txtNewMaMM = new TextBox { Location = new Point(150, 100), Width = 200 };
            
            var btnSave = new Button { Text = "Save", Location = new Point(150, 150), DialogResult = DialogResult.OK };
            var btnCancel = new Button { Text = "Cancel", Location = new Point(250, 150), DialogResult = DialogResult.Cancel };
            
            editForm.Controls.AddRange(new Control[] { lblMaSV, txtMaSV, lblMaMM, txtMaMM, lblNewMaMM, txtNewMaMM, btnSave, btnCancel });
            editForm.AcceptButton = btnSave;
            editForm.CancelButton = btnCancel;
            
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                string newMamm = txtNewMaMM.Text.Trim().ToUpper();
                
                if (string.IsNullOrEmpty(newMamm))
                {
                    MessageBox.Show("Please enter new course ID!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
                // Kiểm tra thời gian đăng ký cho môn học mới
                if (!IsRegistrationPeriodOpen(newMamm))
                {
                    MessageBox.Show("Registration period is closed for the new course!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
                try
                {
                    using var conn = new OracleConnection(_connection.GetConnectionString());
                    conn.Open();
                    string query = "UPDATE C##ADMIN.DANGKY SET MAMM = :newMamm WHERE MASV = :masv AND MAMM = :mamm";
                    using var cmd = new OracleCommand(query, conn);
                    cmd.Parameters.Add(new OracleParameter("newMamm", OracleDbType.Varchar2)).Value = newMamm;
                    cmd.Parameters.Add(new OracleParameter("masv", OracleDbType.Varchar2)).Value = masv;
                    cmd.Parameters.Add(new OracleParameter("mamm", OracleDbType.Varchar2)).Value = mamm;
                    
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Registration updated successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadAllRegistrations();
                    }
                    else
                    {
                        MessageBox.Show("Could not update registration!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có dòng nào được chọn không
            if (dtgvOfficial.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a registration to delete!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
            var selectedRow = dtgvOfficial.SelectedRows[0];
            string masv = selectedRow.Cells[0].Value?.ToString();
            string mamm = selectedRow.Cells[1].Value?.ToString();
            
            // Kiểm tra thời gian đăng ký
            if (!IsRegistrationPeriodOpen(mamm))
            {
                MessageBox.Show("Registration period is closed for this course!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            // Xác nhận xóa
            if (MessageBox.Show($"Are you sure you want to delete this registration?\nStudent ID: {masv}\nCourse ID: {mamm}", 
                               "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    using var conn = new OracleConnection(_connection.GetConnectionString());
                    conn.Open();
                    string query = "DELETE FROM C##ADMIN.DANGKY WHERE MASV = :masv AND MAMM = :mamm";
                    using var cmd = new OracleCommand(query, conn);
                    cmd.Parameters.Add(new OracleParameter("masv", OracleDbType.Varchar2)).Value = masv;
                    cmd.Parameters.Add(new OracleParameter("mamm", OracleDbType.Varchar2)).Value = mamm;
                    
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Registration deleted successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadAllRegistrations();
                    }
                    else
                    {
                        MessageBox.Show("Could not delete registration!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

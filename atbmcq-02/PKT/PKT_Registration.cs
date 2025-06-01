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
    public partial class PKT_Registration : UserControl
    {
        public event EventHandler<OracleDbConnection> backClicked;
        public PKT_Registration(OracleDbConnection _connect)
        {
            InitializeComponent();
            _connection = _connect;
            
            // Hiển thị danh sách đăng ký học phần cho NV PKT
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

                dtgvDangKy.Rows.Clear();

                while (reader.Read())
                {
                    // Lấy dữ liệu từ mỗi cột của bảng DANGKY
                    string masv = reader["MASV"].ToString();
                    string mamm = reader["MAMM"].ToString();
                    
                    // Các cột điểm có thể null
                    decimal? diemth = reader["DIEMTH"] == DBNull.Value ? null : (decimal?)reader.GetDecimal(reader.GetOrdinal("DIEMTH"));
                    decimal? diemqt = reader["DIEMQT"] == DBNull.Value ? null : (decimal?)reader.GetDecimal(reader.GetOrdinal("DIEMQT"));
                    decimal? diemck = reader["DIEMCK"] == DBNull.Value ? null : (decimal?)reader.GetDecimal(reader.GetOrdinal("DIEMCK"));
                    decimal? diemtk = reader["DIEMTK"] == DBNull.Value ? null : (decimal?)reader.GetDecimal(reader.GetOrdinal("DIEMTK"));
                    
                    // Thêm dữ liệu vào DataGridView
                    dtgvDangKy.Rows.Add(
                        masv,
                        mamm,
                        diemth.HasValue ? diemth.ToString() : "",
                        diemqt.HasValue ? diemqt.ToString() : "",
                        diemck.HasValue ? diemck.ToString() : "",
                        diemtk.HasValue ? diemtk.ToString() : ""
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSaveScore_Click(object sender, EventArgs e)
        {
            try
            {
                using var conn = new OracleConnection(_connection.GetConnectionString());
                conn.Open();
                
                // Cập nhật từng dòng trong DataGridView
                foreach (DataGridViewRow row in dtgvDangKy.Rows)
                {
                    // Bỏ qua dòng cuối cùng (dòng trống)
                    if (row.IsNewRow) continue;

                    // Lấy dữ liệu từ các ô trong DataGridView
                    string masv = row.Cells["colStudentID"].Value?.ToString();
                    string mamm = row.Cells["colCourseID"].Value?.ToString();
                    
                    if (string.IsNullOrEmpty(masv) || string.IsNullOrEmpty(mamm))
                        continue;

                    // Lấy giá trị điểm
                    string diemthStr = row.Cells["colPracticeScore"].Value?.ToString();
                    string diemqtStr = row.Cells["colProcessScore"].Value?.ToString();
                    string diemckStr = row.Cells["colFinalScore"].Value?.ToString();
                    string diemtkStr = row.Cells["colTotalScore"].Value?.ToString();
                    
                    // Tạo câu lệnh SQL để cập nhật điểm
                    string query = "UPDATE C##ADMIN.DANGKY SET ";
                    bool hasUpdate = false;
                    var parameters = new List<OracleParameter>();
                    
                    // Chỉ cập nhật các cột có giá trị
                    if (!string.IsNullOrEmpty(diemthStr))
                    {
                        query += "DIEMTH = :diemth";
                        parameters.Add(new OracleParameter("diemth", OracleDbType.Decimal) { Value = decimal.Parse(diemthStr) });
                        hasUpdate = true;
                    }
                    
                    if (!string.IsNullOrEmpty(diemqtStr))
                    {
                        if (hasUpdate) query += ", ";
                        query += "DIEMQT = :diemqt";
                        parameters.Add(new OracleParameter("diemqt", OracleDbType.Decimal) { Value = decimal.Parse(diemqtStr) });
                        hasUpdate = true;
                    }
                    
                    if (!string.IsNullOrEmpty(diemckStr))
                    {
                        if (hasUpdate) query += ", ";
                        query += "DIEMCK = :diemck";
                        parameters.Add(new OracleParameter("diemck", OracleDbType.Decimal) { Value = decimal.Parse(diemckStr) });
                        hasUpdate = true;
                    }
                    
                    if (!string.IsNullOrEmpty(diemtkStr))
                    {
                        if (hasUpdate) query += ", ";
                        query += "DIEMTK = :diemtk";
                        parameters.Add(new OracleParameter("diemtk", OracleDbType.Decimal) { Value = decimal.Parse(diemtkStr) });
                        hasUpdate = true;
                    }
                    
                    // Nếu không có cập nhật nào, bỏ qua dòng này
                    if (!hasUpdate) continue;
                    
                    // Hoàn thiện câu truy vấn với điều kiện WHERE
                    query += " WHERE MASV = :masv AND MAMM = :mamm";
                    parameters.Add(new OracleParameter("masv", OracleDbType.Varchar2) { Value = masv });
                    parameters.Add(new OracleParameter("mamm", OracleDbType.Varchar2) { Value = mamm });
                    
                    // Thực hiện cập nhật
                    using var cmd = new OracleCommand(query, conn);
                    cmd.Parameters.AddRange(parameters.ToArray());
                    cmd.ExecuteNonQuery();
                }
                
                MessageBox.Show("Cập nhật điểm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadAllRegistrations(); // Tải lại dữ liệu sau khi cập nhật
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi cập nhật điểm: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblSignOut_LinkClicked(Object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Restart();
        }
    }
}

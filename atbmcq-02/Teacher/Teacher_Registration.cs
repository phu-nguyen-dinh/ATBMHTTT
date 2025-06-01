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
    public partial class Teacher_Registration : UserControl
    {
        public event EventHandler<OracleDbConnection> backClicked;
        public Teacher_Registration(OracleDbConnection _connect)
        {
            InitializeComponent();
            _connection = _connect;
            
            // Load danh sách đăng ký học phần mà giảng viên phụ trách
            LoadTeacherCourses();
        }

        private void lblBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            backClicked?.Invoke(this, _connection);
        }

        private void LoadTeacherCourses()
        {
            try
            {
                string username = _connection.Username.ToUpper();
                using var conn = new OracleConnection(_connection.GetConnectionString());
                conn.Open();
                
                // Truy vấn lấy danh sách đăng ký học phần mà giảng viên phụ trách
                string query = @"
                    SELECT DK.MASV, DK.MAMM, DK.DIEMTH, DK.DIEMQT, DK.DIEMCK, DK.DIEMTK 
                    FROM C##ADMIN.DANGKY DK
                    JOIN C##ADMIN.MOMON MM ON DK.MAMM = MM.MAMM
                    WHERE MM.MAGV = :username
                    ORDER BY DK.MASV, DK.MAMM";
                
                using var cmd = new OracleCommand(query, conn);
                cmd.Parameters.Add(new OracleParameter("username", OracleDbType.Varchar2)).Value = username;
                using var reader = cmd.ExecuteReader();

                dtgvCourses.Rows.Clear();

                while (reader.Read())
                {
                    // Lấy dữ liệu từ mỗi cột
                    string masv = reader["MASV"].ToString();
                    string mamm = reader["MAMM"].ToString();
                    
                    // Các cột điểm có thể null
                    decimal? diemth = reader["DIEMTH"] == DBNull.Value ? null : (decimal?)reader.GetDecimal(reader.GetOrdinal("DIEMTH"));
                    decimal? diemqt = reader["DIEMQT"] == DBNull.Value ? null : (decimal?)reader.GetDecimal(reader.GetOrdinal("DIEMQT"));
                    decimal? diemck = reader["DIEMCK"] == DBNull.Value ? null : (decimal?)reader.GetDecimal(reader.GetOrdinal("DIEMCK"));
                    decimal? diemtk = reader["DIEMTK"] == DBNull.Value ? null : (decimal?)reader.GetDecimal(reader.GetOrdinal("DIEMTK"));
                    
                    // Thêm dữ liệu vào DataGridView
                    dtgvCourses.Rows.Add(
                        masv,
                        mamm,
                        diemth.HasValue ? diemth.ToString() : "",
                        diemqt.HasValue ? diemqt.ToString() : "",
                        diemck.HasValue ? diemck.ToString() : "",
                        diemtk.HasValue ? diemtk.ToString() : ""
                    );
                }
                
                // Hiển thị thông báo nếu không có lớp nào
                if (dtgvCourses.Rows.Count == 0)
                {
                    MessageBox.Show("You don't have any assigned courses.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void lblSignOut_LinkClicked(Object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Restart();
        }
    }
}

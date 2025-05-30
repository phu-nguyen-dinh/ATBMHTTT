using Oracle.ManagedDataAccess.Client;
using OracleUserManager.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace atbmcq_02
{
    public partial class NVCB_Infor : UserControl
    {
        public event EventHandler<OracleDbConnection> backClicked;

        public NVCB_Infor(OracleDbConnection _connect)
        {
            InitializeComponent();
            _connection = _connect;
            LoadOfficial();
        }

        private void lblBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            backClicked?.Invoke(this, _connection);
        }

        
        private void LoadOfficial()
        {
            try
            {
                using var conn = new OracleConnection(_connection.GetConnectionString());
                conn.Open();

                string query = "SELECT * FROM C##ADMIN.VW_NHANVIEN_SELF";
                using var cmd = new OracleCommand(query, conn);
                using var reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    // Lấy các giá trị từ dòng kết quả và hiển thị vào các TextBox
                    txtID.Text = reader["MANLD"].ToString();
                    txtName.Text = reader["HOTEN"].ToString();
                    txtGender.Text = reader["PHAI"].ToString();
                    txtBirthday.Text = reader["NGSINH"].ToString();
                    
                    // Định dạng lương với dấu cách phân cách hàng nghìn
                    if (decimal.TryParse(reader["LUONG"].ToString(), out decimal luong))
                    {
                        // Sử dụng NumberFormatInfo để thay đổi dấu phân cách
                        NumberFormatInfo nfi = new NumberFormatInfo
                        {
                            NumberGroupSeparator = " ",
                            NumberDecimalSeparator = ",",
                            NumberGroupSizes = new int[] { 3 }
                        };
                        txtSalary.Text = luong.ToString("N0", nfi);
                    }
                    else
                    {
                        txtSalary.Text = reader["LUONG"].ToString();
                    }
                    
                    // Định dạng phụ cấp với dấu cách phân cách hàng nghìn
                    if (decimal.TryParse(reader["PHUCAP"].ToString(), out decimal phucap))
                    {
                        // Sử dụng NumberFormatInfo để thay đổi dấu phân cách
                        NumberFormatInfo nfi = new NumberFormatInfo
                        {
                            NumberGroupSeparator = " ",
                            NumberDecimalSeparator = ",",
                            NumberGroupSizes = new int[] { 3 }
                        };
                        txtBonus.Text = phucap.ToString("N0", nfi);
                    }
                    else
                    {
                        txtBonus.Text = reader["PHUCAP"].ToString();
                    }
                    
                    txtPhone.Text = reader["DT"].ToString();
                    txtRole.Text = reader["VAITRO"].ToString();
                    
                    // Lấy tên đơn vị từ mã đơn vị
                    string madv = reader["MADV"].ToString();
                    txtUnit.Text = GetDepartmentName(madv);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetDepartmentName(string madv)
        {
            try
            {
                using var conn = new OracleConnection(_connection.GetConnectionString());
                conn.Open();

                string query = "SELECT TENDV FROM C##ADMIN.DONVI WHERE MADV = :madv";
                using var cmd = new OracleCommand(query, conn);
                cmd.Parameters.Add(new OracleParameter("madv", madv));
                
                object result = cmd.ExecuteScalar();
                return result != null ? result.ToString() : madv;
            }
            catch
            {
                return madv; // Nếu không lấy được tên, trả về mã
            }
        }
        
        private void lblSignOut_LinkClicked(Object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Restart();
        }
        private void opnd_backClicked(object sender, OracleDbConnection _connect)
        {
            this.Controls.Clear();
            InitializeComponent();
            _connection = _connect;

            
            LoadOfficial();
        }
        private void ButtonTHEM_Click(object sender, EventArgs e)
        {
            try
            {
                var opnd = new AddStudent(_connection);

                opnd.backClicked += opnd_backClicked;

                this.Controls.Clear();
                this.Controls.Add(opnd);
                this.ClientSize = opnd.Size;
            }
            catch
            {
                throw new NotImplementedException();
            }
        }

        private void buttonSUA_Click(object sender, EventArgs e)
        {
            try
            {
                var opnd = new UpdateStudent(_connection);

                opnd.backClicked += opnd_backClicked;

                this.Controls.Clear();
                this.Controls.Add(opnd);
                this.ClientSize = opnd.Size;
            }
            catch { 
                throw new NotImplementedException();
            }
        }

        private void buttonXOA_Click(object sender, EventArgs e)
        {
            try
            {
                var opnd = new DeleteStudent(_connection);

                opnd.backClicked += opnd_backClicked;

                this.Controls.Clear();
                this.Controls.Add(opnd);
                this.ClientSize = opnd.Size;
            }
            catch
            {
                throw new NotImplementedException();
            }
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
                    LoadOfficial(); // Tải lại thông tin sau khi cập nhật
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

        private String getRole()
        {
            using var conn = new OracleConnection(_connection.GetConnectionString());
            conn.Open();
            string role = "";
            string query = "SELECT VAITRO FROM C##ADMIN.VW_NHANVIEN_SELF";
            using var cmd = new OracleCommand(query, conn);
            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                role = reader.GetString(0);
            }

            return role;
        }

    }
}

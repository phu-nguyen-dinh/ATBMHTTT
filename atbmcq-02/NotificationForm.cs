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

namespace atbmcq_02
{
    public partial class NotificationForm : Form
    {
        private OracleDbConnection _connection;
        private DataTable notificationsTable;

        public NotificationForm(OracleDbConnection connection)
        {
            InitializeComponent();
            _connection = connection;
            LoadNotifications();
        }

        private void LoadNotifications()
        {
            try
            {
                using var conn = new OracleConnection(_connection.GetConnectionString());
                conn.Open();

                string query = "SELECT * FROM C##ADMIN.THONGBAO";
                using var cmd = new OracleCommand(query, conn);
                using var adapter = new OracleDataAdapter(cmd);
                notificationsTable = new DataTable();
                adapter.Fill(notificationsTable);

                // Hiển thị dữ liệu trong ListBox
                lstNotifications.DataSource = notificationsTable;
                lstNotifications.DisplayMember = "NOIDUNG";
                lstNotifications.ValueMember = "ID";

                // Kiểm tra xem có thông báo hay không
                if (notificationsTable.Rows.Count == 0)
                {
                    MessageBox.Show("Không có thông báo nào cho bạn!", "Thông báo", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải thông báo: {ex.Message}", "Lỗi", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void lstNotifications_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstNotifications.SelectedIndex >= 0)
            {
                try
                {
                    // Sửa lỗi chuyển đổi kiểu
                    if (lstNotifications.SelectedItem is DataRowView rowView)
                    {
                        // Lấy dữ liệu từ DataRowView
                        DataRow row = rowView.Row;
                        string content = row["NOIDUNG"].ToString();
                        
                        // Hiển thị nội dung thông báo
                        txtNotificationDetail.Text = content;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi hiển thị chi tiết thông báo: {ex.Message}", "Lỗi", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
using Oracle.ManagedDataAccess.Client;
using OracleUserManager.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atbmcq_02
{
    public partial class NotificationForm : Form
    {
        private OracleDbConnection _connection;
        private DataTable notificationsTable;
        // Dictionary để lưu trạng thái đã đọc, key là ID thông báo
        private Dictionary<int, bool> readStatusDict = new Dictionary<int, bool>();
        private string statusFilePath;
        
        // Màu sắc cho các thông báo
        private readonly Color unreadColor = Color.FromArgb(0, 80, 200);   // Xanh đậm cho chưa đọc
        private readonly Color readColor = Color.Gray;                      // Xám cho đã đọc
        private readonly Font unreadFont;                                   // Font in đậm cho chưa đọc
        private readonly Font readFont;                                     // Font thường cho đã đọc

        public NotificationForm(OracleDbConnection connection)
        {
            InitializeComponent();
            _connection = connection;
            
            // Khởi tạo font
            unreadFont = new Font(lstNotifications.Font, FontStyle.Bold);
            readFont = new Font(lstNotifications.Font, FontStyle.Regular);
            
            // Tạo tên file dựa vào tên người dùng để mỗi người dùng có tập tin riêng
            string userName = connection.Username;
            string appDataPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "ATBMHTTT");
            
            // Tạo thư mục nếu chưa tồn tại
            if (!Directory.Exists(appDataPath))
            {
                Directory.CreateDirectory(appDataPath);
            }
            
            statusFilePath = Path.Combine(appDataPath, $"{userName}_notification_status.json");
            
            // Tải trạng thái đã đọc từ tập tin
            LoadReadStatus();
            
            // Tải danh sách thông báo
            LoadNotifications();
            
            // Cập nhật trạng thái nút "Đánh dấu là chưa đọc"
            UpdateMarkAsUnreadButtonState();
        }

        private void LoadReadStatus()
        {
            try
            {
                if (File.Exists(statusFilePath))
                {
                    string jsonContent = File.ReadAllText(statusFilePath);
                    readStatusDict = JsonSerializer.Deserialize<Dictionary<int, bool>>(jsonContent) 
                                     ?? new Dictionary<int, bool>();
                }
            }
            catch (Exception ex)
            {
                // Nếu có lỗi khi đọc tập tin, bắt đầu với một dictionary trống
                Console.WriteLine($"Lỗi khi đọc trạng thái: {ex.Message}");
                readStatusDict = new Dictionary<int, bool>();
            }
        }

        private void SaveReadStatus()
        {
            try
            {
                string jsonContent = JsonSerializer.Serialize(readStatusDict);
                File.WriteAllText(statusFilePath, jsonContent);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi lưu trạng thái: {ex.Message}");
            }
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

                // Xóa và khởi tạo lại ListBox
                lstNotifications.DataSource = null;
                lstNotifications.Items.Clear();
                
                // Thêm các mục thông báo vào ListBox với định dạng riêng
                foreach (DataRow row in notificationsTable.Rows)
                {
                    int id = Convert.ToInt32(row["ID"]);
                    string content = row["NOIDUNG"].ToString();
                    
                    // Mặc định các thông báo là chưa đọc nếu không có trong dictionary
                    if (!readStatusDict.ContainsKey(id))
                    {
                        readStatusDict[id] = false;
                    }
                    
                    lstNotifications.Items.Add(new NotificationItem
                    {
                        Id = id,
                        Content = content,
                        IsRead = readStatusDict[id]
                    });
                }

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
        
        private void lstNotifications_DrawItem(object sender, DrawItemEventArgs e)
        {
            // Kiểm tra nếu không có mục nào được vẽ
            if (e.Index < 0 || e.Index >= lstNotifications.Items.Count)
                return;
            
            // Lấy mục thông báo hiện tại
            var item = lstNotifications.Items[e.Index] as NotificationItem;
            if (item == null)
                return;
            
            // Xác định font và màu sắc dựa trên trạng thái đã đọc
            Font font = item.IsRead ? readFont : unreadFont;
            Color textColor = item.IsRead ? readColor : unreadColor;
            
            // Xác định nền dựa trên việc mục có được chọn hay không
            Color backColor = (e.State & DrawItemState.Selected) == DrawItemState.Selected
                ? SystemColors.Highlight
                : SystemColors.Window;
            
            // Xác định màu chữ khi mục được chọn
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                textColor = SystemColors.HighlightText;
            }
            
            // Vẽ nền
            e.DrawBackground();
            
            // Vẽ nội dung
            using (var brush = new SolidBrush(textColor))
            {
                e.Graphics.DrawString(item.Content, font, brush, e.Bounds);
            }
            
            // Vẽ focus rectangle nếu có focus
            if ((e.State & DrawItemState.Focus) == DrawItemState.Focus)
            {
                e.DrawFocusRectangle();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // Lưu trạng thái trước khi đóng form
            SaveReadStatus();
            this.Close();
        }

        private void lstNotifications_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstNotifications.SelectedIndex >= 0)
            {
                try
                {
                    var selectedItem = lstNotifications.SelectedItem as NotificationItem;
                    if (selectedItem != null)
                    {
                        // Hiển thị nội dung thông báo
                        txtNotificationDetail.Text = selectedItem.Content;
                        
                        // Đánh dấu là đã đọc nếu chưa
                        if (!selectedItem.IsRead)
                        {
                            readStatusDict[selectedItem.Id] = true;
                            selectedItem.IsRead = true;
                            
                            // Cập nhật hiển thị
                            lstNotifications.Invalidate(); // Cập nhật toàn bộ ListBox
                            
                            // Lưu trạng thái mỗi khi có thay đổi
                            SaveReadStatus();
                        }
                        
                        // Cập nhật trạng thái nút "Đánh dấu là chưa đọc"
                        UpdateMarkAsUnreadButtonState();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi hiển thị chi tiết thông báo: {ex.Message}", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnMarkAllAsRead_Click(object sender, EventArgs e)
        {
            try
            {
                // Đánh dấu tất cả là đã đọc trong Dictionary
                for (int i = 0; i < lstNotifications.Items.Count; i++)
                {
                    if (lstNotifications.Items[i] is NotificationItem item)
                    {
                        readStatusDict[item.Id] = true;
                        item.IsRead = true;
                    }
                }
                
                // Cập nhật hiển thị
                lstNotifications.Invalidate();
                
                // Lưu trạng thái sau khi đánh dấu tất cả
                SaveReadStatus();
                
                // Cập nhật trạng thái nút "Đánh dấu là chưa đọc"
                UpdateMarkAsUnreadButtonState();
                
                MessageBox.Show("Tất cả thông báo đã được đánh dấu là đã đọc.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi đánh dấu tất cả thông báo: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void btnMarkAsUnread_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstNotifications.SelectedIndex >= 0)
                {
                    var selectedItem = lstNotifications.SelectedItem as NotificationItem;
                    if (selectedItem != null && selectedItem.IsRead)
                    {
                        // Đánh dấu là chưa đọc
                        readStatusDict[selectedItem.Id] = false;
                        selectedItem.IsRead = false;
                        
                        // Cập nhật hiển thị
                        lstNotifications.Invalidate();
                        
                        // Lưu trạng thái
                        SaveReadStatus();
                        
                        // Cập nhật trạng thái nút
                        UpdateMarkAsUnreadButtonState();
                        
                        MessageBox.Show("Thông báo đã được đánh dấu là chưa đọc.", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một thông báo để đánh dấu là chưa đọc.", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi đánh dấu thông báo là chưa đọc: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void UpdateMarkAsUnreadButtonState()
        {
            // Kiểm tra xem có thông báo được chọn không và nó đã được đọc chưa
            bool canMarkAsUnread = false;
            
            if (lstNotifications.SelectedIndex >= 0)
            {
                var selectedItem = lstNotifications.SelectedItem as NotificationItem;
                canMarkAsUnread = selectedItem != null && selectedItem.IsRead;
            }
            
            // Cập nhật trạng thái nút
            btnMarkAsUnread.Enabled = canMarkAsUnread;
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
    }

    // Lớp để lưu trữ thông tin thông báo
    public class NotificationItem
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public bool IsRead { get; set; }

        public override string ToString()
        {
            return Content;
        }
    }
}
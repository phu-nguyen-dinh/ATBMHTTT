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
    public partial class Official : UserControl
    {
        public event EventHandler<OracleDbConnection> backClicked;
        private string currentRole = "";

        public Official(OracleDbConnection _connect)
        {
            InitializeComponent();
            _connection = _connect;
            currentRole = GetRole();
            ConfigureUIByRole();
            LoadOfficial();
            LoadStudents();
            LoadStaff();
            LoadMomon();
            LoadDangKy();
        }

        private void lblBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            backClicked?.Invoke(this, _connection);
        }

        private void LoadStudents()
        {
            try
            {
                using var conn = new OracleConnection(_connection.GetConnectionString());
                conn.Open();

                string query;
                
                switch(currentRole)
                {
                    case "GV":
                        // Giảng viên chỉ xem sinh viên thuộc đơn vị (khoa) mình trực thuộc
                        query = "SELECT SV.* FROM C##ADMIN.SINHVIEN SV, C##ADMIN.NHANVIEN NV " +
                                "WHERE NV.MANLD = :manv AND SV.KHOA = NV.MADV";
                        break;
                    case "NV CTSV":
                    case "NV PĐT":
                        // Nhân viên phòng CTSV và Phòng ĐT xem tất cả sinh viên
                        query = "SELECT * FROM C##ADMIN.SINHVIEN";
                        break;
                    case "TRGĐV":
                    case "NV TCHC":
                        // Trưởng đơn vị và NV TCHC không xem sinh viên mà xem nhân viên
                        LoadStaff(); // Gọi phương thức load nhân viên
                        return; // Không tải sinh viên
                    default:
                        // Các trường hợp khác không có quyền xem sinh viên
                        dtgvStudent.Rows.Clear();
                        return;
                }

                using var cmd = new OracleCommand(query, conn);
                if (currentRole == "GV" || currentRole == "TRGĐV")
                {
                    cmd.Parameters.Add(new OracleParameter("manv", _connection.Username.ToUpper()));
                }
                
                using var reader = cmd.ExecuteReader();
                dtgvStudent.Rows.Clear();

                while (reader.Read())
                {
                    object[] row = new object[reader.FieldCount];
                    reader.GetValues(row);
                    dtgvStudent.Rows.Add(row);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadMomon()
        {
            try
            {
                using var conn = new OracleConnection(_connection.GetConnectionString());
                conn.Open();

                string query;
                
                switch(currentRole)
                {
                    case "GV":
                        // Giảng viên chỉ xem phân công của mình
                        query = "SELECT MM.MAMM, MM.MAHP, HP.TENHP, MM.MAGV, MM.HK, MM.NAM " +
                                "FROM C##ADMIN.MOMON MM, C##ADMIN.HOCPHAN HP " +
                                "WHERE MM.MAHP = HP.MAHP AND MM.MAGV = :magv";
                        break;
                    case "NV PĐT":
                        // Nhân viên phòng đào tạo xem tất cả phân công
                        query = "SELECT MM.MAMM, MM.MAHP, HP.TENHP, MM.MAGV, MM.HK, MM.NAM " +
                                "FROM C##ADMIN.MOMON MM, C##ADMIN.HOCPHAN HP " +
                                "WHERE MM.MAHP = HP.MAHP";
                        break;
                    case "TRGĐV":
                        // Trưởng đơn vị xem phân công của giảng viên thuộc đơn vị mình
                        query = "SELECT MM.MAMM, MM.MAHP, HP.TENHP, MM.MAGV, MM.HK, MM.NAM " +
                                "FROM C##ADMIN.MOMON MM, C##ADMIN.HOCPHAN HP, C##ADMIN.NHANVIEN NV1, C##ADMIN.NHANVIEN NV2 " +
                                "WHERE MM.MAHP = HP.MAHP AND MM.MAGV = NV1.MANLD AND NV2.MANLD = :manv AND NV1.MADV = NV2.MADV";
                        break;
                    default:
                        // Các trường hợp khác không có quyền xem phân công
                        dtgvMomon.Rows.Clear();
                        return;
                }

                using var cmd = new OracleCommand(query, conn);
                if (currentRole == "GV")
                {
                    cmd.Parameters.Add(new OracleParameter("magv", _connection.Username.ToUpper()));
                }
                else if (currentRole == "TRGĐV")
                {
                    cmd.Parameters.Add(new OracleParameter("manv", _connection.Username.ToUpper()));
                }
                
                using var reader = cmd.ExecuteReader();
                dtgvMomon.Rows.Clear();

                while (reader.Read())
                {
                    string mamm = reader["MAMM"].ToString();
                    string mahp = reader["MAHP"].ToString();
                    string tenhp = reader["TENHP"].ToString();
                    string magv = reader["MAGV"].ToString();
                    string hocky = reader["HK"].ToString();
                    string namhoc = reader["NAM"].ToString();
                    
                    dtgvMomon.Rows.Add(mamm, mahp, tenhp, magv, hocky, namhoc);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDangKy()
        {
            try
            {
                using var conn = new OracleConnection(_connection.GetConnectionString());
                conn.Open();

                string query;
                
                switch(currentRole)
                {
                    case "GV":
                        // Giảng viên chỉ xem đăng ký của các lớp mình dạy
                        query = "SELECT DK.MASV, DK.MAMM, MM.HK, MM.NAM, DK.DIEMQT, DK.DIEMTK, DK.DIEMCK " +
                                "FROM C##ADMIN.DANGKY DK, C##ADMIN.MOMON MM " +
                                "WHERE DK.MAMM = MM.MAMM AND MM.MAGV = :magv";
                        break;
                    case "NV PĐT":
                    case "NV PKT":
                        // Nhân viên PĐT và PKT xem tất cả đăng ký
                        query = "SELECT DK.MASV, DK.MAMM, MM.HK, MM.NAM, DK.DIEMQT, DK.DIEMCK, DK.DIEMTK " +
                                "FROM C##ADMIN.DANGKY DK, C##ADMIN.MOMON MM " +
                                "WHERE DK.MAMM = MM.MAMM";
                        break;
                    default:
                        // Các trường hợp khác không có quyền xem đăng ký
                        dtgvDangKy.Rows.Clear();
                        return;
                }

                using var cmd = new OracleCommand(query, conn);
                if (currentRole == "GV")
                {
                    cmd.Parameters.Add(new OracleParameter("magv", _connection.Username.ToUpper()));
                }
                
                using var reader = cmd.ExecuteReader();
                dtgvDangKy.Rows.Clear();

                while (reader.Read())
                {
                    string masv = reader["MASV"].ToString();
                    string mamm = reader["MAMM"].ToString();
                    string hocky = reader["HK"].ToString();
                    string namhoc = reader["NAM"].ToString();
                    string diemqt = reader["DIEMQT"]?.ToString() ?? "";
                    string diemthi = reader["DIEMCK"]?.ToString() ?? "";
                    string diemkhoa = reader["DIEMTK"]?.ToString() ?? "";
                    
                    dtgvDangKy.Rows.Add(masv, mamm, hocky, namhoc, diemqt, diemthi, diemkhoa);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

                dtgvOfficial.Rows.Clear();

                while (reader.Read())
                {
                    object[] row = new object[reader.FieldCount];
                    reader.GetValues(row);
                    dtgvOfficial.Rows.Add(row);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            
            currentRole = GetRole();
            ConfigureUIByRole();
            LoadOfficial();
            LoadStudents();
            LoadMomon();
            LoadDangKy();
        }
        
        private void ButtonTHEM_Click(object sender, EventArgs e)
        {
            try
            {
                if (currentRole == "NV TCHC")
                {
                    // Hiển thị form thêm nhân viên mới
                    using var addForm = new Form();
                    addForm.Text = "Thêm nhân viên mới";
                    addForm.StartPosition = FormStartPosition.CenterScreen;
                    addForm.Size = new Size(600, 550);
                    addForm.FormBorderStyle = FormBorderStyle.FixedDialog;
                    addForm.MaximizeBox = false;
                    addForm.MinimizeBox = false;

                    // Tạo các control
                    var lblTitle = new Label { Text = "THÊM NHÂN VIÊN MỚI", Font = new Font("Arial", 16, FontStyle.Bold), AutoSize = true };
                    lblTitle.Location = new Point((addForm.ClientSize.Width - lblTitle.Width) / 2, 20);

                    var lblID = new Label { Text = "Mã nhân viên:", Location = new Point(50, 80), AutoSize = true };
                    var txtID = new TextBox { Location = new Point(200, 80), Size = new Size(300, 25) };

                    var lblName = new Label { Text = "Họ tên:", Location = new Point(50, 120), AutoSize = true };
                    var txtName = new TextBox { Location = new Point(200, 120), Size = new Size(300, 25) };

                    var lblGender = new Label { Text = "Giới tính:", Location = new Point(50, 160), AutoSize = true };
                    var cboGender = new ComboBox { Location = new Point(200, 160), Size = new Size(300, 25) };
                    cboGender.Items.AddRange(new object[] { "Nam", "Nữ" });
                    cboGender.DropDownStyle = ComboBoxStyle.DropDownList;
                    cboGender.SelectedIndex = 0;

                    var lblBirthday = new Label { Text = "Ngày sinh:", Location = new Point(50, 200), AutoSize = true };
                    var dtpBirthday = new DateTimePicker { Location = new Point(200, 200), Size = new Size(300, 25), Format = DateTimePickerFormat.Short };

                    var lblSalary = new Label { Text = "Lương:", Location = new Point(50, 240), AutoSize = true };
                    var txtSalary = new TextBox { Location = new Point(200, 240), Size = new Size(300, 25) };

                    var lblAllowance = new Label { Text = "Phụ cấp:", Location = new Point(50, 280), AutoSize = true };
                    var txtAllowance = new TextBox { Location = new Point(200, 280), Size = new Size(300, 25) };

                    var lblPhone = new Label { Text = "Điện thoại:", Location = new Point(50, 320), AutoSize = true };
                    var txtPhone = new TextBox { Location = new Point(200, 320), Size = new Size(300, 25) };

                    var lblRole = new Label { Text = "Vai trò:", Location = new Point(50, 360), AutoSize = true };
                    var cboRole = new ComboBox { Location = new Point(200, 360), Size = new Size(300, 25) };
                    cboRole.Items.AddRange(new object[] { "NVCB", "GV", "TRGĐV", "NV TCHC", "NV CTSV", "NV PĐT", "NV PKT" });
                    cboRole.DropDownStyle = ComboBoxStyle.DropDownList;
                    cboRole.SelectedIndex = 0;

                    var lblDepartment = new Label { Text = "Đơn vị:", Location = new Point(50, 400), AutoSize = true };
                    var txtDepartment = new TextBox { Location = new Point(200, 400), Size = new Size(300, 25) };

                    var btnSave = new Button { Text = "Lưu", Location = new Point(200, 470), Size = new Size(100, 40), BackColor = Color.LightGreen };
                    var btnCancel = new Button { Text = "Hủy", Location = new Point(350, 470), Size = new Size(100, 40), BackColor = Color.LightPink };

                    // Xử lý sự kiện lưu
                    btnSave.Click += (s, ev) =>
                    {
                        try
                        {
                            // Kiểm tra dữ liệu nhập
                            if (string.IsNullOrWhiteSpace(txtID.Text) || string.IsNullOrWhiteSpace(txtName.Text) ||
                                string.IsNullOrWhiteSpace(txtSalary.Text) || string.IsNullOrWhiteSpace(txtAllowance.Text) ||
                                string.IsNullOrWhiteSpace(txtPhone.Text) || string.IsNullOrWhiteSpace(txtDepartment.Text))
                            {
                                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }

                            // Kiểm tra định dạng số
                            if (!decimal.TryParse(txtSalary.Text, out _) || !decimal.TryParse(txtAllowance.Text, out _))
                            {
                                MessageBox.Show("Lương và phụ cấp phải là số!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }

                            // Thực hiện thêm nhân viên
                            using var conn = new OracleConnection(_connection.GetConnectionString());
                            conn.Open();

                            string query = "INSERT INTO C##ADMIN.NHANVIEN (MANLD, HOTEN, PHAI, NGSINH, LUONG, PHUCAP, DT, VAITRO, MADV) " +
                                          "VALUES (:id, :name, :gender, :birthday, :salary, :allowance, :phone, :role, :department)";
                            using var cmd = new OracleCommand(query, conn);
                            cmd.Parameters.Add(new OracleParameter("id", txtID.Text));
                            cmd.Parameters.Add(new OracleParameter("name", txtName.Text));
                            cmd.Parameters.Add(new OracleParameter("gender", cboGender.SelectedItem.ToString()));
                            cmd.Parameters.Add(new OracleParameter("birthday", dtpBirthday.Value));
                            cmd.Parameters.Add(new OracleParameter("salary", decimal.Parse(txtSalary.Text)));
                            cmd.Parameters.Add(new OracleParameter("allowance", decimal.Parse(txtAllowance.Text)));
                            cmd.Parameters.Add(new OracleParameter("phone", txtPhone.Text));
                            cmd.Parameters.Add(new OracleParameter("role", cboRole.SelectedItem.ToString()));
                            cmd.Parameters.Add(new OracleParameter("department", txtDepartment.Text));

                            int result = cmd.ExecuteNonQuery();
                            if (result > 0)
                            {
                                MessageBox.Show("Thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                // Đóng form sau khi thêm thành công
                                addForm.DialogResult = DialogResult.OK;
                            }
                            else
                            {
                                MessageBox.Show("Không thể thêm nhân viên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    };

                    btnCancel.Click += (s, ev) =>
                    {
                        addForm.DialogResult = DialogResult.Cancel;
                    };

                    // Thêm control vào form
                    addForm.Controls.AddRange(new Control[] {
                        lblTitle, lblID, txtID, lblName, txtName, lblGender, cboGender, lblBirthday, dtpBirthday,
                        lblSalary, txtSalary, lblAllowance, txtAllowance, lblPhone, txtPhone, lblRole, cboRole,
                        lblDepartment, txtDepartment, btnSave, btnCancel
                    });

                    if (addForm.ShowDialog() == DialogResult.OK)
                    {
                        LoadStaff(); // Tải lại danh sách nhân viên
                    }
                    
                    return;
                }
                
                // Form thêm sinh viên cho NV CTSV hoặc NV PĐT
                var opnd = new AddStudent(_connection);

                opnd.backClicked += opnd_backClicked;

                this.Controls.Clear();
                this.Controls.Add(opnd);
                this.ClientSize = opnd.Size;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSUA_Click(object sender, EventArgs e)
        {
            try
            {
                if (currentRole == "NV TCHC")
                {
                    // Kiểm tra có dòng nào được chọn không
                    if (dtgvStudent.CurrentRow == null || dtgvStudent.SelectedRows.Count == 0)
                    {
                        MessageBox.Show("Vui lòng chọn nhân viên cần cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    string selectedID = dtgvStudent.CurrentRow.Cells["ID"].Value?.ToString() ?? "";

                    if (string.IsNullOrEmpty(selectedID))
                    {
                        MessageBox.Show("Không tìm thấy mã nhân viên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Lấy thông tin nhân viên hiện tại
                    using var conn = new OracleConnection(_connection.GetConnectionString());
                    conn.Open();
                    string query = "SELECT * FROM C##ADMIN.NHANVIEN WHERE MANLD = :id";
                    using var cmd = new OracleCommand(query, conn);
                    cmd.Parameters.Add(new OracleParameter("id", selectedID));
                    using var reader = cmd.ExecuteReader();

                    if (!reader.Read())
                    {
                        MessageBox.Show("Không tìm thấy thông tin nhân viên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string name = reader["HOTEN"].ToString();
                    string gender = reader["PHAI"].ToString();
                    DateTime birthday = Convert.ToDateTime(reader["NGSINH"]);
                    decimal salary = Convert.ToDecimal(reader["LUONG"]);
                    decimal allowance = Convert.ToDecimal(reader["PHUCAP"]);
                    string phone = reader["DT"].ToString();
                    string role = reader["VAITRO"].ToString();
                    string department = reader["MADV"].ToString();

                    // Hiển thị form cập nhật nhân viên
                    using var updateForm = new Form();
                    updateForm.Text = "Cập nhật thông tin nhân viên";
                    updateForm.StartPosition = FormStartPosition.CenterScreen;
                    updateForm.Size = new Size(600, 550);
                    updateForm.FormBorderStyle = FormBorderStyle.FixedDialog;
                    updateForm.MaximizeBox = false;
                    updateForm.MinimizeBox = false;

                    // Tạo các control
                    var lblTitle = new Label { Text = "CẬP NHẬT THÔNG TIN NHÂN VIÊN", Font = new Font("Arial", 16, FontStyle.Bold), AutoSize = true };
                    lblTitle.Location = new Point((updateForm.ClientSize.Width - lblTitle.Width) / 2, 20);

                    var lblID = new Label { Text = "Mã nhân viên:", Location = new Point(50, 80), AutoSize = true };
                    var txtID = new TextBox { Location = new Point(200, 80), Size = new Size(300, 25), Text = selectedID, ReadOnly = true };

                    var lblName = new Label { Text = "Họ tên:", Location = new Point(50, 120), AutoSize = true };
                    var txtName = new TextBox { Location = new Point(200, 120), Size = new Size(300, 25), Text = name };

                    var lblGender = new Label { Text = "Giới tính:", Location = new Point(50, 160), AutoSize = true };
                    var cboGender = new ComboBox { Location = new Point(200, 160), Size = new Size(300, 25) };
                    cboGender.Items.AddRange(new object[] { "Nam", "Nữ" });
                    cboGender.DropDownStyle = ComboBoxStyle.DropDownList;
                    cboGender.SelectedItem = gender;

                    var lblBirthday = new Label { Text = "Ngày sinh:", Location = new Point(50, 200), AutoSize = true };
                    var dtpBirthday = new DateTimePicker { Location = new Point(200, 200), Size = new Size(300, 25), Format = DateTimePickerFormat.Short, Value = birthday };

                    var lblSalary = new Label { Text = "Lương:", Location = new Point(50, 240), AutoSize = true };
                    var txtSalary = new TextBox { Location = new Point(200, 240), Size = new Size(300, 25), Text = salary.ToString() };

                    var lblAllowance = new Label { Text = "Phụ cấp:", Location = new Point(50, 280), AutoSize = true };
                    var txtAllowance = new TextBox { Location = new Point(200, 280), Size = new Size(300, 25), Text = allowance.ToString() };

                    var lblPhone = new Label { Text = "Điện thoại:", Location = new Point(50, 320), AutoSize = true };
                    var txtPhone = new TextBox { Location = new Point(200, 320), Size = new Size(300, 25), Text = phone };

                    var lblRole = new Label { Text = "Vai trò:", Location = new Point(50, 360), AutoSize = true };
                    var cboRole = new ComboBox { Location = new Point(200, 360), Size = new Size(300, 25) };
                    cboRole.Items.AddRange(new object[] { "NVCB", "GV", "TRGĐV", "NV TCHC", "NV CTSV", "NV PĐT", "NV PKT" });
                    cboRole.DropDownStyle = ComboBoxStyle.DropDownList;
                    cboRole.SelectedItem = role;

                    var lblDepartment = new Label { Text = "Đơn vị:", Location = new Point(50, 400), AutoSize = true };
                    var txtDepartment = new TextBox { Location = new Point(200, 400), Size = new Size(300, 25), Text = department };

                    var btnSave = new Button { Text = "Lưu", Location = new Point(200, 470), Size = new Size(100, 40), BackColor = Color.LightGreen };
                    var btnCancel = new Button { Text = "Hủy", Location = new Point(350, 470), Size = new Size(100, 40), BackColor = Color.LightPink };

                    // Xử lý sự kiện lưu
                    btnSave.Click += (s, ev) =>
                    {
                        try
                        {
                            // Kiểm tra dữ liệu nhập
                            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtSalary.Text) ||
                                string.IsNullOrWhiteSpace(txtAllowance.Text) || string.IsNullOrWhiteSpace(txtPhone.Text) ||
                                string.IsNullOrWhiteSpace(txtDepartment.Text))
                            {
                                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }

                            // Kiểm tra định dạng số
                            if (!decimal.TryParse(txtSalary.Text, out _) || !decimal.TryParse(txtAllowance.Text, out _))
                            {
                                MessageBox.Show("Lương và phụ cấp phải là số!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }

                            // Thực hiện cập nhật nhân viên
                            using var updateConn = new OracleConnection(_connection.GetConnectionString());
                            updateConn.Open();

                            string updateQuery = @"UPDATE C##ADMIN.NHANVIEN 
                                                 SET HOTEN = :name, PHAI = :gender, NGSINH = :birthday, 
                                                     LUONG = :salary, PHUCAP = :allowance, DT = :phone,
                                                     VAITRO = :role, MADV = :department
                                                 WHERE MANLD = :id";

                            using var updateCmd = new OracleCommand(updateQuery, updateConn);
                            updateCmd.Parameters.Add(new OracleParameter("name", txtName.Text));
                            updateCmd.Parameters.Add(new OracleParameter("gender", cboGender.SelectedItem.ToString()));
                            updateCmd.Parameters.Add(new OracleParameter("birthday", dtpBirthday.Value));
                            updateCmd.Parameters.Add(new OracleParameter("salary", decimal.Parse(txtSalary.Text)));
                            updateCmd.Parameters.Add(new OracleParameter("allowance", decimal.Parse(txtAllowance.Text)));
                            updateCmd.Parameters.Add(new OracleParameter("phone", txtPhone.Text));
                            updateCmd.Parameters.Add(new OracleParameter("role", cboRole.SelectedItem.ToString()));
                            updateCmd.Parameters.Add(new OracleParameter("department", txtDepartment.Text));
                            updateCmd.Parameters.Add(new OracleParameter("id", selectedID));

                            int result = updateCmd.ExecuteNonQuery();
                            if (result > 0)
                            {
                                MessageBox.Show("Cập nhật thông tin nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                updateForm.DialogResult = DialogResult.OK;
                            }
                            else
                            {
                                MessageBox.Show("Không thể cập nhật thông tin nhân viên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    };

                    btnCancel.Click += (s, ev) =>
                    {
                        updateForm.DialogResult = DialogResult.Cancel;
                    };

                    // Thêm control vào form
                    updateForm.Controls.AddRange(new Control[] {
                        lblTitle, lblID, txtID, lblName, txtName, lblGender, cboGender, lblBirthday, dtpBirthday,
                        lblSalary, txtSalary, lblAllowance, txtAllowance, lblPhone, txtPhone, lblRole, cboRole,
                        lblDepartment, txtDepartment, btnSave, btnCancel
                    });

                    if (updateForm.ShowDialog() == DialogResult.OK)
                    {
                        LoadStaff(); // Tải lại danh sách nhân viên
                    }
                    
                    return;
                }
                
                // Form cập nhật sinh viên cho NV CTSV hoặc NV PĐT
                var opnd = new UpdateStudent(_connection);

                opnd.backClicked += opnd_backClicked;

                this.Controls.Clear();
                this.Controls.Add(opnd);
                this.ClientSize = opnd.Size;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonXOA_Click(object sender, EventArgs e)
        {
            try
            {
                if (currentRole == "NV TCHC")
                {
                    // Kiểm tra xem có dòng nào được chọn không
                    if (dtgvStudent.CurrentRow == null || dtgvStudent.SelectedRows.Count == 0)
                    {
                        MessageBox.Show("Vui lòng chọn nhân viên cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    string selectedID = dtgvStudent.CurrentRow.Cells["ID"].Value?.ToString() ?? "";
                    string selectedName = dtgvStudent.CurrentRow.Cells["CName"].Value?.ToString() ?? "";

                    if (string.IsNullOrEmpty(selectedID))
                    {
                        MessageBox.Show("Không tìm thấy mã nhân viên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Xác nhận xóa
                    DialogResult confirm = MessageBox.Show(
                        $"Bạn có chắc chắn muốn xóa nhân viên {selectedName} (ID: {selectedID}) không?",
                        "Xác nhận xóa",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (confirm == DialogResult.Yes)
                    {
                        try
                        {
                            using var conn = new OracleConnection(_connection.GetConnectionString());
                            conn.Open();
                            string query = "DELETE FROM C##ADMIN.NHANVIEN WHERE MANLD = :id";
                            using var cmd = new OracleCommand(query, conn);
                            cmd.Parameters.Add(new OracleParameter("id", selectedID));

                            int result = cmd.ExecuteNonQuery();
                            if (result > 0)
                            {
                                MessageBox.Show("Xóa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadStaff(); // Tải lại danh sách nhân viên
                            }
                            else
                            {
                                MessageBox.Show("Không thể xóa nhân viên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    return;
                }
                
                // Form xóa sinh viên cho NV CTSV hoặc NV PĐT
                var opnd = new DeleteStudent(_connection);

                opnd.backClicked += opnd_backClicked;

                this.Controls.Clear();
                this.Controls.Add(opnd);
                this.ClientSize = opnd.Size;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                // Cập nhật qua view thay vì trực tiếp trên bảng NHANVIEN
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

        private string GetRole()
        {
            try
            {
                using var conn = new OracleConnection(_connection.GetConnectionString());
                conn.Open();
                string role = "";
                
                // Truy vấn qua view
                string query = "SELECT VAITRO FROM C##ADMIN.VW_NHANVIEN_SELF";
                
                using var cmd = new OracleCommand(query, conn);
                using var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    role = reader["VAITRO"].ToString();
                }
                return role;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi lấy vai trò: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }
        }
        
        private void ConfigureUIByRole()
        {
            // Mặc định ẩn các nút/tab chức năng
            buttonTHEM.Visible = false;
            buttonSUA.Visible = false;
            buttonXOA.Visible = false;
            
            // Ẩn các nút đăng ký học phần mặc định
            btnAddDangKy.Visible = false;
            btnUpdateDangKy.Visible = false;
            btnDeleteDangKy.Visible = false;
            btnUpdateDiem.Visible = false;
            
            // Ẩn các nút môn học mặc định
            btnAddMomon.Visible = false;
            btnUpdateMomon.Visible = false;
            btnDeleteMomon.Visible = false;
            
            // Mặc định ẩn các tab
            tabControl1.TabPages.Remove(tabPage1); // Thông tin sinh viên
            tabControl1.TabPages.Remove(tabPage3); // Phân công giảng dạy
            tabControl1.TabPages.Remove(tabPage4); // Đăng ký học phần
            
            // Tất cả đều có tab thông tin cá nhân
            
            // Hiển thị các nút/tab theo vai trò
            switch (currentRole)
            {
                case "NV CTSV":
                    tabControl1.TabPages.Add(tabPage1);
                    buttonTHEM.Visible = true;
                    buttonSUA.Visible = true;
                    buttonXOA.Visible = true;
                    // NV CTSV có thể thêm, xóa, sửa thông tin SV
                    tabPage1.Text = "Quản lý thông tin sinh viên";
                    break;
                    
                case "NV TCHC":
                    // NV TCHC quản lý nhân viên
                    tabControl1.TabPages.Add(tabPage1);
                    buttonTHEM.Visible = true;
                    buttonSUA.Visible = true;
                    buttonXOA.Visible = true;
                    tabPage1.Text = "Quản lý thông tin nhân viên";
                    break;
                    
                case "NV PĐT":
                    // Hiển thị các tab
                    tabControl1.TabPages.Add(tabPage1);
                    tabControl1.TabPages.Add(tabPage3);
                    tabControl1.TabPages.Add(tabPage4);
                    
                    // Các nút chức năng
                    buttonTHEM.Visible = true;
                    buttonSUA.Visible = true;
                    buttonXOA.Visible = true;
                    
                    btnAddMomon.Visible = true;
                    btnUpdateMomon.Visible = true;
                    btnDeleteMomon.Visible = true;
                    
                    btnAddDangKy.Visible = true;
                    btnUpdateDangKy.Visible = true;
                    btnDeleteDangKy.Visible = true;
                    
                    tabPage1.Text = "Quản lý thông tin sinh viên";
                    break;
                    
                case "GV":
                    tabControl1.TabPages.Add(tabPage1);
                    tabControl1.TabPages.Add(tabPage3);
                    tabControl1.TabPages.Add(tabPage4);
                    
                    tabPage1.Text = "Thông tin sinh viên thuộc đơn vị";
                    break;
                    
                case "TRGĐV":
                    // Trưởng đơn vị xem được thông tin nhân viên thuộc đơn vị mình và phân công giảng dạy
                    tabControl1.TabPages.Add(tabPage1);
                    tabControl1.TabPages.Add(tabPage3);
                    
                    tabPage1.Text = "Thông tin nhân viên thuộc đơn vị";
                    break;
                    
                case "NV PKT":
                    // Nhân viên phòng kế toán xem đăng ký môn học và cập nhật điểm
                    tabControl1.TabPages.Add(tabPage4);
                    btnUpdateDiem.Visible = true;
                    break;
                    
                default:
                    // NVCB mặc định chỉ xem thông tin cá nhân
                    break;
            }
            
            // Tất cả nhân viên đều có quyền xem và sửa SĐT của mình
            btnEditPhone.Visible = true;
            lblNewPhone.Visible = true;
            txtNewPhone.Visible = true;
        }

        // Xử lý các chức năng phân công giảng dạy
        private void btnAddMomon_Click(object sender, EventArgs e)
        {
            try
            {
                // Chỉ nhân viên PĐT có quyền thêm phân công
                if (currentRole != "NV PĐT")
                {
                    MessageBox.Show("Bạn không có quyền thêm phân công giảng dạy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                
                // TODO: Tạo form thêm phân công giảng dạy
                MessageBox.Show("Chức năng thêm phân công giảng dạy đang được phát triển.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateMomon_Click(object sender, EventArgs e)
        {
            try
            {
                // Chỉ nhân viên PĐT có quyền cập nhật phân công
                if (currentRole != "NV PĐT")
                {
                    MessageBox.Show("Bạn không có quyền cập nhật phân công giảng dạy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                
                // TODO: Tạo form cập nhật phân công giảng dạy
                MessageBox.Show("Chức năng cập nhật phân công giảng dạy đang được phát triển.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteMomon_Click(object sender, EventArgs e)
        {
            try
            {
                // Chỉ nhân viên PĐT có quyền xóa phân công
                if (currentRole != "NV PĐT")
                {
                    MessageBox.Show("Bạn không có quyền xóa phân công giảng dạy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                
                // TODO: Tạo form xóa phân công giảng dạy
                MessageBox.Show("Chức năng xóa phân công giảng dạy đang được phát triển.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Xử lý các chức năng đăng ký học phần
        private void btnAddDangKy_Click(object sender, EventArgs e)
        {
            try
            {
                // Chỉ nhân viên PĐT có quyền thêm đăng ký
                if (currentRole != "NV PĐT")
                {
                    MessageBox.Show("Bạn không có quyền thêm đăng ký học phần!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                
                // TODO: Kiểm tra xem có đang trong 14 ngày đầu học kỳ không
                // Tạm thời giả sử đang trong thời gian đăng ký
                
                // TODO: Tạo form thêm đăng ký học phần
                MessageBox.Show("Chức năng thêm đăng ký học phần đang được phát triển.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateDangKy_Click(object sender, EventArgs e)
        {
            try
            {
                // Chỉ nhân viên PĐT có quyền cập nhật đăng ký
                if (currentRole != "NV PĐT")
                {
                    MessageBox.Show("Bạn không có quyền cập nhật đăng ký học phần!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                
                // TODO: Kiểm tra xem có đang trong 14 ngày đầu học kỳ không
                // Tạm thời giả sử đang trong thời gian đăng ký
                
                // TODO: Tạo form cập nhật đăng ký học phần
                MessageBox.Show("Chức năng cập nhật đăng ký học phần đang được phát triển.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteDangKy_Click(object sender, EventArgs e)
        {
            try
            {
                // Chỉ nhân viên PĐT có quyền xóa đăng ký
                if (currentRole != "NV PĐT")
                {
                    MessageBox.Show("Bạn không có quyền xóa đăng ký học phần!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                
                // TODO: Kiểm tra xem có đang trong 14 ngày đầu học kỳ không
                // Tạm thời giả sử đang trong thời gian đăng ký
                
                // TODO: Tạo form xóa đăng ký học phần
                MessageBox.Show("Chức năng xóa đăng ký học phần đang được phát triển.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateDiem_Click(object sender, EventArgs e)
        {
            try
            {
                // Chỉ giảng viên và nhân viên PKT có quyền cập nhật điểm
                if (currentRole != "GV" && currentRole != "NV PKT")
                {
                    MessageBox.Show("Bạn không có quyền cập nhật điểm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                
                // TODO: Tạo form cập nhật điểm
                MessageBox.Show("Chức năng cập nhật điểm đang được phát triển.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadStaff()
        {
            try
            {
                if (currentRole != "TRGĐV" && currentRole != "NV TCHC")
                    return;
            
                using var conn = new OracleConnection(_connection.GetConnectionString());
                conn.Open();
                
                string query;
                
                if (currentRole == "TRGĐV")
                {
                    // Trưởng đơn vị chỉ xem nhân viên thuộc đơn vị mình qua view
                    query = "SELECT * FROM C##ADMIN.VW_NHANVIEN_NO_SALARY";
                }
                else // NV TCHC
                {
                    // Nhân viên tổ chức hành chính xem tất cả nhân viên qua view hoặc truy cập trực tiếp 
                    // (được cấp quyền qua role R_NT_TCHC)
                    query = "SELECT * FROM C##ADMIN.NHANVIEN";
                }
                
                using var cmd = new OracleCommand(query, conn);
                using var reader = cmd.ExecuteReader();
                dtgvStudent.Rows.Clear();
                
                while (reader.Read())
                {
                    object[] row = new object[reader.FieldCount];
                    reader.GetValues(row);
                    dtgvStudent.Rows.Add(row);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

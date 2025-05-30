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
    public partial class TCHC_Official : UserControl
    {
        public event EventHandler<OracleDbConnection> backClicked;
        private string currentRole = "";

        public TCHC_Official(OracleDbConnection _connect)
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

                string query = "SELECT * FROM C##ADMIN.NHANVIEN";
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
            
            LoadOfficial();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim();
            if (string.IsNullOrEmpty(searchText))
            {
                LoadOfficial();
                return;
            }

            try
            {
                using var conn = new OracleConnection(_connection.GetConnectionString());
                conn.Open();

                string query = "SELECT * FROM C##ADMIN.NHANVIEN WHERE UPPER(MANLD) LIKE UPPER(:search) OR UPPER(HOTEN) LIKE UPPER(:search)";
                using var cmd = new OracleCommand(query, conn);
                cmd.Parameters.Add(new OracleParameter("search", "%" + searchText + "%"));
                using var reader = cmd.ExecuteReader();

                dtgvOfficial.Rows.Clear();

                while (reader.Read())
                {
                    object[] row = new object[reader.FieldCount];
                    reader.GetValues(row);
                    dtgvOfficial.Rows.Add(row);
                }

                if (dtgvOfficial.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy nhân viên nào phù hợp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tìm kiếm: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            try
            {
                    var opnd = new AddStaff(_connection);

                    opnd.backClicked += opnd_backClicked;

                    this.Controls.Clear();
                    this.Controls.Add(opnd);
                    this.ClientSize = opnd.Size;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ERROR: {ex.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateStaff_Click(object sender, EventArgs e)
        {
            try
            {
                var opnd = new UpdateStaff(_connection);

                opnd.backClicked += opnd_backClicked;

                this.Controls.Clear();
                this.Controls.Add(opnd);
                this.ClientSize = opnd.Size;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ERROR: {ex.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteStaff_Click(object sender, EventArgs e)
        {
            try
            {
                var opnd = new DeleteStaff(_connection);

                opnd.backClicked += opnd_backClicked;

                this.Controls.Clear();
                this.Controls.Add(opnd);
                this.ClientSize = opnd.Size;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ERROR: {ex.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

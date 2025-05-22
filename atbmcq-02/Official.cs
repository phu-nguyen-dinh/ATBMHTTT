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

        public Official(OracleDbConnection _connect)
        {
            InitializeComponent();
            _connection = _connect;
            LoadOfficial();
            LoadStudents();
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

                string query = "SELECT * FROM C##ADMIN.SINHVIEN";
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

        private void LoadOfficial()
        {
            try
            {
                string username = _connection.Username.ToUpper();
                using var conn = new OracleConnection(_connection.GetConnectionString());
                conn.Open();

                string query = "SELECT * FROM C##ADMIN.NHANVIEN WHERE MANLD= '"+ username+"'";
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
            LoadStudents();
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
        
    }
}

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
    public partial class Registration : UserControl
    {
        public event EventHandler<OracleDbConnection> backClicked;
        public Registration(OracleDbConnection _connect)
        {
            InitializeComponent();
            _connection = _connect;
            LoadRegisteredCourses();
        }

        private void lblBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            backClicked?.Invoke(this, _connection);
        }

        private void LoadRegisteredCourses()
        {
            try
            {
                string username = _connection.Username.ToUpper();
                using var conn = new OracleConnection(_connection.GetConnectionString());
                conn.Open();
                string query = "SELECT * FROM C##ADMIN.DANGKY";
                
                if (username.StartsWith("SV"))
                {
                    query = "SELECT * FROM C##ADMIN.DANGKY WHERE MASV= '"+username+"'";
                }
                using var cmd = new OracleCommand(query, conn);
                using var reader = cmd.ExecuteReader();

                dtgvStudent2.Rows.Clear();

                while (reader.Read())
                {
                    object[] row = new object[reader.FieldCount];
                    reader.GetValues(row);
                    dtgvStudent2.Rows.Add(row);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

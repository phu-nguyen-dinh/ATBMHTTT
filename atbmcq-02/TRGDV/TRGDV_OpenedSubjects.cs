using Oracle.ManagedDataAccess.Client;
using OracleUserManager.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace atbmcq_02
{
    public partial class TRGDV_OpenedSubjects : UserControl
    {
        public event EventHandler<OracleDbConnection> backClicked;

        public TRGDV_OpenedSubjects(OracleDbConnection _connect)
        {
            InitializeComponent();
            _connection = _connect;
            LoadSubjects();
        }

        private void lblBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            backClicked?.Invoke(this, _connection);
        }

        private void lblSignOut_LinkClicked(Object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Restart();
        }

        private void LoadSubjects()
        {
            try
            {
                string query = @"
                    SELECT HP.TENHP, MM.MAMM, NV.HOTEN, MM.HK, MM.NAM
                    FROM C##ADMIN.MOMON MM
                    JOIN C##ADMIN.HOCPHAN HP ON MM.MAHP = HP.MAHP
                    JOIN C##ADMIN.NHANVIEN NV ON MM.MAGV = NV.MANLD
                    WHERE NV.MADV = (
                        SELECT MADV
                        FROM C##ADMIN.NHANVIEN
                        WHERE MANLD = SYS_CONTEXT('USERENV', 'SESSION_USER')
                          AND VAITRO = 'TRGĐV'
                    )";

                using var cmd = new OracleCommand(query, _connection.conn);
                using var reader = cmd.ExecuteReader();

                dtgvSubject.Rows.Clear();

                while (reader.Read())
                {
                    object[] row = new object[reader.FieldCount];
                    reader.GetValues(row);
                    dtgvSubject.Rows.Add(row);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

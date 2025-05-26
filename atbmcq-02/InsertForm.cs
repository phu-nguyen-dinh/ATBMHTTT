using Oracle.ManagedDataAccess.Client;
using OracleUserManager.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace atbmcq_02
{
    public partial class InsertForm : Form
    {
        public InsertForm(OracleDbConnection _connect)
        {
            InitializeComponent();
            _connection = _connect;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dtgvSubject.Rows)
            {
                if (row.IsNewRow) continue;

                string idcrse = row.Cells["Course"].Value?.ToString().Trim();
                string idsbj = row.Cells["Subject"].Value?.ToString().Trim();
                string idtchr = row.Cells["InCharge"].Value?.ToString().Trim();
                string semes = row.Cells["Semester"].Value?.ToString().Trim();
                string year = row.Cells["Year"].Value?.ToString().Trim();

                if (string.IsNullOrEmpty(idcrse) || string.IsNullOrEmpty(idsbj) || string.IsNullOrEmpty(idtchr) || string.IsNullOrEmpty(semes) || string.IsNullOrEmpty(year))
                {
                    MessageBox.Show("Missing information!");
                    return;
                }

                if (!int.TryParse(semes, out int semesprs) || !int.TryParse(year, out int yearprs))
                {
                    MessageBox.Show($"Semester or Year must be an integer number, at row Suject: {idsbj}");
                    return;
                }

                bool success = SaveDataToDatabase(idcrse, idsbj, idtchr, semesprs, yearprs);

                if (!success)
                {
                    MessageBox.Show($"Error when saving data at row Subject: {idsbj}");
                    return;
                }
            }

            MessageBox.Show("Successfully saving data!");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private bool SaveDataToDatabase(string idcrse, string idsbj, string idtchr, int semes, int year)
        {
            try
            {
                string query = "INSERT INTO C##ADMIN.MOMON (MAMM, MAHP, MAGV, HK, NAM) VALUES (:mamm, :mahp, :magv, :hk, :nam)";

                using (var cmd = new OracleCommand(query, _connection.conn))
                {
                    cmd.BindByName = true;
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add("mahp", OracleDbType.Varchar2).Value = idcrse;
                    cmd.Parameters.Add("mamm", OracleDbType.Varchar2).Value = idsbj;
                    cmd.Parameters.Add("magv", OracleDbType.Varchar2).Value = idtchr;
                    cmd.Parameters.Add("hk", OracleDbType.Int32).Value = semes;
                    cmd.Parameters.Add("nam", OracleDbType.Int32).Value = year;
                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error when saving data: " + ex.Message);
                return false;
            }
        }

    }
}

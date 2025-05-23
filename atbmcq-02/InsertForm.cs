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

                string idcrse = Convert.ToString(row.Cells["Course"].Value)?.Trim();
                string idsbj = Convert.ToString(row.Cells["Subject"].Value)?.Trim();
                string idtchr = Convert.ToString(row.Cells["InCharge"].Value)?.Trim();
                string semes = Convert.ToString(row.Cells["Semester"].Value)?.Trim();
                string year = Convert.ToString(row.Cells["Year"].Value)?.Trim();

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
                string query = "INSERT INTO C##ADMIN.MOMON (MAMM, MAHP, MAGV, HK, NAM) VALUES ('MM301', 'HP100', 'NV065', 1, 2022)";

                using (var cmd = new OracleCommand(query, _connection.conn))
                {
                    MessageBox.Show(idcrse + '\\' + idsbj + '\\' + idtchr);
                    cmd.Parameters.Add(new OracleParameter("mhp", idcrse));
                    cmd.Parameters.Add(new OracleParameter("mamm", idsbj));
                    cmd.Parameters.Add(new OracleParameter("magv", idtchr));
                    cmd.Parameters.Add(new OracleParameter("hk", semes));
                    cmd.Parameters.Add(new OracleParameter("nam", year));
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

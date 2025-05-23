using Oracle.ManagedDataAccess.Client;
using OracleUserManager.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace atbmcq_02
{
    public partial class UpdateForm : Form
    {
        private List<(string idcrse, string idsbj, string idtchr, int semes, int year)> recordsToUpdate;

        public UpdateForm(List<(string idcrse, string idsbj, string idtchr, int semes, int year)> selectedData, OracleDbConnection _connect)
        {
            InitializeComponent();
            _connection = _connect;
            recordsToUpdate = selectedData;
            UpdateForm_Load();
        }

        private void UpdateForm_Load()
        {
            dtgvSubject.Columns["Subject"].ReadOnly = true;

            foreach (var item in recordsToUpdate)
            {
                dtgvSubject.Rows.Add(item.idcrse, item.idsbj, item.idtchr, item.semes, item.year);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dtgvSubject.Rows)
            {
                if (row.IsNewRow) continue;

                string idcrse = Convert.ToString(row.Cells["Course"].Value);
                string idsbj = Convert.ToString(row.Cells["Subject"].Value);
                string idtchr = Convert.ToString(row.Cells["InCharge"].Value);
                string semes = Convert.ToString(row.Cells["Semester"].Value);
                string year = Convert.ToString(row.Cells["Year"].Value);

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

                bool success = UpdateRowInDatabase(idcrse, idsbj, idtchr, semesprs, yearprs);

                if (!success)
                {
                    MessageBox.Show($"Error when updating data at row Subject: {idsbj}");
                    return;
                }
            }

            MessageBox.Show("Successfully updating data!");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private bool UpdateRowInDatabase(string idcrse, string idsbj, string idtchr, int semes, int year)
        {
            try
            {
                string query = @"UPDATE C##ADMIN.MOMON SET MAHP = :idcrse, MAGV = :idtchr, HK = :semes, NAM = :year WHERE MAMM = :idsbj";

                using (var cmd = new OracleCommand(query, _connection.conn))
                {
                    cmd.Parameters.Add(new OracleParameter("idcrse", idcrse));
                    cmd.Parameters.Add(new OracleParameter("idtchr", idtchr));
                    cmd.Parameters.Add(new OracleParameter("semes", semes));
                    cmd.Parameters.Add(new OracleParameter("year", year));
                    cmd.Parameters.Add(new OracleParameter("idsbj", idsbj));
                    cmd.ExecuteNonQuery();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật: " + ex.Message);
                return false;
            }
        }

    }
}

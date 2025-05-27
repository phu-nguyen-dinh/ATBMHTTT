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
    public partial class Teacher_OpenedSubjects : UserControl
    {
        public event EventHandler<OracleDbConnection> backClicked;

        public Teacher_OpenedSubjects(OracleDbConnection _connect)
        {
            InitializeComponent();
            _connection = _connect;
            LoadUI();
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

        private string getRole()
        {
            string query = @"BEGIN
                                    SELECT VAITRO INTO :role FROM C##ADMIN.NHANVIEN WHERE MANLD = SYS_CONTEXT('USERENV', 'SESSION_USER');
                                EXCEPTION
                                    WHEN NO_DATA_FOUND THEN
                                        BEGIN
                                            SELECT 'SINHVIEN' INTO :role FROM C##ADMIN.SINHVIEN WHERE MASV = SYS_CONTEXT('USERENV', 'SESSION_USER');
                                        EXCEPTION
                                            WHEN NO_DATA_FOUND THEN
                                                :role := NULL;
                                        END;
                                END;";

            using var cmd = new OracleCommand(query, _connection.conn);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add("role", OracleDbType.NVarchar2, 30).Direction = ParameterDirection.Output;

            cmd.ExecuteNonQuery();

            string role = cmd.Parameters["role"].Value?.ToString();

            return role;
        }

        private void LoadUI()
        {
            try
            {
                string role = getRole();

                if (role == "NV PĐT")
                {
                    btnInsert.Enabled = true;
                    btnDelete.Enabled = true;
                    btnFind.Enabled = true;
                    btnUpdate.Enabled = true;
                    btnFind.Enabled = true;
                    cbbSemes.Enabled = true;
                    cbbYear.Enabled = true;

                    btnInsert.Visible = true;
                    btnDelete.Visible = true;
                    btnUpdate.Visible = true;
                    btnFind.Visible = true;
                    cbbSemes.Visible = true;
                    cbbYear.Visible = true;
                }
                else
                {
                    btnInsert.Enabled = false;
                    btnDelete.Enabled = false;
                    btnFind.Enabled = false;
                    btnUpdate.Enabled = false;
                    btnFind.Enabled = false;
                    cbbSemes.Enabled = false;
                    cbbYear.Enabled = false;

                    btnInsert.Visible = false;
                    btnDelete.Visible = false;
                    btnUpdate.Visible = false;
                    btnFind.Visible = false;
                    cbbSemes.Visible = false;
                    cbbYear.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadSubjects()
        {
            try
            {
                if (getRole() == "NV PĐT")
                {
                    string semes = cbbSemes.SelectedItem?.ToString();
                    string year = cbbYear.SelectedItem?.ToString();

                    using (var ctxCmd = new OracleCommand("C##ADMIN.set_app_ctx_proc", _connection.conn))
                    {
                        ctxCmd.CommandType = CommandType.StoredProcedure;
                        ctxCmd.Parameters.Add("p_hk", OracleDbType.Varchar2).Value = semes;
                        ctxCmd.Parameters.Add("p_nam", OracleDbType.Varchar2).Value = year;
                        ctxCmd.ExecuteNonQuery();
                    }
                }

                string column_x = null;
                string column_y = null;

                if (getRole() == "NV PĐT")
                {
                    column_x = "MAHP";
                    column_y = "MANLD";
                }
                else
                {
                    column_x = "TENHP";
                    column_y = "HOTEN";
                }

                string query = $@"SELECT HP.{column_x}, MM.MAMM, NV.{column_y}, MM.HK, MM.NAM FROM C##ADMIN.MOMON MM JOIN C##ADMIN.HOCPHAN HP ON MM.MAHP = HP.MAHP JOIN C##ADMIN.NHANVIEN NV ON MM.MAGV = NV.MANLD";
                
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

        private void btnInsert_Click(object sender, EventArgs e)
        {
            InsertForm insertForm = new InsertForm(_connection);

            if (insertForm.ShowDialog() == DialogResult.OK)
            {
                LoadSubjects();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dtgvSubject.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please choose one row to delete.");
                return;
            }

            DataGridViewRow selectedRow = dtgvSubject.SelectedRows[0];

            var idValue = selectedRow.Cells["Subject"].Value;

            if (idValue == null)
            {
                MessageBox.Show("Cannot get row.");
                return;
            }

            string id = idValue.ToString();
            
            DialogResult confirm = MessageBox.Show("Are you sure that you want to delete this row?", "Confirm deleting.", MessageBoxButtons.YesNo);
            if (confirm != DialogResult.Yes)
                return;

            bool success = DeleteRowFromDatabase(id);

            if (success)
            {
                dtgvSubject.Rows.Remove(selectedRow);
                MessageBox.Show("Successfully deleting data!");
            }
        }

        private bool DeleteRowFromDatabase(string id)
        {
            try
            {
                string query = "DELETE FROM C##ADMIN.MOMON WHERE MAMM = :id";

                using (var cmd = new OracleCommand(query, _connection.conn))
                {
                    cmd.Parameters.Add(new OracleParameter("id", id));

                    int rowAffected = cmd.ExecuteNonQuery();

                    return rowAffected > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error when deleting: " + ex.Message);
                return false;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dtgvSubject.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please choose at least 1 row to update.");
                return;
            }

            List<(string idcrse, string idsbj, string idtchr, int semes, int year)> selectedRows = new List<(string, string, string, int, int)>();

            foreach (DataGridViewRow row in dtgvSubject.SelectedRows)
            {
                string idcrse = Convert.ToString(row.Cells["Course"].Value);
                string idsbj = Convert.ToString(row.Cells["Subject"].Value);
                string idtchr = Convert.ToString(row.Cells["InCharge"].Value);
                int semes = Convert.ToInt32(row.Cells["Semester"].Value);
                int year = Convert.ToInt32(row.Cells["Year"].Value);

                selectedRows.Add((idcrse, idsbj, idtchr, semes, year));
            }

            UpdateForm updateForm = new UpdateForm(selectedRows, _connection);

            if (updateForm.ShowDialog() == DialogResult.OK)
            {
                LoadSubjects();
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            LoadSubjects();
        }
    }
}

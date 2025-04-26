using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using OracleUserManager.Models;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace atbmcq_02
{
    public partial class Grant_Privileges : UserControl
    {
        private enum GrantType
        {
            Object,
            System,
            Role
        }

        public Grant_Privileges(OracleDbConnection _connect)
        {
            InitializeComponent();
            _connection = _connect;
        }

        private void Grant_Privileges_Load(object sender, EventArgs e)
        {
            cmbGrantType.SelectedIndex = 0;
            UpdateGrantUI();
            LoadPrivileges(sender, e);
        }

        private void cmbGrantType_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateGrantUI();
        }

        private void UpdateGrantUI()
        {
            GrantType selectedType;

            if (cmbGrantType.SelectedIndex == 1)
            {
                selectedType = GrantType.System;
            }
            else
            {
                selectedType = GrantType.Object;
            }

            if (selectedType == GrantType.System)
            {
                pnlObjectDetails.ForeColor = Color.Gray;
                pnlObjectDetails.Enabled = false;

                chkAdminOption.ForeColor = SystemColors.ControlText;
                pnlSYS.ForeColor = SystemColors.ControlText;
                pnlSYS.Enabled = true;
            }
            else
            {
                pnlObjectDetails.ForeColor = SystemColors.ControlText;
                pnlObjectDetails.Enabled = true;

                chkAdminOption.ForeColor = Color.Gray;
                pnlSYS.ForeColor = Color.Gray;
                pnlSYS.Enabled = false;
            }
        }

        private void cmbObjectPrivilege_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateColumnPanelVisibility();
        }
        private void cmbObjectPrivilege_TextChanged(object sender, EventArgs e)
        {
            UpdateColumnPanelVisibility();
        }

        private void UpdateColumnPanelVisibility()
        {
            string selectedPriv = cmbObjectPrivilege.Text.Trim().ToUpperInvariant();
            pnlColumns.Visible = (selectedPriv == "SELECT" || selectedPriv == "UPDATE");
            if (!pnlColumns.Visible) 
            {  
                txtColumns.Clear(); 
            }
        }

        private void btnGrant_Click(object sender, EventArgs e)
        {
            string grantee = txtGrantee.Text.Trim();
            string grantType = cmbGrantType.SelectedItem.ToString();

            if (string.IsNullOrWhiteSpace(grantee))
            {
                MessageBox.Show("Please enter the User/Role to grant privileges to.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGrantee.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(grantType))
            {
                MessageBox.Show("Please enter the Grant Type to grant privileges.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbGrantType.Focus();
                return;
            }

            GrantType selectedType;

            if (cmbGrantType.SelectedIndex == 1) selectedType = GrantType.System;
            else selectedType = GrantType.Object;

            try
            {
                using var conn = new OracleConnection(_connection.GetConnectionString());
                conn.Open();

                OracleCommand cmd = null;

                switch (selectedType)
                {
                    case GrantType.System:
                        string sysPrivilege = txtSystemPrivilege.Text.Trim();

                        if (string.IsNullOrWhiteSpace(sysPrivilege)) 
                        {
                            MessageBox.Show("Please enter the SYSPrivilege to grant.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtSystemPrivilege.Focus();
                            return; 
                        }

                        cmd = new OracleCommand("grant_sys_priv_proc", conn);
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("p_privilege", OracleDbType.Varchar2).Value = sysPrivilege;
                        cmd.Parameters.Add("p_grantee", OracleDbType.Varchar2).Value = grantee;
                        cmd.Parameters.Add("p_with_admin_option", OracleDbType.Int32).Value = chkAdminOption.Checked ? 1 : 0;
                        break;

                    case GrantType.Object:
                        string objectOwner = txtObjectOwner.Text.Trim();
                        string objectName = txtObjectName.Text.Trim();
                        string objectPrivilege = cmbObjectPrivilege.Text.Trim();
                        string columns = string.IsNullOrWhiteSpace(txtColumns.Text) ? null : txtColumns.Text.Trim();

                        if (string.IsNullOrWhiteSpace(objectOwner) || string.IsNullOrWhiteSpace(objectName) || string.IsNullOrWhiteSpace(objectPrivilege)) 
                        {
                            MessageBox.Show("Please enter the information fully to grant privilege.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return; 
                        }

                        string upperPriv = objectPrivilege.ToUpperInvariant();

                        cmd = new OracleCommand("grant_object_priv_proc", conn);
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("p_privilege", OracleDbType.Varchar2).Value = objectPrivilege;
                        cmd.Parameters.Add("p_grantee", OracleDbType.Varchar2).Value = grantee;
                        cmd.Parameters.Add("p_object_owner", OracleDbType.Varchar2).Value = objectOwner;
                        cmd.Parameters.Add("p_object_name", OracleDbType.Varchar2).Value = objectName;
                        cmd.Parameters.Add("p_columns", OracleDbType.Varchar2).Value = (object)columns ?? DBNull.Value;
                        cmd.Parameters.Add("p_with_grant_option", OracleDbType.Int32).Value = chkGrantOption.Checked ? 1 : 0;
                        break;
                }

                if (cmd != null)
                {
                    using (cmd)
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Grant successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadPrivileges(sender, e);
                    }
                }
            }
            catch (OracleException ox) { MessageBox.Show($"Oracle Error: {ox.Message}\n(Error Code: {ox.Number})", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            catch (Exception ex) { MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void LoadPrivileges(object sender, EventArgs e)
        {
            lstPrivileges.Items.Clear();
            try
            {
                using var conn = new OracleConnection(_connection.GetConnectionString());
                conn.Open();

                using var cmd = new OracleCommand("get_privileges_list", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("p_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var item = new ListViewItem(reader["grantee"].ToString());
                    item.SubItems.Add(reader["privilege"].ToString());
                    item.SubItems.Add(reader["table_name"].ToString());
                    item.SubItems.Add(reader["grantable"].ToString());

                    lstPrivileges.Items.Add(item);
                }
            }
            catch (OracleException ox) { MessageBox.Show($"Oracle Error loading privileges: {ox.Message}\n(Error Code: {ox.Number})", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            catch (Exception ex) { MessageBox.Show($"Error loading privileges: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void RevokePrivilege(object sender, EventArgs e)
        {
            //
        }
    }
}
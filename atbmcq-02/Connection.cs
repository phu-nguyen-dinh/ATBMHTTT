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
using OracleUserManager.Models;
using Oracle.ManagedDataAccess.Client;
using System.Text.Json;
using System.IO;

namespace atbmcq_02
{
    public partial class Connection : Form
    {
        private OracleDbConnection _connection;

        public Connection()
        {
            InitializeComponent();
            _connection = new OracleDbConnection();
            
            // Set default values
            cboAuthType.SelectedIndex = 0;
            cboRole.SelectedIndex = 0;
            cboConnType.SelectedIndex = 0;
            txtUsername.Text = "sys";
            
            // Initial radio button state
            txtSID.Enabled = radSID.Checked;
            txtServiceName.Enabled = radServiceName.Checked;

            // Add event handlers for buttons
            btnSave.Click += BtnSave_Click;
            btnClear.Click += BtnClear_Click;
            btnTest.Click += BtnTest_Click;
            btnConnect.Click += orclConnect;
            btnCancel.Click += BtnCancel_Click;

            // Add event handlers for ListView
            lstSavedAccounts.SelectedIndexChanged += lstSavedAccounts_SelectedIndexChanged;
            this.Load += Connection_Load;

            // Load saved settings if any
            OracleDbConnection.LoadSettings();
            LoadSavedSettings();
        }

        private void LoadSavedSettings()
        {
            // Load saved settings to form controls
            cboHostname.Text = _connection.Hostname;
            txtPort.Text = _connection.Port.ToString();
            txtUsername.Text = _connection.Username;
            if (_connection.SavePassword)
            {
                txtPassword.Text = _connection.Password;
                chkSavePassword.Checked = true;
            }
            
            if (!string.IsNullOrEmpty(_connection.ServiceName))
            {
                radServiceName.Checked = true;
                txtServiceName.Text = _connection.ServiceName;
                txtSID.Text = string.Empty;
            }
            else
            {
                radSID.Checked = true;
                txtSID.Text = _connection.SID;
                txtServiceName.Text = string.Empty;
            }

            // Set role
            for (int i = 0; i < cboRole.Items.Count; i++)
            {
                if (cboRole.Items[i]?.ToString() == _connection.Role)
                {
                    cboRole.SelectedIndex = i;
                    break;
                }
            }
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            try
            {
                // Get connection details
                _connection.Hostname = cboHostname.Text;
                _connection.Port = int.Parse(txtPort.Text);
                _connection.Username = txtUsername.Text;
                _connection.Password = txtPassword.Text;
                _connection.SavePassword = chkSavePassword.Checked;

                if (radSID.Checked)
                {
                    _connection.SID = txtSID.Text;
                    _connection.ServiceName = string.Empty;
                }
                else
                {
                    _connection.ServiceName = txtServiceName.Text;
                    _connection.SID = string.Empty;
                }

                _connection.Role = cboRole.SelectedItem?.ToString() ?? "default";

                // Add to saved connections
                _connection.AddToSavedConnections();

                // Add new hostname to the list if it doesn't exist
                if (!string.IsNullOrEmpty(cboHostname.Text) && !cboHostname.Items.Contains(cboHostname.Text))
                {
                    cboHostname.Items.Add(cboHostname.Text);
                }

                // Update saved accounts list
                LoadSavedAccounts();

                MessageBox.Show("Connection details saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving connection: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnClear_Click(object? sender, EventArgs e)
        {
            // Clear all input fields
            txtUsername.Clear();
            txtPassword.Clear();
            cboHostname.Text = "localhost";
            txtPort.Clear();
            txtSID.Clear();
            txtServiceName.Clear();
            
            // Reset combo boxes to default values
            cboAuthType.SelectedIndex = 0;
            cboRole.SelectedIndex = 0;
            cboConnType.SelectedIndex = 0;
            
            // Reset radio buttons
            radSID.Checked = true;
            radServiceName.Checked = false;
        }

        private void BtnTest_Click(object? sender, EventArgs e)
        {
            try
            {
                // Get connection details
                _connection.Hostname = cboHostname.Text;
                _connection.Port = int.Parse(txtPort.Text);
                _connection.Username = txtUsername.Text;
                _connection.Password = txtPassword.Text;
                _connection.Role = cboRole.SelectedItem?.ToString() ?? "default";

                if (radSID.Checked)
                {
                    _connection.SID = txtSID.Text;
                    _connection.ServiceName = string.Empty;
                }
                else
                {
                    _connection.ServiceName = txtServiceName.Text;
                    _connection.SID = string.Empty;
                }

                // Test the connection
                if (_connection.TestConnection())
                {
                    MessageBox.Show("Connection test successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Add new hostname to the list if it doesn't exist
                    if (!string.IsNullOrEmpty(cboHostname.Text) && !cboHostname.Items.Contains(cboHostname.Text))
                    {
                        cboHostname.Items.Add(cboHostname.Text);
                    }
                }
                else
                {
                    MessageBox.Show("Connection test failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error testing connection: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCancel_Click(object? sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }

        private void orclConnect(object? sender, EventArgs e)
        {
            try
            {
                this._connection.Hostname = cboHostname.Text;
                this._connection.Port = int.Parse(txtPort.Text);
                
                if (radSID.Checked)
                {
                    this._connection.SID = txtSID.Text;
                    this._connection.ServiceName = string.Empty;
                }
                else
                {
                    this._connection.ServiceName = txtServiceName.Text;
                    this._connection.SID = string.Empty;
                }
                
                this._connection.Username = txtUsername.Text;
                this._connection.Password = txtPassword.Text;
                this._connection.Role = cboRole.SelectedItem?.ToString() ?? "default";

                if (_connection.TestConnection())
                {
                    // Add new hostname to the list if it doesn't exist
                    if (!string.IsNullOrEmpty(cboHostname.Text) && !cboHostname.Items.Contains(cboHostname.Text))
                    {
                        cboHostname.Items.Add(cboHostname.Text);
                    }

                    MessageBox.Show("Connection successful!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadMainForm();
                }
                else
                {
                    MessageBox.Show("Connection failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error connecting: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loadMainForm()
        {
            this.Hide();
            Home home = new Home(_connection);
            home.ShowDialog();
            this.Close();
        }

        private void Connection_Load(object? sender, EventArgs e)
        {
            // Load saved accounts when form starts
            LoadSavedAccounts();
        }

        private void LoadSavedAccounts()
        {
            lstSavedAccounts.Items.Clear();
            foreach (var connection in OracleDbConnection.SavedConnections)
            {
                var item = new ListViewItem(connection.Username);
                item.SubItems.Add(connection.Hostname);
                item.SubItems.Add(connection.Role);
                lstSavedAccounts.Items.Add(item);

                // Also add hostname to combobox if not exists
                if (!cboHostname.Items.Contains(connection.Hostname))
                {
                    cboHostname.Items.Add(connection.Hostname);
                }
            }

            // Enable/disable edit and delete buttons based on selection
            bool hasSelection = lstSavedAccounts.SelectedItems.Count > 0;
            btnEdit.Enabled = hasSelection;
            btnDelete.Enabled = hasSelection;
        }

        private void lstSavedAccounts_SelectedIndexChanged(object? sender, EventArgs e)
        {
            // Enable/disable edit and delete buttons based on selection
            bool hasSelection = lstSavedAccounts.SelectedItems.Count > 0;
            btnEdit.Enabled = hasSelection;
            btnDelete.Enabled = hasSelection;

            if (hasSelection)
            {
                var selectedItem = lstSavedAccounts.SelectedItems[0];
                var connection = OracleDbConnection.SavedConnections.FirstOrDefault(c =>
                    c.Username == selectedItem.Text &&
                    c.Hostname == selectedItem.SubItems[1].Text);

                if (connection != null)
                {
                    // Load connection details to form
                    txtUsername.Text = connection.Username;
                    cboHostname.Text = connection.Hostname;
                    txtPort.Text = connection.Port.ToString();
                    cboRole.Text = connection.Role;

                    if (connection.SavePassword)
                    {
                        txtPassword.Text = connection.Password;
                        chkSavePassword.Checked = true;
                    }
                    else
                    {
                        txtPassword.Clear();
                        chkSavePassword.Checked = false;
                    }

                    if (!string.IsNullOrEmpty(connection.ServiceName))
                    {
                        radServiceName.Checked = true;
                        txtServiceName.Text = connection.ServiceName;
                        txtSID.Text = string.Empty;
                    }
                    else
                    {
                        radSID.Checked = true;
                        txtSID.Text = connection.SID;
                        txtServiceName.Text = string.Empty;
                    }
                }
            }
        }

        private void EditAccount_Click(object? sender, EventArgs e)
        {
            if (lstSavedAccounts.SelectedItems.Count > 0)
            {
                var selectedItem = lstSavedAccounts.SelectedItems[0];
                var connection = OracleDbConnection.SavedConnections.FirstOrDefault(c =>
                    c.Username == selectedItem.Text &&
                    c.Hostname == selectedItem.SubItems[1].Text);

                if (connection != null)
                {
                    // Load connection details to form
                    txtUsername.Text = connection.Username;
                    cboHostname.Text = connection.Hostname;
                    txtPort.Text = connection.Port.ToString();
                    cboRole.Text = connection.Role;

                    if (connection.SavePassword)
                    {
                        txtPassword.Text = connection.Password;
                        chkSavePassword.Checked = true;
                    }
                    else
                    {
                        txtPassword.Clear();
                        chkSavePassword.Checked = false;
                    }

                    if (!string.IsNullOrEmpty(connection.ServiceName))
                    {
                        radServiceName.Checked = true;
                        txtServiceName.Text = connection.ServiceName;
                        txtSID.Text = string.Empty;
                    }
                    else
                    {
                        radSID.Checked = true;
                        txtSID.Text = connection.SID;
                        txtServiceName.Text = string.Empty;
                    }

                    // Remove the old connection
                    OracleDbConnection.SavedConnections.Remove(connection);
                    OracleDbConnection.SaveSettings();
                    LoadSavedAccounts();
                }
            }
        }

        private void DeleteAccount_Click(object? sender, EventArgs e)
        {
            if (lstSavedAccounts.SelectedItems.Count > 0)
            {
                var selectedItem = lstSavedAccounts.SelectedItems[0];
                var connection = OracleDbConnection.SavedConnections.FirstOrDefault(c =>
                    c.Username == selectedItem.Text &&
                    c.Hostname == selectedItem.SubItems[1].Text);

                if (connection != null)
                {
                    var result = MessageBox.Show(
                        $"Are you sure you want to delete the connection for {connection.Username}@{connection.Hostname}?",
                        "Confirm Delete",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        OracleDbConnection.SavedConnections.Remove(connection);
                        OracleDbConnection.SaveSettings();
                        LoadSavedAccounts();
                    }
                }
            }
        }
    }
}

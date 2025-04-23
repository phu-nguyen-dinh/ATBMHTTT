using Oracle.ManagedDataAccess.Client;
using System.Text.Json;
using System.IO;
using System.Collections.Generic;

namespace OracleUserManager.Models
{
    public class OracleDbConnection
    {
        public string Hostname { get; set; } = string.Empty;
        public int Port { get; set; } = 1521;
        public string SID { get; set; } = "xe";  // Default SID for Oracle XE
        public string ServiceName { get; set; } = string.Empty;  // New property for Service Name
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Role { get; set; } = "default";  // New property for Role
        public bool SavePassword { get; set; } = false;  // New property for saving password

        private const string SettingsFile = "connection_settings.json";
        private static List<OracleDbConnection> _savedConnections = new List<OracleDbConnection>();

        public static List<OracleDbConnection> SavedConnections
        {
            get
            {
                if (_savedConnections.Count == 0)
                {
                    LoadSettings();
                }
                return _savedConnections;
            }
        }

        public static void LoadSettings()
        {
            _savedConnections.Clear();
            if (File.Exists(SettingsFile))
            {
                try
                {
                    string json = File.ReadAllText(SettingsFile);
                    try
                    {
                        // First try to deserialize as a list
                        var settings = JsonSerializer.Deserialize<List<OracleDbConnection>>(json);
                        if (settings != null)
                        {
                            _savedConnections.AddRange(settings);
                        }
                    }
                    catch
                    {
                        // If that fails, try to deserialize as a single object
                        var singleConnection = JsonSerializer.Deserialize<OracleDbConnection>(json);
                        if (singleConnection != null)
                        {
                            _savedConnections.Add(singleConnection);
                        }
                    }
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show($"Error loading settings: {ex.Message}");
                    // If there's an error, delete the corrupted file
                    try
                    {
                        File.Delete(SettingsFile);
                    }
                    catch { }
                }
            }
        }

        public static void SaveSettings()
        {
            try
            {
                string json = JsonSerializer.Serialize(_savedConnections);
                File.WriteAllText(SettingsFile, json);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show($"Error saving settings: {ex.Message}");
            }
        }

        public void AddToSavedConnections()
        {
            // Check if connection with same username and hostname already exists
            var existingConnection = _savedConnections.FirstOrDefault(c => 
                c.Username == this.Username && 
                c.Hostname == this.Hostname);

            if (existingConnection != null)
            {
                // Update existing connection
                existingConnection.Port = this.Port;
                existingConnection.SID = this.SID;
                existingConnection.ServiceName = this.ServiceName;
                existingConnection.Role = this.Role;
                existingConnection.SavePassword = this.SavePassword;
                if (this.SavePassword)
                {
                    existingConnection.Password = this.Password;
                }
            }
            else
            {
                // Add new connection
                var newConnection = new OracleDbConnection
                {
                    Hostname = this.Hostname,
                    Port = this.Port,
                    SID = this.SID,
                    ServiceName = this.ServiceName,
                    Username = this.Username,
                    Role = this.Role,
                    SavePassword = this.SavePassword
                };

                if (this.SavePassword)
                {
                    newConnection.Password = this.Password;
                }

                _savedConnections.Add(newConnection);
            }

            SaveSettings();
        }

        public string GetConnectionString()
        {
            string connectData;
            if (!string.IsNullOrEmpty(ServiceName))
            {
                connectData = $"(SERVICE_NAME={ServiceName})";
            }
            else
            {
                connectData = $"(SID={SID})";
            }

            string connectionString = $"Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST={Hostname})(PORT={Port}))" +
                                   $"(CONNECT_DATA={connectData}));User Id={Username};Password={Password}";

            // Add DBA Privilege based on role
            if (Role.ToUpper() == "SYSDBA")
            {
                connectionString += ";DBA Privilege=SYSDBA";
            }
            else if (Role.ToUpper() == "SYSOPER")
            {
                connectionString += ";DBA Privilege=SYSOPER";
            }
            else if (Role.ToUpper() == "SYSBACKUP")
            {
                connectionString += ";DBA Privilege=SYSBACKUP";
            }
            else if (Role.ToUpper() == "SYSDG")
            {
                connectionString += ";DBA Privilege=SYSDG";
            }
            else if (Role.ToUpper() == "SYSKM")
            {
                connectionString += ";DBA Privilege=SYSKM";
            }
            else if (Role.ToUpper() == "SYSRAC")
            {
                connectionString += ";DBA Privilege=SYSRAC";
            }

            return connectionString;
        }

        public bool TestConnection()
        {
            try
            {
                using var conn = new OracleConnection(GetConnectionString());
                conn.Open();
                return true;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
} 
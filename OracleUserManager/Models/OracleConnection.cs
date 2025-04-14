using Oracle.ManagedDataAccess.Client;

namespace OracleUserManager.Models
{
    public class OracleDbConnection
    {
        public string Hostname { get; set; } = string.Empty;
        public int Port { get; set; } = 1521;
        public string SID { get; set; } = "xe";  // Default SID for Oracle XE
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;

        public string GetConnectionString()
        {
            string connectionString = $"Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST={Hostname})(PORT={Port}))" +
                                   $"(CONNECT_DATA=(SID={SID})));User Id={Username};Password={Password}";

            // Nếu là tài khoản SYS thì thêm DBA Privilege
            if (Username.ToLower() == "sys")
            {
                connectionString += ";DBA Privilege=SYSDBA";
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
                // In ra lỗi để debug
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
} 
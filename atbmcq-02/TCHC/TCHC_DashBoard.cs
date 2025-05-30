using OracleUserManager.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace atbmcq_02
{
    public partial class TCHC_DashBoard : Form
    {
        //public event EventHandler BackClicked;
        public TCHC_DashBoard(OracleDbConnection _connect)
        {
            InitializeComponent();
            _connection = _connect;
        }
      
        private void dshBoard_Closed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void linkInfor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string username = _connection.Username.ToUpper();
            loadInfor(); 
        }
        private void linkOfficial_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string username = _connection.Username.ToUpper();
            loadOfficial();
        }

        private void opnd_backClicked(object sender, OracleDbConnection _connect)
        {
            this.Controls.Clear();
            InitializeComponent();
            _connection = _connect;
        }
        private void loadInfor() 
        {
            var opnd = new NVCB_Infor(_connection);

            opnd.backClicked += opnd_backClicked;

            this.Controls.Clear();
            this.Controls.Add(opnd);
            this.ClientSize = opnd.Size;
        }

        private void loadOfficial()
        {
            var opnd = new TCHC_Official(_connection);

            opnd.backClicked += opnd_backClicked;

            this.Controls.Clear();
            this.Controls.Add(opnd);
            this.ClientSize = opnd.Size;
        }

        private void lblSignOut_LinkClicked(Object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Restart();
        }
        private void lblNotification_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Hiển thị form thông báo khi nhấp vào liên kết
            ShowNotifications();
        }

        private void picNotification_Click(object sender, EventArgs e)
        {
            // Hiển thị form thông báo khi nhấp vào biểu tượng
            ShowNotifications();
        }

        private void ShowNotifications()
        {
            // Tạo và hiển thị form thông báo
            using (NotificationForm notificationForm = new NotificationForm(_connection))
            {
                notificationForm.ShowDialog(this);
            }
        }
    }
}

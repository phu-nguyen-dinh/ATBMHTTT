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
    public partial class Student_DashBoard : Form
    {
        //public event EventHandler BackClicked;
        public Student_DashBoard(OracleDbConnection _connect)
        {
            InitializeComponent();
            _connection = _connect;
        }

        private void llblCourse_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoadCourse();
        }

        private void LoadCourse()
        {
            var crse = new Student_Courses(_connection);

            crse.backClicked += opnd_backClicked;

            this.Controls.Clear();
            this.Controls.Add(crse);
            this.ClientSize = crse.Size;
        }

        private void dshBoard_Closed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void llblOpened_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoadOpenedSubject();
        }
        private void linkInfor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        { 
            loadStudent();
        }

        private void LoadOpenedSubject()
        {
            var opnd = new Student_OpenedSubjects(_connection);

            opnd.backClicked += opnd_backClicked;

            this.Controls.Clear();
            this.Controls.Add(opnd);
            this.ClientSize = opnd.Size;
        }

        private void opnd_backClicked(object sender, OracleDbConnection _connect)
        {
            this.Controls.Clear();
            InitializeComponent();
            _connection = _connect;
        }

        private void loadStudent()
        {
            var opnd = new Student_Student(_connection);

            opnd.backClicked += opnd_backClicked;

            this.Controls.Clear();
            this.Controls.Add(opnd);
            this.ClientSize = opnd.Size;
        }
        private void loadOfficial()
        {
            var opnd = new Official(_connection);

            opnd.backClicked += opnd_backClicked;

            this.Controls.Clear();
            this.Controls.Add(opnd);
            this.ClientSize = opnd.Size;
        }
        private void llblRegis_LinkClicked(Object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoadRegistration();
        }
        private void LoadRegistration()
        {
            var opnd = new Student_Registration(_connection);

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

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
    public partial class DashBoard : Form
    {
        //public event EventHandler BackClicked;
        public DashBoard(OracleDbConnection _connect)
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
            var crse = new Courses(_connection);

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
        private void linkStudent_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string username = _connection.Username.ToUpper();
            if (username.StartsWith("SV"))
            {
                loadStudent();
            }
            else
            {
                loadTeacher();
            }
        }

        private void LoadOpenedSubject()
        {
            var opnd = new OpenedSubjects(_connection);

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
            var opnd = new Student(_connection);

            opnd.backClicked += opnd_backClicked;

            this.Controls.Clear();
            this.Controls.Add(opnd);
            this.ClientSize = opnd.Size;
        }
        private void loadTeacher()
        {
            var opnd = new Teacher(_connection);

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
            var opnd = new Registration(_connection);

            opnd.backClicked += opnd_backClicked;

            this.Controls.Clear();
            this.Controls.Add(opnd);
            this.ClientSize = opnd.Size;
        }

        private void lblSignOut_LinkClicked(Object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Restart();
        }
    }
}

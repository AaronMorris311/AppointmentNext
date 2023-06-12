using AaronMorris_C969_Task1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AaronMorris_C969_Task1.Forms
{
    public partial class UserInfo : Form
    {
        User _user = new User();
        public UserInfo()
        {
            InitializeComponent();

        }
        public UserInfo(User user)
        {
            InitializeComponent();
            _user = user;
            UsernameTextbox.Text = _user.userName;
        }

        private void UserInfoSaveButton_Click(object sender, EventArgs e)
        {
            if ((!(String.IsNullOrWhiteSpace(UsernameTextbox.Text))) && (!(String.IsNullOrWhiteSpace(PasswordTextbox.Text))))
            {
                _user.userName = UsernameTextbox.Text;
                _user.password = PasswordTextbox.Text;
            }
            else
            {
                MessageBox.Show("Please be sure to fill out Username and Password.", "Missing Information!");
                return;
            }

            if (_user.userId > 0)
            {
                globals.UpdateUser(_user);
            }
            else
            {
                _user.userId = globals.UserList.OrderByDescending(user => user.userId).Select(t => t.userId).First() + 1;
                _user.active = true;
                globals.AddUser(_user);
                globals.UserList.Add(_user);

            }

            globals.ResetSelections();
            this.DialogResult = DialogResult.OK;
        }

        private void UserInfoCancelButton_Click(object sender, EventArgs e)
        {
            globals.currentIndexSelected = -1;
            this.DialogResult = DialogResult.Cancel;
        }
    }
}


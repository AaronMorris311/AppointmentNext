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
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
            UserDGV.DataSource = globals.UserList;
        }

        private void UserFormAddButton_Click(object sender, EventArgs e)
        {
            UserInfo userInfo = new UserInfo();
            userInfo.ShowDialog();
        }

        private void UserFormModifyButton_Click(object sender, EventArgs e)
        {
            if ((globals.currentIndexSelected > -1) && ((globals.UserList[globals.currentIndexSelected]).userName == "test"))
            { 
                MessageBox.Show("Cannot edit test user.", "Not Good!"); 
            }
            else if ((globals.currentIndexSelected > -1) && ((globals.UserList[globals.currentIndexSelected]).userName != "test"))
            {
                UserInfo userInfo = new UserInfo(globals.UserList[globals.currentIndexSelected]);
                if(userInfo.ShowDialog() == DialogResult.OK)
                {
                    UserDGV.ClearSelection();
                    globals.ResetSelections();
                }
            }
            else
            {
                MessageBox.Show("Please select a user to edit.", "Nothing Selected!");
            }
        }

        private void UserFormDeleteButton_Click(object sender, EventArgs e)
        {
            if(globals.UserList[globals.currentIndexSelected].userName != "test")
            {
                if (globals.currentIndexSelected > -1)
                {
                    globals.DeleteUser(globals.UserList[globals.currentIndexSelected]);
                    globals.UserList.Remove(globals.UserList[globals.currentIndexSelected]);
                    globals.currentIndexSelected = -1;
                }
                else
                {
                    MessageBox.Show("Please select a customer to delete.", "Nothing Selected!");
                }
            }
            else if(globals.UserList[globals.currentIndexSelected].userName == "test")
            {
                MessageBox.Show("You cannot delete test user!", "This is for your own safety!");
            }
        }

        private void UserDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            globals.currentIndexSelected = e.RowIndex;
        }

        private void UserDGV_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            UserDGV.ClearSelection();
            globals.ResetSelections();
        }

        private void UserFormCancelButton_Click(object sender, EventArgs e)
        {
            globals.currentIndexSelected = -1;
            this.DialogResult = DialogResult.Cancel;
        }

        private void UserFormSaveButton_Click(object sender, EventArgs e)
        {
            globals.currentIndexSelected = -1;
            this.DialogResult = DialogResult.OK;
        }
    }
}

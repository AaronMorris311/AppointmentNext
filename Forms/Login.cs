using AaronMorris_C969_Task1.Forms;
using AaronMorris_C969_Task1.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AaronMorris_C969_Task1
{
    public partial class Login : Form
    {
        string fileName = "UserLog";

        public Login()
        {
            InitializeComponent();
            globals.GetAllInfo();

            if (CultureInfo.CurrentCulture.TwoLetterISOLanguageName == "es")
            {
                PleaseSignInText.Text = "Por favor, registrese:";
                UsernameLabel.Text = "Nombre de usuario:";
                PasswordLabel.Text = "Clave:";
                LoginButton.Text = "Acceso";
                LoginCancelButton.Text = "Cancelar";

            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {

            User checkUser = globals.UserList.Where(t => t.userName == UsernameTextbox.Text).FirstOrDefault();

            if (String.IsNullOrEmpty(UsernameTextbox.Text) || String.IsNullOrEmpty(PasswordTextbox.Text))
            {
                if (CultureInfo.CurrentCulture.TwoLetterISOLanguageName == "es")
                {
                    MessageBox.Show("¡Por favor complete nombre de usuario y contraseña!", "¡Error!");
                }
                else
                {
                    MessageBox.Show("Please fill out username and password!", "Error!");
                }

                using (StreamWriter writer = File.AppendText(fileName))
                {
                    writer.WriteLine("Failed login using User:" + UsernameTextbox.Text + " at " + DateTime.Now);
                }

            }
            else if(checkUser == null)
            {
                if (CultureInfo.CurrentCulture.TwoLetterISOLanguageName == "es")
                {
                    MessageBox.Show("¡Usuario no encontrado!", "¡Error!");
                }
                else
                {
                    MessageBox.Show("User not found!", "Error!");
                }

                using (StreamWriter writer = File.AppendText(fileName))
                {
                    writer.WriteLine("Failed login using User:" + UsernameTextbox.Text + " at " + DateTime.Now);
                }
            }
            else if ((checkUser.userName == UsernameTextbox.Text.ToString() && (checkUser.password == PasswordTextbox.Text.ToString())))
            {
                using (StreamWriter writer = File.AppendText(fileName))
                {
                    writer.WriteLine("Successful login using User:" + UsernameTextbox.Text + " at " + DateTime.Now);
                }

                globals.currentUser = checkUser;
                Appointments appointments = new Appointments();
                appointments.Show();
                this.Hide();
            }
            else
            {

                if (CultureInfo.CurrentCulture.TwoLetterISOLanguageName == "es")
                {
                    MessageBox.Show("¡Nombre de usuario o contraseña incorrecta!", "¡Error!");
                }
                else
                {
                    MessageBox.Show("Username or password is incorrect!", "Error!");
                }
            }

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}

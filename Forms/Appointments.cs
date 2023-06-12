using AaronMorris_C969_Task1.Models;
using MySql.Data.MySqlClient;
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
    public partial class Appointments : Form
    {
        // BindingList<Appointment> TempAppointment = new BindingList<Appointment>(); 
        public Appointments()
        {
            InitializeComponent();
            AppointmentsDGV.DataSource = globals.AppointmentList;

            List<string> TypeList = new List<string>();
            List<string> Months = new List<string>();

            TypeList.Add("Scrum");
            TypeList.Add("Presentation");
            TypeList.Add("Inspection");
            TypeList.Add("First Meeting");

            Months.Add("January");
            Months.Add("February");
            Months.Add("March");
            Months.Add("April");
            Months.Add("May");
            Months.Add("June");
            Months.Add("July");
            Months.Add("August");
            Months.Add("September");
            Months.Add("October");
            Months.Add("November");
            Months.Add("December");

            CategoryDropdown.DataSource = TypeList;
            MonthDropdown.DataSource = Months;
            CustomerDropdown.DataSource = globals.CustomerList;
            UserDropdown.DataSource = globals.UserList;

            if (globals.AppointmentList.Any(appt => appt.userId == globals.currentUser.userId))
            {
                foreach (Appointment appointment in globals.AppointmentList)
                {
                    if (appointment.userId == globals.currentUser.userId)
                    {
                        if (DateTime.Now.Date == appointment.start.Date)
                        {
                            if (globals.BetweenDates(appointment.start, DateTime.Now, DateTime.Now.AddMinutes(15)))
                            {
                                MessageBox.Show("Upcoming appointment with " + appointment.customer + " at " + appointment.start.TimeOfDay + "!");
                            }
                        }
                    }
                }
            }
        }


        private void CustomersButton_Click(object sender, EventArgs e)
        {
            Customers customers = new Customers();
            customers.ShowDialog();
            globals.currentIndexSelected = -1;
            AppointmentsDGV.ClearSelection();
        }

        private void CreateAppButton_Click(object sender, EventArgs e)
        {
            AppInfo appinfo = new AppInfo(false);
            appinfo.ShowDialog();
            AppointmentsDGV.ClearSelection();
        }

        private void ModifyAppButton_Click(object sender, EventArgs e)
        {
            if (globals.currentIndexSelected > -1)
            {
                AppInfo appinfo = new AppInfo(true);
                appinfo.ShowDialog();
                AppointmentsDGV.ClearSelection();
            }
            else
            {
                MessageBox.Show("Nothing Selected!");
            }
        }

        private void AppointmentsDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            globals.currentIndexSelected = e.RowIndex;
        }

        private void AppointmentsDGV_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            AppointmentsDGV.ClearSelection();
            globals.currentIndexSelected = -1;
        }

        private void DeleteAppButton_Click(object sender, EventArgs e)
        {
            if (globals.currentIndexSelected > -1)
            {
                globals.DeleteAppointment(globals.AppointmentList[globals.currentIndexSelected]);
                globals.AppointmentList.Remove(globals.AppointmentList[globals.currentIndexSelected]);
                globals.currentIndexSelected = -1;
                AppointmentsDGV.ClearSelection();
            }
            else
            {
                MessageBox.Show("Please select an appointment to delete.", "Nothing Selected!");
            }
        }

        private void UserButton_Click(object sender, EventArgs e)
        {
            UserForm userForm = new UserForm();
            userForm.ShowDialog();
        }

        private void ShowAllButton_Click(object sender, EventArgs e)
        {
            AppointmentsDGV.DataSource = globals.AppointmentList;
        }

        private void ShowMonthButton_Click(object sender, EventArgs e)
        {
            List<Appointment> TempAppointment = globals.AppointmentList.Where(appt => globals.BetweenDates(appt.start, DateTime.Now, DateTime.Now.AddDays(30))).ToList();
            AppointmentsDGV.DataSource = TempAppointment;
        }

        private void ShowWeekButton_Click(object sender, EventArgs e)
        {
            List<Appointment> TempAppointment = globals.AppointmentList.Where(appt => globals.BetweenDates(appt.start, DateTime.Now, DateTime.Now.AddDays(7))).ToList();
            AppointmentsDGV.DataSource = TempAppointment;
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            int typeCount = 0;
            string apptMonth = MonthDropdown.Text;
            string apptType = CategoryDropdown.Text;

            foreach (Appointment appointment in globals.AppointmentList)
            {
                if (appointment.start.ToString("MMMM") == apptMonth && appointment.type == apptType)
                {
                    typeCount++;
                }
            }
            MessageBox.Show("There are " + typeCount + " " + apptType + " in " + apptMonth + ".");
        }

        private void UpdateGridButton_Click(object sender, EventArgs e)
        {

            BindingList<Appointment> tempApptList = new BindingList<Appointment>();
            User userSelected = (User)UserDropdown.SelectedItem;

            foreach (Appointment appointment in globals.AppointmentList)
            {
                if (appointment.userId == userSelected.userId)
                {
                    tempApptList.Add(appointment);
                }
            }

            AppointmentsDGV.DataSource = tempApptList;
        }

        private void UpdateCustViewButton_Click(object sender, EventArgs e)
        {

            BindingList<Appointment> tempApptList = new BindingList<Appointment>();
            Customer custSelected = (Customer)CustomerDropdown.SelectedItem;

            foreach (Appointment appointment in globals.AppointmentList)
            {
                if (appointment.customerId == custSelected.customerId)
                {
                    tempApptList.Add(appointment);
                }
            }

            AppointmentsDGV.DataSource = tempApptList;
        }

        private void Appointments_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

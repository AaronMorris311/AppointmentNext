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
    public partial class AppInfo : Form
    {
        private bool isEdit;


        public AppInfo(bool isEdit)
        {
            this.isEdit = isEdit;
            InitializeComponent();

            List<string> TypeList = new List<string>();

            TypeList.Add("Scrum");
            TypeList.Add("Presentation");
            TypeList.Add("Inspection");
            TypeList.Add("First Meeting");

            AppInfoTypeDropdown.DataSource = TypeList;
            AppInfoCustDropdown.DataSource = globals.CustomerList;
            AppInfoDatePicker.CustomFormat = "hh:mm tt  MM / dd / yyyy";
            AppInfoDateTimePicker2.CustomFormat = "hh:mm tt  MM / dd / yyyy";
            AppInfoUserDropdown.DataSource = globals.UserList;

            if (isEdit)
            {
                int appointmentIndex = globals.currentIndexSelected;
                Appointment appointmentEdit = globals.AppointmentList[appointmentIndex];


                AppInfoCustDropdown.Text = globals.CustomerList.First(cust => cust.customerId == appointmentEdit.customerId).ToString();
                AppInfoNotes.Text = appointmentEdit.description;
                AppInfoDatePicker.Value = appointmentEdit.start;
                AppInfoDateTimePicker2.Value = appointmentEdit.end;
                AppInfoLocation.Text = appointmentEdit.location;
                AppInfoTitle.Text = appointmentEdit.title;
                AppInfoTypeDropdown.Text = appointmentEdit.type;
                AppInfoUserDropdown.Text = globals.UserList.First(user => user.userId == appointmentEdit.userId).ToString();
            }
        }

        private void AppInfoSaveButton_Click(object sender, EventArgs e)
        {
            TimeSpan startOfDay = new TimeSpan(8, 0, 0);
            TimeSpan endOfDay = new TimeSpan(17, 0, 0);



            if (this.Controls.OfType<TextBox>().Any(x => string.IsNullOrWhiteSpace(x.Text)))
            {
                MessageBox.Show("Please fill out all information.");
            }
            else if (AppInfoDatePicker.Value.TimeOfDay > AppInfoDateTimePicker2.Value.TimeOfDay)
            {
                MessageBox.Show("Start time needs to be before the end time of a meeting.");
            }
            else if ((!globals.BetweenTimes(AppInfoDatePicker.Value.TimeOfDay, startOfDay, endOfDay)) ||
                (!globals.BetweenTimes(AppInfoDateTimePicker2.Value.TimeOfDay, startOfDay, endOfDay)))
            {
                MessageBox.Show("Time should be between 8am and 5pm.");
            }
            else if (AppInfoDatePicker.Value.Date != AppInfoDateTimePicker2.Value.Date)
            {
                MessageBox.Show("Appointments cannot span multiple days.");
            }
            else if (isEdit == false)
            {
                Appointment newAppointment = new Appointment();

                newAppointment.appointmentId = globals.AppointmentList.OrderByDescending(appt => appt.appointmentId).Select(t => t.appointmentId).First() + 1;
                newAppointment.customerId = globals.CustomerList[AppInfoCustDropdown.SelectedIndex].customerId;
                newAppointment.description = Convert.ToString(AppInfoNotes.Text);
                newAppointment.start = AppInfoDatePicker.Value;
                newAppointment.end = AppInfoDateTimePicker2.Value;
                newAppointment.location = Convert.ToString(AppInfoLocation.Text);
                newAppointment.title = Convert.ToString(AppInfoTitle.Text);
                newAppointment.userId = globals.UserList[AppInfoUserDropdown.SelectedIndex].userId;
                newAppointment.type = AppInfoTypeDropdown.Text;

                if (globals.AppointmentList.Any(appt => appt.userId == newAppointment.userId))
                {
                    foreach (Appointment appointment in globals.AppointmentList)
                    {
                        if (appointment.userId == newAppointment.userId)
                        {
                            if (newAppointment.start.Date == appointment.start.Date)
                            {
                                if ((!(newAppointment.start < appointment.start && newAppointment.end < appointment.start))
                                    && (!(newAppointment.start > appointment.end && newAppointment.end > appointment.end)))
                                {
                                    MessageBox.Show("Current times selected overlap with times already assigned to another appointment for user selected!");
                                    return;
                                }
                            }
                        }
                    }
                }
                globals.AddAppointment(newAppointment);
                globals.AppointmentList.Add(newAppointment);
                this.DialogResult = DialogResult.OK;
            }

            else if (isEdit == true)
            {
                int appointmentIndex = globals.currentIndexSelected;
                Appointment oldAppointment = globals.AppointmentList[appointmentIndex];
                Appointment appointmentEdit = new Appointment(); 

                appointmentEdit.appointmentId = oldAppointment.appointmentId;
                appointmentEdit.customerId = globals.CustomerList[AppInfoCustDropdown.SelectedIndex].customerId;
                appointmentEdit.description = Convert.ToString(AppInfoNotes.Text);
                appointmentEdit.start = AppInfoDatePicker.Value;
                appointmentEdit.end = AppInfoDateTimePicker2.Value;
                appointmentEdit.location = Convert.ToString(AppInfoLocation.Text);
                appointmentEdit.title = Convert.ToString(AppInfoTitle.Text);
                appointmentEdit.userId = globals.UserList[AppInfoUserDropdown.SelectedIndex].userId;
                appointmentEdit.type = AppInfoTypeDropdown.Text;

                if (globals.AppointmentList.Any(appt => appt.userId == appointmentEdit.userId))
                {

                    foreach (Appointment appointment in globals.AppointmentList)
                    {
                        if ((appointment.userId == appointmentEdit.userId && appointment.appointmentId != appointmentEdit.appointmentId))
                        {
                            if ((appointmentEdit.start.Date == appointment.start.Date))

                               if((IsBetweenTwoDates(appointmentEdit.start, appointment.start, appointment.end)) || (IsBetweenTwoDates(appointmentEdit.end, appointment.start, appointment.end)))
                                {
                                    MessageBox.Show("Current times selected overlap with times already assigned to another appointment for user selected!");
                                    return;
                                }
                                else continue;
                        }
                        else continue;
                    }
                 
                }

                globals.AppointmentList[appointmentIndex] = appointmentEdit;
                globals.UpdateAppointment(appointmentEdit);
                this.DialogResult = DialogResult.OK;

            }

        }

        public bool IsBetweenTwoDates(DateTime dt, DateTime start, DateTime end) { return dt >= start && dt <= end; }

        private void AppInfoCancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

using AaronMorris_C969_Task1.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows.Forms;


namespace AaronMorris_C969_Task1.Forms
{
    public partial class Customers : Form
    {
        public Customers()
        {
            InitializeComponent();
            globals.currentIndexSelected = -1;
            CustomerDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // TODO customers.ListChanged += updatedatabase;
            CustomerDGV.DataSource = globals.CustomerList;
        }

        //TODO: event to update database in SQL
        private void updatedatabase(object sender, ListChangedEventArgs e)
        {

            throw new NotImplementedException();
        }


        private void ModifyCustButton_Click(object sender, EventArgs e)
        {
            if (globals.currentIndexSelected > -1)
            {
                CustomerInfo customerInfo = new CustomerInfo(globals.CustomerList[globals.currentIndexSelected]);
                if (customerInfo.ShowDialog() == DialogResult.OK)
                {
                    CustomerDGV.ClearSelection();
                    globals.ResetSelections();
                }
            }
            else
            {
                MessageBox.Show("Nothing Selected!");
            }
        }

        private void AddCustButton_Click(object sender, EventArgs e)
        {
            CustomerInfo customerInfo = new CustomerInfo();
            customerInfo.ShowDialog();
            globals.currentIndexSelected = -1;
        }

        private void CloseCustButton_Click(object sender, EventArgs e)
        {
            globals.currentIndexSelected = -1;
            this.DialogResult = DialogResult.Cancel;
        }

        private void CustomerDGV_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            CustomerDGV.ClearSelection();
        }

        private void CustomerDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            globals.currentIndexSelected = e.RowIndex;
            if (globals.currentIndexSelected > -1)
            {
                CustomerInfo customerInfo = new CustomerInfo(globals.CustomerList[globals.currentIndexSelected]);
                if (customerInfo.ShowDialog() == DialogResult.OK)
                {
                    CustomerDGV.ClearSelection();
                    globals.ResetSelections();
                }
            }
        }


        private void CustomerDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            globals.currentIndexSelected = e.RowIndex;
        }

        private void DeleteCustButton_Click(object sender, EventArgs e)
        {
            if (globals.currentIndexSelected > -1)
            {
                if (globals.AppointmentList.Any(appt => appt.customerId == globals.CustomerList[globals.currentIndexSelected].customerId))
                {
                    MessageBox.Show("This customer is assigned to an appointment. Please remove this customer from all appointments before deleting.", "Active Customer Selected!");
                }
                else
                {
                    int currentAddressId = globals.CustomerList[globals.currentIndexSelected].addressId;
                    int currentCityId = globals.AddressList.First(addr => addr.addressId == currentAddressId).cityId;
                    int currentCountryId = globals.CityList.First(city => city.cityId == currentCityId).countryId;

                    globals.DeleteCustomer(globals.CustomerList[globals.currentIndexSelected]);
                    globals.CustomerList.Remove(globals.CustomerList[globals.currentIndexSelected]);
                    globals.currentIndexSelected = -1;

                    if (globals.CustomerList.Any(cust => cust.addressId == currentAddressId))
                    { 

                    }
                    else
                    {
                        globals.DeleteAddress(globals.AddressList.First(addr => addr.addressId == currentAddressId));
                        globals.AddressList.Remove(globals.AddressList.First(addr => addr.addressId == currentAddressId));
                    }

                    if(globals.AddressList.Any(addr => addr.cityId == currentCityId))
                    {

                    }
                    else
                    {
                        globals.DeleteCity(globals.CityList.First(city => city.cityId == currentCityId));
                        globals.CityList.Remove(globals.CityList.First(city => city.cityId == currentCityId));
                    }

                    if(globals.CityList.Any(city => city.countryId == currentCountryId))
                    {

                    }
                    else
                    {
                        globals.DeleteCountry(globals.CountryList.First(country => country.countryId == currentCountryId));
                        globals.CountryList.Remove(globals.CountryList.First(country => country.countryId == currentCountryId));
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a customer to delete.", "Nothing Selected!");
            }
        }
    }
}

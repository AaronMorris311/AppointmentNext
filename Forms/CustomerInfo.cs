using AaronMorris_C969_Task1.Models;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;


namespace AaronMorris_C969_Task1.Forms
{
    public partial class CustomerInfo : Form
    {

        Customer _customer;
        bool isEdit;
        public CustomerInfo()
        {
            _customer = new Customer();
            isEdit = false;
            InitializeComponent();

            _customer.customerId = globals.CustomerList.OrderByDescending(cust => cust.customerId).Select(t => t.customerId).First() + 1;
            CustIDTextbox.Text = _customer.customerId.ToString();
        }

        public CustomerInfo(Customer customer)
        {
            _customer = customer;
            isEdit = true;
            InitializeComponent();


            if (_customer.customerId > 0)
            {
                CustIDTextbox.Text = _customer.customerId.ToString();
                CustNameTextbox.Text = _customer.customerName;
                globals.currentAddress = globals.AddressList.First(addr => addr.addressId == _customer.addressId);
                globals.currentCity = globals.CityList.First(city => city.cityId == globals.currentAddress.cityId);
                globals.currentCountry = globals.CountryList.First(cntry => cntry.countryId == globals.currentCity.countryId);



                CustAddrTextbox.Text = globals.currentAddress.address;
                CustAddr2Textbox.Text = globals.currentAddress.address2;
                CustPostalTextbox.Text = globals.currentAddress.postalCode;
                CustPhoneTextbox.Text = globals.currentAddress.phone;
                CustCountryTextbox.Text = globals.currentCountry.name;
                CustCityTextbox.Text = globals.currentCity.name;
            }
            else
            {
                MessageBox.Show("Please select a customer.", "Nothing Selected!");
            }
        }

        private void CustInfoCancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void CustInfoSaveButton_Click(object sender, EventArgs e)
        {
            if (this.Controls.OfType<TextBox>().Any(x => string.IsNullOrWhiteSpace(x.Text)))
            {
                MessageBox.Show("Please fill out all information.");
                return;
            }
            else if (globals.currentAddress != null && globals.currentCity != null && globals.currentCountry != null && !isEdit)
            {
                _customer.customerName = CustNameTextbox.Text;
                _customer.addressId = globals.currentAddress.addressId;

                if (globals.countryExists == false)
                {
                    globals.AddCountry(globals.currentCountry);
                    globals.CountryList.Add(globals.currentCountry);
                }
                else
                {

                }

                if (globals.cityExists)
                {
                    if(globals.currentCity.countryId == globals.currentCountry.countryId)
                    {

                    }
                    else
                    {
                        globals.currentCity.cityId = globals.CityList.OrderByDescending(cty => cty.cityId).Select(t => t.cityId).First() + 1;
                        globals.currentCity.countryId = globals.currentCountry.countryId;
                        globals.AddCity(globals.currentCity);
                    }
                            
                }
                else
                {
                    globals.currentCity.countryId = globals.currentCountry.countryId;
                    globals.AddCity(globals.currentCity);
                    globals.CityList.Add(globals.currentCity);
                }

                if (globals.addressExists)
                {
                    if(globals.currentAddress.cityId == globals.currentCity.cityId)
                    {

                    }
                    else
                    {
                        globals.currentAddress.addressId = globals.AddressList.OrderByDescending(addr => addr.addressId).Select(t => t.addressId).First() + 1;
                        globals.currentAddress.cityId = globals.currentCity.cityId;
                        _customer.addressId = globals.currentAddress.addressId;
                        globals.AddAddress(globals.currentAddress);
                    }
                }
                else
                {

                    //if (globals.cityExists == false)
                    //{

                    //}
                    if (globals.addressExists == false)
                    {
                        globals.currentAddress.cityId = globals.currentCity.cityId;
                        _customer.addressId = globals.currentAddress.addressId;
                        globals.AddAddress(globals.currentAddress);
                        globals.AddressList.Add(globals.currentAddress);
                    }

                    globals.CustomerList.Add(_customer);
                    globals.AddCustomer(_customer);
                }
                globals.ResetSelections();
                this.DialogResult = DialogResult.OK;
            }
            else if (isEdit)
            {

                _customer.customerName = CustNameTextbox.Text;
                globals.UpdateCountry(globals.currentCountry);
                globals.UpdateCity(globals.currentCity);
                globals.UpdateAddress(globals.currentAddress);
                globals.UpdateCustomer(_customer);

                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Please be sure to fill out Address, City, and Country.", "Missing Information!");
            }
        }

        private void EditCountryBtn_Click(object sender, EventArgs e)
        {
            Form CountryForm = new CountryForm();
            if (CountryForm.ShowDialog() == DialogResult.OK)
            {
                CustCountryTextbox.Text = globals.currentCountry.name;
            }
        }

        private void EditAddressBtn_Click(object sender, EventArgs e)
        {
            Form AddressForm = new AddressForm();
            if (AddressForm.ShowDialog() == DialogResult.OK)
            {
                CustAddrTextbox.Text = globals.currentAddress.address;
                CustAddr2Textbox.Text = globals.currentAddress.address2;
                CustPostalTextbox.Text = globals.currentAddress.postalCode;
                CustPhoneTextbox.Text = globals.currentAddress.phone;
            }
        }

        private void EditCityBtn_Click(object sender, EventArgs e)
        {
            Form CityForm = new CityForm();
            if (CityForm.ShowDialog() == DialogResult.OK)
            {
                CustCityTextbox.Text = globals.currentCity.name;
            }
        }
    }
}



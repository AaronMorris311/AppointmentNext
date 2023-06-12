using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AaronMorris_C969_Task1.Models;

namespace AaronMorris_C969_Task1
{
    public partial class AddressForm : Form
    {
        public AddressForm()
        {
            InitializeComponent();

            if (globals.currentAddress != null)
            {
                CustAddrTextbox.Text = globals.currentAddress.address;
                CustAddr2Textbox.Text = globals.currentAddress.address2;
                CustPostalTextbox.Text = globals.currentAddress.postalCode;
                CustPhoneTextbox.Text = globals.currentAddress.phone;

            }
        }

        private void CustInfoSaveButton_Click(object sender, EventArgs e)
        {
            Address address = new Address();
            address.address = CustAddrTextbox.Text;
            address.address2 = CustAddr2Textbox.Text;
            address.phone = CustPhoneTextbox.Text;
            address.postalCode = CustPostalTextbox.Text;

            if (this.Controls.OfType<TextBox>().Any(x => string.IsNullOrWhiteSpace(x.Text)))
            {
                MessageBox.Show("Please fill out all information.");
                return;
            }
            else if (address.postalCode.Length > 10 || address.phone.Length > 20)
            {
                MessageBox.Show("Postal code or phone number too long.");
                return;
            }
            else if (globals.AddressList.Where(addr => addr.ToString().ToLower() == address.ToString().ToLower()).Any())
            {
                globals.currentAddress = globals.AddressList.Where(addr => addr.ToString().ToLower() == address.ToString().ToLower()).First();
                address = globals.currentAddress;
                globals.addressExists = true;
            }
            else if (globals.currentAddress != null)
            {
                if (globals.currentAddress.addressId > 0)
                {
                    globals.addressExists = false;

                    globals.currentAddress.address = CustAddrTextbox.Text;
                    globals.currentAddress.address2 = CustAddr2Textbox.Text;
                    globals.currentAddress.phone = CustPhoneTextbox.Text;
                    globals.currentAddress.postalCode = CustPostalTextbox.Text;

                    globals.UpdateAddress(globals.currentAddress);
                }
            }
            else
            {
                globals.addressExists = false;
                address.addressId = globals.AddressList.OrderByDescending(addr => addr.addressId).Select(t => t.addressId).First() + 1;
                globals.currentAddress = address;

            }
            this.DialogResult = DialogResult.OK;
        }

        private void CustInfoCancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}

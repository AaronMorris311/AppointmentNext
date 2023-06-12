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

namespace AaronMorris_C969_Task1.Forms
{
    public partial class CountryForm : Form
    {
        public CountryForm()
        {
            InitializeComponent();

            if (globals.currentCountry != null)
            {
                CustCountryTextbox.Text = globals.currentCountry.name;
            }
        }

        private void CntryCnclBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void CntrySaveBtn_Click(object sender, EventArgs e)
        {
            if (this.Controls.OfType<TextBox>().Any(x => string.IsNullOrWhiteSpace(x.Text)))
            {
                MessageBox.Show("Please fill out all information.");
                return;
            }
            else if (globals.CountryList.Where(cnty => cnty.name.ToLower() == CustCountryTextbox.Text.ToLower()).Any())
            {
                globals.currentCountry = globals.CountryList.Where(country => country.name.ToLower() == CustCountryTextbox.Text.ToLower()).First();
                globals.countryExists = true;
            }
            else if (globals.currentCountry != null)
            {
                if (globals.currentCountry.countryId > 0)
                {
                    globals.countryExists = false;
                    globals.currentCountry.name = CustCountryTextbox.Text;
                    globals.UpdateCountry(globals.currentCountry);
                }
            }
            else
            {
                globals.countryExists = false;
                Country country = new Country();
                country.name = CustCountryTextbox.Text;
                country.countryId = globals.CountryList.OrderByDescending(cntry => cntry.countryId).Select(t => t.countryId).First() + 1;

                globals.currentCountry = country;

            }

            this.DialogResult = DialogResult.OK;
        }
    }
}

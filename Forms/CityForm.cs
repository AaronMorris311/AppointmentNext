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
    public partial class CityForm : Form
    {
        public CityForm()
        {
            InitializeComponent();

            if (globals.currentCity != null)
            {
                CustCityTextbox.Text = globals.currentCity.name;
            }
        }

        private void CustInfoSaveButton_Click(object sender, EventArgs e)
        {
            if (this.Controls.OfType<TextBox>().Any(x => string.IsNullOrWhiteSpace(x.Text)))
            {
                MessageBox.Show("Please fill out all information.");
                return;
            }
            else if (globals.CityList.Where(city => city.name.ToLower() == CustCityTextbox.Text.ToLower()).Any())
            {

                globals.currentCity = globals.CityList.Where(city => city.name.ToLower() == CustCityTextbox.Text.ToLower()).First();
                globals.cityExists = true;
            }
            else if (globals.currentCity != null)
            {
                if (globals.currentCity.cityId > 0)
                {
                    globals.countryExists = false;
                    globals.currentCity.name = CustCityTextbox.Text;
                    globals.UpdateCity(globals.currentCity);
                }
            }
            else
            {
                globals.cityExists = false;
                City city = new City();
                city.name = CustCityTextbox.Text;
                city.cityId = globals.CityList.OrderByDescending(cty => cty.cityId).Select(t => t.cityId).First() + 1;

                globals.currentCity = city;
            }
            this.DialogResult = DialogResult.OK;
        }

        private void CustInfoCancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}

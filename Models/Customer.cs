using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AaronMorris_C969_Task1.Models
{
    public class Customer
    {
        public int customerId { get; set; }
        public string customerName { get; set; }
        public int addressId { get; set; }

        public bool active { get; set; }

        public override string ToString()
        {
            return customerName;
        }
        public string addressToString
        {
            get
            {
                if (addressId > 0)
                {
                   return globals.AddressList.Where(addr => addr.addressId == customerId).First().ToString();
                    //return globals.GetAddressById(addressId).ToString();

                }
                else
                {
                    return string.Empty;
                }
            }
        }
    }
}

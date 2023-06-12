using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AaronMorris_C969_Task1.Models
{
    class Address
    {
        public int addressId { get; set; }
        public string address { get; set; }
        public string address2 { get; set; }
        public string postalCode { get; set; }
        public string phone { get; set; }

    public int cityId { get; set; }

        public override string ToString()
        {
            return address + " " + address2 + ", " + phone + ", "+ postalCode;
        }

    }
}

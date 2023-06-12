using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AaronMorris_C969_Task1.Models
{
    class Appointment
    {
        public int appointmentId { get; set; }
        public int customerId { get; set; }
        public int userId { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string location { get; set; }
        public string type { get; set; }
        public DateTime start { get; set; }
        public DateTime end { get; set; }
        public string customer
        {
            get
            {
                if(customerId > 0)
                {
                    return globals.GetCustomerById(customerId).customerName;
                }
                else
                {
                    return string.Empty;
                }
            }
        }
        public string user
        {
            get
            {
                if(userId > 0)
                {
                    return globals.GetUserById(userId).userName;
                }
                else
                {
                    return string.Empty;
                }
            }
        }
    }
}

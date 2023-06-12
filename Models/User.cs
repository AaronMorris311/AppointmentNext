using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AaronMorris_C969_Task1.Models
{
    public class User
    {
        public int userId { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public bool active { get; set; }

        public override string ToString()
        {
            return userName;
        }
    }
}

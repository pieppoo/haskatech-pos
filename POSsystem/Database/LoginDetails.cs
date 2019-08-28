using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSsystem.Database
{
    public class LoginDetails
    {
        public int id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string name { get; set; }
        public string status_code { get; set; }
        public string lastlogin { get; set; }
        public string user_role { get; set; }

    }
}

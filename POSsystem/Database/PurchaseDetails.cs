using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSsystem.Database
{
    public class PurchaseDetails
    {
        public int id { get; set; }
        public int itemid { get; set; }
        public int purchase_qty { get; set; }
        public string purchase_unit { get; set; }
        public double purchase_price { get; set; }
        public int qty_pcs_in_container { get; set; }
        public string pcs_unit { get; set; }
        public int total_in_pcs { get; set; }
        public DateTime Created_datetime { get; set; }
        public DateTime updated_datetime { get; set; }

    }
}

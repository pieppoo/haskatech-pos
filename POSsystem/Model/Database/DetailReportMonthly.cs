using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSsystem.Model.Database
{
    public class DetailReportMonthly
    {
        public int itemid { get; set; }
        public string item_name { get; set; }
        public int totalQTY { get; set; }
        public int pcsqty { get; set; }
        public int subtotal { get; set; }
        public int discount { get; set; }
        public int grandtotal { get; set; }
        public string unit_bulk { get; set; }
        public string unit_pcs { get; set; }

    }
}

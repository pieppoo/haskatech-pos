using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSsystem.Model
{
    public class SalesDetailReportDetails
    {
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public DateTime DateRange { get; set; }
       
        public string SubTotal { get; set; }
        public string Discount { get; set; }
        public string additional_discount { get; set; }
        public string GrandTotal { get; set; }

        public List<SaleDetail> SaleDetails { get; set; }

        public class SaleDetail
        {
            public int itemid { get; set; }
            public string item_name { get; set; }
            public string subTotal { get; set; }
            public string discount { get; set; }
            public string total { get; set; }
            public string totalQTY { get; set; }
            public string pcsqty { get; set; }
            public string unit_bulk { get; set; }
            public string unit_pcs { get; set; }
        }
    }
}

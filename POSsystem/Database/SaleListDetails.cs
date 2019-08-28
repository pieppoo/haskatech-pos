using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSsystem.Database
{
    public class SaleListDetails
    {
        public int id { get; set; }
        public int historyid { get; set; }
        public int itemid { get; set; }
        public int qtysale { get; set; }
        public int priceperitem { get; set; }
        public int totalprice { get; set; }
        public string Unitsale { get; set; }
    }
}

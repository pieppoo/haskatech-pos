using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSsystem.Database
{
    public class SaleItemsDetail
    {
        public int itemid { get; set; }
        public int qtysale { get; set; }
        public string unitsale { get; set; }
        public int priceperitem { get; set; }
        public int originaltotal { get; set; }
        public int discount { get; set; }
        public int totalprice { get; set; }
    }
}

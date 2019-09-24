using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSsystem.Database
{
    public class SaleHistoryDetails
    {
        public int id { get; set; }
        public DateTime datesale { get; set; }
        public int totalsale { get; set; }
        public int payment_mode { get; set; }
        public string remark { get; set; }
        public int discount { get; set; }
        public int originaltotal { get; set; }
        public string username { get; set; }
        public string cardno { get; set; }
        public string cardreference { get; set; }
        public string guid { get; set; }
        public int balanceamt { get; set; }
    }
}

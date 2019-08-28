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
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSsystem.Database
{
    public class SearchHistoryFilter
    {
        public int? payment_mode { get; set; }
        public DateTime? dateFrom { get; set; }
        public DateTime? dateTo { get; set; }
    }
}

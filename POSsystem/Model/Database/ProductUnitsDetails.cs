using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSsystem.Model.Database
{
    public class ProductUnitsDetails
    {
        public int id { get; set; }
        public int itemid { get; set; }
        public int seq { get; set; }
        public string unitcode { get; set; }
        public int qty { get; set; }
        public string pcsflag { get; set; }
    }
}

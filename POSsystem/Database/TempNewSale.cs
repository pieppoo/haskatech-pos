using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSsystem.Database
{
    public class TempNewSale
    {
        
        public int item_id { get; set; }
        public int sell_qty { get; set; }
        public string sell_unit { get; set; }
        public double sell_price { get; set; }
        public string Barcodeno { get; set; }
    }
}

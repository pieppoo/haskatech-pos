using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSsystem.Database
{
    public class ProductDetails
    {
        public int id { get; set; }
        public int brand_id { get; set; }
        public string name { get; set; }
        public int Stock { get; set; }
        public string unit_bulk { get; set; }
        public string unit_pcs { get; set; }
        public int qty_pcs_in_container { get; set; }
        public string brandname { get; set; }
        public int prod_catetogry { get; set; }
        public string UnitRelated { get; set; }
    }
}

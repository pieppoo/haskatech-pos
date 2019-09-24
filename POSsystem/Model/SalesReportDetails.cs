using System;
using System.Collections.Generic;

namespace POSsystem.Model
{
    public class SalesReportDetails
    {
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public DateTime DateRange { get; set; }

        public int TrxCount { get; set; }
        public int CardTrxCount { get; set; }
        public int CashTrxCount { get; set; }

        public string SubTotal { get; set; }
        public string Discount { get; set; }
        public string GrandTotal { get; set; }

        public List<SaleDetail> SaleDetails { get; set; }

        public class SaleDetail
        {
            public DateTime Timestamp { get; set; }
            public string PaymentMode { get; set; }
            public string SubTotal { get; set; }
            public string Discount { get; set; }
            public string Total { get; set; }
            public string CardNo { get; set; }
            public string CardRef { get; set; }
        }
    }
}

using POSsystem.Common;
using POSsystem.Database;
using POSsystem.Model;
using POSsystem.Repository;
using POSsystem.Views;
using POSsystem.Views.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSsystem.Views
{
    public partial class Report : BaseForm
    {
        public LoginDetails userdata { get; set; }

        private SaleHistoryRepository saleHistoryRepository = new SaleHistoryRepository();
        private PaymentModeRepository paymentModeRepository = new PaymentModeRepository();
        private SaleListRepository saleListRepository = new SaleListRepository();
        public Report()
        {
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            string curryear = DateTime.Now.Year.ToString();

            lbyear.Text = "Tahun : " + curryear;

            SortedDictionary<int, string> Monthcache = new SortedDictionary<int, string>
            {
                {0, "---Pilih Bulan---" },
                {1, "Januari" },
                {2, "Februari" },
                {3, "Maret" },
                {4, "April" },
                {5, "Mei" },
                {6, "Juni" },
                {7, "Juli" },
                {8, "Agustus" },
                {9, "September" },
                {10, "Oktober" },
                {11, "November" },
                {12, "Desember" }

            };


            cbmonthlyreport.DataSource = new BindingSource(Monthcache, null);
            cbmonthlyreport.DisplayMember = "Value";
            cbmonthlyreport.ValueMember = "Key";

            cbdetailReport.DataSource = new BindingSource(Monthcache, null);
            cbdetailReport.DisplayMember = "Value";
            cbdetailReport.ValueMember = "Key";

        }

        private void printmonthlyreport_Click(object sender, EventArgs e)
        {
            int selectedmonth = (int)cbmonthlyreport.SelectedValue; 
            var Monthlysaledetail = saleHistoryRepository.Getbymonth(selectedmonth);
            var PaymentModeList = paymentModeRepository.GetAll();
            int cashtrxcount = 0;
            int cardtrxcount = 0;
            int subtotal = 0;
            int discount = 0;
            int grandtotal = 0;

            var saleDetails = new List<SalesReportDetails.SaleDetail>();

            foreach (var item in Monthlysaledetail)
            {
                var paymode = PaymentModeList.FirstOrDefault(x => x.id == item.payment_mode);

                if (paymode.description == "Tunai")
                    cashtrxcount += 1;
                else
                    cardtrxcount += 1;

                subtotal = subtotal + item.originaltotal;
                discount = discount + item.discount;
                grandtotal = grandtotal + item.totalsale;

                saleDetails.Add(new SalesReportDetails.SaleDetail
                {
                    Timestamp = item.datesale,
                    PaymentMode = paymode.description,
                    SubTotal = Utils.ToRupiah(item.originaltotal),
                    Discount = Utils.ToRupiah(item.discount),
                    Total = Utils.ToRupiah(item.totalsale),
                    CardNo = item.cardno,
                    CardRef = item.cardreference
                });
            }

            var reportData = new SalesReportDetails();
            reportData.Title = "Toko In Sadar";
            reportData.SubTitle = "Laporan Bulanan Penjualan";
            reportData.DateRange = new DateTime(DateTime.Now.Year, selectedmonth, 1);
            reportData.TrxCount = Monthlysaledetail.Count;
            reportData.CardTrxCount = cardtrxcount;
            reportData.CashTrxCount = cashtrxcount;
            reportData.SubTotal = Utils.ToRupiah(subtotal);
            reportData.Discount = Utils.ToRupiah(discount);
            reportData.GrandTotal = Utils.ToRupiah(grandtotal);
            reportData.SaleDetails = saleDetails;

            var gen = new ReportGenerator();
            gen.ReportData = reportData;
            gen.GenerateReport();
        }

        private void printdetailreport_Click(object sender, EventArgs e)
        {
            int selectedmonth = (int)cbdetailReport.SelectedValue;
            var DetailReportList = saleListRepository.GetReportDetail(selectedmonth);
            var Monthlysaledetail = saleHistoryRepository.Getbymonth(selectedmonth);
            int subtotal = 0;
            int discount = 0;
            int additional_discount = 0;
            int grandtotal = 0;

            //get additional discoutn from salehistorytable
            foreach (var item in Monthlysaledetail)
            {
                additional_discount = discount + item.discount;
            }
            //---------------------------------------------------------

            var saleDetails = new List<SalesDetailReportDetails.SaleDetail>();

            foreach (var item in DetailReportList)
            {

                subtotal = subtotal + item.subtotal;
                discount = discount + item.discount;
                grandtotal = grandtotal + item.grandtotal;

                saleDetails.Add(new SalesDetailReportDetails.SaleDetail
                {
                    item_name = item.item_name,
                    totalQTY = item.totalQTY.ToString(),
                    subTotal = Utils.ToRupiah(item.subtotal),
                    discount = Utils.ToRupiah(item.discount),
                    total = Utils.ToRupiah(item.grandtotal),
                    pcsqty = item.pcsqty.ToString(),
                    unit_bulk = item.unit_bulk,
                    unit_pcs = item.unit_pcs,
                 });
            }

            var reportData = new SalesDetailReportDetails();
            reportData.Title = "Toko In Sadar";
            reportData.SubTitle = "Detail Laporan Bulanan";
            reportData.DateRange = new DateTime(DateTime.Now.Year, selectedmonth, 1);
            reportData.SubTotal = Utils.ToRupiah(subtotal);
            reportData.Discount = Utils.ToRupiah(discount);
            reportData.additional_discount = Utils.ToRupiah(additional_discount);
            reportData.GrandTotal = Utils.ToRupiah(grandtotal);
            reportData.SaleDetails = saleDetails;

            var gen = new ReportDetailsGenerator();
            gen.ReportData = reportData;
            gen.GenerateReport();
        }
    }
}

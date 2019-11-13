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
using System.Diagnostics;
using System.Drawing;
using System.IO;
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

            if (string.IsNullOrEmpty(Properties.Settings.Default.reportFolder))
            {
                var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "report");
                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);

                tbReportFolder.Text = Properties.Settings.Default.reportFolder = path;
                Properties.Settings.Default.Save();
            }
            else
            {
                if (!Directory.Exists(Properties.Settings.Default.reportFolder))
                    Directory.CreateDirectory(Properties.Settings.Default.reportFolder);

                tbReportFolder.Text = Properties.Settings.Default.reportFolder;
            }
        }

        private async void printmonthlyreport_Click(object sender, EventArgs e)
        {
            if (cbmonthlyreport.SelectedIndex == 0)
                return;

            var loadingDialog = new LoadingDialog();
            loadingDialog.Message = "Memproses laporan...";
            loadingDialog.TimeoutSec = 5;
            int selectedmonth = (int)cbmonthlyreport.SelectedValue;

            var compileReportTask = Task.Run(async() =>
            {
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

                await Task.Delay(1000);

                Invoke((MethodInvoker)delegate {
                    loadingDialog.EnableClosingForm();
                    loadingDialog.Close();
                });

                return reportData;
            });

            try
            {
                loadingDialog.ShowDialog(this);
                var result = await compileReportTask;

                var gen = new ReportGenerator();
                gen.ReportData = result;
                gen.ReportFolder = Properties.Settings.Default.reportFolder;
                gen.GenerateReport();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           
        }

        private async void printdetailreport_Click(object sender, EventArgs e)
        {
            if (cbdetailReport.SelectedIndex == 0)
                return;

            var loadingDialog = new LoadingDialog();
            loadingDialog.Message = "Memproses laporan...";
            loadingDialog.TimeoutSec = 5;
            int selectedmonth = (int)cbdetailReport.SelectedValue;

            var compileTask = Task.Run(async() => 
            {
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

                await Task.Delay(1000);

                Invoke((MethodInvoker)delegate {
                    loadingDialog.EnableClosingForm();
                    loadingDialog.Close();
                });

                return reportData;
            });

            loadingDialog.ShowDialog(this);
            var result = await compileTask;
            
            var gen = new ReportDetailsGenerator();
            gen.ReportData = result;
            gen.ReportFolder = Properties.Settings.Default.reportFolder;
            gen.GenerateReport();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {

            if (keyData == (Keys.Escape))
            {
                if (MessageBox.Show("Anda yakin keluar dari halaman Laporan ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void tbReportFolder_DoubleClick(object sender, EventArgs e)
        {
            Process.Start(@tbReportFolder.Text);
        }
    }
}

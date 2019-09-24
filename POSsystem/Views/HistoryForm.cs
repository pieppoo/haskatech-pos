﻿using POSsystem.Common;
using POSsystem.Database;
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

namespace POSsystem
{
    public partial class HistoryForm : BaseForm
    {
        private SaleHistoryRepository saleHistoryRepository = new SaleHistoryRepository();
        private PaymentModeRepository paymentModeRepository = new PaymentModeRepository();
        public LoginDetails userdata { get; set; }
        public List<SaleHistoryDetails> SaleHistoryList { get; set; }
        public List<PaymentModeDetails> PaymentModeList { get; set; }
        public HistoryForm()
        {
            InitializeComponent();
        }

        public void LoadData()
        {
            int totalingv = 0;

            try
            {
                SaleHistoryList = saleHistoryRepository.GetbyNowDate().OrderByDescending(x => x.id).ToList();
                PaymentModeList = paymentModeRepository.GetAll().ToList();

                gvhistory.Rows.Clear();

                foreach (var item in SaleHistoryList)
                {
                    var paymode = PaymentModeList.FirstOrDefault(x => x.id == item.payment_mode);

                    gvhistory.Rows.Add(
                        item.id,
                        item.datesale.ToString("dd-MM-yyyy HH:mm:ss"),
                        paymode != null ? paymode.description : " - ",
                        Utils.ToRupiah(item.originaltotal),
                        Utils.ToRupiah(item.discount),
                        Utils.ToRupiah(item.totalsale)
                        );
                    totalingv += item.totalsale;

                }

                var cbpaymode = PaymentModeList;
                cbpaymode.Insert(0, new PaymentModeDetails { id = -1, description = "--- Pilih tipe pembayaran ---" });
                
                cbpaymentmode.DataSource = new BindingSource(PaymentModeList, null);
                cbpaymentmode.DisplayMember =  "description" ;
                cbpaymentmode.ValueMember = "id";

                tbtotalgv.Text = Utils.ToRupiahWithSymbol(totalingv);
            }
            catch (Exception ex)
            {
                var errMsg = "Details : " + ex.Message + Environment.NewLine + "Stacktrace : " + ex.StackTrace;
                MessageBox.Show(errMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btpenjualanbaru_Click(object sender, EventArgs e)
        {
            var form = new POSSalesEntry();
            form.userdata = userdata;
            Hide();
            form.ShowDialog();
            Show();
            LoadData();
        }

        private void HistoryForm_Load(object sender, EventArgs e)
        {
            dtpfrom.Value = DateTime.Now;
            dtpto.Value = DateTime.Now;
            LoadData();

            dtpfrom.CustomFormat = dtpto.CustomFormat = " ";
            if (userdata.user_role == "admin")
                btfinditem.Visible = false;

        }

        private void gvhistory_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = Convert.ToInt32(gvhistory.Rows[e.RowIndex].Cells[0].Value);
            var history = SaleHistoryList.FirstOrDefault(x => x.id == id);

            if (history != null)
            {
                var form = new SaleDetail();
                form.SaleHistoryData = history;
                Hide();
                form.ShowDialog();
                Show();
                LoadData();
            }
        }


        private void dtpfrom_ValueChanged(object sender, EventArgs e)
        {
            dtpfrom.CustomFormat = "dd-MMM-yyyy";
            dtpto.MinDate = dtpfrom.Value;

            if (!dtpto.Enabled)
            {
                dtpto.Value = dtpfrom.Value;
                dtpto.Enabled = true;
            }
        }

        private void dtpto_ValueChanged(object sender, EventArgs e)
        {
            dtpto.CustomFormat = "dd-MMM-yyyy";
        }

        private void btfinditem_Click(object sender, EventArgs e)
        {
            var form = new ManageProduct();
            form.userdata = userdata;
            //Hide();
            form.ShowDialog();
            //Show();
        }

        private void pbsearch_Click(object sender, EventArgs e)
        {
            var searchinfo = new SearchHistoryFilter();
            int totalingv = 0;

            if ((int)cbpaymentmode.SelectedValue != -1)
            {
                searchinfo.payment_mode = (int)cbpaymentmode.SelectedValue;
            }

            if (!string.IsNullOrWhiteSpace(dtpfrom.CustomFormat))
                searchinfo.dateFrom = dtpfrom.Value.Date;

            if (!string.IsNullOrWhiteSpace(dtpto.CustomFormat))
                searchinfo.dateTo = dtpto.Value.Date;

            var result = saleHistoryRepository.Search(searchinfo);

            if (result != null)
            {
                gvhistory.Rows.Clear();

                foreach (var item in result)
                {
                    var pymtmode = PaymentModeList.FirstOrDefault(x => x.id == item.payment_mode);

                    gvhistory.Rows.Add(
                        item.id,
                        item.datesale,
                        pymtmode != null ? pymtmode.description : " - ",
                        Utils.ToRupiah(item.originaltotal),
                        Utils.ToRupiah(item.discount),
                        Utils.ToRupiah(item.totalsale)
                        );

                    totalingv += item.totalsale;


                }
                tbtotalgv.Text = Utils.ToRupiahWithSymbol(totalingv);
            }
        }

        private void pbreset_Click(object sender, EventArgs e)
        {
            LoadData();
            dtpto.ResetText();
            dtpfrom.ResetText();
            dtpfrom.CustomFormat = dtpto.CustomFormat = " ";
            dtpto.Enabled = false;
        }
    }
}

using POSsystem.Common;
using POSsystem.Database;
using POSsystem.Repository;
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
    public partial class AddEditSellPrice : BaseForm
    {
        public AddEditSellPrice()
        {
            InitializeComponent();
        }
        public bool Editmode { get; set; }

        private SellingPriceRepository sellingPriceRepository = new SellingPriceRepository();
        private UnitRepository unitRepository = new UnitRepository();
        private ProductRepository productRepository = new ProductRepository();

        public SellingPriceDetails SellingPriceData { get; set; }
        public ProductDetails ProductData { get; set; }
        public PurchaseDetails PurchaseData { get; set; }
        public List<ProductDetails> ProductList { get; set; }
        public List<UnitItem> UnitList { get; set; }
        public List<SellingPriceDetails> SellingPriceList { get; set; }

        private void AddEditSellPrice_Load(object sender, EventArgs e)
        {
            ProductList = productRepository.GetAll();

            if (Editmode)
            {
                UnitList = unitRepository.GetAll();
                cbunitsell.DataSource = new BindingSource(UnitList, null);
                cbunitsell.DisplayMember = "description";
                cbunitsell.ValueMember = "unitcode";
                cbunitsell.Enabled = false;

                var itemname = ProductList.FirstOrDefault(x => x.id == SellingPriceData.item_id);
                tbitemname.Text = itemname.name;
                tbsellprice.Text = SellingPriceData.sell_price.ToString();
                cbunitsell.SelectedValue = SellingPriceData.sell_unit.ToString();
                tbbarcodeno.Text = SellingPriceData.Barcodeno.ToString();
            }
            else
            {
                UnitList = unitRepository.GetAll(ProductData.id);
                cbunitsell.DataSource = new BindingSource(UnitList, null);
                cbunitsell.DisplayMember = "description";
                cbunitsell.ValueMember = "unitcode";
                tbitemname.Text = ProductData.name;
            }
   
        }


        private void btsave_Click(object sender, EventArgs e)
        {
            if (tbsellprice.Value == 0)
                MessageBox.Show("Harga Jual tidak boleh nol (Rp 0)");
            else
            {
                if (Editmode)
                {
                    SellingPriceData.sell_price = Utils.ToNumbers(tbsellprice.Text);
                    SellingPriceData.sell_unit = cbunitsell.SelectedValue.ToString();
                    SellingPriceData.Barcodeno = tbbarcodeno.Text;

                    ////if (string.IsNullOrWhiteSpace(tbbarcodeno.Text))
                    ////{
                    ////    tbbarcodeno.Text = "null";
                    ////    Console.WriteLine("hai");
                    ////}

                    SellingPriceList = sellingPriceRepository.GetAll(SellingPriceData.item_id);
                    int samebarcode = 0;
                    int sameunit = 0;

                    foreach (var Item in SellingPriceList)
                    {
                        if (SellingPriceData.id != Item.id)
                        {
                            if (tbbarcodeno.Text == "")
                            {
                                samebarcode = 0;
                            }
                            else if (Item.Barcodeno == tbbarcodeno.Text)
                            {
                                samebarcode += 1;
                                break;
                            }

                            if (SellingPriceData.sell_unit == Item.sell_unit)
                            {
                                sameunit += 1;
                                break;
                            }
                        }
                    }


                    if (samebarcode > 0)
                        MessageBox.Show("Barcode yang anda masukkan telah terdaftar, silahkan masukkan barcode no lainnya");
                    else if (sameunit > 0)
                        MessageBox.Show("Harga jual untuk kemasan ini sudah ada, silahkan pilih kemasan lainnya");
                    else
                    {
                        if (sellingPriceRepository.Update(SellingPriceData))
                        {
                            MessageBox.Show("Data telah berhasil di ubah");
                            Close();
                        }
                        else
                            MessageBox.Show("Data gagal di ubah");
                    }

                    samebarcode = 0;
                }
                else
                {
                    var sellprice = new SellingPriceDetails();
                    sellprice.item_id = ProductData.id;
                    sellprice.sell_qty = 1;
                    sellprice.sell_price = Utils.ToNumbers(tbsellprice.Text);
                    sellprice.sell_unit = cbunitsell.SelectedValue.ToString();
                    sellprice.Barcodeno = tbbarcodeno.Text;

                    SellingPriceList = sellingPriceRepository.GetAll(ProductData.id);
                    int samebarcode = 0;
                    int sameunit = 0;

                    foreach (var Item in SellingPriceList)
                    {
                        if (tbbarcodeno.Text == "")
                            samebarcode = 0;
                        else if (Item.Barcodeno == tbbarcodeno.Text)
                        {
                            samebarcode = samebarcode + 1;
                            break;
                        }


                        if (sellprice.sell_unit == Item.sell_unit)
                        {
                            sameunit += 1;
                            break;
                        }

                    }

                    if (samebarcode > 0)
                        MessageBox.Show("Barcode yang anda masukkan sudah terdaftar");
                    else if (sameunit > 0)
                        MessageBox.Show("Harga jual untuk kemasan ini sudah ada, silahkan pilih kemasan lain");
                    else
                    {

                        if (sellingPriceRepository.Add(sellprice))
                        {
                            MessageBox.Show("Data baru telah berhasil di tambahkan");
                            Close();
                        }

                        else
                            MessageBox.Show("Data baru gagal ditambahkan");
                    }
                    samebarcode = 0;
                    sameunit = 0;
                }
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Escape))
            {
                if (MessageBox.Show("Apa Anda Yakin keluar tanpa menyimpan data?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void tbsellprice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                cbunitsell.Focus();
        }

        private void cbunitsell_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                tbbarcodeno.Focus();
        }

        private void tbbarcodeno_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btsave.PerformClick();
        }

    }
}

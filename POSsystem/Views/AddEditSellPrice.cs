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
            if (Editmode)
            {
                SellingPriceData.sell_price = int.Parse(tbsellprice.Text);
                SellingPriceData.sell_unit = cbunitsell.SelectedValue.ToString();
                SellingPriceData.Barcodeno = tbbarcodeno.Text;

                ////if (string.IsNullOrWhiteSpace(tbbarcodeno.Text))
                ////{
                ////    tbbarcodeno.Text = "null";
                ////    Console.WriteLine("hai");
                ////}

                SellingPriceList = sellingPriceRepository.GetAll(SellingPriceData.item_id);
                int samebarcode = 0;

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
                            samebarcode = samebarcode + 1;
                        }
                    }

                    
                }

                if (samebarcode > 0)
                    MessageBox.Show("Barcode yang anda masukkan sudah terdaftar, data gagal diubah");
                else
                {
                    if (sellingPriceRepository.Update(SellingPriceData))
                        MessageBox.Show("Data telah berhasil di ubah");
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
                sellprice.sell_price = long.Parse(tbsellprice.Text);
                sellprice.sell_unit = cbunitsell.SelectedValue.ToString();
                sellprice.Barcodeno = tbbarcodeno.Text;

                SellingPriceList = sellingPriceRepository.GetAll(ProductData.id);
                int samebarcode = 0;

                foreach (var Item in SellingPriceList)
                {
                    if (Item.Barcodeno == tbbarcodeno.Text)
                    {
                        samebarcode = samebarcode + 1;
                    }

                }

                if (samebarcode > 0)
                    MessageBox.Show("Barcode yang anda masukkan sudah terdaftar, data gagal diubah");
                else
                {

                    if (sellingPriceRepository.Add(sellprice))
                        MessageBox.Show("Data baru telah berhasil di tambahkan");
                    else
                        MessageBox.Show("Data baru gagal ditambahkan");
                }
                samebarcode = 0;
            }
            Close();
        }
    }
}

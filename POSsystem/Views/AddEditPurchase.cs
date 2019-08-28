using POSsystem.Views.Base;
using POSsystem.Database;
using POSsystem.Repository;
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
    public partial class AddEditPurchase : BaseForm
    {

        public AddEditPurchase()
        {
            InitializeComponent();
        }

        public bool Editmode { get; set; }
        private ProductRepository productRepository = new ProductRepository();
        private UnitRepository unitRepository = new UnitRepository();
        private PurchaseRepository purchaseRepository = new PurchaseRepository();
        private BrandRepository brandRepository = new BrandRepository();

        public PurchaseDetails PurchaseData { get; set; }
        public ProductDetails ProductData { get; set; }
        public List<UnitItem> UnitList { get; set; }
        public List<Brand> BrandList { get; set; }
        public List<ProductDetails> ProductList { get; set; }

        private void AddEditPurchase_Load(object sender, EventArgs e)
        {
            ProductList = productRepository.GetAll().ToList();
            BrandList = brandRepository.GetAll().ToList();
            UnitList = unitRepository.GetAll();

            cbpcsunit.DataSource = new BindingSource(UnitList, null);
            cbpcsunit.DisplayMember = "description";
            cbpcsunit.ValueMember = "unitcode";

            cbunitpurchase.DataSource = new BindingSource(UnitList, null);
            cbunitpurchase.DisplayMember = "description";
            cbunitpurchase.ValueMember = "unitcode";

            

            if (Editmode)
            {
                var Productinfo = ProductList.FirstOrDefault(x => x.id == PurchaseData.itemid);
                tbname.Text = Productinfo.name;
                tbpurchaseprice.Text = PurchaseData.purchase_price.ToString();
                numpurchaseqty.Text = PurchaseData.purchase_qty.ToString();
                numpcsincontainer.Text = PurchaseData.qty_pcs_in_container.ToString();
                tbtotal.Text = PurchaseData.total_in_pcs.ToString();

                int differentOriginalwithcurrent = (PurchaseData.purchase_qty * PurchaseData.qty_pcs_in_container) - PurchaseData.total_in_pcs;
                if (differentOriginalwithcurrent != 0)
                {
                    numpcsincontainer.ReadOnly = true;
                    numpcsincontainer.Increment = 0;
                    numpurchaseqty.ReadOnly = true;
                    numpurchaseqty.Increment = 0;
                }


            }
            else
            {
                
                var Productinfo = ProductList.FirstOrDefault(x => x.id == ProductData.id);
                //var unitbulkinfo = UnitList.FirstOrDefault(x => x.unitcode == ProductData.unit_bulk);
                //var unitpcsinfo = UnitList.FirstOrDefault(x => x.unitcode == ProductData.unit_pcs);
                tbname.Text = Productinfo.name;
                cbpcsunit.SelectedValue = ProductData.unit_pcs;
                cbunitpurchase.SelectedValue = ProductData.unit_bulk;
            }
        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            if(Editmode)
            {
                PurchaseData.purchase_price =  long.Parse(tbpurchaseprice.Text);
                PurchaseData.purchase_qty = int.Parse(numpurchaseqty.Text);
                PurchaseData.purchase_unit = cbunitpurchase.SelectedValue.ToString();
                PurchaseData.qty_pcs_in_container = int.Parse(numpcsincontainer.Text);
                PurchaseData.pcs_unit = cbpcsunit.SelectedValue.ToString();
                PurchaseData.total_in_pcs = int.Parse(tbtotal.Text);


                if (purchaseRepository.Update(PurchaseData))
                    MessageBox.Show("Data telah berhasil di ubah");
                else
                    MessageBox.Show("Data gagal di ubah");

            }
            else
            {
                var purchase = new PurchaseDetails();
                purchase.itemid = ProductData.id;
                purchase.purchase_price = long.Parse(tbpurchaseprice.Text);
                purchase.purchase_qty = int.Parse(numpurchaseqty.Text);
                purchase.purchase_unit = cbunitpurchase.SelectedValue.ToString();
                purchase.qty_pcs_in_container = int.Parse(numpcsincontainer.Text);
                purchase.pcs_unit = cbpcsunit.SelectedValue.ToString();
                purchase.total_in_pcs = int.Parse(tbtotal.Text);


                
                ProductData.Stock = int.Parse(tbtotal.Text)+ProductData.Stock;



                if (productRepository.Update(ProductData))
                {
                    if (purchaseRepository.Add(purchase))
                        MessageBox.Show("Data baru telah berhasil di tambahkan");
                    else
                        MessageBox.Show("Data baru gagal ditambahkan");
                }
                else
                    MessageBox.Show("Gagal memperbaharui stock");



            }
            Close();
        }

        private void calculatetotal()
        {
            tbtotal.Text = (numpcsincontainer.Value * numpurchaseqty.Value).ToString();

        }

        private void numQuantityAndPriceValueChanged(object sender, EventArgs e)
        {
            calculatetotal();
        }
    }
}

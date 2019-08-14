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
        public PurchaseDetails PurchaseData { get; set; }
        public ProductDetails ProductData { get; set; }
        public List<UnitItem> UnitList { get; set; }
        public List<ProductDetails> ProductList { get; set; }

        private void AddEditWarehouse_Load(object sender, EventArgs e)
        {
            ProductList = productRepository.GetAll().ToList();
            LoadUnit();

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
                tbname.Text = Productinfo.name;
            }
        }

        private void LoadUnit()
        {
            UnitList = unitRepository.GetAll();
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
                var warehouse = new PurchaseDetails();
                warehouse.itemid = ProductData.id;
                warehouse.purchase_price = long.Parse(tbpurchaseprice.Text);
                warehouse.purchase_qty = int.Parse(numpurchaseqty.Text);
                warehouse.purchase_unit = cbunitpurchase.SelectedValue.ToString();
                warehouse.qty_pcs_in_container = int.Parse(numpcsincontainer.Text);
                warehouse.pcs_unit = cbpcsunit.SelectedValue.ToString();
                warehouse.total_in_pcs = int.Parse(tbtotal.Text);

                if (purchaseRepository.Add(warehouse))
                    MessageBox.Show("Data baru telah berhasil di tambahkan");
                else
                    MessageBox.Show("Data baru gagal ditambahkan");

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

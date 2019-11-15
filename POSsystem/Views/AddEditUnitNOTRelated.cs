using POSsystem.Database;
using POSsystem.Model;
using POSsystem.Model.Database;
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
    public partial class AddEditUnitNOTRelated : BaseForm
    {
        public ProductDetails ProductData { get; set; }
        public List<UnitItem> UnitList { get; set; }
        public List<ProductUnitsDetails> ProdUnitList { get; set; }
        public ProductUnitsDetails ProdunitSelected { get; set; }
        public bool Editmode { get; set; }

        private UnitRepository unitRepository = new UnitRepository();
        private ProductUnitsRepository prodUnitsRepository = new ProductUnitsRepository();
        public AddEditUnitNOTRelated()
        {
            InitializeComponent();
        }

        private void AddEditUnitNOTRelated_Load(object sender, EventArgs e)
        {
            UnitList = unitRepository.GetAll();

            cbunitparent.DataSource = new BindingSource(UnitList, null);
            cbunitparent.DisplayMember = "description";
            cbunitparent.ValueMember = "unitcode";

            cbunitchild.DataSource = new BindingSource(UnitList, null);
            cbunitchild.DisplayMember = "description";
            cbunitchild.ValueMember = "unitcode";

            if (Editmode)
            {
                ProdUnitList = prodUnitsRepository.GetAll(ProdunitSelected.itemid);

                if (ProdunitSelected.pcsflag == "Y")
                {
                    lbunitparent.Text = "Kemasan eceran";
                    nbqty.Enabled = false;
                    lbunitchild.Visible = false;
                    cbunitchild.Visible = false;

                    cbunitparent.SelectedValue = ProdunitSelected.unitcode;

                }
                else
                {
                    lbunitparent.Text = "Kemasan besar";
                    lbunitchild.Text = "Kemasan eceran";
                    cbunitparent.SelectedValue = ProdunitSelected.unitcode;
                    nbqty.Value = ProdunitSelected.qty;

                    var pcsunit = ProdUnitList.FirstOrDefault(x => x.pcsflag == "Y");
                    cbunitchild.SelectedValue = pcsunit.unitcode;
                    cbunitchild.Enabled = false;

                }
            }
            else
            {
                ProdUnitList = prodUnitsRepository.GetAll(ProductData.id);

                lbunitparent.Text = "Kemasan besar";
                lbunitchild.Text = "Kemasan eceran";

                if (ProdUnitList.Count != 0)
                {
                    var pcsunit = ProdUnitList.FirstOrDefault(x => x.pcsflag == "Y");

                    cbunitchild.Enabled = false;
                    cbunitchild.SelectedValue = pcsunit.unitcode;

                }
                    
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Editmode)
            {
                ProdunitSelected.unitcode = cbunitparent.SelectedValue.ToString();
                ProdunitSelected.qty = (int)nbqty.Value;

                var sameunit = ProdUnitList.FirstOrDefault(x => x.unitcode == ProdunitSelected.unitcode && x.id != ProdunitSelected.id);

                if (sameunit != null)
                    MessageBox.Show("Kemasan yang anda pilih sudah terdaftar");
                else if (nbqty.Value == 0 && ProdunitSelected.pcsflag != "Y")
                    MessageBox.Show("Silahkan isi jumlah nya");
                else if (prodUnitsRepository.Update(ProdunitSelected))
                {

                    MessageBox.Show("Kemasan data berhasil di ubah");
                    Close();
                }
                else
                    MessageBox.Show("Gagal mengubah data kemasan");
            }
            else
            {
                if (ProdUnitList.Count != 0)
                {
                    var parentunit = new ProductUnitsDetails();
                    parentunit.itemid = ProductData.id;
                    parentunit.qty = (int)nbqty.Value;
                    parentunit.pcsflag = "N";
                    parentunit.unitcode = cbunitparent.SelectedValue.ToString();
                    parentunit.seq = ProdUnitList.Count + 1;

                    var sameunit = ProdUnitList.FirstOrDefault(x => x.unitcode == parentunit.unitcode);

                    if (sameunit != null)
                        MessageBox.Show("Kemasan baru yang anda masukkan sudah terdaftar");
                    else if (nbqty.Value == 0)
                        MessageBox.Show("Silahkan isi jumlah nya");
                    else if (prodUnitsRepository.Add(parentunit))
                    {
                        MessageBox.Show("Kemasan baru telah berhasil ditambahkan");
                        Close();
                    }
                    else
                        MessageBox.Show("Gagal menambahkan kemasan baru");
                }
                else
                {
                    var parentunit = new ProductUnitsDetails();
                    parentunit.itemid = ProductData.id;
                    parentunit.qty = (int)nbqty.Value;
                    parentunit.pcsflag = "N";
                    parentunit.unitcode = cbunitparent.SelectedValue.ToString();
                    parentunit.seq = 2;

                    var childunit = new ProductUnitsDetails();
                    childunit.itemid = ProductData.id;
                    childunit.qty = 0;
                    childunit.pcsflag = "Y";
                    childunit.unitcode = cbunitchild.SelectedValue.ToString();
                    childunit.seq = 1;

                    if (parentunit.unitcode == childunit.unitcode)
                        MessageBox.Show("Kemasan besar dan Kemasan eceran tidak boleh sama");
                    else if (nbqty.Value == 0)
                        MessageBox.Show("Silahkan isi jumlah nya");
                    else if(prodUnitsRepository.Addtwounits(parentunit, childunit))
                    {
                        MessageBox.Show("Kemasan baru telah berhasil ditambahkan");
                        Close();
                    }
                    else
                        MessageBox.Show("Gagal menambahkan kemasan baru");
                }
            }
        }
    }
}

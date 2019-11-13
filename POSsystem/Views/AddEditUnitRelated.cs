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
    public partial class AddEditUnitRelated : BaseForm
    {
        public ProductDetails ProductData { get; set; }
        public ProductUnitsDetails SelectedUnitData { get; set; }
        public List<UnitItem> UnitList { get; set; }
        public List<ProductUnitsDetails> productUnitsList { get; set; }

        
        public bool Editmode { get; set; }

        public int seqno = 0;
        public int maxseq = 0;
        private UnitRepository unitRepository = new UnitRepository();
        private ProductUnitsRepository productUnitsRepository = new ProductUnitsRepository();
        public AddEditUnitRelated()
        {
            InitializeComponent();
        }

        private void AddEditUnitRelated_Load(object sender, EventArgs e)
        {
            lbunitparent.Text = "Kemasan " + seqno;
            lbunitchild.Text = "Kemasan " + (seqno + 1);

            UnitList = unitRepository.GetAll();

            cbunitparent.DataSource = new BindingSource(UnitList, null);
            cbunitparent.DisplayMember = "description";
            cbunitparent.ValueMember = "unitcode";

            cbunitchild.DataSource = new BindingSource(UnitList, null);
            cbunitchild.DisplayMember = "description";
            cbunitchild.ValueMember = "unitcode";

            if(Editmode)
            {
                productUnitsList = productUnitsRepository.GetAll(SelectedUnitData.itemid).ToList();
                var childunit = productUnitsList.FirstOrDefault(x => x.seq == SelectedUnitData.seq + 1);

                cbunitparent.SelectedValue = SelectedUnitData.unitcode;
                nbqty.Value = SelectedUnitData.qty;
                cbunitchild.Enabled = false;


                if (productUnitsList.Count == SelectedUnitData.seq)
                {
                    nbqty.Enabled = false;
                    lbunitchild.Visible = false;
                    cbunitchild.Visible = false;
                    lbunitparent.Text = "Kemasan " + SelectedUnitData.seq;
                }
                else
                {
                    lbunitparent.Text = "Kemasan " + SelectedUnitData.seq;
                    lbunitchild.Text = "Kemasan " + childunit.seq;
                    cbunitchild.SelectedValue = childunit.unitcode;
                }

            }
            else
            {
                productUnitsList = productUnitsRepository.GetAll(ProductData.id).ToList();

                if (productUnitsList.Count != 0)
                {
                    maxseq = productUnitsList.Count;
                    var parentsunit = productUnitsList.FirstOrDefault(x => x.seq == seqno - 1);

                    cbunitparent.SelectedValue = parentsunit.unitcode;

                    if (seqno == 1)
                    {
                        cbunitchild.Enabled = false;
                    }
                    else if (seqno < maxseq && seqno > 1)
                    {
                        cbunitparent.Enabled = false;
                    }
                    else
                    {
                        cbunitparent.Enabled = false;
                    }
                }
            }
            
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if(Editmode)
            {

            }
            else
            {
                var produnitparent = new ProductUnitsDetails();
                var produnitchild = new ProductUnitsDetails();

                if(productUnitsList.Count == 0)
                {
                    produnitparent.itemid = ProductData.id;
                    produnitparent.seq = 1;
                    produnitparent.unitcode = cbunitparent.SelectedValue.ToString();
                    produnitparent.qty = (int)nbqty.Value;
                    produnitparent.pcsflag = "N";

                    produnitchild.itemid = ProductData.id;
                    produnitchild.seq = 2;
                    produnitchild.unitcode = cbunitchild.SelectedValue.ToString();
                    produnitchild.qty = 0;
                    produnitchild.pcsflag = "Y";

                    if (produnitparent.unitcode == produnitchild.unitcode)
                        MessageBox.Show("Kemasan 1 dan Kemasan 2 tidak boleh sama");
                    else if (nbqty.Value == 0)
                        MessageBox.Show("Silahkan isi jumlah nya");
                    else
                    {
                        if (productUnitsRepository.Addtwounits(produnitparent, produnitchild))
                        {
                            MessageBox.Show("Data baru telah berhasil di tambahkan");
                            Close();
                        }
                        else
                            MessageBox.Show("Gagal menambahkan kemasan produk yang baru");
                    }
                }
                else
                {

                    if (seqno == 1) 
                    {
                        //adding new unit with sequence 1, 
                        //all existing unit seq will increase by 1 
                        //in the screen, the parent unit dropdownlist will enable but the child unit dropdownlist disable because child unit taken from the old first unit in the list 

                        var newunit = new ProductUnitsDetails();
                        newunit.itemid = ProductData.id;
                        newunit.seq = seqno;
                        newunit.unitcode = cbunitparent.SelectedValue.ToString();
                        newunit.qty = (int)nbqty.Value;
                        newunit.pcsflag = "N";

                        var sameunit = productUnitsList.FirstOrDefault(x => x.unitcode == newunit.unitcode);

                        if(sameunit != null)
                            MessageBox.Show("Kemasan baru yang anda masukkan sudah terdaftar");
                        else if (productUnitsRepository.AddUnitinfirstOfList(newunit))
                        {
                            MessageBox.Show("Kemasan baru berhasil ditambahkan");
                            Close();
                        }
                        else
                            MessageBox.Show("Kemasan baru gagal ditambahkan");
                       
                    }
                    else if (seqno < maxseq && seqno > 1)
                    {
                        //adding new unit in the middle of the list (random seq)
                        //in the screen parent unit dropdownlist will disable while child unit dropdownlist is enable.
                        //ex: we want to add new unit for the 3rd(ex: tim) of 5 sequences. in parent will show unit from 2nd unit (ex: dus).
                        //then in the child unit we need to put the new 3rd unit. for qty can fill in by the qty of the new unit in parent unit (meaning how many tim available in one ddus) --> this will need us to update qty of parent unit (dus)
                        //because of we adding new unit in the middle then we need to update all sequence below the desired sequence by increasing one.

                        var newunit = new ProductUnitsDetails();
                        newunit.itemid = ProductData.id;
                        newunit.seq = seqno;
                        newunit.unitcode = cbunitchild.SelectedValue.ToString();
                        newunit.qty = 0;
                        newunit.pcsflag = "N";

                        var sameunit = productUnitsList.FirstOrDefault(x => x.unitcode == newunit.unitcode);

                        if (sameunit != null)
                            MessageBox.Show("Kemasan baru yang anda masukkan sudah terdaftar");
                        else if (productUnitsRepository.AddUnitinmiddletOfList(newunit, (int)nbqty.Value))
                        {
                            MessageBox.Show("Kemasan baru berhasil ditambahkan");
                            Close();
                        }
                        else
                            MessageBox.Show("Kemasan baru gagal ditambahkan");

                    }
                    else
                    {
                        //adding new unit in the last sequence of the list
                        //parent unit dropdownlist will disable while child unit dropdownlist is enable.  parent unit taken from last unit in the list and child unit will be new unit that we will add into list
                        //qty text box in the screen is belong to parent. so when saving the data, we need to update that parent unit become "not" pcs unit(update pcsflag) and update the qty from 0 with the qty input in screen
                        //the new unit will be the pcs unit

                        var newunit = new ProductUnitsDetails();
                        newunit.itemid = ProductData.id;
                        newunit.seq = seqno;
                        newunit.unitcode = cbunitchild.SelectedValue.ToString();
                        newunit.qty = 0;
                        newunit.pcsflag = "Y";

                        var sameunit = productUnitsList.FirstOrDefault(x => x.unitcode == newunit.unitcode);

                        if (sameunit != null)
                            MessageBox.Show("Kemasan baru yang anda masukkan sudah terdaftar");
                        else if (productUnitsRepository.AddUnitinLastOfList(newunit, (int)nbqty.Value))
                        {
                            MessageBox.Show("Kemasan baru berhasil ditambahkan");
                            Close();
                        }
                        else
                            MessageBox.Show("Kemasan baru gagal ditambahkan");

                    }
                }
                seqno = 0;
            }
        }
    }
}

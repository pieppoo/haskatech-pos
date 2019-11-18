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
        private ProductRepository productRepository = new ProductRepository();
        public AddEditUnitRelated()
        {
            InitializeComponent();
        }

        private void AddEditUnitRelated_Load(object sender, EventArgs e)
        {
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
                maxseq = productUnitsList.Count;

                cbunitparent.SelectedValue = SelectedUnitData.unitcode;
                nbqtyparent.Value = SelectedUnitData.qty;
                cbunitchild.Enabled = false;

                lbunitchildcopy.Visible = false;
                tbchildcopy.Visible = false;
                lbqtychild.Visible = false;
                nbqtychild.Visible = false;
                lb2ndchild.Visible = false;
                tbsecondchild.Visible = false;
                mandatory2.Visible = false;

                lbunitparent.Text = "Kemasan " + SelectedUnitData.seq;

                if (productUnitsList.Count == SelectedUnitData.seq) //lastseq
                {
                    nbqtyparent.Enabled = false;
                    lbunitchild.Visible = false;
                    cbunitchild.Visible = false;
                }
                else
                {
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
                    
                    if (seqno > maxseq || seqno == 1)
                    {
                        lbunitchildcopy.Visible = false;
                        tbchildcopy.Visible = false;
                        lbqtychild.Visible = false;
                        nbqtychild.Visible = false;
                        lb2ndchild.Visible = false;
                        tbsecondchild.Visible = false;
                        mandatory2.Visible = false;
                    }
                    else
                    {
                        int totalunit = UnitList.Count;

                        Random rnd = new Random();
                        int unitrandom = rnd.Next(0, totalunit);

                        cbunitchild.SelectedIndex = unitrandom;
                        var childunitcode = cbunitchild.SelectedValue.ToString();
                        var childunitdesc = UnitList.FirstOrDefault(x => x.unitcode == childunitcode);

                        var secondchildunit = productUnitsList.FirstOrDefault(x => x.seq == seqno);

                        var secondchildunitdet = UnitList.FirstOrDefault(x => x.unitcode == secondchildunit.unitcode);

                        tbchildcopy.Text = childunitdesc.description;
                        tbsecondchild.Text = secondchildunitdet.description;
                        tbsecondchild.Enabled = false;
                    }

                    if (seqno == 1)
                    {
                        lbunitparent.Text = "Kemasan " + seqno;
                        lbunitchild.Text = "Kemasan " + (seqno + 1);

                        var childunit = productUnitsList.FirstOrDefault(x => x.seq == seqno);
                        cbunitchild.SelectedValue = childunit.unitcode;
                        cbunitchild.Enabled = false;
                    }
                    else
                    {
                        lbunitparent.Text = "Kemasan " + (seqno-1);
                        lbunitchild.Text = "Kemasan " + seqno;
                        lb2ndchild.Text = "Kemasan " + (seqno + 1);
                        lbunitchildcopy.Text = lbunitchild.Text;

                        cbunitparent.Enabled = false;
                        var parentsunit = productUnitsList.FirstOrDefault(x => x.seq == seqno - 1);
                        cbunitparent.SelectedValue = parentsunit.unitcode;
                    }
                }
                else
                {
                    lbunitparent.Text = "Kemasan " + seqno;
                    lbunitchild.Text = "Kemasan " + (seqno + 1);

                    lbunitchildcopy.Visible = false;
                    tbchildcopy.Visible = false;
                    lbqtychild.Visible = false;
                    nbqtychild.Visible = false;
                    lb2ndchild.Visible = false;
                    tbsecondchild.Visible = false;
                    mandatory2.Visible = false;
                }
            }

        }

        private void cbunitchild_SelectionChangeCommitted(object sender, EventArgs e)
        {
            UnitList = unitRepository.GetAll();
            var childunitcode = cbunitchild.SelectedValue;
            var childunitdesc = UnitList.FirstOrDefault(x => x.unitcode == childunitcode.ToString());
            tbchildcopy.Text = childunitdesc.description;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(Editmode)
            {
                SelectedUnitData.unitcode = cbunitparent.SelectedValue.ToString();
                SelectedUnitData.qty = (int)nbqtyparent.Value;

                var sameunit = productUnitsList.FirstOrDefault(x => x.unitcode == SelectedUnitData.unitcode && x.seq != SelectedUnitData.seq);

                if (sameunit != null)
                    MessageBox.Show("Kemasan yang anda pilih sudah terdaftar");
                else if (nbqtyparent.Value == 0 && SelectedUnitData.seq != maxseq)
                    MessageBox.Show("Silahkan isi jumlah nya");
                else if (productUnitsRepository.Update(SelectedUnitData))
                {

                    MessageBox.Show("Kemasan data berhasil di ubah");
                    Close();
                }
                else
                    MessageBox.Show("Gagal mengubah data kemasan");
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
                    produnitparent.qty = (int)nbqtyparent.Value;
                    produnitparent.pcsflag = "N";

                    produnitchild.itemid = ProductData.id;
                    produnitchild.seq = 2;
                    produnitchild.unitcode = cbunitchild.SelectedValue.ToString();
                    produnitchild.qty = 0;
                    produnitchild.pcsflag = "Y";

                    if (produnitparent.unitcode == produnitchild.unitcode)
                        MessageBox.Show("Kemasan 1 dan Kemasan 2 tidak boleh sama");
                    else if (nbqtyparent.Value == 0)
                        MessageBox.Show("Silahkan isi jumlah nya");
                    else
                    {
                        if (productUnitsRepository.Addtwounits(produnitparent, produnitchild))
                        {
                            MessageBox.Show("Data baru telah berhasil di tambahkan");
                            seqno = 0;
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
                        newunit.qty = (int)nbqtyparent.Value;
                        newunit.pcsflag = "N";

                        var sameunit = productUnitsList.FirstOrDefault(x => x.unitcode == newunit.unitcode);

                        if(sameunit != null)
                            MessageBox.Show("Kemasan baru yang anda masukkan sudah terdaftar");
                        else if (nbqtyparent.Value == 0)
                            MessageBox.Show("Silahkan isi jumlah nya");
                        else if (productUnitsRepository.AddUnitinfirstOfList(newunit))
                        {
                            MessageBox.Show("Kemasan baru berhasil ditambahkan");
                            seqno = 0;
                            Close();
                        }
                        else
                            MessageBox.Show("Kemasan baru gagal ditambahkan");
                       
                    }
                    else if (seqno <= maxseq && seqno > 1)
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
                        newunit.qty = (int)nbqtychild.Value;
                        newunit.pcsflag = "N";

                        var sameunit = productUnitsList.FirstOrDefault(x => x.unitcode == newunit.unitcode);

                        if (sameunit != null)
                            MessageBox.Show("Kemasan baru yang anda masukkan sudah terdaftar");
                        else if (nbqtyparent.Value == 0)
                            MessageBox.Show("Silahkan isi jumlah nya");
                        else if (nbqtychild.Value == 0)
                            MessageBox.Show("Silahkan isi jumlah nya");
                        else if (productUnitsRepository.AddUnitinmiddletOfList(newunit, (int)nbqtyparent.Value))
                        {
                            MessageBox.Show("Kemasan baru berhasil ditambahkan");
                            seqno = 0;
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
                        //update stock

                        var newunit = new ProductUnitsDetails();
                        newunit.itemid = ProductData.id;
                        newunit.seq = seqno;
                        newunit.unitcode = cbunitchild.SelectedValue.ToString();
                        newunit.qty = 0;
                        newunit.pcsflag = "Y";

                        var productupdated = productRepository.GetById(ProductData.id);
                        int newstock = productupdated.Stock * (int)nbqtyparent.Value;

                        var sameunit = productUnitsList.FirstOrDefault(x => x.unitcode == newunit.unitcode);

                        if (sameunit != null)
                            MessageBox.Show("Kemasan baru yang anda masukkan sudah terdaftar");
                        else if (nbqtyparent.Value == 0)
                            MessageBox.Show("Silahkan isi jumlah nya");
                        else if (productUnitsRepository.AddUnitinLastOfList(newunit, (int)nbqtyparent.Value, newstock))
                        {
                            MessageBox.Show("Kemasan baru berhasil ditambahkan");
                            seqno = 0;
                            Close();
                        }
                        else
                            MessageBox.Show("Kemasan baru gagal ditambahkan");

                    }
                }
                
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Enter))
            {
                btnSave.PerformClick();
                return true;
            }
            else if (keyData == (Keys.Escape))
            {
                Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}

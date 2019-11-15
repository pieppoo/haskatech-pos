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
    public partial class ManageUnitInProduct : BaseForm
    {
        public ProductDetails ProductData { get; set; }
        public List<ProductUnitsDetails> productUnitsList { get; set; }
        public List<UnitItem> unitItemsList { get; set; }
        private bool Editflag { get; set; }
        private int selectseq { get; set; }
        private bool Deleteflag { get; set; }
        private bool Addflag { get; set; }

        private int runningno;
        private ProductUnitsRepository productUnitsRepository = new ProductUnitsRepository();
        private UnitRepository unitRepository = new UnitRepository();
        public ManageUnitInProduct()
        {
            InitializeComponent();
        }

        private void ManageUnitInProduct_Load(object sender, EventArgs e)
        {
            Editflag = false;
            Deleteflag = false;
            selectseq = 0;
           // int seq = 0;
            lbdate.Text = DateTime.Now.ToLongDateString();
            timer1.Start();
            lbtime.Text = DateTime.Now.ToLongTimeString();
            unitItemsList = unitRepository.GetAll().ToList();

            lbitemname.Text = "Nama Produk : " + ProductData.name;

            LoadData();
            

        }

        private void LoadData()
        {
            if (!string.IsNullOrEmpty(ProductData.UnitRelated))
            {
                var relation = "Ya";

                if (ProductData.UnitRelated == "N")
                    relation = "Tidak";

                lbunitrelation.Text = "Kemasan berkaitan ? " + relation;
            }

            productUnitsList = productUnitsRepository.GetAll(ProductData.id).ToList();

            if (!string.IsNullOrEmpty(ProductData.UnitRelated))
            {
                if (ProductData.UnitRelated == "Y")
                {
                    cbseq.Enabled = true;
                    btaddunit.Enabled = true;
                    bteditunit.Enabled = true;
                    btdeleteunit.Enabled = true;
                    btdeleteall.Enabled = true;

                    gvunitlist.Rows.Clear();

                    if (productUnitsList.Count == 0)
                    {
                        SortedDictionary<int, int> seqno = new SortedDictionary<int, int>
                        {
                            {1, 1}
                        };

                        cbseq.DataSource = new BindingSource(seqno, null);
                        cbseq.DisplayMember = "Value";
                        cbseq.ValueMember = "Key";
                    }
                    else
                    {
                        var seqlist = new List<int>();
                        int additional_seq = 0;

                        foreach (var item in productUnitsList.OrderBy(x => x.seq))
                        {
                            var unitList = unitItemsList.FirstOrDefault(x => x.unitcode == item.unitcode);

                            gvunitlist.Rows.Add(
                                item.id,
                                item.itemid,
                                item.seq,
                                unitList != null ? unitList.description : " - ",
                                item.qty,
                                item.pcsflag
                                );

                            seqlist.Add(item.seq);
                            additional_seq = item.seq + 1;
                        }

                        if(additional_seq <11)
                        {
                            seqlist.Add(additional_seq);
                        }
                        cbseq.DataSource = new BindingSource(seqlist, null);

                        cbseq.SelectedItem = additional_seq;
                        additional_seq = 0;
                        if (Editflag == true)
                        {
                           // gvunitlist.Rows[Editseq-1].Selected = true;
                            gvunitlist.CurrentCell = gvunitlist[2, selectseq - 1];
                            Editflag = false;
                            selectseq = 0;
                        }
                        else if (Deleteflag == true)
                        {
                            gvunitlist.CurrentCell = gvunitlist[2, gvunitlist.Rows.Count-1];
                            Deleteflag = false;
                        }
                    }

                    
                }
                else
                {
                    cbseq.Enabled = false;
                    btaddunit.Enabled = true;
                    bteditunit.Enabled = true;
                    btdeleteunit.Enabled = true;
                    btdeleteall.Enabled = true;

                    gvunitlist.Rows.Clear();

                    foreach (var item in productUnitsList.OrderBy(x=> x.seq))
                    {
                        var unitList = unitItemsList.FirstOrDefault(x => x.unitcode == item.unitcode);

                        gvunitlist.Rows.Add(
                            item.id,
                            item.itemid,
                            item.seq,
                            unitList != null ? unitList.description : " - ",
                            item.qty,
                            item.pcsflag
                            );
                    }

                    if (Editflag)
                    {
                        // gvunitlist.Rows[Editseq-1].Selected = true;
                        gvunitlist.CurrentCell = gvunitlist[2, selectseq - 1];
                        Editflag = false;
                        selectseq = 0;
                    }
                    else if (Addflag)
                    {
                        gvunitlist.CurrentCell = gvunitlist[2, gvunitlist.Rows.Count -1];
                        Addflag = false;
                    }
                }
            }
            else
            {
                cbseq.Enabled = false;
                btaddunit.Enabled = false;
                bteditunit.Enabled = false;
                btdeleteunit.Enabled = false;
                btdeleteall.Enabled = false;
            }
            
            
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lbtime.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void btdeleteunit_Click(object sender, EventArgs e)
        {
            if (gvunitlist.SelectedRows.Count == 0)
                MessageBox.Show("Tidak ada Kemasan yang akan dihapus");
            else if(ProductData.UnitRelated == "Y")
            {
                int totalunit = gvunitlist.Rows.Count;

                var seq_no = Convert.ToInt32(gvunitlist.Rows[gvunitlist.CurrentCell.RowIndex].Cells["seq_no"].Value);
                var id = Convert.ToInt32(gvunitlist.Rows[gvunitlist.CurrentCell.RowIndex].Cells["id"].Value);

                if (seq_no == totalunit && totalunit != 1)
                {
                    MessageBox.Show("Anda tidak dibenarkan menghapus Kemasan eceran sebelum menghapus kemasan lainnya");
                }
                else
                {
                    
                    var form = new ConfirmationDialog();
                    form.Message = "Apa anda yakin menghapus kemasan terpilih?";
                    form.ShowDialog();

                    if (form.YES  && totalunit > 1)
                    {
                        if(seq_no == totalunit) // delete last unit (pcs unit) while other unit still exist
                            MessageBox.Show("Anda tidak dibenarkan menghapus Kemasan eceran sebelum menghapus kemasan lainnya");
                        else if (seq_no == 1) // delete 1st unit while having other units
                        {
                            if (productUnitsRepository.DeleteRelatedfirst(ProductData.id, seq_no))
                                MessageBox.Show("Kemasan terpilih berhasil dihapus");
                            else
                                MessageBox.Show("Gagal menghapus kemasan");
                        }
                        else
                        {
                            if (productUnitsRepository.DeleteRelatedmiddle(ProductData.id, seq_no))
                                MessageBox.Show("Kemasan " + seq_no + " berhasil di hapus, PASTIKAN ANDA MENGUBAH JUMLAH DARI KEMASAN " + (seq_no-1) + " setelah ini");
                            else
                                MessageBox.Show("Gagal menghapus kemasan");
                        }
                    }
                    else if (form.YES) // if yes and only left 1 unit
                    {
                        if (productUnitsRepository.Delete(id))
                            MessageBox.Show("Kemasan terpilih berhasil dihapus");
                        else
                            MessageBox.Show("Gagal menghapus kemasan");
                    }

                    Deleteflag = true;
                    LoadData();
                }
            }
            else
            {
                var seq_no = Convert.ToInt32(gvunitlist.Rows[gvunitlist.CurrentCell.RowIndex].Cells["seq_no"].Value);
                var selectedUnit = productUnitsList.FirstOrDefault(x => x.itemid == ProductData.id && x.seq == seq_no);

                if (seq_no == 1 && gvunitlist.Rows.Count !=1) //seq 1 means unit eceran
                    MessageBox.Show("Anda tidak dibenarkan menghapus Kemasan eceran sebelum menghapus kemasan lainnya");
                else
                {
                    var form = new ConfirmationDialog();
                    form.Message = "Apa anda yakin menghapus kemasan terpilih?";
                    form.ShowDialog();

                    
                    if (form.YES && seq_no == 1)//delete the pcs unit 
                    {
                        if (productUnitsRepository.Delete(selectedUnit.id))
                            MessageBox.Show("Kemasan terpilih berhasil dihapus");
                        else
                            MessageBox.Show("Gagal menghapus kemasan");
                        LoadData();
                    }
                    else if (form.YES && seq_no != gvunitlist.Rows.Count)
                    {
                        if (productUnitsRepository.DeleteNOTRelated(selectedUnit.itemid, seq_no))
                            MessageBox.Show("Kemasan terpilih berhasil dihapus");
                        else
                            MessageBox.Show("Gagal menghapus kemasan");
                        LoadData();
                    }
                    else if (form.YES && seq_no == gvunitlist.Rows.Count) //last unit in the list when the list have more than 1 units
                    {
                        if (productUnitsRepository.Delete(selectedUnit.id))
                            MessageBox.Show("Kemasan terpilih berhasil dihapus");
                        else
                            MessageBox.Show("Gagal menghapus kemasan");
                        LoadData();
                    }
                }
            }
        }

        private void btdeleteall_Click(object sender, EventArgs e)
        {
            if (gvunitlist.SelectedRows.Count == 0)
                MessageBox.Show("Tidak ada Kemasan yang akan dihapus");
            else 
            {
                var form = new ConfirmationDialog();
                form.Message = "Apa anda yakin menghapus Semua kemasan terdaftar?";
                form.ShowDialog();

                if (form.YES)
                {

                    if (productUnitsRepository.DeleteAll(ProductData.id))
                        MessageBox.Show("Semua kemasan berhasil dihapus");
                    else
                        MessageBox.Show("Gagal menghapus semua kemasan");
                    
                    LoadData();
                }
            }
        }

        private void btaddunit_Click(object sender, EventArgs e)
        {
            if (ProductData.UnitRelated == "Y")
            {
                var form = new AddEditUnitRelated();
                form.ProductData = ProductData;
                form.seqno = (int)cbseq.SelectedValue;
                form.Editmode = false;
                form.ShowDialog();
                LoadData();
            }
            else
            {
                var form = new AddEditUnitNOTRelated();
                form.ProductData = ProductData;
                form.ShowDialog();
                Addflag = true;
                LoadData();
            }
        }

        private void bteditunit_Click(object sender, EventArgs e)
        {
            if (gvunitlist.SelectedRows.Count == 0)
                MessageBox.Show("Tidak ada Kemasan yang akan diubah");
            else if (ProductData.UnitRelated == "Y")
            {
                var seq_no = Convert.ToInt32(gvunitlist.Rows[gvunitlist.CurrentCell.RowIndex].Cells["seq_no"].Value);

                var selectedUnit = productUnitsList.FirstOrDefault(x => x.itemid == ProductData.id && x.seq == seq_no);
                if (selectedUnit != null)
                {
                    var form = new AddEditUnitRelated();
                    form.Editmode = true;
                    form.SelectedUnitData = selectedUnit;
                    form.ShowDialog();
                    Editflag = true;
                    selectseq = seq_no;
                    LoadData();
                }
            }
            else
            {
                var id = Convert.ToInt32(gvunitlist.Rows[gvunitlist.CurrentCell.RowIndex].Cells["id"].Value);
                var selectedunit = productUnitsList.FirstOrDefault(x => x.id == id);
                if (selectedunit != null)
                {
                    var form = new AddEditUnitNOTRelated();
                    form.Editmode = true;
                    form.ProdunitSelected = selectedunit;
                    form.ShowDialog();
                    Editflag = true;
                    selectseq = selectedunit.seq;
                    LoadData();

                }
            }
        }

        private void lbchangerelation_Click(object sender, EventArgs e)
        {
            if (gvunitlist.Rows.Count != 0)
            {
                MessageBox.Show("Anda tidak boleh menukar 'kemasan berkaitan' jika masih ada yang terdaftar");
            }
            else
            {
                var form = new AddEditUnitRelation();
                form.ProductData = ProductData;
                form.ShowDialog();
                LoadData();
            }

        }


        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.F1))
            {
                btaddunit.PerformClick();
                return true;
            }
            else if (keyData == (Keys.F2))
            {
                bteditunit.PerformClick();
                return true;
            }
            else if (keyData == (Keys.F3))
            {
                btdeleteunit.PerformClick();
                return true;
            }
            else if (keyData == (Keys.F4))
            {
                cbseq.Focus();
                return true;
            }
            else if (keyData == (Keys.F10))
            {
                btdeleteall.PerformClick();
                return true;
            }
            else if (keyData == (Keys.Delete))
            {
                btdeleteunit.PerformClick();
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

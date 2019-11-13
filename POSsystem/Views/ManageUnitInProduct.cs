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

        private ProductUnitsRepository productUnitsRepository = new ProductUnitsRepository();
        private UnitRepository unitRepository = new UnitRepository();
        public ManageUnitInProduct()
        {
            InitializeComponent();
        }

        private void ManageUnitInProduct_Load(object sender, EventArgs e)
        {
            int seq = 0;
            lbdate.Text = DateTime.Now.ToLongDateString();
            timer1.Start();
            lbtime.Text = DateTime.Now.ToLongTimeString();
            unitItemsList = unitRepository.GetAll().ToList();

            lbitemname.Text = "Nama Produk : " + ProductData.name;
            if (!string.IsNullOrEmpty(ProductData.UnitRelated))
            {
                var relation = "Ya";

                if (ProductData.UnitRelated == "N")
                    relation = "Tidak";

                lbunitrelation.Text = "Unit berkaitan ? " + relation;
            }

            LoadData();


        }

        private void LoadData()
        {
            productUnitsList = productUnitsRepository.GetAll(ProductData.id).ToList();

            if (!string.IsNullOrEmpty(ProductData.UnitRelated))
            {
                if (ProductData.UnitRelated == "Y")
                {
                    cbseq.Enabled = true;
                    btaddunit.Enabled = true;
                    bteditunit.Enabled = true;
                    btdeleteunit.Enabled = true;

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

                        seqlist.Add(additional_seq);
                        cbseq.DataSource = new BindingSource(seqlist, null);

                        cbseq.SelectedItem = additional_seq;
                        additional_seq = 0;
                    }

                    
                }
                else
                {
                    cbseq.Enabled = false;
                    btaddunit.Enabled = true;
                    bteditunit.Enabled = true;
                    btdeleteunit.Enabled = true;

                    foreach (var item in productUnitsList)
                    {
                        var unitList = unitItemsList.FirstOrDefault(x => x.unitcode == item.unitcode);

                        gvunitlist.Rows.Add(
                            item.id,
                            item.itemid,
                            "--",
                            unitList != null ? unitList.description : " - ",
                            item.qty,
                            item.pcsflag
                            );
                    }
                }
            }
            else
            {
                cbseq.Enabled = false;
                btaddunit.Enabled = false;
                bteditunit.Enabled = false;
                btdeleteunit.Enabled = false;
            }
            
            
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lbtime.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void btdeleteunit_Click(object sender, EventArgs e)
        {

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
        }

        private void bteditunit_Click(object sender, EventArgs e)
        {
            if (gvunitlist.SelectedRows.Count == 0)
                MessageBox.Show("Tidak ada Kemasan yang akan diubah");
            else
            {
                var seq_no = Convert.ToInt32(gvunitlist.Rows[gvunitlist.CurrentCell.RowIndex].Cells["seq_no"].Value);

                var selectedUnit = productUnitsList.FirstOrDefault(x => x.itemid == ProductData.id && x.seq == seq_no);
                if (selectedUnit != null)
                {
                    var form = new AddEditUnitRelated();
                    form.Editmode = true;
                    form.SelectedUnitData = selectedUnit;
                    form.ShowDialog();
                    LoadData();
                }
            }
        }

        private void lbchangerelation_Click(object sender, EventArgs e)
        {
            var form = new AddEditUnitRelation();
            form.ProductData = ProductData;
            form.ShowDialog();
            LoadData();
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

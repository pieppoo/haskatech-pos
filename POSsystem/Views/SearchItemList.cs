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
using POSsystem.Common;

namespace POSsystem.Views
{
    public partial class SearchItemList : BaseForm
    {
        public string QueriedItemName { get; set; }
        public SellingPriceDetails SelectedItemDetails { get; set; }
        public List<SellingPriceDetails> productsaledata { get; set; }
        public List<UnitItem> UnitList { get; set; }
        public List<SellingPriceDetails> SellingPriceList { get; set; }
        public List<SellingPriceDetails> TempNewSaleList { get; set; }

        private ProductRepository productRepository = new ProductRepository();
        private SaleFindItemRepository saleFindItemRepository = new SaleFindItemRepository();
        private UnitRepository unitRepository = new UnitRepository();


        public SearchItemList()
        {
            InitializeComponent();
        }


        private void SearchItemList_Load(object sender, EventArgs e)
        {
            var args = new List<object>();

            if (!string.IsNullOrEmpty(QueriedItemName))
            {
                args.Add(QueriedItemName);
            }

            SellingPriceList = saleFindItemRepository.GetAll();

            var result = productRepository.Search(args.ToArray());
            gvresultitem.Rows.Clear();
            UnitList = unitRepository.GetAll();

            if (result != null)
            {
                foreach (var item in result)
                {
                    productsaledata = saleFindItemRepository.GetAll(item.id);
                    if (productsaledata != null)
                    {
                        foreach (var sale in productsaledata)
                        {
                            var unitdata = UnitList.FirstOrDefault(x => x.unitcode == sale.sell_unit);

                            gvresultitem.Rows.Add(
                                sale.id,
                                item.name,
                                unitdata != null ? unitdata.description : " - ",
                                Utils.ToRupiah(sale.sell_price),
                                sale.Barcodeno != null ? sale.Barcodeno : " - "
                                );
                        }
                    }
                }
            }
        }

        private void gvresultitem_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = Convert.ToInt32(gvresultitem.Rows[e.RowIndex].Cells[0].Value);
            SelectedItemDetails = SellingPriceList.FirstOrDefault(x => x.id == id);
            Close();
        }
    }
}

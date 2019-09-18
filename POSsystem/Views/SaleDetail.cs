using POSsystem.Common;
using POSsystem.Database;
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
    public partial class SaleDetail : BaseForm
    {
        private SaleListRepository saleListRepository = new SaleListRepository();
        private ProductRepository productRepository = new ProductRepository();
        private UnitRepository unitRepository = new UnitRepository();

        public SaleHistoryDetails SaleHistoryData { get; set; }
        public List<SaleListDetails> SaleDetailList { get; set; }
        public List<ProductDetails> ProductList { get; set; }
        public List<UnitItem> UnitList { get; set; }
        public SaleDetail()
        {
            InitializeComponent();
        }

        public void LoadData()
        {
            SaleDetailList = saleListRepository.GetAll(SaleHistoryData.id);
            ProductList = productRepository.GetAll();
            UnitList = unitRepository.GetAll();
            gvsaledetail.Rows.Clear();
            int total = 0;

            foreach (var item in SaleDetailList)
            {
                var product = ProductList.FirstOrDefault(x => x.id == item.itemid);
                var unitsell = UnitList.FirstOrDefault(x => x.unitcode == item.unitsale);

                gvsaledetail.Rows.Add(
                    item.id,
                    item.historyid,
                    product != null ? product.name : " - ",
                    item.qtysale,
                    unitsell != null ? unitsell.description : " - ",
                    Utils.ToRupiah(item.priceperitem),
                    Utils.ToRupiah(item.originaltotal),
                    Utils.ToRupiah(item.discount),
                    Utils.ToRupiah(item.totalprice)
                    );

                total = total + item.totalprice;
            }

            tbtotal.Text = Utils.ToRupiahWithSymbol(total);
        }

        private void SaleDetail_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}

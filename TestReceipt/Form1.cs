using HASKA.POS.RECEIPT;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestReceipt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var itemList = new List<ItemDetails>();
            itemList.Add(new ItemDetails
            {
                ItemName = "Teh Botol",
                Quantity = "2",
                UnitPrice = "5.000.000",
                SubTotal = "10.000.000"
            });

            itemList.Add(new ItemDetails
            {
                ItemName = "Mie Bakso",
                Quantity = "3",
                UnitPrice = "1.000.000",
                SubTotal = "3.000.000",
                Discount = "200.000"
            });

            itemList.Add(new ItemDetails
            {
                ItemName = "Air Manis",
                Quantity = "1",
                UnitPrice = "1.000.000",
                SubTotal = "1.000.000"
            });

            itemList.Add(new ItemDetails
            {
                ItemName = "Teh Botol",
                Quantity = "2",
                UnitPrice = "5.000.000",
                SubTotal = "10.000.000"
            });

            itemList.Add(new ItemDetails
            {
                ItemName = "Mie Bakso",
                Quantity = "3",
                UnitPrice = "1.000.000",
                SubTotal = "3.000.000",
                Discount = "200.000"
            });

            itemList.Add(new ItemDetails
            {
                ItemName = "Air Manis",
                Quantity = "1",
                UnitPrice = "1.000.000",
                SubTotal = "1.000.000"
            });


            var receiptData = new ReceiptData();
            receiptData.ItemList = itemList;
            receiptData.StoreName = "TOKO IN SADAR";
            receiptData.ReceiptID = "123123123";
            receiptData.Datetime = "10/10/2010 10:10:10";

            receiptData.TotalItem = "500";
            receiptData.SubTotal = "10.000.000";
            receiptData.Discount = "249.000";
            receiptData.GrandTotal = "888.888.888";
            receiptData.TotalPaid = "100.000.000";
            receiptData.Balance = "1.000.000";

            receiptData.SalePaymentMethod = PaymentMethod.Card;
            receiptData.CardNo = "1265385192873";
            receiptData.RefNo = "92378129731923";

            var receipt = new Receipt { Data = receiptData };
            receipt.CompileReceipt();
            receipt.ShowPreviewDialog();
        }
    }
}

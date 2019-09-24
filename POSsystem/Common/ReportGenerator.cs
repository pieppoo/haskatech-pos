using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Tables;
using MigraDoc.Rendering;
using POSsystem.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BorderStyle = MigraDoc.DocumentObjectModel.BorderStyle;
using TabAlignment = MigraDoc.DocumentObjectModel.TabAlignment;

namespace POSsystem.Common
{
    public class ReportGenerator
    {
        public SalesReportDetails ReportData { get; set; }

        private Document document;

        public void GenerateReport()
        {
            if(ReportData == null)
            {
                MessageBox.Show("Data tidak tersedia. (NULL)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            document = new Document();
            DefineStyles();
            CreatePage();

            document.UseCmykColor = true;

            // Create a renderer for the MigraDoc document.
            PdfDocumentRenderer pdfRenderer = new PdfDocumentRenderer(false);

            // Associate the MigraDoc document with a renderer
            pdfRenderer.Document = document;

            // Layout and render document to PDF
            pdfRenderer.RenderDocument();

            // Save the document...
            string filename = "Laporan_Bulanan_" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".pdf";
            pdfRenderer.PdfDocument.Save(filename);
            // ...and start a viewer.
            Process.Start(filename);
        }

        private void DefineStyles()
        {
            // Get the predefined style Normal.
            Style style = document.Styles["Normal"];
            // Because all styles are derived from Normal, the next line changes the 
            // font of the whole document. Or, more exactly, it changes the font of
            // all styles and paragraphs that do not redefine the font.
            style.Font.Name = "Microsoft Sans Serif";

            style = document.Styles[StyleNames.Header];
            style.ParagraphFormat.AddTabStop("16cm", TabAlignment.Right);

            style = document.Styles[StyleNames.Footer];
            style.ParagraphFormat.AddTabStop("8cm", TabAlignment.Center);

            // Create a new style called Table based on style Normal
            style = document.Styles.AddStyle("Table", "Normal");
            style.Font.Size = 9;

            // Create a new style called Reference based on style Normal
            style = document.Styles.AddStyle("Reference", "Normal");
            style.ParagraphFormat.SpaceBefore = "5mm";
            style.ParagraphFormat.SpaceAfter = "5mm";
            style.ParagraphFormat.TabStops.AddTabStop("16cm", TabAlignment.Right);
        }

        void CreatePage()
        {
            // Each MigraDoc document needs at least one section.
            Section section = document.AddSection();

            // Create footer
            Paragraph paragraph = section.Footers.Primary.AddParagraph();
            paragraph.AddText("Tanggal Cetak : " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
            paragraph.Format.Font.Size = 7;
            paragraph.Format.Alignment = ParagraphAlignment.Right;

            paragraph = section.AddParagraph();
            paragraph.Format.Alignment = ParagraphAlignment.Center;
            paragraph.AddFormattedText(ReportData.Title, TextFormat.Bold);
            paragraph.Format.Font.Size = 15;

            paragraph = section.AddParagraph();
            paragraph.Format.Alignment = ParagraphAlignment.Center;
            paragraph.AddFormattedText(ReportData.SubTitle);

            paragraph = section.AddParagraph();
            paragraph.Format.Alignment = ParagraphAlignment.Center;
            paragraph.AddFormattedText("(" + ReportData.DateRange.ToString("MMMM yyyy") + ")");

            paragraph = section.AddParagraph();
            paragraph = section.AddParagraph();

            CrateSalesDetailsTable(section);

            section.AddParagraph();

            CrateSalesSummaryTable(section);

        }

        void CrateSalesDetailsTable(Section section)
        {
            // Create the item table
            var table = section.AddTable();
            table.Style = "Table";
            table.Borders.Color = Color.Parse("#000");
            table.Borders.Width = 0.25;
            table.Borders.Left.Width = 0.5;
            table.Borders.Right.Width = 0.5;
            table.Rows.LeftIndent = 0;

            // Before you can add a row, you must define the columns
            Column column = table.AddColumn("0.75cm");
            column.Format.Alignment = ParagraphAlignment.Center;

            column = table.AddColumn("5cm");
            column.Format.Alignment = ParagraphAlignment.Left;

            column = table.AddColumn("4cm");
            column.Format.Alignment = ParagraphAlignment.Left;

            column = table.AddColumn("2cm");
            column.Format.Alignment = ParagraphAlignment.Right;

            column = table.AddColumn("2cm");
            column.Format.Alignment = ParagraphAlignment.Right;

            column = table.AddColumn("2cm");
            column.Format.Alignment = ParagraphAlignment.Right;

            // Create the header of the table
            Row row = table.AddRow();
            row.HeadingFormat = true;
            row.Format.Alignment = ParagraphAlignment.Center;
            row.VerticalAlignment = VerticalAlignment.Center;
            row.Height = "0.7cm";
            row.Shading.Color = Color.Parse("#B5DCF2");
            row.Cells[0].AddParagraph("No.");
            row.Cells[0].Format.Font.Bold = false;
            row.Cells[0].Format.Alignment = ParagraphAlignment.Center;

            row.Cells[1].AddParagraph("Tanggal & Jam");
            row.Cells[1].Format.Alignment = ParagraphAlignment.Center;

            row.Cells[2].AddParagraph("Tipe Bayar");
            row.Cells[2].Format.Alignment = ParagraphAlignment.Center;

            row.Cells[3].AddParagraph("Subtotal");
            row.Cells[3].Format.Alignment = ParagraphAlignment.Center;

            row.Cells[4].AddParagraph("Diskon");
            row.Cells[4].Format.Alignment = ParagraphAlignment.Center;

            row.Cells[5].AddParagraph("Total");
            row.Cells[5].Format.Alignment = ParagraphAlignment.Center;


            table.SetEdge(0, 0, 6, 1, Edge.Box, BorderStyle.Single, 0.75, Color.Empty);

            int index = 1;
            foreach (var item in ReportData.SaleDetails)
            {
                // Each item fills two rows
                Row contentRow = table.AddRow();
                contentRow.Height = "0.4cm";

                contentRow.Cells[0].VerticalAlignment = VerticalAlignment.Center;
                contentRow.Cells[0].AddParagraph(index.ToString());

                contentRow.Cells[1].VerticalAlignment = VerticalAlignment.Center;
                contentRow.Cells[1].AddParagraph(item.Timestamp.ToString("dd/MM/yyyy HH:mm:ss"));
                contentRow.Cells[1].Format.Alignment = ParagraphAlignment.Center;

                contentRow.Cells[2].VerticalAlignment = VerticalAlignment.Center;
                var paragraph = contentRow.Cells[2].AddParagraph();
                paragraph.AddText(item.PaymentMode);

                if (!string.IsNullOrEmpty(item.CardNo))
                {
                    paragraph = contentRow.Cells[2].AddParagraph();
                    paragraph.Format.Font.Size = 7;
                    paragraph.AddText("No Kartu : " + item.CardNo);
                }

                if (!string.IsNullOrEmpty(item.CardRef))
                {
                    paragraph = contentRow.Cells[2].AddParagraph();
                    paragraph.Format.Font.Size = 7;
                    paragraph.AddText("No Ref. : " + item.CardRef);
                }


                contentRow.Cells[3].Format.Alignment = ParagraphAlignment.Right;
                contentRow.Cells[3].VerticalAlignment = VerticalAlignment.Center;
                contentRow.Cells[3].AddParagraph(item.SubTotal.ToString());

                contentRow.Cells[4].Format.Alignment = ParagraphAlignment.Right;
                contentRow.Cells[4].VerticalAlignment = VerticalAlignment.Center;
                contentRow.Cells[4].AddParagraph(item.Discount.ToString());

                contentRow.Cells[5].Format.Alignment = ParagraphAlignment.Right;
                contentRow.Cells[5].VerticalAlignment = VerticalAlignment.Center;
                contentRow.Cells[5].AddParagraph(item.Total.ToString());

                table.SetEdge(0, table.Rows.Count - 1, 6, 1, Edge.Box, BorderStyle.Single, 0.75);

                index++;
            }

            // Add an invisible row as a space line to the table
            Row invisRow = table.AddRow();
            invisRow.Borders.Visible = false;
        }

        void CrateSalesSummaryTable(Section section)
        {
            // Create the item table
            var table = section.AddTable();
            table.Style = "Table";

            // Before you can add a row, you must define the columns
            Column column = table.AddColumn("8cm");
            column.Format.Alignment = ParagraphAlignment.Left;

            column = table.AddColumn("5.7cm");
            column.Format.Alignment = ParagraphAlignment.Left;

            column = table.AddColumn("2.3cm");
            column.Format.Alignment = ParagraphAlignment.Left;

            for (int i = 0; i < 3; i++)
            {
                // Each item fills two rows
                Row contentRow = table.AddRow();
                contentRow.Height = "0.5cm";

                switch (i)
                {
                    case 0:
                        contentRow.Cells[0].VerticalAlignment = VerticalAlignment.Center;
                        contentRow.Cells[0].AddParagraph("Jumlah Transaksi\t\t: " + ReportData.TrxCount);

                        contentRow.Cells[1].VerticalAlignment = VerticalAlignment.Center;
                        contentRow.Cells[1].Format.Alignment = ParagraphAlignment.Right;
                        contentRow.Cells[1].AddParagraph("Subtotal : ");

                        contentRow.Cells[2].VerticalAlignment = VerticalAlignment.Center;
                        contentRow.Cells[2].Format.Alignment = ParagraphAlignment.Right;
                        contentRow.Cells[2].AddParagraph(ReportData.SubTotal.ToString());
                        break;
                    case 1:
                        contentRow.Cells[0].VerticalAlignment = VerticalAlignment.Center;
                        contentRow.Cells[0].AddParagraph("Jumlah Kartu\t\t: " + ReportData.CardTrxCount);

                        contentRow.Cells[1].VerticalAlignment = VerticalAlignment.Center;
                        contentRow.Cells[1].Format.Alignment = ParagraphAlignment.Right;
                        contentRow.Cells[1].AddParagraph("Diskon : ");

                        contentRow.Cells[2].VerticalAlignment = VerticalAlignment.Center;
                        contentRow.Cells[2].Format.Alignment = ParagraphAlignment.Right;
                        contentRow.Cells[2].AddParagraph(ReportData.Discount.ToString());
                        break;
                    case 2:
                        contentRow.Cells[0].VerticalAlignment = VerticalAlignment.Center;
                        contentRow.Cells[0].AddParagraph("Jumlah Tunai\t\t: " + ReportData.CashTrxCount);

                        contentRow.Cells[1].VerticalAlignment = VerticalAlignment.Center;
                        contentRow.Cells[1].Format.Alignment = ParagraphAlignment.Right;
                        contentRow.Cells[1].AddParagraph("Grand Total : ");

                        contentRow.Cells[2].VerticalAlignment = VerticalAlignment.Center;
                        contentRow.Cells[2].Format.Alignment = ParagraphAlignment.Right;
                        contentRow.Cells[2].AddParagraph(ReportData.GrandTotal.ToString());
                        break;
                    default:
                        break;
                }

                table.SetEdge(2, i, 1, 1, Edge.Box, BorderStyle.Single, 0.5);
            }

        }
    }
}

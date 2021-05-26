using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
//using System.IO;
//using iTextSharp.text;
//using iTextSharp.text.pdf;
using PdfSharp.Pdf;
using PdfSharp.Drawing;
using PdfSharp.Fonts;
using Microsoft.Extensions.DependencyInjection;

namespace PBL3REAL.View
{
    public partial class Form_Detail_Invoice : Form
    {
        public Form_Detail_Invoice()
        {
            InitializeComponent();
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            //ConfigureServices();
        }
        public void ExportToPDF(string FileName)
        {
            //if (dataGridView1.Rows.Count > 0)
            //{
            //    SaveFileDialog sfd = new SaveFileDialog();
            //    sfd.Filter = "PDF (*.pdf)|*.pdf";
            //    sfd.FileName = "Output.pdf";
            //    bool fileError = false;
            //    if (sfd.ShowDialog() == DialogResult.OK)
            //    {
            //        if (File.Exists(sfd.FileName))
            //        {
            //            try
            //            {
            //                File.Delete(sfd.FileName);
            //            }
            //            catch (IOException ex)
            //            {
            //                fileError = true;
            //                MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
            //            }
            //        }
            //        if (!fileError)
            //        {
            //            try
            //            {
            //                PdfPTable pdfTable = new PdfPTable(dataGridView1.Columns.Count);
            //                pdfTable.DefaultCell.Padding = 3;
            //                pdfTable.WidthPercentage = 100;
            //                pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

            //                foreach (DataGridViewColumn column in dataGridView1.Columns)
            //                {
            //                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
            //                    pdfTable.AddCell(cell);
            //                }

            //                foreach (DataGridViewRow row in dataGridView1.Rows)
            //                {
            //                    foreach (DataGridViewCell cell in row.Cells)
            //                    {
            //                        pdfTable.AddCell(cell.Value.ToString());
            //                    }
            //                }

            //                using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
            //                {
            //                    Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
            //                    PdfWriter.GetInstance(pdfDoc, stream);
            //                    pdfDoc.Open();
            //                    pdfDoc.Add(pdfTable);
            //                    pdfDoc.Close();
            //                    stream.Close();
            //                }

            //                MessageBox.Show("Data Exported Successfully !!!", "Info");
            //            }
            //            catch (Exception ex)
            //            {
            //                MessageBox.Show("Error :" + ex.Message);
            //            }
            //        }
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("No Record To Export !!!", "Info");
            //}
            PdfDocument pdf = new PdfDocument();
            PdfPage pdfPage = pdf.AddPage();
            XGraphics graph = XGraphics.FromPdfPage(pdfPage);
            XFont font_Header = new XFont("Arial", 30, XFontStyle.Bold);
            XFont font_Footer = new XFont("Arial", 8, XFontStyle.Bold);
            graph.DrawString("INVOICE", font_Header, XBrushes.Black,new XRect(0, 30, pdfPage.Width.Point, 0), XStringFormats.BaseLineCenter);
            graph.DrawString("Invoice ID: " + FileName, font_Footer, XBrushes.Black, new XRect(3, 0, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.BottomLeft);
            pdf.Save(FileName + ".pdf");
        }
        //public void ConfigureServices(IServiceCollection services)
        //{
        //    Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

        //    // more code here
        //}
        private void btn_OK_Click(object sender, EventArgs e)
        {
            ExportToPDF("Test");
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}

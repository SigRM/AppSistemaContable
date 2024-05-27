using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppSistemaContable.Utilitarios
{
    class ExportarGrid
    {
        public void ExportarPDF(DataGridView grd, String nombreArchivo)
        {
            if (grd.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "Grid_" + nombreArchivo + ".pdf";

                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("No se puede guardar la planilla" + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            PdfPTable pdfTable = new PdfPTable(grd.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn column in grd.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                pdfTable.AddCell(cell);
                            }

                            foreach (DataGridViewRow row in grd.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    pdfTable.AddCell(cell.Value.ToString());
                                }
                            }

                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }

                            MessageBox.Show("Planilla creada con exito", "Atencion");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record To Export !!!", "Info");
            }
        }

        public void ExportarPDF2(DataGridView grd, String nombreArchivo)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "PDF files|*.pdf", FileName = "Grid_" + nombreArchivo + ".pdf" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        Document doc = new Document(iTextSharp.text.PageSize.A4, 10, 10, 42, 35);
                        PdfWriter pdfWriter = PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));
                        doc.Open();
                        PdfContentByte pdfContent = pdfWriter.DirectContent;
                        iTextSharp.text.Rectangle rectangle = new iTextSharp.text.Rectangle(doc.PageSize);
                        //customized border sizes
                        rectangle.Left += doc.LeftMargin - 5;
                        rectangle.Right -= doc.RightMargin - 5;
                        rectangle.Top -= doc.TopMargin - 5;
                        rectangle.Bottom += doc.BottomMargin - 5;
                        pdfContent.SetColorStroke(BaseColor.WHITE);//setting the color of the border to white
                        pdfContent.Rectangle(rectangle.Left, rectangle.Bottom, rectangle.Width, rectangle.Height);
                        pdfContent.Stroke();
                        //setting font type, font size and font color
                        iTextSharp.text.Font headerFont = iTextSharp.text.FontFactory.GetFont(FontFactory.TIMES_ROMAN, 25, BaseColor.LIGHT_GRAY);
                        Paragraph p = new Paragraph();
                        p.Alignment = Element.ALIGN_CENTER;//adjust the alignment of the heading
                        p.Add(new Chunk(nombreArchivo, headerFont));//adding a heading to the PDF
                        doc.Add(p);//adding component to the document
                        iTextSharp.text.Font font = iTextSharp.text.FontFactory.GetFont(FontFactory.TIMES_ROMAN, 12, BaseColor.LIGHT_GRAY);
                        //creating pdf table
                        PdfPTable table = new PdfPTable(grd.Columns.Count);
                        for (int j = 0; j < grd.Columns.Count; j++)
                        {
                            PdfPCell cell = new PdfPCell(); //create object from the pdfpcell
                            cell.BackgroundColor = BaseColor.WHITE;//set color of cells
                            cell.AddElement(new Chunk(grd.Columns[j].HeaderText.ToUpper(), font));
                            table.AddCell(cell);
                        }
                        //adding rows from gridview to table
                        for (int i = 0; i < grd.Rows.Count; i++)
                        {
                            table.WidthPercentage = 100;//set width of the table
                            for (int j = 0; j < grd.Columns.Count; j++)
                            {
                                if (grd[j, i].Value != null)
                                    table.AddCell(new Phrase(grd[j, i].Value.ToString()));
                            }
                        }
                        //adding table to document
                        doc.Add(table);
                        doc.Close();
                        MessageBox.Show("Documento creado con exito", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}

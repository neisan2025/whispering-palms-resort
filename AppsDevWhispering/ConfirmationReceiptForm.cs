using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using System.Xml.Linq;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.Runtime.Serialization;

namespace AppsDevWhispering
{
    public partial class ConfirmationReceiptForm : Form
    {
        string text = "";
        decimal totalPrice = 0;
        decimal totalAmountRoom = 0;
        public ConfirmationReceiptForm()
        {
            InitializeComponent();
            label5.Text = "P" + RoomReceiptForm.totalPrice.ToString("N2");
            string formattedTime = DateTime.Now.ToString("h:mm tt");
            string formattedDate = DateTime.Now.ToString("MMMM d, yyyy");
            label8.Text = formattedDate;
            label9.Text = formattedTime;
        }

        public ConfirmationReceiptForm(string txt)
        {
            text = txt;
            if (text == "Dining")
            {
                InitializeComponent();
                label5.Text = "P" + ReceiptForm.total.ToString("N2");
                string formattedTime = DateTime.Now.ToString("h:mm tt");
                string formattedDate = DateTime.Now.ToString("MMMM d, yyyy");
                label8.Text = formattedDate;
                label9.Text = formattedTime;
            }
            if (text == "Diving")
            {
                InitializeComponent();
                label5.Text = DivingFinalReceipt.total;
                string formattedTime = DateTime.Now.ToString("h:mm tt");
                string formattedDate = DateTime.Now.ToString("MMMM d, yyyy");
                label8.Text = formattedDate;
                label9.Text = formattedTime;
            }
        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            if (text == "Dining")
            {
                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "PDF file|*.pdf", ValidateNames = true })
                {
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        float width = 700;
                        float height = 800;

                        iTextSharp.text.Rectangle pageSize = new iTextSharp.text.Rectangle(width, height);

                        iTextSharp.text.Document doc = new iTextSharp.text.Document(pageSize);
                        try
                        {
                            PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));
                            doc.Open();


                            /*System.Drawing.Image image = RecieptPdfPic.Image;
                             iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(image, System.Drawing.Imaging.ImageFormat.Jpeg);
                             img.ScaleToFit(120f, 35f);
                             doc.Add(img);
                            */

                            iTextSharp.text.Font font1 = iTextSharp.text.FontFactory.GetFont("Proxima Nova", 36, iTextSharp.text.Font.BOLD);
                            iTextSharp.text.Font font2 = iTextSharp.text.FontFactory.GetFont("Proxima Nova", 12, iTextSharp.text.Font.NORMAL);
                            iTextSharp.text.Font font4 = iTextSharp.text.FontFactory.GetFont("Proxima Nova", 16, iTextSharp.text.Font.NORMAL);
                            //iTextSharp.text.Font fontLine = iTextSharp.text.FontFactory.GetFont("Proxima Nova", 14, iTextSharp.text.Font.NORMAL);


                            DateTime currentDate = DateTime.Now;
                            string dateString = currentDate.ToString("DATE: " + "MM/dd/yyyy");

                            float leftPadding = 60f;
                            float centerPadding = 200f;

                            Paragraph receiptParagraph = new Paragraph("RECIEPT", font1);
                            receiptParagraph.IndentationLeft = leftPadding;
                            doc.Add(receiptParagraph);

                            Paragraph paragraph = new Paragraph("\n");
                            paragraph.SetLeading(0, 1.2f);
                            doc.Add(paragraph);

                            Paragraph WhisperName = new Paragraph("BILL FROM: Whispering Palms Island Resort", font2);
                            WhisperName.IndentationLeft = leftPadding;
                            doc.Add(WhisperName);

                            Paragraph BillTo = new Paragraph("BILL TO: " + HomeForm.currentEmail, font2);
                            BillTo.IndentationLeft = leftPadding;
                            doc.Add(BillTo);

                            Paragraph dateParagraph = new Paragraph(dateString, font2);
                            dateParagraph.IndentationLeft = leftPadding;
                            doc.Add(dateParagraph);

                            doc.Add(new iTextSharp.text.Chunk("\n"));

                            DataGridView dataGrid = new DataGridView();
                            List<string[]> data = new List<string[]>();

                            int i = 0;
                            foreach (var order in MenuRestaurantFINAL.foodOrders)
                            {
                                i++;
                                data.Add(new string[] { i.ToString(), order.Item, order.Quantity.ToString(), ReceiptForm.checkInDate.ToString(), "P" + order.Total.ToString("N2") });
                            }

                            AddDataGridViewToPDF(data, doc, FontFactory.GetFont("Proxima Nova", 12, iTextSharp.text.Font.NORMAL));

                            doc.Add(new iTextSharp.text.Chunk("\n"));
                            doc.Add(new iTextSharp.text.Chunk("\n"));

                            Paragraph line1 = new Paragraph("------------------------------------------------------------------------------------------------------------------------------", font2);
                            line1.IndentationLeft = leftPadding;
                            doc.Add(line1);

                            Paragraph ThankYouLabel = new Paragraph("Thanks for your Business!", font4);
                            ThankYouLabel.IndentationLeft = centerPadding;
                            doc.Add(ThankYouLabel);

                            Paragraph line2 = new Paragraph("------------------------------------------------------------------------------------------------------------------------------", font2);
                            line2.IndentationLeft = leftPadding;
                            doc.Add(line2);


                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            doc.Close();
                        }
                    }
                }

                MenuRestaurantFINAL.foodOrders.Clear();/////////////////////////////////////////////////////////////////////////////////
            }
            else if (text == "Diving")
            {
                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "PDF file|*.pdf", ValidateNames = true })
                {
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        float width = 700;
                        float height = 800;

                        iTextSharp.text.Rectangle pageSize = new iTextSharp.text.Rectangle(width, height);

                        iTextSharp.text.Document doc = new iTextSharp.text.Document(pageSize);
                        try
                        {
                            PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));
                            doc.Open();


                            /*System.Drawing.Image image = RecieptPdfPic.Image;
                             iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(image, System.Drawing.Imaging.ImageFormat.Jpeg);
                             img.ScaleToFit(120f, 35f);
                             doc.Add(img);
                            */

                            iTextSharp.text.Font font1 = iTextSharp.text.FontFactory.GetFont("Proxima Nova", 36, iTextSharp.text.Font.BOLD);
                            iTextSharp.text.Font font2 = iTextSharp.text.FontFactory.GetFont("Proxima Nova", 12, iTextSharp.text.Font.NORMAL);
                            iTextSharp.text.Font font4 = iTextSharp.text.FontFactory.GetFont("Proxima Nova", 16, iTextSharp.text.Font.NORMAL);
                            //iTextSharp.text.Font fontLine = iTextSharp.text.FontFactory.GetFont("Proxima Nova", 14, iTextSharp.text.Font.NORMAL);


                            DateTime currentDate = DateTime.Now;
                            string dateString = currentDate.ToString("DATE: " + "MM/dd/yyyy");

                            float leftPadding = 60f;
                            float centerPadding = 200f;

                            Paragraph receiptParagraph = new Paragraph("RECIEPT", font1);
                            receiptParagraph.IndentationLeft = leftPadding;
                            doc.Add(receiptParagraph);

                            Paragraph paragraph = new Paragraph("\n");
                            paragraph.SetLeading(0, 1.2f);
                            doc.Add(paragraph);

                            Paragraph WhisperName = new Paragraph("BILL FROM: Whispering Palms Island Resort", font2);
                            WhisperName.IndentationLeft = leftPadding;
                            doc.Add(WhisperName);

                            Paragraph BillTo = new Paragraph("BILL TO: " + HomeForm.currentEmail, font2);
                            BillTo.IndentationLeft = leftPadding;
                            doc.Add(BillTo);

                            Paragraph dateParagraph = new Paragraph(dateString, font2);
                            dateParagraph.IndentationLeft = leftPadding;
                            doc.Add(dateParagraph);

                            doc.Add(new iTextSharp.text.Chunk("\n"));

                            DataGridView dataGrid = new DataGridView();
                            List<string[]> data = new List<string[]>();

                            for(int i = 0, j = 1; i < 3; i++, j++)
                            {
                                if (!string.IsNullOrEmpty(DivingFinalReceipt.pack[i]) && !string.IsNullOrEmpty(DivingFinalReceipt.pric[i]))
                                {
                                    decimal formatted = decimal.Parse(DivingFinalReceipt.pric[i].Substring(1));
                                    data.Add(new string[] { j.ToString(), DivingFinalReceipt.pack[i], DivingReceipt.reservation.ToShortDateString(), "P" + formatted.ToString("N2")});
                                }
                            }

                            AddDataGridViewToPDF(data, doc, FontFactory.GetFont("Proxima Nova", 12, iTextSharp.text.Font.NORMAL));

                            doc.Add(new iTextSharp.text.Chunk("\n"));
                            doc.Add(new iTextSharp.text.Chunk("\n"));

                            Paragraph line1 = new Paragraph("------------------------------------------------------------------------------------------------------------------------------", font2);
                            line1.IndentationLeft = leftPadding;
                            doc.Add(line1);

                            Paragraph ThankYouLabel = new Paragraph("Thanks for your Business!", font4);
                            ThankYouLabel.IndentationLeft = centerPadding;
                            doc.Add(ThankYouLabel);

                            Paragraph line2 = new Paragraph("------------------------------------------------------------------------------------------------------------------------------", font2);
                            line2.IndentationLeft = leftPadding;
                            doc.Add(line2);


                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            doc.Close();
                        }
                    }
                }
            }
            else
            {
                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "PDF file|*.pdf", ValidateNames = true })
                {
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        float width = 700;
                        float height = 800;

                        iTextSharp.text.Rectangle pageSize = new iTextSharp.text.Rectangle(width, height);

                        iTextSharp.text.Document doc = new iTextSharp.text.Document(pageSize);
                        try
                        {
                            PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));
                            doc.Open();


                            /*System.Drawing.Image image = RecieptPdfPic.Image;
                             iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(image, System.Drawing.Imaging.ImageFormat.Jpeg);
                             img.ScaleToFit(120f, 35f);
                             doc.Add(img);
                            */

                            iTextSharp.text.Font font1 = iTextSharp.text.FontFactory.GetFont("Proxima Nova", 36, iTextSharp.text.Font.BOLD);
                            iTextSharp.text.Font font2 = iTextSharp.text.FontFactory.GetFont("Proxima Nova", 12, iTextSharp.text.Font.NORMAL);
                            iTextSharp.text.Font font4 = iTextSharp.text.FontFactory.GetFont("Proxima Nova", 16, iTextSharp.text.Font.NORMAL);
                            //iTextSharp.text.Font fontLine = iTextSharp.text.FontFactory.GetFont("Proxima Nova", 14, iTextSharp.text.Font.NORMAL);


                            DateTime currentDate = DateTime.Now;
                            string dateString = currentDate.ToString("DATE: " + "MM/dd/yyyy");

                            float leftPadding = 60f;
                            float centerPadding = 200f;

                            Paragraph receiptParagraph = new Paragraph("RECIEPT", font1);
                            receiptParagraph.IndentationLeft = leftPadding;
                            doc.Add(receiptParagraph);

                            Paragraph paragraph = new Paragraph("\n");
                            paragraph.SetLeading(0, 1.2f);
                            doc.Add(paragraph);

                            Paragraph WhisperName = new Paragraph("BILL FROM: Whispering Palms Island Resort", font2);
                            WhisperName.IndentationLeft = leftPadding;
                            doc.Add(WhisperName);

                            Paragraph BillTo = new Paragraph("BILL TO: " + HomeForm.currentEmail, font2);
                            BillTo.IndentationLeft = leftPadding;
                            doc.Add(BillTo);

                            Paragraph dateParagraph = new Paragraph(dateString, font2);
                            dateParagraph.IndentationLeft = leftPadding;
                            doc.Add(dateParagraph);

                            doc.Add(new iTextSharp.text.Chunk("\n"));

                            DataGridView dataGrid = new DataGridView();
                            List<string[]> data = new List<string[]>();

                            foreach (var room in AvailableRooms.bookedRooms)
                            {
                                decimal formatted = decimal.Parse(room.Subtotal);
                                decimal formatted1 = decimal.Parse(room.Price);
                                data.Add(new string[] { room.Title, room.CheckInDateTime.ToString(), room.CheckOutDateTime.ToString(), "P" + formatted1.ToString("N2"), "P" +  formatted.ToString("N2")});
                                totalAmountRoom += formatted;
                            }

                           


                            AddDataGridViewToPDF(data, doc, FontFactory.GetFont("Proxima Nova", 12, iTextSharp.text.Font.NORMAL));

                            doc.Add(new iTextSharp.text.Chunk("\n"));
                            doc.Add(new iTextSharp.text.Chunk("\n"));

                            Paragraph line1 = new Paragraph("------------------------------------------------------------------------------------------------------------------------------", font2);
                            line1.IndentationLeft = leftPadding;
                            doc.Add(line1);

                            Paragraph ThankYouLabel = new Paragraph("Thanks for your Business!", font4);
                            ThankYouLabel.IndentationLeft = centerPadding;
                            doc.Add(ThankYouLabel);

                            Paragraph line2 = new Paragraph("------------------------------------------------------------------------------------------------------------------------------", font2);
                            line2.IndentationLeft = leftPadding;
                            doc.Add(line2);


                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            doc.Close();
                        }
                    }
                }

                AvailableRooms.bookedRooms.Clear();///////////////////////////////////////////////////
            }
        }

        private void AddDataGridViewToPDF(List<string[]> data, Document document, iTextSharp.text.Font font)
        {
            if (text == "Dining")
            {
                PdfPTable pdfTable = new PdfPTable(data[0].Length);
                pdfTable.SetTotalWidth(new float[] { 100f, 300f, 200f, 250f, 250f });
                iTextSharp.text.Font font3 = iTextSharp.text.FontFactory.GetFont("Proxima Nova", 12, iTextSharp.text.Font.BOLD);

                // Add custom row headers
                string[] rowHeaders = { "NO.", "ITEM", "QTY", "RESERVATION", "SUBTOTAL" };
                foreach (string header in rowHeaders)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(header, font3));
                    cell.PaddingTop = 5f;
                    cell.PaddingBottom = 10f;
                    cell.PaddingLeft = 5f;

                    cell.BackgroundColor = new BaseColor(0x38, 0xB6, 0xFF);
                    cell.BorderColor = new BaseColor(0x38, 0xB6, 0xFF);
                    cell.Phrase.Font.Color = BaseColor.WHITE;
                    //cell.BorderColor = BaseColor.WHITE;
                    pdfTable.AddCell(cell);
                }
                totalPrice = 0;

                foreach (string[] rowData in data)
                {
                    foreach (string value in rowData)
                    {
                        PdfPCell cell2 = new PdfPCell(new Phrase(value, font));
                        cell2.PaddingTop = 15f;
                        cell2.PaddingBottom = 15f;
                        cell2.PaddingLeft = 5f;

                        cell2.BorderColor = BaseColor.WHITE;
                        pdfTable.AddCell(cell2);

                        if (Array.IndexOf(rowData, value) == 4)
                        {
                            totalPrice += decimal.Parse(value.TrimStart('P').Replace(",", ""));
                        }

                    }
                }

                iTextSharp.text.Font font4 = iTextSharp.text.FontFactory.GetFont("Proxima Nova", 12, iTextSharp.text.Font.BOLD);

                PdfPCell emptyCell = new PdfPCell(new Phrase(""));
                emptyCell.Colspan = 2;
                emptyCell.BorderColor = BaseColor.WHITE;
                pdfTable.AddCell(emptyCell);

                PdfPCell emptyCell2 = new PdfPCell(new Phrase(""));
                emptyCell2.Colspan = 1;
                emptyCell2.BorderColor = BaseColor.WHITE;
                pdfTable.AddCell(emptyCell2);

                PdfPCell totalLabelCell = new PdfPCell(new Phrase("TOTAL", font4));
                totalLabelCell.Colspan = 1;
                totalLabelCell.HorizontalAlignment = Element.ALIGN_LEFT; // Align to the right
                totalLabelCell.PaddingTop = 5f;
                totalLabelCell.PaddingBottom = 10f;
                totalLabelCell.PaddingLeft = 5f;
                totalLabelCell.BackgroundColor = new BaseColor(0x38, 0xB6, 0xFF);
                totalLabelCell.BorderColor = new BaseColor(0x38, 0xB6, 0xFF);
                totalLabelCell.Phrase.Font.Color = BaseColor.WHITE;
                //totalLabelCell.BorderColor = BaseColor.WHITE;
                pdfTable.AddCell(totalLabelCell);

                PdfPCell totalPriceCell = new PdfPCell(new Phrase("P" + totalPrice.ToString("N2"), font4));
                totalPriceCell.Colspan = 2; // Span the last two columns
                totalPriceCell.PaddingTop = 5f;
                totalPriceCell.PaddingBottom = 10f;
                totalPriceCell.PaddingLeft = 5f;
                totalPriceCell.BackgroundColor = new BaseColor(0x38, 0xB6, 0xFF);
                totalPriceCell.BorderColor = new BaseColor(0x38, 0xB6, 0xFF);
                totalPriceCell.Phrase.Font.Color = BaseColor.WHITE;
                //totalPriceCell.BorderColor = BaseColor.WHITE;

                pdfTable.AddCell(totalPriceCell);

                document.Add(pdfTable);
            }
            else if (text == "Diving")
            {
                PdfPTable pdfTable = new PdfPTable(data[0].Length);
                pdfTable.SetTotalWidth(new float[] { 100f, 300f, 200f, 250f});
                iTextSharp.text.Font font3 = iTextSharp.text.FontFactory.GetFont("Proxima Nova", 12, iTextSharp.text.Font.BOLD);

                // Add custom row headers
                string[] rowHeaders = { "NO.", "PACKAGE", "RESERVATION", "SUBTOTAL" };
                foreach (string header in rowHeaders)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(header, font3));
                    cell.PaddingTop = 5f;
                    cell.PaddingBottom = 10f;
                    cell.PaddingLeft = 5f;

                    cell.BackgroundColor = new BaseColor(0x38, 0xB6, 0xFF);
                    cell.BorderColor = new BaseColor(0x38, 0xB6, 0xFF);
                    cell.Phrase.Font.Color = BaseColor.WHITE;
                    //cell.BorderColor = BaseColor.WHITE;
                    pdfTable.AddCell(cell);
                }

                decimal totalPrice = 0;
                foreach (string[] rowData in data)
                {
                    foreach (string value in rowData)
                    {
                        PdfPCell cell2 = new PdfPCell(new Phrase(value, font));
                        cell2.PaddingTop = 15f;
                        cell2.PaddingBottom = 15f;
                        cell2.PaddingLeft = 5f;

                        cell2.BorderColor = BaseColor.WHITE;
                        pdfTable.AddCell(cell2);

                        if (Array.IndexOf(rowData, value) == 3)
                        {
                            totalPrice += decimal.Parse(value.TrimStart('P').Replace(",",""));
                        }

                    }
                }

                iTextSharp.text.Font font4 = iTextSharp.text.FontFactory.GetFont("Proxima Nova", 12, iTextSharp.text.Font.BOLD);

                PdfPCell emptyCell = new PdfPCell(new Phrase(""));
                emptyCell.Colspan = 2;
                emptyCell.BorderColor = BaseColor.WHITE;
                pdfTable.AddCell(emptyCell);

                PdfPCell emptyCell2 = new PdfPCell(new Phrase(""));
                emptyCell2.Colspan = 1;
                emptyCell2.BorderColor = BaseColor.WHITE;
                pdfTable.AddCell(emptyCell2);

                PdfPCell totalLabelCell = new PdfPCell(new Phrase("TOTAL: P" + totalPrice.ToString("N2"), font4));
                totalLabelCell.Colspan = 1;
                totalLabelCell.HorizontalAlignment = Element.ALIGN_LEFT; // Align to the right
                totalLabelCell.PaddingTop = 5f;
                totalLabelCell.PaddingBottom = 10f;
                totalLabelCell.PaddingLeft = 5f;
                totalLabelCell.BackgroundColor = new BaseColor(0x38, 0xB6, 0xFF);
                totalLabelCell.BorderColor = new BaseColor(0x38, 0xB6, 0xFF);
                totalLabelCell.Phrase.Font.Color = BaseColor.WHITE;
                //totalLabelCell.BorderColor = BaseColor.WHITE;
                pdfTable.AddCell(totalLabelCell);

                PdfPCell totalPriceCell = new PdfPCell(new Phrase("P" , font4));
                totalPriceCell.Colspan = 2; // Span the last two columns
                totalPriceCell.PaddingTop = 5f;
                totalPriceCell.PaddingBottom = 10f;
                totalPriceCell.PaddingLeft = 5f;
                totalPriceCell.BackgroundColor = new BaseColor(0x38, 0xB6, 0xFF);
                totalPriceCell.BorderColor = new BaseColor(0x38, 0xB6, 0xFF);
                totalPriceCell.Phrase.Font.Color = BaseColor.WHITE;
                //totalPriceCell.BorderColor = BaseColor.WHITE;

                pdfTable.AddCell(totalPriceCell);

                document.Add(pdfTable);
            }
            else
            {
                PdfPTable pdfTable = new PdfPTable(data[0].Length);
                pdfTable.SetTotalWidth(new float[] { 100f, 300f, 200f, 250f, 250f });
                iTextSharp.text.Font font3 = iTextSharp.text.FontFactory.GetFont("Proxima Nova", 12, iTextSharp.text.Font.BOLD);

                // Add custom row headers
                string[] rowHeaders = { "ROOM TYPE", "CHECK-IN", "CHECK-OUT", "PRICE PER DAY", "SUBTOTAL" };
                foreach (string header in rowHeaders)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(header, font3));
                    cell.PaddingTop = 5f;
                    cell.PaddingBottom = 10f;
                    cell.PaddingLeft = 5f;

                    cell.BackgroundColor = new BaseColor(0x38, 0xB6, 0xFF);
                    cell.BorderColor = new BaseColor(0x38, 0xB6, 0xFF);
                    cell.Phrase.Font.Color = BaseColor.WHITE;
                    //cell.BorderColor = BaseColor.WHITE;
                    pdfTable.AddCell(cell);
                }
                decimal totalPrice = 0;

                foreach (string[] rowData in data)
                {
                    foreach (string value in rowData)
                    {
                        PdfPCell cell2 = new PdfPCell(new Phrase(value, font));
                        cell2.PaddingTop = 15f;
                        cell2.PaddingBottom = 15f;
                        cell2.PaddingLeft = 5f;

                        cell2.BorderColor = BaseColor.WHITE;
                        pdfTable.AddCell(cell2);

                        if (Array.IndexOf(rowData, value) == 4)
                        {
                            totalPrice += decimal.Parse(value.TrimStart('P').Replace(",", ""));
                            
                        }

                    }
                }

                iTextSharp.text.Font font4 = iTextSharp.text.FontFactory.GetFont("Proxima Nova", 12, iTextSharp.text.Font.BOLD);

                PdfPCell emptyCell = new PdfPCell(new Phrase(""));
                emptyCell.Colspan = 2;
                emptyCell.BorderColor = BaseColor.WHITE;
                pdfTable.AddCell(emptyCell);

                PdfPCell emptyCell2 = new PdfPCell(new Phrase(""));
                emptyCell2.Colspan = 1;
                emptyCell2.BorderColor = BaseColor.WHITE;
                pdfTable.AddCell(emptyCell2);

                PdfPCell totalLabelCell = new PdfPCell(new Phrase("TOTAL", font4));
                totalLabelCell.Colspan = 1;
                totalLabelCell.HorizontalAlignment = Element.ALIGN_LEFT; // Align to the right
                totalLabelCell.PaddingTop = 5f;
                totalLabelCell.PaddingBottom = 10f;
                totalLabelCell.PaddingLeft = 5f;
                totalLabelCell.BackgroundColor = new BaseColor(0x38, 0xB6, 0xFF);
                totalLabelCell.BorderColor = new BaseColor(0x38, 0xB6, 0xFF);
                totalLabelCell.Phrase.Font.Color = BaseColor.WHITE;
                //totalLabelCell.BorderColor = BaseColor.WHITE;
                pdfTable.AddCell(totalLabelCell);

                Console.WriteLine("I'm here: " + totalPrice);
                PdfPCell totalPriceCell = new PdfPCell(new Phrase("P" + totalAmountRoom.ToString("N2"), font4));
                totalPriceCell.Colspan = 2; // Span the last two columns
                totalPriceCell.PaddingTop = 5f;
                totalPriceCell.PaddingBottom = 10f;
                totalPriceCell.PaddingLeft = 5f;
                totalPriceCell.BackgroundColor = new BaseColor(0x38, 0xB6, 0xFF);
                totalPriceCell.BorderColor = new BaseColor(0x38, 0xB6, 0xFF);
                totalPriceCell.Phrase.Font.Color = BaseColor.WHITE;
                //totalPriceCell.BorderColor = BaseColor.WHITE;

                pdfTable.AddCell(totalPriceCell);

                document.Add(pdfTable);

            }
        }
    }
}

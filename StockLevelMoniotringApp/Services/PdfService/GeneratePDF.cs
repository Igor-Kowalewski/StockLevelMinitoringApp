using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using System;
using iText.Kernel.Pdf.Canvas.Draw;
using System.Collections.Generic;
using System.IO;
using System.Text;
using iText.Kernel.Colors;
using iText.Layout.Borders;
using FormUI.Models;

namespace FormUI.Services.PdfService
{
    public class GeneratePDF
    {
        public void ExportPDF()
        {
            var exportFolder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            var exportFile = System.IO.Path.Combine(exportFolder, "Test.pdf");

            using (var writer = new PdfWriter(exportFile))
            {
                using (var pdf = new PdfDocument(writer))
                {
                    var doc = new Document(pdf);
                    doc.Add(new Paragraph("Hello World"));

                }

            }
        }

        public void ExportPDF(string ordernr, string adres1, string adres2, string Client, Company comp, float subtotal, string uwagi)
        {
            var exportFolder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            var exportFile = System.IO.Path.Combine(exportFolder, "Zamówienie " + ordernr + " " + Client + " " + DateTime.Now.ToString("MM/dd/yyyy") + ".pdf");

            string miasto = "Lodz";
            uint lp = 2;

            using (var writer = new PdfWriter(exportFile))
            {
                using (var pdf = new PdfDocument(writer))
                {
                    var doc = new Document(pdf);

                    // Line Separator
                    LineSeparator ls = new LineSeparator(new SolidLine());

                    // New line
                    Paragraph newline = new Paragraph(new Text("\n"));

                    string compInfo = comp.CompanyName + "\n" + comp.Address;
                    // COMPANY NAME
                    Paragraph addresses = new Paragraph();

                    doc.Add(ls);



                    addresses.AddTabStops(new TabStop(1000, TabAlignment.RIGHT));
                    addresses.Add(new Tab());
                    addresses.Add(DateTime.Now.ToString("MM/dd/yyyy") + " " + miasto + "\n");





                    doc.Add(addresses);


                    //TITLE
                    Paragraph title = new Paragraph("WZ " + Client + " " + DateTime.Now.ToString("MM/dd/yyyy"))
                        .SetTextAlignment(TextAlignment.CENTER)
                        .SetFontSize(20);
                    doc.Add(newline);
                    doc.Add(newline);
                    doc.Add(title);
                    doc.Add(newline);
                    doc.Add(newline);
                    doc.Add(newline);
                    doc.Add(newline);

                    // COMPANYS DATA

                    // COMPANY NAME
                    Paragraph temp = new Paragraph()
                        .SetTextAlignment(TextAlignment.LEFT)
                        .SetFontSize(10);

                    temp.AddTabStops(new TabStop(1000, TabAlignment.RIGHT));
                    temp.Add("Firma");
                    temp.Add(new Tab());
                    temp.Add(Client + "\n");
                    temp.Add("Sloneczna 56");
                    temp.Add(new Tab());
                    temp.Add(adres1 + "\n");
                    temp.Add("Lodz, 98-765");
                    temp.Add(new Tab());
                    temp.Add(adres2 + "\n");

                    doc.Add(temp);


                    Table table = new Table(5);
                    table.SetWidth(UnitValue.CreatePercentValue(100));
                    table.SetBorder(Border.NO_BORDER);


                    // info to table
                    Cell[] info = new Cell[5 * (lp + 1)];

                    string[] inf = { "lp.", "Nazwa towaru", "ilosc", "Jm", "Uwagi" };

                    for (int i = 0; i < 5; i++)
                    {
                        Cell c = new Cell(1, 1)
                              .SetBackgroundColor(ColorConstants.GRAY)
                              .SetTextAlignment(TextAlignment.LEFT)
                              .SetBorder(Border.NO_BORDER)
                               .Add(new Paragraph(inf[i]));
                        info[i] = c;
                        table.AddCell(info[i]);
                    }

                    /* List<Cell> pos = new List<Cell>();*/
                    Cell[] pos = new Cell[5 * (lp + 1)];


                    for (int j = 0; j < lp; j++)
                    {
                        for (int i = 0; i < 5; i++)
                        {
                            Cell dat = new Cell(1, 1)
                                  .SetBackgroundColor(ColorConstants.WHITE)
                                  .SetTextAlignment(TextAlignment.RIGHT)
                                  .SetBorder(Border.NO_BORDER)
                                  .Add(new Paragraph("co"));
                            pos[i] = dat;
                            table.AddCell(pos[i]);

                        }

                    }
                    table.SetTextAlignment(TextAlignment.CENTER);
                    doc.Add(table);


                    doc.Add(newline);
                    doc.Add(newline);
                    doc.Add(newline);
                    doc.Add(newline);
                    doc.Add(newline);

                    string dot = "...............................";

                    Paragraph d = new Paragraph(dot)
                       .SetTextAlignment(TextAlignment.LEFT)
                       .SetFontSize(10);

                    d.Add(new Tab());

                    d.AddTabStops(new TabStop(1000, TabAlignment.RIGHT));
                    d.Add(dot);
                    doc.Add(d);


                    string spr = "Towar Sprawdzil i odebral";
                    string odb = "Towar wydal";

                    Paragraph sprodb = new Paragraph(spr)
                       .SetTextAlignment(TextAlignment.LEFT)
                       .SetFontSize(10);

                    sprodb.Add(new Tab());

                    sprodb.AddTabStops(new TabStop(1000, TabAlignment.RIGHT));
                    sprodb.Add(odb);
                    doc.Add(sprodb);









                }

            }
        }
    }
}

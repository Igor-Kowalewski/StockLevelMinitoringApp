using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

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
    }
}

using EngineeringManagement.Core.Contracts;
using EngineeringManagement.Data.Models;
using iText.IO.Font.Constants;
using iText.Kernel.Colors;
using iText.Kernel.Font;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Borders;
using iText.Layout.Element;
using iText.Layout.Properties;

namespace EngineeringManagement.Core.Services
{
    public class PdfGeneratorService : IPdfGeneratorService
    {
        private static readonly PdfFont boldFont = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);

        public void Generate(GeneralEmployee employee, string basePath)
        {
            if (!Directory.Exists(basePath))
            {
                Directory.CreateDirectory(basePath);
            }
            var filePath = Path.Combine(basePath, $"Alcance {employee.EmployeeName}.pdf");
            using var writer = new PdfWriter(filePath);
            using var pdf = new PdfDocument(writer);
            var document = new Document(pdf);

            AddHeader(document);

            AddSectionTitle(document, "DATOS DE INGRESO DEL EMPLEADO (INFORMACIÓN LLENADA POR EL EMPLEADO)");

            document.Close();
        }

        private void AddHeader(Document document)
        {
            var table = new Table(3, false)
            .SetWidth(UnitValue.CreatePercentValue(100))
            .SetTextAlignment(TextAlignment.CENTER);

            table.AddCell(new Cell().Add(new Paragraph("AMERICA ENERGY SERVICE, S.A. DE C.V.").SetFont(boldFont)));
            table.AddCell(new Cell().Add(new Paragraph("RH-PR1-F04").SetFont(boldFont)));

            document.Add(table);
        }

        private static void AddSectionTitle(Document document, string titleText)
        {
            var table = new Table(1).UseAllAvailableWidth();

            var titleCell = new Cell()
                .Add(new Paragraph(titleText).SetFont(boldFont).SetFontSize(12))
                .SetBackgroundColor(ColorConstants.LIGHT_GRAY)
                .SetTextAlignment(TextAlignment.CENTER)
                .SetVerticalAlignment(VerticalAlignment.MIDDLE)
                .SetBorder(new SolidBorder(1))
                .SetPadding(5);

            table.AddCell(titleCell);
            document.Add(table);
        }
    }
}
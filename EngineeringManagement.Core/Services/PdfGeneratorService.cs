using EngineeringManagement.Core.Contracts;
using EngineeringManagement.Data.Models;
using iText.IO.Font.Constants;
using iText.IO.Image;
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
        private static readonly PdfFont regularFont = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);
        private readonly string logoPath;

        public void Generate(GeneralEmployee employee, string basePath, string logoPath)
        {
            if (!Directory.Exists(basePath))
            {
                Directory.CreateDirectory(basePath);
            }
            var filePath = Path.Combine(basePath, $"Alcance {employee.EmployeeName}.pdf");
            using var writer = new PdfWriter(filePath);
            using var pdf = new PdfDocument(writer);
            var document = new Document(pdf);

            AddHeader(document, logoPath);

            AddSectionTitle(document, "DATOS DE INGRESO DEL EMPLEADO (INFORMACIÓN LLENADA POR EL EMPLEADO)");

            AddFirstSection(document);

            document.Close();
        }

        private static void AddFirstSection(Document document)
        {
            // First block of info (2-column layout)
            var table1 = new Table(2).UseAllAvailableWidth();

            table1.AddCell("Nombre:");
            table1.AddCell("ERICK EUGENIO DEL VALLE BALDERAS");

            table1.AddCell("Estado civil:");
            table1.AddCell("SOLTERO");

            table1.AddCell("Correo:");
            table1.AddCell("");

            table1.AddCell("Domicilio:");
            table1.AddCell("AV LAS TORRES 2308 COL LAZARO CARDENAS CP. 89602 ALTAMIRA TAMPS.");

            table1.AddCell("NSS:");
            table1.AddCell("38179900907");

            table1.AddCell("No. Clínica IMSS:");
            table1.AddCell("10");

            table1.AddCell("Teléfono:");
            table1.AddCell("833 323 5657");

            table1.AddCell("No. Crédito Infonavit:");
            table1.AddCell("NO APLICA");

            table1.AddCell("% - VSM - Cuota:");
            table1.AddCell("NO APLICA");

            table1.AddCell("Número de cliente (Fonacot):");
            table1.AddCell("NO APLICA");

            table1.AddCell("CURP:");
            table1.AddCell("VABE990508HTSLLR05");

            table1.AddCell("RFC:");
            table1.AddCell("VABE9905088J4");

            table1.AddCell("Fecha de Nacimiento:");
            table1.AddCell("08/05/1999");

            table1.AddCell("Lugar de Nacimiento:");
            table1.AddCell("CD MADERO TAMPS.");

            table1.AddCell("Grado acad.:");
            table1.AddCell("");

            table1.AddCell("Documento:");
            table1.AddCell("");

            table1.AddCell("Profesión:");
            table1.AddCell("");

            table1.AddCell("Nombre del padre:");
            table1.AddCell("JAIME DEL VALLE OLMEDO");

            table1.AddCell("Nombre de la madre:");
            table1.AddCell("ZOILA BALDERAS RAMIREZ");

            table1.AddCell("Beneficiario:");
            table1.AddCell("ZOILA BALDERAS RAMIREZ");

            table1.AddCell("%:");
            table1.AddCell("100");

            table1.AddCell("Teléfono beneficiario:");
            table1.AddCell("833 104 2230");

            table1.AddCell("Fecha de nacimiento:");
            table1.AddCell("");

            table1.AddCell("Parentesco:");
            table1.AddCell("MADRE");

            table1.AddCell("Domicilio del beneficiario:");
            table1.AddCell("AV LAS TORRES 2308 COL LAZARO CARDENAS CP. 89602 ALTAMIRA TAMPS.");

            table1.AddCell("Cuenta Bancaria:");
            table1.AddCell("");

            table1.AddCell("Tarjeta / Clabe:");
            table1.AddCell("");

            table1.AddCell("Banco:");
            table1.AddCell("");

            document.Add(table1);
            document.Add(new Paragraph().SetHeight(10));
        }

        private static void AddHeader(Document document, string logoPath)
        {
            var headerTable = new Table([1, 2, 3]).UseAllAvailableWidth();

            var logoCell = new Cell();
            string imagePath = Path.Combine(logoPath, "LogoAES.png");
            if (File.Exists(imagePath))
            {
                var logo = new Image(ImageDataFactory.Create(imagePath))
                    .ScaleToFit(100, 100)
                    .SetHorizontalAlignment(HorizontalAlignment.LEFT);
                logoCell.Add(logo);
            }
            headerTable.AddCell(logoCell);

            var middleCell = new Cell();
            middleCell.Add(new Paragraph("AMERICA ENERGY SERVICE, S.A. DE C.V.")
                .SetFont(boldFont)
                .SetTextAlignment(TextAlignment.CENTER));

            middleCell.Add(new Paragraph("ALCANCE DE CONTRATACIÓN")
               .SetFont(boldFont)
               .SetFontSize(14)
               .SetTextAlignment(TextAlignment.CENTER));

            headerTable.AddCell(middleCell);

            var rightCell = new Cell();

            rightCell.Add(new Paragraph("RH-PR1-F04")
                .SetFont(regularFont)
                .SetTextAlignment(TextAlignment.CENTER));

            rightCell.Add(new Paragraph("REV. 01")
                .SetFont(regularFont)
                .SetTextAlignment(TextAlignment.CENTER));

            rightCell.Add(new Paragraph("08/MAR/2023")
                .SetFont(regularFont)
                .SetTextAlignment(TextAlignment.CENTER));

            headerTable.AddCell(rightCell);


            document.Add(headerTable);

            document.Add(new Paragraph("\n"));
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
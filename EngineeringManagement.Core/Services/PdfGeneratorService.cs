using EngineeringManagement.Core.Contracts;
using EngineeringManagement.Core.Extensions;
using EngineeringManagement.Core.Models;
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
        private readonly string logoPath;

        public void Generate(GeneralEmployeeWithExtras employee, string basePath, string logoPath)
        {
            var boldFont = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);
            var regularFont = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);

            if (!Directory.Exists(basePath))
            {
                Directory.CreateDirectory(basePath);
            }
            var filePath = Path.Combine(basePath, $"Alcance {employee.EmployeeName}.pdf");
            using var writer = new PdfWriter(filePath);
            using var pdf = new PdfDocument(writer);
            var document = new Document(pdf);

            AddHeader(document, logoPath, boldFont, regularFont);

            AddFirstSection(document, boldFont, regularFont, employee);

            AddSecondSection(document, boldFont, regularFont, employee);

            document.Close();
        }

        private static void AddSecondSection(Document document, PdfFont boldFont, PdfFont regularFont, GeneralEmployeeWithExtras employee)
        {
            var tableTitle2 = new Table(1).UseAllAvailableWidth();
            tableTitle2.AddCell(new Cell()
                .Add(new Paragraph("INFORMACIÓN LLENADA POR PERSONAL DE LA EMPRESA")
                .SetFont(boldFont).SetFontSize(10))
                .SetBackgroundColor(ColorConstants.LIGHT_GRAY)
                .SetTextAlignment(TextAlignment.CENTER)
                .SetPadding(5));
            document.Add(tableTitle2);
            document.Add(new Paragraph().SetHeight(10));

            // Flexible 6-column layout for second section
            var table2 = new Table([1.2f, 1f, 1.2f, 1f, 1.2f, 1f]).UseAllAvailableWidth().SetFont(regularFont).SetFontSize(9);

            // --- Ingresos / Categoria / Proyecto ---
            table2.AddCell(new Cell()
                .SetBorder(Border.NO_BORDER)
                .Add(new Paragraph("Ingresos:").SetFont(boldFont)));

            table2.AddCell(new Cell()
                .SetBorder(Border.NO_BORDER)
                .Add(new Paragraph($"{employee.StartDate}").SetUnderline()));

            table2.AddCell(new Cell()
                .SetBorder(Border.NO_BORDER)
                .Add(new Paragraph("Categoría:").SetFont(boldFont)));

            table2.AddCell(new Cell()
                .SetBorder(Border.NO_BORDER)
                .Add(new Paragraph($"{employee.Category}").SetUnderline()));

            table2.AddCell(new Cell()
                .SetBorder(Border.NO_BORDER)
                .Add(new Paragraph("Proyecto:").SetFont(boldFont).SetTextAlignment(TextAlignment.LEFT)));

            table2.AddCell(new Cell()
                .SetBorder(Border.NO_BORDER)
                .Add(new Paragraph($"{employee.ProjectNumber}").SetUnderline().SetTextAlignment(TextAlignment.LEFT)));

            // --- header row grouping with right borders ---
            table2.AddCell(new Cell(1, 2)
                .SetBackgroundColor(ColorConstants.LIGHT_GRAY)
                .Add(new Paragraph("Ingresos").SetFont(boldFont).SetTextAlignment(TextAlignment.CENTER)));

            table2.AddCell(new Cell(1, 2)
                .SetBackgroundColor(ColorConstants.LIGHT_GRAY)
                .Add(new Paragraph("Impuestos - Descuentos").SetFont(boldFont).SetTextAlignment(TextAlignment.CENTER)));

            table2.AddCell(new Cell(1, 2)
                .SetBackgroundColor(ColorConstants.LIGHT_GRAY)
                .Add(new Paragraph("Empresa").SetFont(boldFont).SetTextAlignment(TextAlignment.CENTER)));

            // data rows with right borders between sections
            //table2.AddCell(new Cell().SetBorder(Border.NO_BORDER).SetBorderRight(new SolidBorder(1)).Add(new Paragraph("SDB:")));
            //table2.AddCell(new Cell().SetBorder(Border.NO_BORDER).SetBorderRight(new SolidBorder(1)).Add(new Paragraph("$278.80")));
            //table2.AddCell(new Cell().SetBorder(Border.NO_BORDER).SetBorderRight(new SolidBorder(1)).Add(new Paragraph("Infonavit:")));
            //table2.AddCell(new Cell().SetBorder(Border.NO_BORDER).SetBorderRight(new SolidBorder(1)).Add(new Paragraph("NO APLICA")));
            //table2.AddCell(NoBorderCell("AES:"));
            //table2.AddCell(NoBorderCell("X"));

            //table2.AddCell(new Cell().SetBorder(Border.NO_BORDER).SetBorderRight(new SolidBorder(1)).Add(new Paragraph("SDI:")));
            //table2.AddCell(new Cell().SetBorder(Border.NO_BORDER).SetBorderRight(new SolidBorder(1)).Add(new Paragraph("$292.54")));
            //table2.AddCell(new Cell().SetBorder(Border.NO_BORDER).SetBorderRight(new SolidBorder(1)).Add(new Paragraph("% sindical:")));
            //table2.AddCell(new Cell().SetBorder(Border.NO_BORDER).SetBorderRight(new SolidBorder(1)).Add(new Paragraph("SI APLICA")));
            //table2.AddCell(NoBorderCell("Neto Semanal:"));
            //table2.AddCell(NoBorderCell("$ 3,044.75 SEMANALES"));

            //table2.AddCell(new Cell().SetBorder(Border.NO_BORDER).SetBorderRight(new SolidBorder(1)).Add(new Paragraph("Tipo de contrato:")));
            //table2.AddCell(new Cell().SetBorder(Border.NO_BORDER).SetBorderRight(new SolidBorder(1)).Add(new Paragraph("TIEMPO DETERMINADO")));
            //table2.AddCell(new Cell().SetBorder(Border.NO_BORDER).SetBorderRight(new SolidBorder(1)).Add(new Paragraph("Tiempo de contratación:")));
            //table2.AddCell(NoBorderCell("DEL 01 ABRIL 2025 AL 01 MAYO 2025.", 3));

            document.Add(table2);
        }

        private static void AddFirstSection(Document document, PdfFont boldFont, PdfFont regularFont, GeneralEmployeeWithExtras employee)
        {
            // First block of info (2-column layout)
            var tableTitle = new Table(1).UseAllAvailableWidth();
            tableTitle.AddCell(new Cell()
                .Add(new Paragraph("DATOS DE INGRESO DEL EMPLEADO (INFORMACIÓN LLENADA POR EL EMPLEADO)")
                .SetFont(boldFont)
                .SetFontSize(10))
                .SetBackgroundColor(ColorConstants.LIGHT_GRAY)
                .SetTextAlignment(TextAlignment.CENTER)
                .SetPadding(5));
            document.Add(tableTitle);

            // Flexible info table layout (6 columns)
            var table1 = new Table(6).UseAllAvailableWidth().SetFont(regularFont).SetFontSize(9);

            table1.AddCell(NoBorderCell("Nombre:"));
            table1.AddCell(NoBorderCell($"{employee.EmployeeName}").SetUnderline());
            table1.AddCell(NoBorderCell("Estado civil:"));
            table1.AddCell(NoBorderCell($"{employee.MaritalStatus}").SetUnderline());
            table1.AddCell(NoBorderCell("Correo:"));
            table1.AddCell(NoBorderCell($"{employee.Email}").SetUnderline());

            table1.AddCell(NoBorderCell("Domicilio:"));
            table1.AddCell(NoBorderCell($"{employee.Address}", 5).SetUnderline());

            table1.AddCell(NoBorderCell("NSS:"));
            table1.AddCell(NoBorderCell($"{employee.SocialSecurityNumber}").SetUnderline());
            table1.AddCell(NoBorderCell("No. Clínica IMSS:"));
            table1.AddCell(NoBorderCell($"{employee.HospitalNumber}").SetUnderline());
            table1.AddCell(NoBorderCell("Teléfono:"));
            table1.AddCell(NoBorderCell($"{employee.PersonalCellPhone}").SetUnderline());

            table1.AddCell(NoBorderCell("No. Crédito Infonavit:"));
            table1.AddCell(NoBorderCell($"{employee.InfonavitNumber}").SetUnderline());
            table1.AddCell(NoBorderCell("% - VSM - Cuota:"));
            table1.AddCell(NoBorderCell($"{employee.InfonavitPercent}").SetUnderline());
            table1.AddCell(NoBorderCell("Número de cliente (Fonacot):"));
            table1.AddCell(NoBorderCell($"{employee.FonacotClientNumber}").SetUnderline());

            table1.AddCell(NoBorderCell("CURP:"));
            table1.AddCell(NoBorderCell($"{employee.Curp}").SetUnderline());
            table1.AddCell(NoBorderCell("RFC:"));
            table1.AddCell(NoBorderCell($"{employee.Rfc}").SetUnderline());
            table1.AddCell(NoBorderCell("Fecha de Nacimiento:"));
            table1.AddCell(NoBorderCell($"{employee.BirthDate.Value:d}").SetUnderline());

            table1.AddCell(NoBorderCell("Lugar de Nacimiento:", 2));
            table1.AddCell(NoBorderCell($"{employee.BirthPlace}", 5).SetUnderline());

            table1.AddCell(NoBorderCell("Grado acad."));
            table1.AddCell(NoBorderCell($"{employee.AcademicDegree}").SetUnderline());
            table1.AddCell(NoBorderCell("Documento:"));
            table1.AddCell(NoBorderCell($"{employee.AcademicDegreeDocument}").SetUnderline());
            table1.AddCell(NoBorderCell("Profesión:"));
            table1.AddCell(NoBorderCell($"{employee.Profession}").SetUnderline());

            table1.AddCell(NoBorderCell("Nombre del padre:"));
            table1.AddCell(NoBorderCell($"{employee.FatherName}", 5).SetUnderline());

            table1.AddCell(NoBorderCell("Nombre de la madre:"));
            table1.AddCell(NoBorderCell($"{employee.MotherName}", 5).SetUnderline());

            table1.AddCell(NoBorderCell("Beneficiario:"));
            table1.AddCell(NoBorderCell($"{employee.EmergencyContactName}").SetUnderline());
            table1.AddCell(NoBorderCell("%:"));
            table1.AddCell(NoBorderCell($"{employee.BenefitiaryPercent}").SetTextAlignment(TextAlignment.LEFT).SetUnderline());
            table1.AddCell(NoBorderCell("Teléfono beneficiario:"));
            table1.AddCell(NoBorderCell($"{employee.EmergencyPhoneNumber}").SetUnderline());

            table1.AddCell(NoBorderCell("Fecha de nacimiento:"));
            table1.AddCell(NoBorderCell($"{employee.BenefitiaryBirthDate.Value:d}", 5).SetUnderline());

            table1.AddCell(NoBorderCell("Parentesco:"));
            table1.AddCell(NoBorderCell($"{employee.EmergencyContactRelationShip}").SetUnderline());
            table1.AddCell(NoBorderCell("Domicilio del beneficiario:"));
            table1.AddCell(NoBorderCell($"{employee.BenefitiaryAddress}", 3).SetUnderline());

            table1.AddCell(NoBorderCell("Cuenta Bancaria:"));
            table1.AddCell(NoBorderCell($"{employee.BankAccountNumber}").SetUnderline());
            table1.AddCell(NoBorderCell("Tarjeta / Clabe:"));
            table1.AddCell(NoBorderCell($"{employee.BankAccountCard}").SetUnderline());
            table1.AddCell(NoBorderCell("Banco:"));
            table1.AddCell(NoBorderCell($"{employee.BankName}").SetUnderline());


            document.Add(table1);
            document.Add(new Paragraph().SetHeight(10)); // Spacer
        }

        private static void AddHeader(Document document, string logoPath, PdfFont boldFont, PdfFont regularFont)
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

            document.Add(new Paragraph().SetHeight(10)); // Spacer
        }

        private static Cell NoBorderCell(string text)
        {
            return new Cell().SetBorder(Border.NO_BORDER).Add(new Paragraph(text));
        }

        private static Cell NoBorderCell(string text, int colspan)
        {
            return new Cell(1, colspan).SetBorder(Border.NO_BORDER).Add(new Paragraph(text));
        }
    }
}
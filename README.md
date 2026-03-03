# Engineering Management System (Technical Prototype)

A specialized desktop ERP prototype built for personnel management, focusing on certification tracking and automated legal documentation for industrial plants.

> **Status: Alpha / Technical Prototype** > This project was developed as a solution for a specific industrial client. While currently in an early alpha state, it showcases complex business logic, automated document generation, and modern .NET architecture.

---

## 🛠️ Technical Architecture

Unlike traditional "Drag-and-Drop" WinForms apps, this project implements a modern architectural approach:

- **Framework:** .NET 8 (Windows)
- **ORM:** Entity Framework Core 8 using a **Code-First** approach. Managed database schema evolution through **EF Migrations**, ensuring consistent data structures across development and local environments.
- **Inversion of Control:** Implemented **Microsoft.Extensions.DependencyInjection** to manage service lifetimes and promote decoupled code.
- **Reporting:** Utilized **iText 9** for programmatic PDF generation and **ClosedXML** for spreadsheet data exports.

---

## 💡 Key Engineering Challenges

### 📄 Programmatic PDF Automation
One of the most complex features was the automated contract renewal engine. 
- **The Challenge:** Generating legal contracts dynamically based on employee database records.
- **The Solution:** Developed a logic-heavy PDF builder that maps DB entities directly into iText document structures, ensuring that contract renewals are always based on the most recent personnel data.

### 🔐 Certification & Compliance Logic
The system handles more than just basic CRUD operations; it manages **conditional access logic**. 
- Implemented a validation layer to determine if an employee is eligible for specific plant work based on the expiration dates and types of their professional certifications.

### 📅 Proactive Expiration Tracking
Designed a specialized monitoring screen (in Alpha) that queries the database for contracts expiring within a 10-day window, providing a "Red-Alert" dashboard for HR management.

---

## 📂 Project Structure

The solution is divided into three distinct layers to ensure separation of concerns:

- **EngineeringManagement.UI:** The WinForms presentation layer with DI container configuration.
- **EngineeringManagement.Core:** Business logic, Domain models, and interface definitions.
- **EngineeringManagement.Data:** EF Core DbContext, migrations, and repository implementations.

---

## 🔧 Skills Showcased
- **C# / .NET 8**
- **Entity Framework Core (Code First)**
- **Dependency Injection**
- **File I/O & Document Automation (PDF/Excel)**
- **UI Responsiveness (Code-Behind optimizations)**

---
*Developed by [Darkk3n](https://github.com/Darkk3n) as a custom solution for personnel compliance.*

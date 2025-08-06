using EngineeringManagement.Core.Contracts;
using EngineeringManagement.Core.Services;
using EngineeringManagement.UI.Forms;
using EngineeringManagement.UI.Forms.Certifications;
using EngineeringManagement.UI.Forms.Employees;
using EngineeringManagement.UI.Forms.ExceptionHandler;
using EngineeringManagement.UI.Forms.GeneralEmployeeForm;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using HrDataContext = EngineeringManagement.Data.HrDataContext;

namespace EngineeringManagement.UI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var services = new ServiceCollection();
            ConfigureServices(services);

            var serviceProvider = services.BuildServiceProvider();
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            using (var scope = serviceProvider.CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<HrDataContext>();
                context.Database.Migrate();
            }
            if (!Directory.Exists(Path.Combine(Application.StartupPath, "Documentos")))
            {
                Directory.CreateDirectory(Path.Combine(Application.StartupPath, "Documentos"));
            }

            Application.ThreadException += new ThreadExceptionEventHandler(UIThreadException);
            // Set the unhandled exception mode to force all Windows Forms errors to go through
            // our handler.
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);

            // Add the event handler for handling non-UI thread exceptions to the event.
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);
            var mainForm = serviceProvider.GetRequiredService<MainForm>();
            Application.Run(mainForm);
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            #region Forms
            services.AddTransient<MainForm>();
            services.AddTransient<AddCertification>();
            services.AddTransient<AddEmployeeCertification>();
            services.AddTransient<AddEmployeeCertification2>();
            services.AddTransient<EditCertification>();
            services.AddTransient<EditEmployeeCertification>();
            services.AddTransient<AddEmployee>();
            services.AddTransient<EditEmployee>();
            services.AddTransient<EmployeeMedFileForm>();
            services.AddTransient<ExceptionHandlerForm>();
            services.AddTransient<AddFacility>();
            services.AddTransient<EditFacility>();
            services.AddTransient<GeneralEmployeeForm>();
            services.AddTransient<EmployeeContractGenerator>();
            services.AddTransient<EmployeeScopeOfContractGenerator>();
            #endregion

            #region Services
            services.AddTransient<ICopyFilesService, CopyFilesService>();
            services.AddTransient<IEmployeeListService, EmployeeListService>();
            services.AddTransient<IOpenFileService, OpenFileService>();
            services.AddTransient<IPdfGeneratorService, PdfGeneratorService>();
            #endregion

            services.AddDbContext<HrDataContext>(options => options.UseSqlite($"Data Source = {Path.Combine(Environment.CurrentDirectory + @"\EngineeringManagement.db")}"));
        }

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            throw new NotImplementedException();
        }

        private static void UIThreadException(object sender, ThreadExceptionEventArgs t)
        {

            using var handler = new ExceptionHandlerForm(t.Exception);
            handler.ShowDialog();
        }
    }
}
using System.Windows.Forms.Design;
using EngineeringManagement.Core.Contracts;
using EngineeringManagement.Core.Services;
using EngineeringManagement.UI.Forms.ExceptionHandler;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

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
         using (var context = new Data.AppContext())
         {
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
         Application.Run(new MainForm());
      }

      private static void ConfigureServices(IServiceCollection services)
      {
         services.AddTransient<ICopyFilesService, CopyFilesService>();
         services.AddTransient<IEmployeeListService, EmployeeListService>();
         services.AddTransient<IOpenFileService, OpenFileService>();
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
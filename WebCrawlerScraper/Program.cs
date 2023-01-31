using Autofac;
using WebCrawlerScraper.Utils.DependencyInjection;
using WebCrawlerScraper.Utils.Interfaces;

namespace WebCrawlerScraper
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Autofac.IContainer container = ContainerConfig.Configure();
            IDataCollectionManager _dataCollectionManager = container.Resolve<IDataCollectionManager>();
            IInputValidator _inputValidator = container.Resolve<IInputValidator>();

            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new PresentationLayer(_dataCollectionManager , _inputValidator));
        }
    }
}
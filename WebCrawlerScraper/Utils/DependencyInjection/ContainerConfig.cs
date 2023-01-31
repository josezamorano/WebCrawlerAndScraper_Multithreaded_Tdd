using Autofac;
using WebCrawlerScraper.DataAccessLayer.IOFiles;
using WebCrawlerScraper.DataAccessLayer.RemoteWebSites;
using WebCrawlerScraper.DomainLayer;
using WebCrawlerScraper.Services;
using WebCrawlerScraper.Utils.Interfaces;

namespace WebCrawlerScraper.Utils.DependencyInjection
{
    public static class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new Autofac.ContainerBuilder();
            builder.RegisterType<CsvFileProvider>().As<ICsvFileProvider>();
            builder.RegisterType<DataCollectionManager>().As<IDataCollectionManager>();
            builder.RegisterType<DirectoryProvider>().As<IDirectoryProvider>();
            builder.RegisterType<DownloadProvider>().As<IDownloadProvider>();
            builder.RegisterType<FileActivityManager>().As<IFileActivityManager>();
            builder.RegisterType<FileHelper>().As<IFileHelper>();
            builder.RegisterType<HtmlParser>().As<IHtmlParser>();
            builder.RegisterType<InputValidator>().As<IInputValidator>();
            builder.RegisterType<LinkInspector>().As<ILinkInspector>();
            builder.RegisterType<PathProvider>().As<IPathProvider>();
            builder.RegisterType<TextFileProvider>().As<ITextFileProvider>();
            builder.RegisterType<WebSiteCrawler>().As<IWebSiteCrawler>();
            builder.RegisterType<WebSiteScraper>().As<IWebSiteScraper>();



            return builder.Build();
        }
    }
}

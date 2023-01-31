namespace WebCrawlerScraper.DomainLayer.Models
{
    public class WebScraperInfo
    {
        public string ScrapingFolderFullPath { get; set; }
        public string XPathExpression { get; set; }
        public Queue<string> AllTextFilesToScrape { get; set; }

        public PresentationScrapeReportDelegate ScrapeReportCallback { get; set; }
    }
}

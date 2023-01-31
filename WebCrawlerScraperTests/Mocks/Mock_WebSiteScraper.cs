using WebCrawlerScraper.DomainLayer.Models;
using WebCrawlerScraper.Utils.Interfaces;

namespace WebCrawlerScraperTests.Mocks
{
    internal class Mock_WebSiteScraper : IWebSiteScraper
    {
        public void RunScraperMultithreaded(WebScraperInfo webScraperInfo)
        {
            string result = "callback called";
            webScraperInfo.ScrapeReportCallback(result);
        }
    }
}

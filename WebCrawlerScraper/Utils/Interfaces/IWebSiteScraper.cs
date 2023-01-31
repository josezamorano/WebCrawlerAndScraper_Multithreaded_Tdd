using WebCrawlerScraper.DomainLayer.Models;

namespace WebCrawlerScraper.Utils.Interfaces
{
    public interface IWebSiteScraper
    {
        void RunScraperMultithreaded(WebScraperInfo webScraperInfo);
    }
}

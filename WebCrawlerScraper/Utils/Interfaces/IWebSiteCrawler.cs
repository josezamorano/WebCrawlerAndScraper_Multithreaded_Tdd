using WebCrawlerScraper.DomainLayer;
using WebCrawlerScraper.DomainLayer.Models;

namespace WebCrawlerScraper.Utils.Interfaces
{
    public interface IWebSiteCrawler
    {
        void RunCrawlerMultithreaded(WebCrawlerInfo webCrawlerInfo);
    }
}

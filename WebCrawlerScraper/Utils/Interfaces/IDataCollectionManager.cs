using WebCrawlerScraper.DomainLayer.Models;

namespace WebCrawlerScraper.Utils.Interfaces
{
    public interface IDataCollectionManager
    {
        void RunCrawler(WebCrawlerInfo webCrawlerInfo);

        List<string> GetAllFilesInSelectedDirectory(string folderFullPath);

        void RunScraper(WebScraperInfo webScraperInfo);
    }
}

namespace WebCrawlerScraper.Utils.Interfaces
{
    public interface IDownloadProvider
    {
        Task<string> DownloadPageAsyncUsingPuppeteer(string fullUrl);
        string DownloadPageUsingSelenium(string fullUrl);
    }
}

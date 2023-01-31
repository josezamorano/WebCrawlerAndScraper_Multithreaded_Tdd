namespace WebCrawlerScraper.Utils.Interfaces
{
    public interface IHtmlParser
    {
        List<string> GetLinks(string htmlContent);
    }
}

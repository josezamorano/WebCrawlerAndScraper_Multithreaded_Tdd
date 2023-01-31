namespace WebCrawlerScraper.Utils.Interfaces
{
    public interface ITextFileProvider
    {
        bool WriteToTextFile(string fullFilePath, string htmlFileContent);
        string ReadFromTextFile(string fullFilePath);
    }
}

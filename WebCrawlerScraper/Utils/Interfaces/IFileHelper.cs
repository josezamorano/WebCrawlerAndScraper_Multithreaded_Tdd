using WebCrawlerScraper.DataAccessLayer.IOFiles.Models;
using WebCrawlerScraper.Utils.Enumerations;

namespace WebCrawlerScraper.Utils.Interfaces
{
    public interface IFileHelper
    {
        string CreateUniqueName(string originalName, FileExtension? fileExtension);
        string RemoveSpecialCharacters(string originaFileName);
        string ConvertCsvDataPropertiesTostring(CsvDataFormat data);
    }
}

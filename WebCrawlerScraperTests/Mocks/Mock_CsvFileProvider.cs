using WebCrawlerScraper.DataAccessLayer.IOFiles.Models;
using WebCrawlerScraper.Utils.Interfaces;

namespace WebCrawlerScraperTests.Mocks
{
    public class Mock_CsvFileProvider : ICsvFileProvider
    {
        public bool AddSingleRecordToCsvFile(string fileFullPathName, string record)
        {
            return true;
        }

        public bool CreateCsvFile(string fileFullPathName)
        {
            return true;
        }

        public bool CreateHeaderCsvFile(string fileFullPathName)
        {
            return true;
        }
    }
}

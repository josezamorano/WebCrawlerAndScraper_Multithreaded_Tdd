using WebCrawlerScraper.DataAccessLayer.IOFiles.Models;
using WebCrawlerScraper.DomainLayer.Models;
using WebCrawlerScraper.Utils.Enumerations;

namespace WebCrawlerScraper.Utils.Interfaces
{
    public interface IFileActivityManager
    {
        string CreateFullPathFileName(string originalFileName, string folderFullPath, FileExtension? fileExtension);

        CsvDataFormat CreateSingleCsvRecord(KeyValuePair<string, CrawledLinkInfo> crawledLink);

        bool CreateCsvFile(string fileFullPathName);

        bool CreateHeaderInCsvFile(string fileFullPathName);
        
        bool SaveSingleRecordToCSVFile(string fileFullPathName, CsvDataFormat record);

        bool SaveSingleRecordToCSVFile(string fileFullPathName, string record);

        bool WriteToTxtFile(string fullFilePath, string fileContent);

        string ReadFromTxtFile(string fullFilePath);

        List<string> GetAllFilesInDirectory(string folderFullPath);

        bool CreateDirectoryIfNotExist(string directoryFullPath);

        string GetFileName(string fileFullPath);
    }
}

﻿using WebCrawlerScraper.DomainLayer.Models;
using WebCrawlerScraper.Utils.Interfaces;

namespace WebCrawlerScraper.DomainLayer
{
    public delegate void CrawlReportDelegate(CrawlExecutionReport crawlReport);
    public class DataCollectionManager : IDataCollectionManager
    {       

        IWebSiteCrawler _webSiteCrawler;
        IWebSiteScraper _webSiteScraper;
        IFileActivityManager _fileActivityManager;
        public DataCollectionManager(IWebSiteCrawler webSiteCrawler, IWebSiteScraper webSiteScraper, IFileActivityManager fileActivityManager)
        {
            _webSiteCrawler = webSiteCrawler;
            _webSiteScraper = webSiteScraper;
            _fileActivityManager = fileActivityManager;
        }

        //Tested
        public void RunCrawler(WebCrawlerInfo webCrawlerInfo) 
        {
            void GetReport(CrawlExecutionReport crawlExecutionReport)
            {
                string notification = $"Process completed. Used { crawlExecutionReport.ThreadsUsed.Count } threads. Saved {crawlExecutionReport.CrawledLinksPositiveResult.Count} to the folder";
                webCrawlerInfo.PresentationReportCallback(notification);
            }
            CrawlReportDelegate crawlReportCallback = new CrawlReportDelegate(GetReport);

            webCrawlerInfo.CrawlReportCallback = crawlReportCallback;
            _webSiteCrawler.RunCrawlerMultithreaded(webCrawlerInfo);         
        }

        //Tested
        public List<string> GetAllFilesInSelectedDirectory(string folderFullPath)
        {
            //List<string> 
            var allFiles =  _fileActivityManager.GetAllFilesInDirectory(folderFullPath);
            List<string> txtFiles = allFiles.Where(a=>a.EndsWith(".txt")).ToList();
            return txtFiles;

        }

        //Tested
        public void RunScraper(WebScraperInfo webScraperInfo)
        {
            _webSiteScraper.RunScraperMultithreaded(webScraperInfo);
        }

    }
}

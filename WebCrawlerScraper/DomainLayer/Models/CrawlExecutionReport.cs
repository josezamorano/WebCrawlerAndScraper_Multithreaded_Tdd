﻿namespace WebCrawlerScraper.DomainLayer.Models
{
    public class CrawlExecutionReport
    {
        public List<Thread> ThreadsUsed { get; set; }
        public SortedDictionary<string, CrawledLinkInfo> CrawledLinksPositiveResult { get; set; }
        public SortedDictionary<string, CrawledLinkInfo> CrawledLinksFailedResult { get; set; }
        public SortedDictionary<string, CrawledLinkInfo> LinksPendingCrawling { get; set; }

    }
}

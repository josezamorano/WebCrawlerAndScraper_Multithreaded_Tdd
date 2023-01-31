using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebCrawlerScraper.DomainLayer.Models
{
    public class WebCrawlerInfo
    {
        public Uri Uri { get; set; }

        public int TotalPagesToSearch { get; set; }

        public string ReportFolderFullPath { get; set; }
        public PresentationCrawlReportDelegate PresentationReportCallback { get; set; }

        public CrawlReportDelegate CrawlReportCallback { get; set; }


    }
}

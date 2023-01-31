namespace WebCrawlerScraper.Services.Models
{
    public class InputsForValidation
    {
        //Crawl Inputs
        public string UrlText { get; set; }
        public string TotalPagesForSearchText { get; set; }

        public RadioButton RadioBtnSearchAllPages { get; set; }

        public RadioButton RadioBtnSearchCount { get; set; }

        public string ReportFolder { get; set; }

        //Scrape Inputs

        public string ScrapingFolderPath { get; set; }

        public Queue<string> AllCheckedTxtFiles { get; set; }

        public string XPathExpression { get; set; }
    }
}

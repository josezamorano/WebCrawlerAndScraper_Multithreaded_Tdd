using WebCrawlerScraper.Services.Models;

namespace WebCrawlerScraper.Utils.Interfaces
{
    public interface IInputValidator
    {
        CrawlInputValidationReport ValidateCrawlInputs(InputsForValidation inputsForValidation);

        ScrapeInputValidationReport ValidateScrapeInputs(InputsForValidation inputsForValidation);
    }
}

using WebCrawlerScraper.Services.Models;
using WebCrawlerScraper.Utils.Interfaces;

namespace WebCrawlerScraper.Services
{
    public class InputValidator : IInputValidator
    {        
        ILinkInspector _linkInspector;
        CrawlInputValidationReport _crawlInputValidationReport;
        ScrapeInputValidationReport _scrapeInputValidationReport;
        public InputValidator(ILinkInspector linkInspector)
        {
            _linkInspector = linkInspector;
            _crawlInputValidationReport = new CrawlInputValidationReport();
            _scrapeInputValidationReport = new ScrapeInputValidationReport();
        }

        //Tested
        public CrawlInputValidationReport ValidateCrawlInputs(InputsForValidation inputsForValidation)
        {
            SetCrawlReportInitialState();

            bool _urlIsValid = ResolveUriValidation(inputsForValidation.UrlText);
            bool _optionsAreValid = ResolveSearchOptionsValidation(inputsForValidation.RadioBtnSearchAllPages, inputsForValidation.RadioBtnSearchCount);
            bool _totalPagesForSearchAreValid = ResolveTotalPagesForSearchValidation(inputsForValidation.TotalPagesForSearchText, inputsForValidation.RadioBtnSearchCount);
            bool _folderIsSelected = ResolveReportFolderValidation(inputsForValidation.ReportFolder);

            if (!_urlIsValid || !_optionsAreValid || !_totalPagesForSearchAreValid || !_folderIsSelected)
            {
                _crawlInputValidationReport.AllCrawlInputsAreValid = false;
            }

            return _crawlInputValidationReport;
        }

        //Tested
        public ScrapeInputValidationReport ValidateScrapeInputs(InputsForValidation inputsForValidation)
        {
            SetScrapeReportInitialState();

            bool scrapingFolderIsValid = ResolveCrapingFolderPath(inputsForValidation.ScrapingFolderPath);
            bool checkedFoldersAreValid = ResolveCheckedTextFiles(inputsForValidation.AllCheckedTxtFiles);
            bool xPathExpressionIsValid = ResolveXPathExpression(inputsForValidation.XPathExpression);

            if (!scrapingFolderIsValid || !checkedFoldersAreValid || !xPathExpressionIsValid)
            {
                _scrapeInputValidationReport.AllScrapeInputsAreValid = false;
            }

            return _scrapeInputValidationReport;
        }


        #region Private Methods 

        private void SetCrawlReportInitialState()
        {
            _crawlInputValidationReport.AllCrawlInputsAreValid = true;
            _crawlInputValidationReport.UrlLabelReport = string.Empty;
            _crawlInputValidationReport.OptionsLabelReport = string.Empty;
            _crawlInputValidationReport.PagesCountLabelReport = string.Empty;
            _crawlInputValidationReport.SelectedFolderReport = string.Empty;
        }

        private bool ResolveUriValidation(string urlText)
        {
            Uri urlForSearch;
            bool uriIsValid = Uri.TryCreate(urlText, UriKind.Absolute, out urlForSearch);

            var uriIsWellFormatted = (uriIsValid) ? (_linkInspector.IsUriSchemeValid(urlForSearch.Scheme)) : false;
            if (!uriIsWellFormatted)
            {
                _crawlInputValidationReport.UrlLabelReport = NotificationMessage.WarningUrlMalformed;
                return false;
            }

            return true;
        }

        private bool ResolveSearchOptionsValidation(RadioButton radioBtnSearchAllPages, RadioButton radioBtnSearchCount)
        {
            if(radioBtnSearchAllPages == null || radioBtnSearchCount == null)
            {
                _crawlInputValidationReport.OptionsLabelReport = NotificationMessage.WarningSelectAnOption;

                return false;
            }

            if (!radioBtnSearchAllPages.Checked && !radioBtnSearchCount.Checked)
            {
                _crawlInputValidationReport.OptionsLabelReport = NotificationMessage.WarningSelectAnOption;

                return false;
            }

            return true;
        }

        private bool ResolveTotalPagesForSearchValidation(string totalPagesForSearchText, RadioButton radioBtnSearchCount)
        {
            //Note: Validation just in case the variable totalPagesForSearchText ever comes without value due to some code change
            if (InputIsNullEmptyOrWhiteSpace(totalPagesForSearchText))
            {
                _crawlInputValidationReport.PagesCountLabelReport = NotificationMessage.WarningSelectNumberGreaterThanZero;

                return false;
            }

            int defaultValue = 0;
            var numberIsValid = Int32.TryParse(totalPagesForSearchText, out defaultValue);
            if (numberIsValid)
            {
                if (radioBtnSearchCount != null && radioBtnSearchCount.Checked && defaultValue < 1)
                {
                    _crawlInputValidationReport.PagesCountLabelReport =NotificationMessage.WarningSelectNumberGreaterThanZero;

                    return false;
                }
            }

            return true;
        }

        private bool ResolveReportFolderValidation( string reportFolder)
        {
            if (InputIsNullEmptyOrWhiteSpace(reportFolder))
            {
                _crawlInputValidationReport.SelectedFolderReport = NotificationMessage.WarningSelectFolder;

                return false;
            }

            return true;
        }

        private bool InputIsNullEmptyOrWhiteSpace(string input)
        {
            if(!string.IsNullOrEmpty(input) && !string.IsNullOrWhiteSpace(input))
            {
                return false;
            }
            return true;
        }
               
        private void SetScrapeReportInitialState()
        {
            _scrapeInputValidationReport.AllScrapeInputsAreValid = true;
            _scrapeInputValidationReport.AlltxtFilesReport = string.Empty;
            _scrapeInputValidationReport.ScrapingFolderPathReport = string.Empty;
            _scrapeInputValidationReport.XPathExpressionReport= string.Empty;
        }

        private bool ResolveCrapingFolderPath(string scrapeFolderPath)
        {
            if (InputIsNullEmptyOrWhiteSpace(scrapeFolderPath))
            {
                _scrapeInputValidationReport.ScrapingFolderPathReport = NotificationMessage.WarningScrapingFolder;

                return false;
            }
            return true;
        }

        private bool ResolveCheckedTextFiles(Queue<string> allCheckedTxtFiles)
        {
            if (allCheckedTxtFiles != null && allCheckedTxtFiles.Count > 0)
            {
                return true;
            }
            _scrapeInputValidationReport.AlltxtFilesReport = NotificationMessage.WarningTextFileNotSelected;

            return false;
        }

        private bool ResolveXPathExpression(string xPathExpression)
        {

            if (InputIsNullEmptyOrWhiteSpace(xPathExpression))
            {
                _scrapeInputValidationReport.XPathExpressionReport = NotificationMessage.WarningXPathExpression;

                return false;
            }
            return true;
        }

        #endregion Private Methods
    }
}

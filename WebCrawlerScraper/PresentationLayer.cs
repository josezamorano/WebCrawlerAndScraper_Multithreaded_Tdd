using System.Data;
using WebCrawlerScraper.DomainLayer.Models;
using WebCrawlerScraper.Services.Models;
using WebCrawlerScraper.Utils.Interfaces;

namespace WebCrawlerScraper
{
    public delegate void PresentationCrawlReportDelegate(string pathFile);

    public delegate void PresentationScrapeReportDelegate(string report);
    public partial class PresentationLayer : Form
    {
        IDataCollectionManager _dataCollectionManager;
        IInputValidator _inputValidator;

        public PresentationLayer(IDataCollectionManager dataCollectionManager, IInputValidator inputValidator)
        {
            _dataCollectionManager = dataCollectionManager;
            _inputValidator = inputValidator;
            InitializeComponent();            
        }

        private void txtUrl_KeyPress(object sender, KeyPressEventArgs e)
        {
            lblWarningUrl.Text = "Url Format: https://www.example.com";
            lblWarningUrl.ForeColor = Color.Black;
        }

        private void radioBtnSearchAllPages_CheckedChanged(object sender, EventArgs e)
        {
            lblWarningOptions.Text = string.Empty;
            lblWarningSearchCount.Text = "Insert only Complete Numbers not decimals";
            lblWarningSearchCount.ForeColor= SystemColors.ControlText;
            if (radioBtnSearchAllPages.Checked)
            {
                txtTotalPages.Enabled = false;
                txtTotalPages.ReadOnly = true;
                txtTotalPages.Text = "0";
                radioBtnSearchCount.Checked = false;
            }
        }

        private void radioBtnSearchCount_CheckedChanged(object sender, EventArgs e)
        {
            lblWarningOptions.Text = string.Empty;
            lblWarningSearchCount.Text = "Insert only Complete Numbers not decimals";
            lblWarningSearchCount.ForeColor = SystemColors.ControlText;
            if (radioBtnSearchCount.Checked)
            {
                txtTotalPages.Enabled = true;
                txtTotalPages.ReadOnly = false;
                txtTotalPages.Text = string.Empty;
                radioBtnSearchAllPages.Checked = false;               
            }
        }

        private void txtTotalPages_KeyPress(object sender, KeyPressEventArgs e)
        {
            lblWarningSearchCount.Text = "Insert only Complete Numbers not decimals";
            lblWarningSearchCount.ForeColor= Color.Black;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                DialogResult folderBrowserResult = folderBrowserDialog.ShowDialog();

                if (folderBrowserResult == DialogResult.OK && !string.IsNullOrEmpty(folderBrowserDialog.SelectedPath) && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
                {
                    txtReportFolder.Text = folderBrowserDialog.SelectedPath;
                    txtReportFolder.BackColor = txtReportFolder.BackColor;
                    txtReportFolder.ForeColor = Color.Black;
                }
            }
        }

        private void btnStartCrawler_Click(object sender, EventArgs e)
        {
            var inputsAreValid = ResolveCrawlInputsValidation();
            if (!inputsAreValid) { return; }

            btnStartCrawler.Enabled = false; 
            PresentationCrawlReportDelegate presentationReportCallback = new PresentationCrawlReportDelegate(GetCrawlReportResult);
            WebCrawlerInfo webCrawlerInfo = new WebCrawlerInfo()
            {
                Uri = new Uri(txtUrl.Text),
                TotalPagesToSearch = int.Parse(txtTotalPages.Text),
                ReportFolderFullPath = txtReportFolder.Text,
                PresentationReportCallback = presentationReportCallback
            };

            _dataCollectionManager.RunCrawler(webCrawlerInfo);
        }

        private void btnScrapingFolder_Click(object sender, EventArgs e)
        {
            checkedListBoxAlltxtFiles.Items.Clear();

            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                DialogResult folderBrowserResult = folderBrowserDialog.ShowDialog();
                if (folderBrowserResult == DialogResult.OK && !string.IsNullOrEmpty(folderBrowserDialog.SelectedPath) && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
                {
                    txtScrapingFolder.Text = folderBrowserDialog.SelectedPath;
                    txtScrapingFolder.BackColor = txtReportFolder.BackColor;
                    txtScrapingFolder.ForeColor = Color.Black;

                    List<string> allFiles = _dataCollectionManager.GetAllFilesInSelectedDirectory(folderBrowserDialog.SelectedPath);   
                    checkedListBoxAlltxtFiles.Items.AddRange(allFiles.ToArray());
                    lblFilesFoundInFolder.Text = $"A total of {allFiles.Count.ToString()} .TXT files were found in the Folder.";
                }
            }
        }

        private void checkBoxSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            lblWarningListBox.Text= string.Empty;
            bool allItemsChecked = (checkBoxSelectAll.Checked) ? SetCheckedStateInAllItems(true) : SetCheckedStateInAllItems(false);
        }

        private void checkedListBoxAlltxtFiles_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                lblWarningListBox.Text = string.Empty;
            }
        }

        private void txtXPathExpression_Click(object sender, EventArgs e)
        {
            txtXPathExpression.Text = string.Empty;
            txtXPathExpression.BackColor = txtXPathExpression.BackColor;
            txtXPathExpression.ForeColor = Color.Black;
        }

        private void btnRunScraper_Click(object sender, EventArgs e)
        {
            //Validation Report
            var inputsAreValid = ResolveScrapeInputsValidation();
            if (!inputsAreValid) { return; }

            btnRunScraper.Enabled = false;
            Queue<string> allCheckedItems = GetAllCheckedTextFiles();
            PresentationScrapeReportDelegate reportCallback = new PresentationScrapeReportDelegate(GetScrapeReportResult);
            WebScraperInfo webScrapeInfo = new WebScraperInfo()
            {
                ScrapingFolderFullPath = txtScrapingFolder.Text,
                AllTextFilesToScrape = allCheckedItems,
                ScrapeReportCallback = reportCallback,
                XPathExpression = txtXPathExpression.Text,
            };
            _dataCollectionManager.RunScraper(webScrapeInfo);
        }

        #region Helper Methods

        private bool ResolveCrawlInputsValidation()
        {
            InputsForValidation crawlInputsForValidation = new InputsForValidation()
            {
                UrlText = txtUrl.Text,
                TotalPagesForSearchText = txtTotalPages.Text,
                RadioBtnSearchAllPages = radioBtnSearchAllPages,
                RadioBtnSearchCount = radioBtnSearchCount,
                ReportFolder= txtReportFolder.Text,
            };
    
            CrawlInputValidationReport crawlInputValidationReport = _inputValidator.ValidateCrawlInputs(crawlInputsForValidation);

            if (!crawlInputValidationReport.AllCrawlInputsAreValid)
            {
                lblWarningUrl.Text = crawlInputValidationReport.UrlLabelReport;
                lblWarningUrl.ForeColor = Color.Red;
                lblWarningOptions.Text = crawlInputValidationReport.OptionsLabelReport;
                lblWarningSearchCount.Text = crawlInputValidationReport.PagesCountLabelReport;
                lblWarningSearchCount.ForeColor = Color.Red;
                txtReportFolder.Text = crawlInputValidationReport.SelectedFolderReport;
                txtReportFolder.BackColor = txtReportFolder.BackColor;
                txtReportFolder.ForeColor = Color.Red;

                return false;
            }

            return true;
        }

        private void GetCrawlReportResult (string reportResult)
        {
            btnStartCrawler.BeginInvoke(() => 
            {
                btnStartCrawler.Enabled = true;
                this.btnStartCrawler.Refresh();
            });

            lblReportResult.BeginInvoke(() =>
            {
                lblReportResult.Text = reportResult;
                this.lblReportResult.Refresh();
            });
        }

        private bool SetCheckedStateInAllItems(bool state)
        {

            for (int i = 0; i < checkedListBoxAlltxtFiles.Items.Count; i++)
            {
                checkedListBoxAlltxtFiles.SetItemChecked(i, state);
            }
            return state;
        }

        private Queue<string> GetAllCheckedTextFiles()
        {
            Queue<string> allCheckedItems = new Queue<string>();
           
            foreach (object itemChecked in checkedListBoxAlltxtFiles.CheckedItems)
            {
                var info = itemChecked.ToString();
                allCheckedItems.Enqueue(info);
            }
            return allCheckedItems;
        }

        private bool ResolveScrapeInputsValidation()
        {
            InputsForValidation scrapeInputsForValidation = new InputsForValidation()
            {
                ScrapingFolderPath = txtScrapingFolder.Text,
                AllCheckedTxtFiles = GetAllCheckedTextFiles(),
                XPathExpression= txtXPathExpression.Text                
            };

            ScrapeInputValidationReport scrapeInputValidationReport = _inputValidator.ValidateScrapeInputs(scrapeInputsForValidation);
            if(!scrapeInputValidationReport.AllScrapeInputsAreValid)
            {
                if(!string.IsNullOrEmpty(scrapeInputValidationReport.ScrapingFolderPathReport))
                {
                    txtScrapingFolder.Text = scrapeInputValidationReport.ScrapingFolderPathReport;
                    txtScrapingFolder.BackColor = txtScrapingFolder.BackColor;
                    txtScrapingFolder.ForeColor = Color.Red;
                }
               
                if(!string.IsNullOrEmpty(scrapeInputValidationReport.AlltxtFilesReport))
                {
                    lblWarningListBox.Text = scrapeInputValidationReport.AlltxtFilesReport;
                    lblWarningListBox.ForeColor = Color.Red;
                }
                
                if(!string.IsNullOrEmpty(scrapeInputValidationReport.XPathExpressionReport))
                {
                    txtXPathExpression.Text = scrapeInputValidationReport.XPathExpressionReport;
                    txtXPathExpression.BackColor = txtXPathExpression.BackColor;
                    txtXPathExpression.ForeColor = Color.Red;
                }
                

                return false;
            }

            return true;
        }

        private void GetScrapeReportResult(string reportResult)
        {
            //btnRunScraper.Enabled = true;
            btnRunScraper.BeginInvoke(() => {
                btnRunScraper.Enabled = true;
                this.btnStartCrawler.Refresh();
            });

            lblScrapeReport.Invoke(() => 
            { 
                lblScrapeReport.Text = reportResult;
                this.lblScrapeReport.Refresh();
            });            
        }
        #endregion Helper Methods
    }
}
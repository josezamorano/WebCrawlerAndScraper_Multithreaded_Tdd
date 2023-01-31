namespace WebCrawlerScraper
{
    partial class PresentationLayer
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelCrawl = new System.Windows.Forms.Panel();
            this.lblWarningListBox = new System.Windows.Forms.Label();
            this.checkBoxSelectAll = new System.Windows.Forms.CheckBox();
            this.checkedListBoxAlltxtFiles = new System.Windows.Forms.CheckedListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblScrapeReport = new System.Windows.Forms.Label();
            this.btnRunScraper = new System.Windows.Forms.Button();
            this.txtXPathExpression = new System.Windows.Forms.TextBox();
            this.lblXPath = new System.Windows.Forms.Label();
            this.lblFilesFoundInFolder = new System.Windows.Forms.Label();
            this.txtScrapingFolder = new System.Windows.Forms.TextBox();
            this.lblSelectScrapingFolder = new System.Windows.Forms.Label();
            this.btnScrapingFolder = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblReportResult = new System.Windows.Forms.Label();
            this.txtReportFolder = new System.Windows.Forms.TextBox();
            this.lblSelectFolder = new System.Windows.Forms.Label();
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.lblWarningOptions = new System.Windows.Forms.Label();
            this.btnStartCrawler = new System.Windows.Forms.Button();
            this.lblWarningUrl = new System.Windows.Forms.Label();
            this.panelSearchSelection = new System.Windows.Forms.Panel();
            this.lblWarningSearchCount = new System.Windows.Forms.Label();
            this.txtTotalPages = new System.Windows.Forms.TextBox();
            this.radioBtnSearchCount = new System.Windows.Forms.RadioButton();
            this.radioBtnSearchAllPages = new System.Windows.Forms.RadioButton();
            this.lblSelectSearchType = new System.Windows.Forms.Label();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.lblUrl = new System.Windows.Forms.Label();
            this.panelCrawl.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelSearchSelection.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCrawl
            // 
            this.panelCrawl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelCrawl.Controls.Add(this.lblWarningListBox);
            this.panelCrawl.Controls.Add(this.checkBoxSelectAll);
            this.panelCrawl.Controls.Add(this.checkedListBoxAlltxtFiles);
            this.panelCrawl.Controls.Add(this.panel2);
            this.panelCrawl.Controls.Add(this.panel1);
            this.panelCrawl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCrawl.Location = new System.Drawing.Point(0, 0);
            this.panelCrawl.Name = "panelCrawl";
            this.panelCrawl.Size = new System.Drawing.Size(1341, 553);
            this.panelCrawl.TabIndex = 0;
            // 
            // lblWarningListBox
            // 
            this.lblWarningListBox.AutoSize = true;
            this.lblWarningListBox.Location = new System.Drawing.Point(825, 17);
            this.lblWarningListBox.Name = "lblWarningListBox";
            this.lblWarningListBox.Size = new System.Drawing.Size(0, 20);
            this.lblWarningListBox.TabIndex = 9;
            // 
            // checkBoxSelectAll
            // 
            this.checkBoxSelectAll.AutoSize = true;
            this.checkBoxSelectAll.Location = new System.Drawing.Point(712, 15);
            this.checkBoxSelectAll.Name = "checkBoxSelectAll";
            this.checkBoxSelectAll.Size = new System.Drawing.Size(93, 24);
            this.checkBoxSelectAll.TabIndex = 8;
            this.checkBoxSelectAll.Text = "Select All";
            this.checkBoxSelectAll.UseVisualStyleBackColor = true;
            this.checkBoxSelectAll.CheckedChanged += new System.EventHandler(this.checkBoxSelectAll_CheckedChanged);
            // 
            // checkedListBoxAlltxtFiles
            // 
            this.checkedListBoxAlltxtFiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkedListBoxAlltxtFiles.FormattingEnabled = true;
            this.checkedListBoxAlltxtFiles.HorizontalScrollbar = true;
            this.checkedListBoxAlltxtFiles.Location = new System.Drawing.Point(708, 49);
            this.checkedListBoxAlltxtFiles.Name = "checkedListBoxAlltxtFiles";
            this.checkedListBoxAlltxtFiles.Size = new System.Drawing.Size(621, 488);
            this.checkedListBoxAlltxtFiles.TabIndex = 7;
            this.checkedListBoxAlltxtFiles.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBoxAlltxtFiles_ItemCheck);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblScrapeReport);
            this.panel2.Controls.Add(this.btnRunScraper);
            this.panel2.Controls.Add(this.txtXPathExpression);
            this.panel2.Controls.Add(this.lblXPath);
            this.panel2.Controls.Add(this.lblFilesFoundInFolder);
            this.panel2.Controls.Add(this.txtScrapingFolder);
            this.panel2.Controls.Add(this.lblSelectScrapingFolder);
            this.panel2.Controls.Add(this.btnScrapingFolder);
            this.panel2.Location = new System.Drawing.Point(3, 298);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(697, 239);
            this.panel2.TabIndex = 6;
            // 
            // lblScrapeReport
            // 
            this.lblScrapeReport.AutoSize = true;
            this.lblScrapeReport.Location = new System.Drawing.Point(140, 200);
            this.lblScrapeReport.Name = "lblScrapeReport";
            this.lblScrapeReport.Size = new System.Drawing.Size(0, 20);
            this.lblScrapeReport.TabIndex = 7;
            // 
            // btnRunScraper
            // 
            this.btnRunScraper.Location = new System.Drawing.Point(5, 196);
            this.btnRunScraper.Name = "btnRunScraper";
            this.btnRunScraper.Size = new System.Drawing.Size(122, 29);
            this.btnRunScraper.TabIndex = 6;
            this.btnRunScraper.Text = "Run Scraper";
            this.btnRunScraper.UseVisualStyleBackColor = true;
            this.btnRunScraper.Click += new System.EventHandler(this.btnRunScraper_Click);
            // 
            // txtXPathExpression
            // 
            this.txtXPathExpression.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtXPathExpression.Location = new System.Drawing.Point(143, 112);
            this.txtXPathExpression.Multiline = true;
            this.txtXPathExpression.Name = "txtXPathExpression";
            this.txtXPathExpression.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtXPathExpression.Size = new System.Drawing.Size(533, 77);
            this.txtXPathExpression.TabIndex = 5;
            this.txtXPathExpression.Click += new System.EventHandler(this.txtXPathExpression_Click);
            // 
            // lblXPath
            // 
            this.lblXPath.AutoSize = true;
            this.lblXPath.Location = new System.Drawing.Point(4, 86);
            this.lblXPath.Name = "lblXPath";
            this.lblXPath.Size = new System.Drawing.Size(262, 20);
            this.lblXPath.TabIndex = 4;
            this.lblXPath.Text = "Insert XPath Expression for the Scraper";
            // 
            // lblFilesFoundInFolder
            // 
            this.lblFilesFoundInFolder.AutoSize = true;
            this.lblFilesFoundInFolder.Location = new System.Drawing.Point(145, 89);
            this.lblFilesFoundInFolder.Name = "lblFilesFoundInFolder";
            this.lblFilesFoundInFolder.Size = new System.Drawing.Size(0, 20);
            this.lblFilesFoundInFolder.TabIndex = 3;
            // 
            // txtScrapingFolder
            // 
            this.txtScrapingFolder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtScrapingFolder.Location = new System.Drawing.Point(142, 28);
            this.txtScrapingFolder.Multiline = true;
            this.txtScrapingFolder.Name = "txtScrapingFolder";
            this.txtScrapingFolder.ReadOnly = true;
            this.txtScrapingFolder.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtScrapingFolder.Size = new System.Drawing.Size(534, 49);
            this.txtScrapingFolder.TabIndex = 2;
            // 
            // lblSelectScrapingFolder
            // 
            this.lblSelectScrapingFolder.AutoSize = true;
            this.lblSelectScrapingFolder.Location = new System.Drawing.Point(2, 3);
            this.lblSelectScrapingFolder.Name = "lblSelectScrapingFolder";
            this.lblSelectScrapingFolder.Size = new System.Drawing.Size(230, 20);
            this.lblSelectScrapingFolder.TabIndex = 1;
            this.lblSelectScrapingFolder.Text = "Select Folder With Files to Scrape";
            // 
            // btnScrapingFolder
            // 
            this.btnScrapingFolder.Location = new System.Drawing.Point(5, 28);
            this.btnScrapingFolder.Name = "btnScrapingFolder";
            this.btnScrapingFolder.Size = new System.Drawing.Size(122, 29);
            this.btnScrapingFolder.TabIndex = 0;
            this.btnScrapingFolder.Text = "Select Folder";
            this.btnScrapingFolder.UseVisualStyleBackColor = true;
            this.btnScrapingFolder.Click += new System.EventHandler(this.btnScrapingFolder_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblReportResult);
            this.panel1.Controls.Add(this.txtReportFolder);
            this.panel1.Controls.Add(this.lblSelectFolder);
            this.panel1.Controls.Add(this.btnSelectFolder);
            this.panel1.Controls.Add(this.lblWarningOptions);
            this.panel1.Controls.Add(this.btnStartCrawler);
            this.panel1.Controls.Add(this.lblWarningUrl);
            this.panel1.Controls.Add(this.panelSearchSelection);
            this.panel1.Controls.Add(this.lblSelectSearchType);
            this.panel1.Controls.Add(this.txtUrl);
            this.panel1.Controls.Add(this.lblUrl);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(697, 286);
            this.panel1.TabIndex = 5;
            // 
            // lblReportResult
            // 
            this.lblReportResult.AutoSize = true;
            this.lblReportResult.Location = new System.Drawing.Point(141, 254);
            this.lblReportResult.Name = "lblReportResult";
            this.lblReportResult.Size = new System.Drawing.Size(0, 20);
            this.lblReportResult.TabIndex = 13;
            // 
            // txtReportFolder
            // 
            this.txtReportFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReportFolder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReportFolder.Location = new System.Drawing.Point(142, 199);
            this.txtReportFolder.Multiline = true;
            this.txtReportFolder.Name = "txtReportFolder";
            this.txtReportFolder.ReadOnly = true;
            this.txtReportFolder.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReportFolder.Size = new System.Drawing.Size(534, 49);
            this.txtReportFolder.TabIndex = 12;
            // 
            // lblSelectFolder
            // 
            this.lblSelectFolder.AutoSize = true;
            this.lblSelectFolder.Location = new System.Drawing.Point(4, 176);
            this.lblSelectFolder.Name = "lblSelectFolder";
            this.lblSelectFolder.Size = new System.Drawing.Size(255, 20);
            this.lblSelectFolder.TabIndex = 11;
            this.lblSelectFolder.Text = "Select the folder to Store the Reports";
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.Location = new System.Drawing.Point(5, 200);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(122, 29);
            this.btnSelectFolder.TabIndex = 10;
            this.btnSelectFolder.Text = "Select Folder";
            this.btnSelectFolder.UseVisualStyleBackColor = true;
            this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
            // 
            // lblWarningOptions
            // 
            this.lblWarningOptions.AutoSize = true;
            this.lblWarningOptions.ForeColor = System.Drawing.Color.Red;
            this.lblWarningOptions.Location = new System.Drawing.Point(5, 99);
            this.lblWarningOptions.Name = "lblWarningOptions";
            this.lblWarningOptions.Size = new System.Drawing.Size(0, 20);
            this.lblWarningOptions.TabIndex = 9;
            // 
            // btnStartCrawler
            // 
            this.btnStartCrawler.Location = new System.Drawing.Point(5, 250);
            this.btnStartCrawler.Name = "btnStartCrawler";
            this.btnStartCrawler.Size = new System.Drawing.Size(122, 29);
            this.btnStartCrawler.TabIndex = 8;
            this.btnStartCrawler.Text = "Run Crawler";
            this.btnStartCrawler.UseVisualStyleBackColor = true;
            this.btnStartCrawler.Click += new System.EventHandler(this.btnStartCrawler_Click);
            // 
            // lblWarningUrl
            // 
            this.lblWarningUrl.AutoSize = true;
            this.lblWarningUrl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblWarningUrl.Location = new System.Drawing.Point(78, 44);
            this.lblWarningUrl.Name = "lblWarningUrl";
            this.lblWarningUrl.Size = new System.Drawing.Size(259, 20);
            this.lblWarningUrl.TabIndex = 7;
            this.lblWarningUrl.Text = "Url Format: https://www.example.com";
            // 
            // panelSearchSelection
            // 
            this.panelSearchSelection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSearchSelection.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelSearchSelection.Controls.Add(this.lblWarningSearchCount);
            this.panelSearchSelection.Controls.Add(this.txtTotalPages);
            this.panelSearchSelection.Controls.Add(this.radioBtnSearchCount);
            this.panelSearchSelection.Controls.Add(this.radioBtnSearchAllPages);
            this.panelSearchSelection.Location = new System.Drawing.Point(142, 71);
            this.panelSearchSelection.Name = "panelSearchSelection";
            this.panelSearchSelection.Size = new System.Drawing.Size(534, 101);
            this.panelSearchSelection.TabIndex = 6;
            // 
            // lblWarningSearchCount
            // 
            this.lblWarningSearchCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWarningSearchCount.AutoSize = true;
            this.lblWarningSearchCount.Location = new System.Drawing.Point(171, 76);
            this.lblWarningSearchCount.Name = "lblWarningSearchCount";
            this.lblWarningSearchCount.Size = new System.Drawing.Size(299, 20);
            this.lblWarningSearchCount.TabIndex = 8;
            this.lblWarningSearchCount.Text = "Insert only Complete Numbers not decimals";
            // 
            // txtTotalPages
            // 
            this.txtTotalPages.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalPages.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalPages.Location = new System.Drawing.Point(176, 46);
            this.txtTotalPages.Name = "txtTotalPages";
            this.txtTotalPages.Size = new System.Drawing.Size(245, 27);
            this.txtTotalPages.TabIndex = 6;
            this.txtTotalPages.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTotalPages_KeyPress);
            // 
            // radioBtnSearchCount
            // 
            this.radioBtnSearchCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioBtnSearchCount.AutoSize = true;
            this.radioBtnSearchCount.Location = new System.Drawing.Point(16, 46);
            this.radioBtnSearchCount.Name = "radioBtnSearchCount";
            this.radioBtnSearchCount.Size = new System.Drawing.Size(153, 24);
            this.radioBtnSearchCount.TabIndex = 5;
            this.radioBtnSearchCount.TabStop = true;
            this.radioBtnSearchCount.Text = "Search Total Pages";
            this.radioBtnSearchCount.UseVisualStyleBackColor = true;
            this.radioBtnSearchCount.CheckedChanged += new System.EventHandler(this.radioBtnSearchCount_CheckedChanged);
            // 
            // radioBtnSearchAllPages
            // 
            this.radioBtnSearchAllPages.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioBtnSearchAllPages.AutoSize = true;
            this.radioBtnSearchAllPages.Location = new System.Drawing.Point(14, 3);
            this.radioBtnSearchAllPages.Name = "radioBtnSearchAllPages";
            this.radioBtnSearchAllPages.Size = new System.Drawing.Size(138, 24);
            this.radioBtnSearchAllPages.TabIndex = 4;
            this.radioBtnSearchAllPages.TabStop = true;
            this.radioBtnSearchAllPages.Text = "Search All Pages";
            this.radioBtnSearchAllPages.UseVisualStyleBackColor = true;
            this.radioBtnSearchAllPages.CheckedChanged += new System.EventHandler(this.radioBtnSearchAllPages_CheckedChanged);
            // 
            // lblSelectSearchType
            // 
            this.lblSelectSearchType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSelectSearchType.AutoSize = true;
            this.lblSelectSearchType.Location = new System.Drawing.Point(3, 73);
            this.lblSelectSearchType.Name = "lblSelectSearchType";
            this.lblSelectSearchType.Size = new System.Drawing.Size(132, 20);
            this.lblSelectSearchType.TabIndex = 5;
            this.lblSelectSearchType.Text = "Select Search Type";
            // 
            // txtUrl
            // 
            this.txtUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUrl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUrl.Location = new System.Drawing.Point(77, 14);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(599, 27);
            this.txtUrl.TabIndex = 2;
            this.txtUrl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUrl_KeyPress);
            // 
            // lblUrl
            // 
            this.lblUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUrl.AutoSize = true;
            this.lblUrl.Location = new System.Drawing.Point(3, 17);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(68, 20);
            this.lblUrl.TabIndex = 0;
            this.lblUrl.Text = "Insert Url";
            // 
            // PresentationLayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1341, 553);
            this.Controls.Add(this.panelCrawl);
            this.Name = "PresentationLayer";
            this.Text = "Form1";
            this.panelCrawl.ResumeLayout(false);
            this.panelCrawl.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelSearchSelection.ResumeLayout(false);
            this.panelSearchSelection.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelCrawl;
        private Panel panel1;
        private Panel panelSearchSelection;
        private TextBox txtTotalPages;
        private RadioButton radioBtnSearchCount;
        private RadioButton radioBtnSearchAllPages;
        private Label lblSelectSearchType;
        private TextBox txtUrl;
        private Label lblUrl;
        private Label lblWarningSearchCount;
        private Label lblWarningUrl;
        private Button btnStartCrawler;
        private Label lblWarningOptions;
        private TextBox txtReportFolder;
        private Label lblSelectFolder;
        private Button btnSelectFolder;
        private Panel panel2;
        private TextBox txtScrapingFolder;
        private Label lblSelectScrapingFolder;
        private Button btnScrapingFolder;
        private Label lblFilesFoundInFolder;
        private CheckedListBox checkedListBoxAlltxtFiles;
        private CheckBox checkBoxSelectAll;
        private Label lblReportResult;
        private Button btnRunScraper;
        private TextBox txtXPathExpression;
        private Label lblXPath;
        private Label lblScrapeReport;
        private Label lblWarningListBox;
    }
}
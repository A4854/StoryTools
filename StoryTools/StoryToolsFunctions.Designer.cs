namespace StoryTools
{
    partial class StoryToolsFunctions : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public StoryToolsFunctions()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.ExcelTools = this.Factory.CreateRibbonTab();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.ButtonExportCSV = this.Factory.CreateRibbonButton();
            this.ButtonCheckRoleName = this.Factory.CreateRibbonButton();
            this.ButtonConfigManager = this.Factory.CreateRibbonButton();
            this.ButtonUpdateLog = this.Factory.CreateRibbonButton();
            this.ButtonApplendLang = this.Factory.CreateRibbonButton();
            this.ConfigManagerWindow = new System.Windows.Forms.FolderBrowserDialog();
            this.ExcelTools.SuspendLayout();
            this.group1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExcelTools
            // 
            this.ExcelTools.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.ExcelTools.Groups.Add(this.group1);
            this.ExcelTools.Label = "ExcelTools";
            this.ExcelTools.Name = "ExcelTools";
            // 
            // group1
            // 
            this.group1.Items.Add(this.ButtonExportCSV);
            this.group1.Items.Add(this.ButtonCheckRoleName);
            this.group1.Items.Add(this.ButtonConfigManager);
            this.group1.Items.Add(this.ButtonUpdateLog);
            this.group1.Items.Add(this.ButtonApplendLang);
            this.group1.Label = "StoryTools";
            this.group1.Name = "group1";
            // 
            // ButtonExportCSV
            // 
            this.ButtonExportCSV.Label = "ExportToCSV";
            this.ButtonExportCSV.Name = "ButtonExportCSV";
            this.ButtonExportCSV.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.ButtonExportCSV_Click);
            // 
            // ButtonCheckRoleName
            // 
            this.ButtonCheckRoleName.Label = "CheckRoleName";
            this.ButtonCheckRoleName.Name = "ButtonCheckRoleName";
            this.ButtonCheckRoleName.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.CheckRoleName_Click);
            // 
            // ButtonConfigManager
            // 
            this.ButtonConfigManager.Label = "ConfigManager";
            this.ButtonConfigManager.Name = "ButtonConfigManager";
            this.ButtonConfigManager.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.ButtonConfigManager_Click);
            // 
            // ButtonUpdateLog
            // 
            this.ButtonUpdateLog.KeyTip = "F";
            this.ButtonUpdateLog.Label = "MakeLog";
            this.ButtonUpdateLog.Name = "ButtonUpdateLog";
            this.ButtonUpdateLog.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.MakeLog_Click);
            // 
            // ButtonApplendLang
            // 
            this.ButtonApplendLang.Label = "ButtonApplendLang";
            this.ButtonApplendLang.Name = "ButtonApplendLang";
            this.ButtonApplendLang.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.ButtonApplendLang_Click);
            // 
            // ConfigManagerWindow
            // 
            this.ConfigManagerWindow.HelpRequest += new System.EventHandler(this.ConfigManagerWindow_HelpRequest);
            // 
            // StoryToolsFunctions
            // 
            this.Name = "StoryToolsFunctions";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.ExcelTools);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.OnStoryToolsLoad);
            this.ExcelTools.ResumeLayout(false);
            this.ExcelTools.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab ExcelTools;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton ButtonExportCSV;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton ButtonCheckRoleName;
        private System.Windows.Forms.FolderBrowserDialog ConfigManagerWindow;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton ButtonConfigManager;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton ButtonUpdateLog;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton ButtonApplendLang;
    }

    partial class ThisRibbonCollection
    {
        internal StoryToolsFunctions StoryToolsFunctions
        {
            get { return this.GetRibbon<StoryToolsFunctions>(); }
        }
    }
}

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
            this.ButtonExportToCSV = this.Factory.CreateRibbonButton();
            this.button1 = this.Factory.CreateRibbonButton();
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
            this.group1.Items.Add(this.ButtonExportToCSV);
            this.group1.Items.Add(this.button1);
            this.group1.Label = "StoryTools";
            this.group1.Name = "group1";
            // 
            // ButtonExportToCSV
            // 
            this.ButtonExportToCSV.Label = "ExportToCSV";
            this.ButtonExportToCSV.Name = "ButtonExportToCSV";
            this.ButtonExportToCSV.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.ButtonExportToCSV_Click);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Label = "CheckRoleName";
            this.button1.Name = "button1";
            this.button1.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.button1_Click);
            // 
            // StoryToolsFunctions
            // 
            this.Name = "StoryToolsFunctions";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.ExcelTools);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.StoryToolsFunctions_Load);
            this.ExcelTools.ResumeLayout(false);
            this.ExcelTools.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab ExcelTools;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton ButtonExportToCSV;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button1;
    }

    partial class ThisRibbonCollection
    {
        internal StoryToolsFunctions StoryToolsFunctions
        {
            get { return this.GetRibbon<StoryToolsFunctions>(); }
        }
    }
}

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
            this.TabTest = this.Factory.CreateRibbonTab();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.ButtonGo = this.Factory.CreateRibbonButton();
            this.TabTest.SuspendLayout();
            this.group1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabTest
            // 
            this.TabTest.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.TabTest.Groups.Add(this.group1);
            this.TabTest.Label = "TabTest";
            this.TabTest.Name = "TabTest";
            // 
            // group1
            // 
            this.group1.Items.Add(this.ButtonGo);
            this.group1.Label = "Go";
            this.group1.Name = "group1";
            // 
            // ButtonGo
            // 
            this.ButtonGo.Label = "Go";
            this.ButtonGo.Name = "ButtonGo";
            this.ButtonGo.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.ButtonGo_Click);
            // 
            // StoryToolsFunctions
            // 
            this.Name = "StoryToolsFunctions";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.TabTest);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.StoryToolsFunctions_Load);
            this.TabTest.ResumeLayout(false);
            this.TabTest.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab TabTest;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton ButtonGo;
    }

    partial class ThisRibbonCollection
    {
        internal StoryToolsFunctions StoryToolsFunctions
        {
            get { return this.GetRibbon<StoryToolsFunctions>(); }
        }
    }
}

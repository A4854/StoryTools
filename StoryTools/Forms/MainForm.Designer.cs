using System.ComponentModel;

namespace StoryTools.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ButtonChooseCSVPath = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ButtonResetCSVPath = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.LabelCSVPath = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.LabelCurrentCSVPath = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.ButtonChooseLocalizationPath = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ButtonResetLocalizationPath = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.LabelLocalizationPath = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.LabelCurrentLocalizationPath = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.LabelUserName = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.ButtonSetUserName = new System.Windows.Forms.ToolStripButton();
            this.ButtonResetUserName = new System.Windows.Forms.ToolStripButton();
            this.TextBoxCurrentUserName = new System.Windows.Forms.ToolStripTextBox();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.toolStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ButtonChooseCSVPath,
            this.toolStripSeparator2,
            this.ButtonResetCSVPath,
            this.toolStripSeparator6,
            this.LabelCSVPath,
            this.toolStripSeparator1,
            this.LabelCurrentCSVPath,
            this.toolStripSeparator5});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ButtonChooseCSVPath
            // 
            this.ButtonChooseCSVPath.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ButtonChooseCSVPath.Image = ((System.Drawing.Image)(resources.GetObject("ButtonChooseCSVPath.Image")));
            this.ButtonChooseCSVPath.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonChooseCSVPath.Name = "ButtonChooseCSVPath";
            this.ButtonChooseCSVPath.Size = new System.Drawing.Size(23, 22);
            this.ButtonChooseCSVPath.Text = "toolStripButton1";
            this.ButtonChooseCSVPath.Click += new System.EventHandler(this.ButtonChooseCSVPath_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // ButtonResetCSVPath
            // 
            this.ButtonResetCSVPath.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ButtonResetCSVPath.Image = ((System.Drawing.Image)(resources.GetObject("ButtonResetCSVPath.Image")));
            this.ButtonResetCSVPath.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonResetCSVPath.Name = "ButtonResetCSVPath";
            this.ButtonResetCSVPath.Size = new System.Drawing.Size(23, 22);
            this.ButtonResetCSVPath.Text = "toolStripButton1";
            this.ButtonResetCSVPath.Click += new System.EventHandler(this.ButtonResetCSVPath_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // LabelCSVPath
            // 
            this.LabelCSVPath.Name = "LabelCSVPath";
            this.LabelCSVPath.Size = new System.Drawing.Size(79, 22);
            this.LabelCSVPath.Text = "当前CSV路径";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // LabelCurrentCSVPath
            // 
            this.LabelCurrentCSVPath.Name = "LabelCurrentCSVPath";
            this.LabelCurrentCSVPath.Size = new System.Drawing.Size(56, 22);
            this.LabelCurrentCSVPath.Text = "默认路径";
            this.LabelCurrentCSVPath.Paint += new System.Windows.Forms.PaintEventHandler(this.LabelCurrentCSVPath_Paint);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ButtonChooseLocalizationPath,
            this.toolStripSeparator3,
            this.ButtonResetLocalizationPath,
            this.toolStripSeparator7,
            this.LabelLocalizationPath,
            this.toolStripSeparator4,
            this.LabelCurrentLocalizationPath,
            this.toolStripSeparator8});
            this.toolStrip2.Location = new System.Drawing.Point(0, 25);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(800, 25);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // ButtonChooseLocalizationPath
            // 
            this.ButtonChooseLocalizationPath.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ButtonChooseLocalizationPath.Image = ((System.Drawing.Image)(resources.GetObject("ButtonChooseLocalizationPath.Image")));
            this.ButtonChooseLocalizationPath.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonChooseLocalizationPath.Name = "ButtonChooseLocalizationPath";
            this.ButtonChooseLocalizationPath.Size = new System.Drawing.Size(23, 22);
            this.ButtonChooseLocalizationPath.Text = "toolStripButton1";
            this.ButtonChooseLocalizationPath.Click += new System.EventHandler(this.ButtonChooseLocalizationPath_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // ButtonResetLocalizationPath
            // 
            this.ButtonResetLocalizationPath.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ButtonResetLocalizationPath.Image = ((System.Drawing.Image)(resources.GetObject("ButtonResetLocalizationPath.Image")));
            this.ButtonResetLocalizationPath.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonResetLocalizationPath.Name = "ButtonResetLocalizationPath";
            this.ButtonResetLocalizationPath.Size = new System.Drawing.Size(23, 22);
            this.ButtonResetLocalizationPath.Text = "toolStripButton2";
            this.ButtonResetLocalizationPath.Click += new System.EventHandler(this.ButtonResetLocalizationPath_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // LabelLocalizationPath
            // 
            this.LabelLocalizationPath.Name = "LabelLocalizationPath";
            this.LabelLocalizationPath.Size = new System.Drawing.Size(124, 22);
            this.LabelLocalizationPath.Text = "当前Localization路径";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // LabelCurrentLocalizationPath
            // 
            this.LabelCurrentLocalizationPath.Name = "LabelCurrentLocalizationPath";
            this.LabelCurrentLocalizationPath.Size = new System.Drawing.Size(56, 22);
            this.LabelCurrentLocalizationPath.Text = "默认路径";
            this.LabelCurrentLocalizationPath.Paint += new System.Windows.Forms.PaintEventHandler(this.LabelCurrentLocalizationPath_Paint);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStrip3
            // 
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ButtonSetUserName,
            this.toolStripSeparator9,
            this.ButtonResetUserName,
            this.toolStripSeparator10,
            this.LabelUserName,
            this.toolStripSeparator11,
            this.TextBoxCurrentUserName});
            this.toolStrip3.Location = new System.Drawing.Point(0, 50);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(800, 25);
            this.toolStrip3.TabIndex = 2;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(6, 25);
            // 
            // LabelUserName
            // 
            this.LabelUserName.Name = "LabelUserName";
            this.LabelUserName.Size = new System.Drawing.Size(80, 22);
            this.LabelUserName.Text = "当前用户名称";
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 25);
            // 
            // ButtonSetUserName
            // 
            this.ButtonSetUserName.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ButtonSetUserName.Image = ((System.Drawing.Image)(resources.GetObject("ButtonSetUserName.Image")));
            this.ButtonSetUserName.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonSetUserName.Name = "ButtonSetUserName";
            this.ButtonSetUserName.Size = new System.Drawing.Size(23, 22);
            this.ButtonSetUserName.Text = "toolStripButton1";
            this.ButtonSetUserName.Click += new System.EventHandler(this.ButtonSetUserName_Click);
            // 
            // ButtonResetUserName
            // 
            this.ButtonResetUserName.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ButtonResetUserName.Image = ((System.Drawing.Image)(resources.GetObject("ButtonResetUserName.Image")));
            this.ButtonResetUserName.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonResetUserName.Name = "ButtonResetUserName";
            this.ButtonResetUserName.Size = new System.Drawing.Size(23, 22);
            this.ButtonResetUserName.Text = "toolStripButton2";
            this.ButtonResetUserName.Click += new System.EventHandler(this.ButtonResetUserName_Click);
            // 
            // TextBoxCurrentUserName
            // 
            this.TextBoxCurrentUserName.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.TextBoxCurrentUserName.Name = "TextBoxCurrentUserName";
            this.TextBoxCurrentUserName.Size = new System.Drawing.Size(100, 25);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip3);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.ToolStripButton ButtonResetCSVPath;

        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;

        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;

        private System.Windows.Forms.ToolStripLabel LabelCSVPath;

        private System.Windows.Forms.ToolStripLabel LabelCurrentCSVPath;

        private System.Windows.Forms.ToolStripButton ButtonChooseCSVPath;

        private System.Windows.Forms.ToolStrip toolStrip1;

        #endregion

        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton ButtonChooseLocalizationPath;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton ButtonResetLocalizationPath;
        private System.Windows.Forms.ToolStripLabel LabelLocalizationPath;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel LabelCurrentLocalizationPath;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripLabel LabelUserName;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStripButton ButtonSetUserName;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripButton ButtonResetUserName;
        private System.Windows.Forms.ToolStripTextBox TextBoxCurrentUserName;
    }
}
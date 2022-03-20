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
            this.LabelCSVPath = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.LabelCurrentCSVPath = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ButtonChooseCSVPath,
            this.toolStripSeparator2,
            this.ButtonResetCSVPath,
            this.LabelCSVPath,
            this.toolStripSeparator1,
            this.LabelCurrentCSVPath});
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
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
    }
}
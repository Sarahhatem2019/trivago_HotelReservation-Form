
namespace HotelTrivago
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.connectedModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giveFeedBackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewFormReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectedModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewReportFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 28);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1026, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectedModeToolStripMenuItem,
            this.disconnectedModeToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1026, 28);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // connectedModeToolStripMenuItem
            // 
            this.connectedModeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.giveFeedBackToolStripMenuItem,
            this.viewFormReportToolStripMenuItem});
            this.connectedModeToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectedModeToolStripMenuItem.Name = "connectedModeToolStripMenuItem";
            this.connectedModeToolStripMenuItem.Size = new System.Drawing.Size(136, 24);
            this.connectedModeToolStripMenuItem.Text = "Connected Mode";
            // 
            // giveFeedBackToolStripMenuItem
            // 
            this.giveFeedBackToolStripMenuItem.Name = "giveFeedBackToolStripMenuItem";
            this.giveFeedBackToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.giveFeedBackToolStripMenuItem.Text = "FeedBacks ";
            this.giveFeedBackToolStripMenuItem.Click += new System.EventHandler(this.giveFeedBackToolStripMenuItem_Click);
            // 
            // viewFormReportToolStripMenuItem
            // 
            this.viewFormReportToolStripMenuItem.Name = "viewFormReportToolStripMenuItem";
            this.viewFormReportToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.viewFormReportToolStripMenuItem.Text = "View FeedBack Report";
            this.viewFormReportToolStripMenuItem.Click += new System.EventHandler(this.viewFormReportToolStripMenuItem_Click);
            // 
            // disconnectedModeToolStripMenuItem
            // 
            this.disconnectedModeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchFormToolStripMenuItem,
            this.viewReportFormToolStripMenuItem});
            this.disconnectedModeToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disconnectedModeToolStripMenuItem.Name = "disconnectedModeToolStripMenuItem";
            this.disconnectedModeToolStripMenuItem.Size = new System.Drawing.Size(150, 24);
            this.disconnectedModeToolStripMenuItem.Text = "DisconnectedMode";
            // 
            // searchFormToolStripMenuItem
            // 
            this.searchFormToolStripMenuItem.Name = "searchFormToolStripMenuItem";
            this.searchFormToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.searchFormToolStripMenuItem.Text = "Search Deals";
            this.searchFormToolStripMenuItem.Click += new System.EventHandler(this.searchFormToolStripMenuItem_Click);
            // 
            // viewReportFormToolStripMenuItem
            // 
            this.viewReportFormToolStripMenuItem.Name = "viewReportFormToolStripMenuItem";
            this.viewReportFormToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.viewReportFormToolStripMenuItem.Text = "View Search Report";
            this.viewReportFormToolStripMenuItem.Click += new System.EventHandler(this.viewReportFormToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HotelTrivago.Properties.Resources.WhatsApp_Image_2022_05_05_at_1_06_19_AM;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1026, 572);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Form6";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem connectedModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giveFeedBackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewFormReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disconnectedModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewReportFormToolStripMenuItem;
    }
}
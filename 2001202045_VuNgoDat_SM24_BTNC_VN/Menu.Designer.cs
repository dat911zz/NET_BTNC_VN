
namespace _2001202045_VuNgoDat_SM24_BTNC_VN
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
            this.bài1BTVNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBTNC = new System.Windows.Forms.ToolStripMenuItem();
            this.bài1BTVNToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBTVN_1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBTVN_2 = new System.Windows.Forms.ToolStripMenuItem();
            this.webViewTest = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webViewTest)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bài1BTVNToolStripMenuItem,
            this.bài1BTVNToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1010, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bài1BTVNToolStripMenuItem
            // 
            this.bài1BTVNToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuBTNC});
            this.bài1BTVNToolStripMenuItem.Name = "bài1BTVNToolStripMenuItem";
            this.bài1BTVNToolStripMenuItem.Size = new System.Drawing.Size(166, 27);
            this.bài1BTVNToolStripMenuItem.Text = "Bài tập nâng cao";
            // 
            // menuBTNC
            // 
            this.menuBTNC.Name = "menuBTNC";
            this.menuBTNC.Size = new System.Drawing.Size(135, 28);
            this.menuBTNC.Text = "Bài 1";
            this.menuBTNC.Click += new System.EventHandler(this.menuBTNC_Click);
            // 
            // bài1BTVNToolStripMenuItem1
            // 
            this.bài1BTVNToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuBTVN_1,
            this.menuBTVN_2});
            this.bài1BTVNToolStripMenuItem1.Name = "bài1BTVNToolStripMenuItem1";
            this.bài1BTVNToolStripMenuItem1.Size = new System.Drawing.Size(145, 27);
            this.bài1BTVNToolStripMenuItem1.Text = "Bài tập về nhà";
            // 
            // menuBTVN_1
            // 
            this.menuBTVN_1.Name = "menuBTVN_1";
            this.menuBTVN_1.Size = new System.Drawing.Size(135, 28);
            this.menuBTVN_1.Text = "Bài 1";
            this.menuBTVN_1.Click += new System.EventHandler(this.menuBTVN_1_Click);
            // 
            // menuBTVN_2
            // 
            this.menuBTVN_2.Name = "menuBTVN_2";
            this.menuBTVN_2.Size = new System.Drawing.Size(135, 28);
            this.menuBTVN_2.Text = "Bài 2";
            this.menuBTVN_2.Click += new System.EventHandler(this.menuBTVN_2_Click);
            // 
            // webViewTest
            // 
            this.webViewTest.AllowExternalDrop = true;
            this.webViewTest.CreationProperties = null;
            this.webViewTest.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webViewTest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webViewTest.Location = new System.Drawing.Point(0, 31);
            this.webViewTest.Name = "webViewTest";
            this.webViewTest.Size = new System.Drawing.Size(1010, 517);
            this.webViewTest.Source = new System.Uri("http://dat911zz.somee.com/", System.UriKind.Absolute);
            this.webViewTest.TabIndex = 1;
            this.webViewTest.ZoomFactor = 1D;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1010, 548);
            this.Controls.Add(this.webViewTest);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sảnh Chính";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webViewTest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bài1BTVNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bài1BTVNToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menuBTNC;
        private System.Windows.Forms.ToolStripMenuItem menuBTVN_1;
        private System.Windows.Forms.ToolStripMenuItem menuBTVN_2;
        private Microsoft.Web.WebView2.WinForms.WebView2 webViewTest;
    }
}

